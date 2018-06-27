using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace WinServicePublishManager
{
    /// <summary>
    /// by lihan 2018-06-25
    /// </summary>
    public partial class FrmMain : Form
    {
        private List<WindowsService> _allWindowsServiceList;

        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 程序启动,加载所有服务列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            var serviceList = GetServiceList();
            if (serviceList.Any())
            {
                dgvServiceList.DataSource = serviceList;
                _allWindowsServiceList = serviceList;
            }
        }

        private void RefreshData(WindowsService winService,int status)
        {
            foreach (var service in _allWindowsServiceList)
            {
                if (service.ServiceName == winService.ServiceName)
                {
                    service.RunStatus = status == 0 ? "停止" : "启动";
                    break;
                }
            }
            var rowNo = dgvServiceList.CurrentRow.Index;
            dgvServiceList.DataSource = _allWindowsServiceList.ToList();
            dgvServiceList.Rows[rowNo].Selected = true;
        }

        //启动服务
        private void btnStart_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedItem();
            Start(selectedRow);
            RefreshData(selectedRow, 1);
        }

        //停止服务
        private void btnStop_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedItem();
            Stop(selectedRow);
            RefreshData(selectedRow, 0);
        }

        //打开发布目录
        private void btnPublishPath_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedItem();
            OpenFolder(selectedRow.PublishPath);
        }

        //打开服务目录
        private void btnSourcePath_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedItem();
            OpenFolder(selectedRow.SourcePath);
        }

        //发布
        private void btnPublish_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedItem();
            Publish(selectedRow);
        }

        //修改配置
        private void btnConfigMotify_Click(object sender, EventArgs e)
        {
            var configPath = GetConfigPath();
            if (string.IsNullOrWhiteSpace(configPath))
            {
                return;
            }
            Process.Start("notepad.exe", configPath);
        }

        /// <summary>
        /// 读取配置获取数据源
        /// </summary>
        /// <returns></returns>
        private List<WindowsService> GetServiceList()
        {
            var resultList = new List<WindowsService>();
            try
            {
                var fullPath = GetConfigPath();
                if (string.IsNullOrWhiteSpace(fullPath))
                    return null;
                FileStream fileStream = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding("GB2312"));
                string configString = streamReader.ReadToEnd();
                streamReader.Close();

                if (!string.IsNullOrWhiteSpace(configString))
                {
                    JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                    var winServiceModel = jsonSerializer.Deserialize<WinServiceModel>(configString);
                    if (winServiceModel != null && winServiceModel.WindowsServices != null &&
                        winServiceModel.WindowsServices.Any())
                    {
                        resultList = winServiceModel.WindowsServices;
                        foreach (var service in resultList)
                        {
                            var serviceController = Get(service.ServiceName);
                            if (serviceController != null)
                            {
                                service.RunStatus = serviceController.Status == ServiceControllerStatus.Stopped
                                    ? "停止"
                                    : "启动";
                            }
                        }
                        dgvServiceList.DataSource = resultList;
                    }
                    else
                    {
                        MessageBox.Show("未正确配置Windows服务信息 !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultList;
        }

        private string GetConfigPath()
        {
            string currentPath = Environment.CurrentDirectory;
            string jsonFilePath = @"config\ServiceConfig.json";
            string fullPath = string.Format(@"{0}\{1}", currentPath, jsonFilePath);
            if (!File.Exists(fullPath))
            {
                MessageBox.Show("Windows服务配置文件不存在 !");
                return string.Empty;
            }
            return fullPath;
        }

        /// <summary>
        /// 获取当前选中行
        /// </summary>
        /// <returns></returns>
        private WindowsService GetSelectedItem()
        {
            var selectedRow = dgvServiceList.SelectedRows[0];
            return new WindowsService()
            {
                ServiceName = selectedRow.Cells[0].Value.ToString(),
                ServiceDisplayName = selectedRow.Cells[1].Value.ToString(),
                PublishPath = selectedRow.Cells[2].Value.ToString(),
                SourcePath = selectedRow.Cells[3].Value.ToString()
            };
        }

        private void Publish(WindowsService winService)
        {
            //Stop(winService.ServiceName);
            //todo:对比发布目录和源目录的文件信息,替换时间较新的文件
            //Start(winService.ServiceName);
        }

        /// <summary>
        /// 打开文件夹目录
        /// </summary>
        /// <param name="folderPath"></param>
        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                Process.Start(folderPath);
            }
            else
            {
                OutPut("要打开的目录不存在 !");
            }
        }

        private void OutPut(string outPutMsg)
        {
            if (txtOutPut.TextLength > 10000)
            {
                txtOutPut.Text = string.Empty;
            }
            txtOutPut.Text += outPutMsg + "\r\n";
            txtOutPut.Focus(); //获取焦点
            txtOutPut.Select(txtOutPut.TextLength - 1, 0); //光标定位到文本最后
            txtOutPut.ScrollToCaret(); //滚动到光标处
        }

        private void dgvServiceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var service = GetSelectedItem();
            if (service != null)
            {
                OpenFolder(service.SourcePath);
            }
            else
            {
                OutPut("未选择需要操作的服务 !");
            }
        }

        #region Windows服务操作

        /// <summary>
        /// 开启服务
        /// </summary>
        /// <param name="service"></param>
        public void Start(WindowsService service)
        {
            using (ServiceController control = new ServiceController(service.ServiceName))
            {
                if (control.Status == ServiceControllerStatus.Stopped)
                {
                    OutPut($"{service.ServiceDisplayName} 正在启动 . . . ");
                    control.Start();
                    OutPut($"{service.ServiceDisplayName} 启动成功 ! ");
                }
                else
                {
                    OutPut($"{service.ServiceDisplayName} 已经是启动状态 ! ");
                }
            }
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        /// <param name="service"></param>
        public void Stop(WindowsService service)
        {
            using (ServiceController control = new ServiceController(service.ServiceName))
            {
                if (control.Status == ServiceControllerStatus.Running)
                {
                    OutPut($"{service.ServiceDisplayName} 正在停止 . . . ");
                    control.Stop();
                    OutPut($"{service.ServiceDisplayName} 停止成功 ! ");
                }
                else
                {
                    OutPut($"{service.ServiceDisplayName} 已经是停止状态 ! ");
                }
            }
        }

        /// <summary>
        /// 根据服务名获取服务
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        public ServiceController Get(string serviceName)
        {
            return new ServiceController(serviceName);
        }

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
