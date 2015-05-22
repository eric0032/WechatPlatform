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
    /// 关注、取消关注、扫码
    /// </summary>
    public class SubscribeMessage : MessageBase
    {
        [XmlElement("Event")]
        public string Event { get; set; }

        [XmlElement("EventKey")]
        /// <summary>
        /// 关注时的场景值，
        /// </summary>
        public string EventKey { get; set; }

        [XmlElement("Ticket")]
        public string Ticket { get; set; }
    }
}
