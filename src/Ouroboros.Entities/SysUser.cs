using Ouroboros.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.Entities
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class SysUser : BaseEntity
    {
        /// <summary>
        /// 帐号
        /// </summary>
        public string Account { get; set; }

       /// <summary>
       /// 姓名
       /// </summary>
        public string Name { get; set; }

       /// <summary>
       /// 邮箱
       /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public long RoleId { get; set; }

        public SysRole SysRole { get; set; }

    }
}
