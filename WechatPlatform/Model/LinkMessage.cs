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
    /// 链接消息
    /// </summary>
    public class LinkMessage : MessageBase
    {
        [XmlElement("Title")]
        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title { get; set; }

        [XmlElement("Description")]
        /// <summary>
        /// 消息描述
        /// </summary>
        public string Description { get; set; }

        [XmlElement("Url")]
        /// <summary>
        /// 消息链接
        /// </summary>
        public string Url { get; set; }

        [XmlElement("MsgId")]
        /// <summary>
        /// 消息ID
        /// </summary>
        public string MsgId { get; set; }
    }
}
