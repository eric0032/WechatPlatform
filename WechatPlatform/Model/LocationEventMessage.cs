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
    /// 上报地理位置事件
    /// </summary>
    public class LocationEventMessage : MessageBase
    {
        [XmlElement("Event")]
        /// <summary>
        /// 
        /// </summary>
        public string Event { get; set; }

        [XmlElement("Latitude")]
        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude { get; set; }

        [XmlElement("Longitude")]
        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude { get; set; }

        [XmlElement("Precision")]
        /// <summary>
        /// 精度
        /// </summary>
        public string Precision { get; set; }
    }
}
