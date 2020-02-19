using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.Entities
{
    /// <summary>
    /// 密码表
    /// </summary>
    public class SysUserLogin
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 帐号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string HashedPassword { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// 最后失败次数
        /// </summary>
        public int AccessFailedCount { get; set; }

        /// <summary>
        /// 是否锁定
        /// </summary>
        public bool IsLocked { get; set; }

        /// <summary>
        /// 锁定时间
        /// </summary>
        public DateTime? LockedTime { get; set; }

        /// <summary>
        /// 用户实体
        /// </summary>
        public SysUser SysUser { get; set; }

    }
}
