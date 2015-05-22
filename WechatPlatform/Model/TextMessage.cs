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
    /// 文本消息
    /// </summary>
    public class TextMessage : MessageBase
    {
        [XmlElement("Content")]
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }

        [XmlElement("MsgId")]
        /// <summary>
        /// 消息Id
        /// </summary>
        public string MsgId { get; set; }
    }
}
