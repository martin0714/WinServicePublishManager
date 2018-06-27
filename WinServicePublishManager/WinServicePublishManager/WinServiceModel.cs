using System;
using System.Collections.Generic;

namespace WinServicePublishManager
{
    public class WinServiceModel
    {
        public List<WindowsService> WindowsServices { get; set; }
    }

    public class WindowsService
    {
        /// <summary>
        /// 服务标识
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务显示名称
        /// </summary>
        public string ServiceDisplayName { get; set; }

        /// <summary>
        /// 服务发布路径
        /// </summary>
        public string PublishPath { get; set; }

        /// <summary>
        /// 服务根路径
        /// </summary>
        public string SourcePath { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        public string RunStatus { get; set; }

        /// <summary>
        /// 最后启动时间
        /// </summary>
        public DateTime? LastStartTime { get; set; }
    }
}