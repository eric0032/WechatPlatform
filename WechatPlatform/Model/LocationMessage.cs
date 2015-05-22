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
    /// 地理位置消息
    /// </summary>
    public class LocationMessage : MessageBase
    {
        [XmlElement("LocationX")]
        /// <summary>
        /// 纬度
        /// </summary>
        public string LocationX { get; set; }

        [XmlElement("LocationY")]
        /// <summary>
        /// 经度
        /// </summary>
        public string LocationY { get; set; }

        [XmlElement("Scale")]
        /// <summary>
        /// 地图缩放大小
        /// </summary>
        public string Scale { get; set; }

        [XmlElement("Label")]
        /// <summary>
        /// 地理位置信息
        /// </summary>
        public string Label { get; set; }

        [XmlElement("MsgId")]
        /// <summary>
        /// 消息ID
        /// </summary>
        public string MsgId { get; set; }
    }
}
