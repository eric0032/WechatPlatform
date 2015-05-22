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
    /// 视频、小视频id
    /// </summary>
    public class VideoMessage : MessageBase
    {
        [XmlElement("MediaId")]
        /// <summary>
        /// 视频消息媒体ID
        /// </summary>
        public string MediaId { get; set; }

        [XmlElement("ThumbMediaId")]
        /// <summary>
        /// 缩略图的媒体ID
        /// </summary>
        public string ThumbMediaId { get; set; }

        [XmlElement("MsgId")]
        /// <summary>
        /// 消息id
        /// </summary>
        public string MsgId { get; set; }

    }
}
