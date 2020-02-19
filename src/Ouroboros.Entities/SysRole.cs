using Ouroboros.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.Entities
{
    /// <summary>
    /// 角色实体
    /// </summary>
    public class SysRole : BaseEntity
    {
        /// <summary>
        /// 角色名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
