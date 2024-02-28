using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Attendence_System.Controller;
namespace Attendence_Management_System;

internal class CounterLoader
{
    public static void LoadCountersFromXML(string filePath)
    {
        XElement root = XElement.Load(filePath);

        XmlDocument doc = new XmlDocument();
        doc.Load(filePath);

        var students = root.Element("students");
        var teachers = root.Element("teachers");
        var classes = root.Element("AttendanceData");
        Console.WriteLine("Loading Counters");
        if (students != null)
        {
            var lastStudent = students.Elements("student").Last();
            string lastId = lastStudent.Attribute("id").Value.Split('-')[1];
            AddUser.SetStudentCounter(int.Parse(lastId) + 1);

        }
        if (teachers != null)
        {
            var lastTeacher = teachers.Elements("teacher").Last();
            string lastId = lastTeacher.Attribute("id").Value.Split('-')[1];
            AddUser.SetTeacherCounter(int.Parse(lastId) + 1);
        }


        XmlDocument XmlDoc = xmlController.ReadSecondDocument();
        XmlDoc.Load(filePath);
        XmlNodeList nodeList = XmlDoc.SelectNodes("/AttendanceData/Class");
        Console.WriteLine(nodeList.Count);
        if (nodeList != null)
        {
            var lastClass = nodeList[nodeList.Count - 1];
            string lastClassId = lastClass.SelectSingleNode("ClassID").InnerText.Split('-')[1];


            AddClass.SetClassCounter(int.Parse(lastClassId) + 1);
        }


    }
}
