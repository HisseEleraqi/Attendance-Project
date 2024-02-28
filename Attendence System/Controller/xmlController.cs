using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


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
        public static XmlDocument ReadSecondDocument()
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load("../../../Resources/Attendance.xml");
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
        // function to add a new user to the xml file
        public static void XMLAddUser(string userName, string role, string password, string email, string ID)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            //make the root is custom node called users
            XmlNode root = XmlDoc.SelectSingleNode("/school/users");

            XmlNode user = XmlDoc.CreateElement("user");
            XmlNode userNameNode = XmlDoc.CreateElement("username");
            userNameNode.InnerText = userName;
            XmlNode roleNode = XmlDoc.CreateElement("role");
            roleNode.InnerText = role;
            XmlNode passwordNode = XmlDoc.CreateElement("password");
            passwordNode.InnerText = password;
            XmlNode emailNode = XmlDoc.CreateElement("email");
            emailNode.InnerText = email;
            XmlNode idNode = XmlDoc.CreateElement("id");
            idNode.InnerText = ID;
            user.AppendChild(idNode);
            user.AppendChild(userNameNode);
            user.AppendChild(roleNode);
            user.AppendChild(passwordNode);
            user.AppendChild(emailNode);
            root.AppendChild(user);
            XmlDoc.Save("../../../Resources/Data.xml");
            XMLAddRole(role, ID, userName);
        }
        public static void XMLAddRole(string role, string id, string name)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            // based on rule choose the root node
            XmlNode root;
            switch (role.ToLower())
            {
                case "admin":
                    root = XmlDoc.SelectSingleNode("/school/admins");
                    AddAdmin(id, name);
                    break;
                case "teacher":
                    root = XmlDoc.SelectSingleNode("/school/teachers");
                    AddTeacher(id, name);
                    break;
                case "student":
                    root = XmlDoc.SelectSingleNode("/school/students");
                    AddStudent(id, name, root);
                    break;
            }
        }
        public static void AddStudent(string id, string name, XmlNode root)
        {
            // create node student with id attribute and name as value
            XmlNode student = root.OwnerDocument.CreateElement("student");
            XmlAttribute idAttribute = root.OwnerDocument.CreateAttribute("id");
            idAttribute.Value = id;
            student.Attributes.Append(idAttribute);
            // add name as node
            XmlNode nameNode = root.OwnerDocument.CreateElement("name");
            nameNode.InnerText = name;
            student.AppendChild(nameNode);
            root.AppendChild(student);
            root.OwnerDocument.Save("../../../Resources/Data.xml");
        }
        public static void AddAdmin(string id, string name)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode root = XmlDoc.SelectSingleNode("/school/admins");
            XmlNode admin = root.OwnerDocument.CreateElement("admin");
            XmlAttribute idAttribute = root.OwnerDocument.CreateAttribute("id");
            idAttribute.Value = id;
            admin.Attributes.Append(idAttribute);
            XmlNode nameNode = root.OwnerDocument.CreateElement("name");
            nameNode.InnerText = name;
            admin.AppendChild(nameNode);
            root.AppendChild(admin);
            root.OwnerDocument.Save("../../../Resources/Data.xml");
        }
        public static void AddTeacher(string id, string name)
        {
            XmlDocument XmlDoc = ReadSecondDocument();
            XmlNode root = XmlDoc.SelectSingleNode("/school/teachers");
            XmlNode teacher = root.OwnerDocument.CreateElement("teacher");
            XmlAttribute idAttribute = root.OwnerDocument.CreateAttribute("id");
            idAttribute.Value = id;
            teacher.Attributes.Append(idAttribute);
            XmlNode nameNode = root.OwnerDocument.CreateElement("name");
            nameNode.InnerText = name;
            teacher.AppendChild(nameNode);
            root.AppendChild(teacher);
            root.OwnerDocument.Save("../../../Resources/Data.xml");
        }

        public static void XMLAddClass(string id, string name)
        {

            XmlDocument XmlDoc = ReadSecondDocument();
            XmlNode root = XmlDoc.SelectSingleNode("/AttendanceData");

            XmlNode user = root.OwnerDocument.CreateElement("Class");
            XmlNode IdNode = root.OwnerDocument.CreateElement("ClassID");
            IdNode.InnerText = id;
            XmlNode NameNode = root.OwnerDocument.CreateElement("ClassName");
            NameNode.InnerText = name;
            XmlNode teacherIdNode = root.OwnerDocument.CreateElement("TeacherID");
            teacherIdNode.InnerText = "0";

            XmlNode teacherNameNode = root.OwnerDocument.CreateElement("TeacherName");
            teacherIdNode.InnerText = "0";

            XmlNode Students = root.OwnerDocument.CreateElement("Students");
            XmlNode student = root.OwnerDocument.CreateElement("Student");
            student.InnerText = "0";
            Students.AppendChild(student);

            user.AppendChild(IdNode);
            user.AppendChild(NameNode);
            user.AppendChild(teacherIdNode);
            user.AppendChild(teacherNameNode);
            user.AppendChild(Students);
            root.AppendChild(user);
            root.OwnerDocument.Save("../../../Resources/Attendance.xml");
        }
    }

}
