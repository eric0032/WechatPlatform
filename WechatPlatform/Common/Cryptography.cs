using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WechatPlatform.Common
{
    class Cryptography
    {
        /// <summary>
        /// 对字符串进行SHA1加密
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string SHA1Encode(string source)
        {
            byte[] StrRes = Encoding.Default.GetBytes(source);
            HashAlgorithm iSHA = new SHA1CryptoServiceProvider();
            StrRes = iSHA.ComputeHash(StrRes);
            StringBuilder EnText = new StringBuilder();
            foreach (byte iByte in StrRes)
            {
                EnText.AppendFormat("{0:x2}", iByte);
            }
            return EnText.ToString();
        }





    }
}
