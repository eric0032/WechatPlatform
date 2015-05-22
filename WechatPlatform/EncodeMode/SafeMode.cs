using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WechatPlatform.Common;
using WechatPlatform.Interface;

namespace WechatPlatform.EncodeMode
{
    class SafeMode : IEncodeModeInterface
    {

        private string _token;
        private string _timestamp;
        private string _nonce;
        private string _msgSignature;

        public SafeMode(string token, string timestamp, string nonce, string msgSignature)
        {
            this._token = token;
            this._timestamp = timestamp;
            this._nonce = nonce;
            this._msgSignature = msgSignature;
        }

        #region IEncodeModeInterface 成员

        public Model.MessageBase ReceiveMessage(string encrypt)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(encrypt);

            var node = xmlDocument.SelectSingleNode("Encrypt").Value;

            var arr = new[] { _token, _timestamp, _nonce, encrypt };
            Array.Sort(arr);

            var result = Cryptography.SHA1Encode(string.Join("", arr));
            if (result == _msgSignature)
            {

            }
        }

        public string SendMessage(Model.MessageBase xmlMessage)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
