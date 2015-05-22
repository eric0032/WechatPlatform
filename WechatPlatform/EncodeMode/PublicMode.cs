using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WechatPlatform.Common;
using WechatPlatform.Interface;

namespace WechatPlatform.EncodeMode
{
    class PublicMode : IEncodeModeInterface
    {
        #region IEncodeModeInterface 成员

        public Model.MessageBase ReceiveMessage(string encrypt, string token, string timestamp, string nonce)
        {
            var model = Tools.XmlToObj<Model.MessageBase>(encrypt);
            return model;
        }

        public string SendMessage(Model.MessageBase xmlMessage)
        {
            var str = Tools.ObjToXml(xmlMessage);
            return str;
        }

        #endregion
    }
}
