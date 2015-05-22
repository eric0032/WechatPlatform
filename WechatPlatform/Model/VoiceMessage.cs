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
    /// 语音消息
    /// </summary>
    public class VoiceMessage : MessageBase
    {
        [XmlElement("MediaId")]
        /// <summary>
        /// 媒体ID
        /// </summary>
        public string MediaId { get; set; }

        [XmlElement("Format")]
        /// <summary>
        /// 格式
        /// </summary>
        public string Format { get; set; }

        [XmlElement("MsgId")]
        /// <summary>
        /// 消息ID
        /// </summary>
        public string MsgId { get; set; }
    }
}
