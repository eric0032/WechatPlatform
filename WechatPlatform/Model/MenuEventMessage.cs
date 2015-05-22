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
    /// 自定义菜单点击事件
    /// </summary>
    public class MenuEventMessage : MessageBase
    {
        [XmlElement("Event")]
        public string Event { get; set; }

        [XmlElement("EventKey")]
        /// <summary>
        /// 
        /// </summary>
        public string EventKey { get; set; }
    }
}
