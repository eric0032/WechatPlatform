using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WechatPlatform.Common
{
    class Tools
    {

        /// <summary>
        /// 将XML字符串反序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlStr"></param>
        /// <returns></returns>
        public static T XmlToObj<T>(string xmlStr) where T : class
        {
            T obj = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader sr = null;
            try
            {
                sr = new StringReader(xmlStr);
                obj = xmlSerializer.Deserialize(sr) as T;
            }
            catch (Exception)
            {
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
            return obj;
        }

        /// <summary>
        /// 将对象序列化为XML字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ObjToXml(object obj)
        {
            string xmlStr = "";

            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
            using (StringWriter sw = new StringWriter())
            {
                XmlWriterSettings xws = new XmlWriterSettings();
                xws.Indent = true;
                xws.OmitXmlDeclaration = true;
                xws.Encoding = System.Text.Encoding.UTF8;

                //run framework 4.0
                //xws.NamespaceHandling = NamespaceHandling.OmitDuplicates;

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                using (XmlWriter xtw = XmlTextWriter.Create(sw, xws))
                {
                    xmlSerializer.Serialize(xtw, obj, ns);
                    xmlStr = sw.ToString();
                }
            }
            return xmlStr;
        }

    }
}
