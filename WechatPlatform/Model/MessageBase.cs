using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WechatPlatform.Model
{
    [XmlRoot("xml")]
    public class MessageBase
    {
        [XmlElement("ToUserName")]
        /// <summary>
        /// 接受消息的微信号
        /// </summary>
        public string ToUserName { get; set; }

        [XmlElement("FromUserName")]
        /// <summary>
        /// 发送方帐号
        /// </summary>
        public string FromUserName { get; set; }

        [XmlElement("CreateTime")]
        /// <summary>
        /// 创建消息时间
        /// </summary>
        public string CreateTime { get; set; }

        [XmlElement("MsgType")]
        /// <summary>
        /// 消息类型
        /// </summary>
        public string MsgType { get; set; }
    }
}
