using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WechatPlatform.Model;

namespace WechatPlatform.Interface
{
    interface IEncodeModeInterface
    {
        /// <summary>
        /// 接受消息
        /// </summary>
        /// <param name="encrypt"></param>
        /// <returns></returns>
        MessageBase ReceiveMessage(string encrypt);

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="xmlMessage"></param>
        /// <returns></returns>
        string SendMessage(MessageBase xmlMessage);
    }
}
