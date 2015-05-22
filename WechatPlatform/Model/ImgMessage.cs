using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WechatPlatform.Model
{
    [XmlRoot("xml")]
    /// <summary>
    /// 图片消息
    /// </summary>
    public class ImgMessage : MessageBase
    {
        [XmlElement("PicUrl")]
        /// <summary>
        /// 图片链接
        /// </summary>
        public string PicUrl { get; set; }

        [XmlElement("MediaId")]
        /// <summary>
        /// 图片消息媒体ID
        /// </summary>
        public string MediaId { get; set; }

        [XmlElement("MsgId")]
        /// <summary>
        /// 消息ID
        /// </summary>
        public string MsgId { get; set; }
    }
}
