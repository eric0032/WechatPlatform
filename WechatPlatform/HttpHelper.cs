using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WechatPlatform
{
    class HttpHelper
    {
        /// <summary>
        /// 发起一个http请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="method">请求方法:post|get</param>
        /// <param name="args">请求参数</param>
        /// <returns></returns>
        public static string HttpRequest(string url, string method, string args, string postData = "", string encoding = "utf-8")
        {
            HttpWebRequest _request = null;
            HttpWebResponse _response = null;
            StreamReader _reader = null;

            try
            {
                if (url.IndexOf("?", StringComparison.Ordinal) == -1)
                    url = url + "?" + args;
                else
                    url = url.Substring(0, url.IndexOf("?", StringComparison.Ordinal) - 1) + "?" + args;

                _request = (HttpWebRequest)WebRequest.Create(url);
                if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                    _request.ProtocolVersion = HttpVersion.Version10;
                }
                _request.Method = method;

                if (method.ToLower() == "post")
                {
                    using (Stream requestStream = _request.GetRequestStream())
                    {
                        byte[] postDataBytes = Encoding.GetEncoding(encoding).GetBytes(postData);
                        requestStream.Write(postDataBytes, 0, postDataBytes.Length);
                    }
                }

                _response = (HttpWebResponse)_request.GetResponse();
                _reader = new StreamReader(_response.GetResponseStream(), Encoding.GetEncoding(encoding));

                return _reader.ReadToEnd();

            }
            catch (Exception ex)
            {
                throw new Exception("HttpRequest Error:" + ex.Message);
            }
            finally
            {
                _request = null;
                if (_response != null)
                {
                    _response.Close();
                    _reader.Dispose();
                }
            }
        }

    }
}
