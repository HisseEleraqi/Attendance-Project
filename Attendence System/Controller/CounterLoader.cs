using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Attendence_System.Controller
{
    internal class CounterLoader
    {
        public static void LoadCountersFromXML(string filePath)
        {
            XElement root = XElement.Load(filePath);
            var students = root.Element("students");
            var teachers = root.Element("teachers");
            if (students != null)
            {
                var lastStudent = students.Elements("student").Last();
                string lastId = lastStudent.Attribute("id").Value.Split('-')[1];
                AddUser.SetStudentCounter(int.Parse(lastId));

            }
            if(teachers != null)
            {
                var lastTeacher = teachers.Elements("teacher").Last();
                string lastId = lastTeacher.Attribute("id").Value.Split('-')[1];
                AddUser.SetTeacherCounter(int.Parse(lastId));
            }
        
        }
    }
}
