using System;
using System.Collections.Generic;
using System.Text;

namespace Ouroboros.WebCore
{
    public class SiteSetting
    {
        /// <summary>
        /// 雪花算法参数
        /// </summary>
        public long WorkerId { get; set; }

        /// <summary>
        /// 雪花算法参数
        /// </summary>
        public long DataCenterId { get; set; }

        /// <summary>
        /// 是用户锁定后，多久可以重新登录
        /// </summary>
        public int LoginFailedCountLimits { get; set; }

        /// <summary>
        /// 用户锁定后，多久可以重新登录
        /// </summary>
        public int LoginLockedTimeout { get; set; }

    }
}
