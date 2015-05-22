using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WechatPlatform
{
    /// <summary>
    /// 加密方式
    /// </summary>
    public enum EncodeModeEnum
    {
        /// <summary>
        /// 公开的
        /// </summary>
        PublicMode,

        /// <summary>
        /// 兼容的
        /// </summary>
        CompatibleMode,

        /// <summary>
        /// 安全的
        /// </summary>
        SafeMode
    }
}
