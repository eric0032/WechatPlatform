using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using WechatPlatform.Common;
using WechatPlatform.EncodeMode;
using WechatPlatform.Interface;
using WechatPlatform.Model;

namespace WechatPlatform
{
    public class Passive
    {

        /// <summary>
        /// 被动响应消息
        /// </summary>
        /// <param name="context">请求上下文</param>
        /// <param name="mode">加密方式</param>
        /// <param name="token">令牌</param>
        /// <param name="encodingAESkey">加、解密的密钥</param>
        public static void Handler(HttpContext context, EncodeModeEnum mode, string token, string encodingAESkey)
        {
            string signature = context.Request.QueryString["signature"];
            string timestamp = context.Request.QueryString["timestamp"];
            string nonce = context.Request.QueryString["nonce"];

            //验证是否为微信服务器发送的请求
            var result = ValidateMessage(signature, timestamp, nonce, token);
            if (!result)//如果不是微信服务器发过来的请求，就返回一个空的字符串
                context.Response.Write("");

            if (context.Request.RequestType.ToLower() == "get")
            {
                var echostr = context.Request.QueryString["echostr"];
                context.Response.Write(echostr);
            }
            else
            {
                IEncodeModeInterface instance = null;
                var stream = context.Request.InputStream;
                var sr = new StreamReader(stream);
                var xmlStr = sr.ReadToEnd();

                if (mode == EncodeModeEnum.PublicMode)
                    instance = new PublicMode();

                var messageBase = instance.ReceiveMessage(xmlStr);
                
            }
        }

        /// <summary>
        /// 验证消息来源是否是微信服务器
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private static bool ValidateMessage(string signature, string timestamp, string nonce, string token)
        {
            //将token,timestamp,nonce排序
            var arr = new[] { token, timestamp, nonce };
            Array.Sort(arr);
            //排完序后拼接起来
            var str = string.Join("", arr);
            //再进行加密
            var result = Cryptography.SHA1Encode(str);
            //加密后的结果和signature进行对比
            return result.Equals(signature);
        }



        /// <summary>
        /// 获取消息内容
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private static MessageBase GetMessageBody(Stream inputStream, EncodeModeEnum mode, string token, string timestamp, string nonce,string msg_signature)
        {
            //读取到消息
            var sr = new StreamReader(inputStream);
            var messageBody = sr.ReadToEnd();

            //判断消息是否加密
            if (mode == EncodeModeEnum.PublicMode)
            {
                return Tools.XmlToObj<MessageBase>(messageBody);
            }
            if (mode == EncodeModeEnum.SafeMode)
            {
                var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(messageBody);
                var encrypt = xmlDocument.SelectSingleNode("Encrypt").Value;

                var arr = new[] { token, timestamp, nonce, encrypt };
                Array.Sort(arr);
                var sha1 = Cryptography.SHA1Encode(string.Join("", arr));

                if (sha1 == msg_signature)
                {
 
                }
            }

            return null;
        }




    }
}
