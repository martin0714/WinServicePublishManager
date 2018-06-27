namespace WinServicePublishManager
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPublishPath = new System.Windows.Forms.Button();
            this.btnSourcePath = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.gbServiceList = new System.Windows.Forms.GroupBox();
            this.dgvServiceList = new System.Windows.Forms.DataGridView();
            this.cmsServiceOperation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开服务目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfigMotify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourcePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbServiceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).BeginInit();
            this.cmsServiceOperation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 27);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(100, 17);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 27);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPublishPath
            // 
            this.btnPublishPath.Location = new System.Drawing.Point(399, 17);
            this.btnPublishPath.Name = "btnPublishPath";
            this.btnPublishPath.Size = new System.Drawing.Size(92, 27);
            this.btnPublishPath.TabIndex = 0;
            this.btnPublishPath.Text = "打开发布目录";
            this.btnPublishPath.UseVisualStyleBackColor = true;
            this.btnPublishPath.Visible = false;
            this.btnPublishPath.Click += new System.EventHandler(this.btnPublishPath_Click);
            // 
            // btnSourcePath
            // 
            this.btnSourcePath.Location = new System.Drawing.Point(195, 17);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(92, 27);
            this.btnSourcePath.TabIndex = 0;
            this.btnSourcePath.Text = "打开服务目录";
            this.btnSourcePath.UseVisualStyleBackColor = true;
            this.btnSourcePath.Click += new System.EventHandler(this.btnSourcePath_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(511, 17);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 27);
            this.btnPublish.TabIndex = 0;
            this.btnPublish.Text = "发布";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Visible = false;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // gbServiceList
            // 
            this.gbServiceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbServiceList.Controls.Add(this.dgvServiceList);
            this.gbServiceList.Location = new System.Drawing.Point(1, 172);
            this.gbServiceList.Name = "gbServiceList";
            this.gbServiceList.Size = new System.Drawing.Size(852, 298);
            this.gbServiceList.TabIndex = 1;
            this.gbServiceList.TabStop = false;
            this.gbServiceList.Text = "服务列表";
            // 
            // dgvServiceList
            // 
            this.dgvServiceList.AllowUserToAddRows = false;
            this.dgvServiceList.AllowUserToDeleteRows = false;
            this.dgvServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.ServiceDisplayName,
            this.RunStatus,
            this.SourcePath,
            this.LastStartTime,
            this.PublishPath});
            this.dgvServiceList.ContextMenuStrip = this.cmsServiceOperation;
            this.dgvServiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceList.Location = new System.Drawing.Point(3, 17);
            this.dgvServiceList.MultiSelect = false;
            this.dgvServiceList.Name = "dgvServiceList";
            this.dgvServiceList.ReadOnly = true;
            this.dgvServiceList.RowHeadersVisible = false;
            this.dgvServiceList.RowTemplate.Height = 23;
            this.dgvServiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceList.Size = new System.Drawing.Size(846, 278);
            this.dgvServiceList.TabIndex = 0;
            this.dgvServiceList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceList_CellDoubleClick);
            // 
            // cmsServiceOperation
            // 
            this.cmsServiceOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动ToolStripMenuItem,
            this.停止ToolStripMenuItem,
            this.打开服务目录ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.发布ToolStripMenuItem});
            this.cmsServiceOperation.Name = "cmsServiceOperation";
            this.cmsServiceOperation.Size = new System.Drawing.Size(149, 114);
            // 
            // 启动ToolStripMenuItem
            // 
            this.启动ToolStripMenuItem.Name = "启动ToolStripMenuItem";
            this.启动ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.启动ToolStripMenuItem.Text = "启动";
            this.启动ToolStripMenuItem.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.停止ToolStripMenuItem.Text = "停止";
            this.停止ToolStripMenuItem.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Enabled = false;
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开ToolStripMenuItem.Text = "打开发布目录";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.btnPublishPath_Click);
            // 
            // 打开服务目录ToolStripMenuItem
            // 
            this.打开服务目录ToolStripMenuItem.Name = "打开服务目录ToolStripMenuItem";
            this.打开服务目录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开服务目录ToolStripMenuItem.Text = "打开服务目录";
            this.打开服务目录ToolStripMenuItem.Click += new System.EventHandler(this.btnSourcePath_Click);
            // 
            // 发布ToolStripMenuItem
            // 
            this.发布ToolStripMenuItem.Enabled = false;
            this.发布ToolStripMenuItem.Name = "发布ToolStripMenuItem";
            this.发布ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.发布ToolStripMenuItem.Text = "发布";
            this.发布ToolStripMenuItem.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnConfigMotify
            // 
            this.btnConfigMotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigMotify.Location = new System.Drawing.Point(745, 17);
            this.btnConfigMotify.Name = "btnConfigMotify";
            this.btnConfigMotify.Size = new System.Drawing.Size(93, 27);
            this.btnConfigMotify.TabIndex = 2;
            this.btnConfigMotify.Text = "修改服务配置";
            this.btnConfigMotify.UseVisualStyleBackColor = true;
            this.btnConfigMotify.Click += new System.EventHandler(this.btnConfigMotify_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnConfigMotify);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnSourcePath);
            this.groupBox1.Controls.Add(this.btnPublishPath);
            this.groupBox1.Controls.Add(this.btnPublish);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtOutPut);
            this.groupBox2.Location = new System.Drawing.Point(4, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 108);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出";
            // 
            // txtOutPut
            // 
            this.txtOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOutPut.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOutPut.ForeColor = System.Drawing.Color.Green;
            this.txtOutPut.Location = new System.Drawing.Point(6, 12);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.ReadOnly = true;
            this.txtOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutPut.Size = new System.Drawing.Size(838, 91);
            this.txtOutPut.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(305, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 27);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "服务Id";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Visible = false;
            // 
            // ServiceDisplayName
            // 
            this.ServiceDisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ServiceDisplayName.DataPropertyName = "ServiceDisplayName";
            this.ServiceDisplayName.FillWeight = 100.7983F;
            this.ServiceDisplayName.HeaderText = "服务名称";
            this.ServiceDisplayName.Name = "ServiceDisplayName";
            this.ServiceDisplayName.ReadOnly = true;
            this.ServiceDisplayName.Width = 200;
            // 
            // RunStatus
            // 
            this.RunStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RunStatus.DataPropertyName = "RunStatus";
            this.RunStatus.FillWeight = 175.3438F;
            this.RunStatus.HeaderText = "当前状态";
            this.RunStatus.Name = "RunStatus";
            this.RunStatus.ReadOnly = true;
            this.RunStatus.Width = 120;
            // 
            // SourcePath
            // 
            this.SourcePath.DataPropertyName = "SourcePath";
            this.SourcePath.FillWeight = 24.13417F;
            this.SourcePath.HeaderText = "服务文件路径";
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.ReadOnly = true;
            // 
            // LastStartTime
            // 
            this.LastStartTime.DataPropertyName = "LastStartTime";
            this.LastStartTime.HeaderText = "最后启动时间";
            this.LastStartTime.Name = "LastStartTime";
            this.LastStartTime.ReadOnly = true;
            this.LastStartTime.Visible = false;
            // 
            // PublishPath
            // 
            this.PublishPath.DataPropertyName = "PublishPath";
            this.PublishPath.HeaderText = "发布路径";
            this.PublishPath.Name = "PublishPath";
            this.PublishPath.ReadOnly = true;
            this.PublishPath.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbServiceList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 服务发布辅助小工具 V1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbServiceList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).EndInit();
            this.cmsServiceOperation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPublishPath;
        private System.Windows.Forms.Button btnSourcePath;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.GroupBox gbServiceList;
        private System.Windows.Forms.DataGridView dgvServiceList;
        private System.Windows.Forms.ContextMenuStrip cmsServiceOperation;
        private System.Windows.Forms.ToolStripMenuItem 启动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开服务目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发布ToolStripMenuItem;
        private System.Windows.Forms.Button btnConfigMotify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourcePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishPath;
    }
}

