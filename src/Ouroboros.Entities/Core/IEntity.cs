using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.Entities.Core
{
    /// <summary>
    /// 没有Id主键的实体继承这个
    /// </summary>
    public interface IEntity
    {
    }

    /// <summary>
    /// 有Id主键的实体继承这个
    /// </summary>
    public abstract class BaseEntity : IEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public long? Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        public long? Modifier { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }

}
