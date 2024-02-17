namespace XmlDataManger
{
    using System;
    using System.Xml;

    public class XMLDataManager
    {
        private  XmlDocument xmlDoc;

        public XMLDataManager(string xmlFilePath)
        {
            xmlDoc = new XmlDocument();
            LoadXmlFile(xmlFilePath);
        }

        private void LoadXmlFile(string filePath)
        {
            try
            {
                xmlDoc.Load(filePath);
                Console.WriteLine($"Loaded XML file: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading XML file: {ex.Message}");
            }
        }

        public void SaveXmlFile(string filePath)
        {
            try
            {
                xmlDoc.Save(filePath);
                Console.WriteLine($"XML file saved: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }

        public XmlNodeList? GetNodes(string xpath)
        {
            return xmlDoc.SelectNodes(xpath);
        }

        public void AddNode(XmlNode parentNode, string nodeName, string? innerText = null)
        {
            XmlElement newNode = xmlDoc.CreateElement(nodeName);
            if (innerText != null)
            {
                newNode.InnerText = innerText;
            }
            parentNode.AppendChild(newNode);
        }
    }
}