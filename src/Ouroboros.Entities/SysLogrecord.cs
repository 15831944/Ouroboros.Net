using Ouroboros.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.Entities
{
    /// <summary>
    /// 日志表
    /// </summary>
    public class SysLogrecord : IEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 日志日期
        /// </summary>
        public DateTime LogDate { get; set; }

        /// <summary>
        /// 日志等级
        /// </summary>
        public string LogLevel { get; set; }

        /// <summary>
        /// 记录器
        /// </summary>
        public string Logger { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 异常
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// 机器名
        /// </summary>
        public string MachineName { get; set; }

        /// <summary>
        /// 机器IP地址
        /// </summary>
        public string MachineIp { get; set; }

        /// <summary>
        /// 请求方法
        /// </summary>
        public string NetRequestMethod { get; set; }

        /// <summary>
        /// 请求URL
        /// </summary>
        public string NetRequestUrl { get; set; }

        /// <summary>
        /// 用户是否认证
        /// </summary>
        public string NetUserIsauthenticated { get; set; }

        /// <summary>
        /// 用户认真类型
        /// </summary>
        public string NetUserAuthtype { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string NetUserIdentity { get; set; }

    }
}
