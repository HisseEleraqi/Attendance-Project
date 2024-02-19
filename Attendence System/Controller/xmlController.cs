using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;


namespace Attendence_Management_System
{
    public class xmlController
    {
        public static XmlDocument ReadAllDocument()
        {
            XmlDocument XmlDoc = new XmlDocument();
            
            XmlDoc.Load("../../../Resources/Data.xml");

            return XmlDoc;
        }

        public static List<string> NodesToList(string nodePath, string target)
        {
            List<string> list = new List<string>();
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNodeList nodeList = XmlDoc.SelectNodes(nodePath);
            foreach (XmlNode node in nodeList)
            {
                list.Add(node.SelectSingleNode(target).InnerText);
            }
            return list;
        }

       

        public static List<List<string>> MultibleNodesToList(string nodepath, string target, params string[] targets)
        {
            List<List<string>> list = new List<List<string>>();
            list.Add(NodesToList(nodepath, target));

            foreach (string t in targets)
            {
                list.Add(NodesToList(nodepath, t));
            }
            return list;
        }

        public static XmlNode? GetNode(string nodePath, string target, string value)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            return GetNode(XmlDoc, nodePath, target, value);
        }

        public static XmlNode? GetNode(XmlDocument XmlDoc, string nodePath, string target, string value)
        {
            string xPath = string.Format("{0}[{1}='{2}']", nodePath, target, value);
            XmlNode? userNode = XmlDoc.SelectSingleNode(xPath);
            return userNode;
        }
    }

}
