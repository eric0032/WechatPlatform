using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WechatPlatform.Interface;

namespace WechatPlatform.EncodeMode
{
    class CompatibleMode : IEncodeModeInterface
    {
        #region IEncodeModeInterface 成员

        public Model.MessageBase ReceiveMessage(string encrypt, string token, string timestamp, string nonce)
        {
            return null;
        }

        public string SendMessage(Model.MessageBase xmlMessage)
        {
            return null;
        }

        #endregion
    }
}
