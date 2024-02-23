using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendence_Management_System
{
    public class AttendanceXmlController
    {
        private string XmlFilePath { get; }

        public AttendanceXmlController(string xmlFilePath)
        {
            XmlFilePath = xmlFilePath;
        }
        public List<Course> GetCoursesByTeacherID(string teacherID)
        {
            List<Course> courseList = new List<Course>();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                XmlNodeList classNodes = xmlDoc.SelectNodes("/AttendanceData/Class");

                if (classNodes != null)
                {
                    foreach (XmlNode classNode in classNodes)
                    {
                        XmlNode teacherIDNode = classNode.SelectSingleNode("TeacherID");

                        if (teacherIDNode != null && teacherIDNode.InnerText == teacherID)
                        {
                            XmlNode courseIDNode = classNode.SelectSingleNode("ClassID");
                            XmlNode courseNameNode = classNode.SelectSingleNode("ClassName");

                            if (courseIDNode != null && courseNameNode != null)
                            {
                                string courseID = courseIDNode.InnerText;
                                string courseName = courseNameNode.InnerText;

                                courseList.Add(new Course
                                {
                                    CourseID = courseID,
                                    CourseName = courseName
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during XML processing: {ex.Message}");
            }

            return courseList;
        }

        public List<StudentData> GetStudentDataByClassName(string className, string selectedDate)
        {
            List<StudentData> studentList = new List<StudentData>();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                XmlNode classNode = FindClassNode(xmlDoc, className);

                if (classNode != null)
                {
                    XmlNodeList studentNodes = classNode.SelectNodes("Students/Student");

                    if (studentNodes != null)
                    {
                        foreach (XmlNode studentNode in studentNodes)
                        {
                            // Get the StudentID and StudentName nodes
                            XmlNode studentIDNode = studentNode.SelectSingleNode("StudentID");
                            XmlNode studentNameNode = studentNode.SelectSingleNode("StudentName");

                            // If both nodes are found, add the student data to the list
                            if (studentIDNode != null && studentNameNode != null)
                            {
                                // Get the student ID and name
                                string studentID = studentIDNode.InnerText;
                                string studentName = studentNameNode.InnerText;

                                // Get the attendance record for the specified date
                                XmlNodeList attendanceRecords = studentNode.SelectNodes($"AttendanceRecords/Record[Date='{selectedDate}']");
                                string attendanceStatus = (attendanceRecords != null && attendanceRecords.Count > 0) ?
                                    attendanceRecords[0].SelectSingleNode("Status").InnerText : "Absent";

                                // Add the student data to the list
                                studentList.Add(new StudentData
                                {
                                    StudentID = studentID,
                                    StudentName = studentName,
                                    AbsentStatus = attendanceStatus
                                });
                            }
                            else
                            {
                                Console.WriteLine("Invalid student node structure");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No students found for the specified class");
                    }
                }
                else
                {
                    Console.WriteLine($"Class {className} not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during XML processing: {ex.Message}");
            }

            return studentList;
        }
        public void AddNewRecordDateForAllStudents(string newDate)
        {
            try
            {
                // Load XML document
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                // Get all class nodes
                XmlNodeList classNodes = xmlDoc.SelectNodes("/AttendanceData/Class");

                if (classNodes != null)
                {
                    foreach (XmlNode classNode in classNodes)
                    {
                        // Get all student nodes in the current class
                        XmlNodeList studentNodes = classNode.SelectNodes("Students/Student");

                        if (studentNodes != null)
                        {
                            foreach (XmlNode studentNode in studentNodes)
                            {
                                // Check if the attendance record for the new date already exists
                                XmlNode existingRecord = studentNode.SelectSingleNode($"AttendanceRecords/Record[Date='{newDate}']");

                                if (existingRecord == null)
                                {
                                    // If not, add a new attendance record for the new date
                                    XmlNode attendanceRecordsNode = studentNode.SelectSingleNode("AttendanceRecords");

                                    if (attendanceRecordsNode != null)
                                    {
                                        XmlNode newRecordNode = xmlDoc.CreateElement("Record");
                                        XmlNode dateNode = xmlDoc.CreateElement("Date");
                                        dateNode.InnerText = newDate;

                                        XmlNode statusNode = xmlDoc.CreateElement("Status");
                                        statusNode.InnerText = "Absent"; // You can set the default status if needed

                                        newRecordNode.AppendChild(dateNode);
                                        newRecordNode.AppendChild(statusNode);

                                        attendanceRecordsNode.AppendChild(newRecordNode);
                                    }
                                }
                            }
                        }
                    }

                    // Save changes to XML
                    xmlDoc.Save(XmlFilePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during XML processing: {ex.Message}");
            }
        }
        public void ToggleAbsentStatusInXml(string courseName, string studentID, string date)
        {
/*            // Print Data
            Console.WriteLine(courseName);

            Console.WriteLine(studentID);
            Console.WriteLine(date);
*/
            // Load XML document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XmlFilePath);

            // Find the student node
            XmlNode studentNode = FindStudentNodeByCourseName(xmlDoc, courseName, studentID);

            if (studentNode != null)
            {
                // Find the attendance record for the specified date
                XmlNode recordNode = FindAttendanceRecord(studentNode, date);

                if (recordNode != null)
                {
                    // Toggle the "AbsentStatus" value
                    string currentStatus = recordNode.SelectSingleNode("Status").InnerText;

                    recordNode.SelectSingleNode("Status").InnerText = (currentStatus == "Present") ? "Absent" : "Present";
                    //
                    Console.WriteLine("Attendance status updated successfully");
                    // Save changes to XML
                    xmlDoc.Save(XmlFilePath);
                }
                else
                {
                    Console.WriteLine($"Attendance record for {date} not found");
                }
            }
            else
            {
                Console.WriteLine($"Student {studentID} not found");
            }
        }
        public List<AttendanceData> GetAttendanceDataByStudentIDAndClassName(string studentID, string className)
        {
            List<AttendanceData> attendanceList = new List<AttendanceData>();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                XmlNode classNode = FindClassNode(xmlDoc, className);
                Console.WriteLine(classNode);
                if (classNode != null)
                {
                    XmlNode studentNode = classNode.SelectSingleNode($"Students/Student[StudentID='{studentID}']"); 
                    Console.WriteLine(studentNode);
                    if (studentNode != null)
                    {
                        XmlNodeList attendanceRecords = studentNode.SelectNodes("AttendanceRecords/Record");

                        if (attendanceRecords != null)
                        {
                            foreach (XmlNode recordNode in attendanceRecords)
                            {
                                XmlNode dateNode = recordNode.SelectSingleNode("Date");
                                XmlNode statusNode = recordNode.SelectSingleNode("Status");

                                if (dateNode != null && statusNode != null)
                                {
                                    string date = dateNode.InnerText;
                                    string status = statusNode.InnerText;

                                    attendanceList.Add(new AttendanceData
                                    {
                                        StudentID = studentID,
                                        ClassName = className,
                                        Date = date,
                                        AbsentStatus = status
                                    });
                                }
                                else
                                {
                                    Console.WriteLine("Invalid attendance record node structure");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No attendance records found for the specified student");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Student {studentID} not found in class {className}");
                    }
                }
                else
                {
                    Console.WriteLine($"Class {className} not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during XML processing: {ex.Message}");
            }

            return attendanceList;
        }
        public List<Course> GetCoursesByStudentID(string studentID)
        {
            List<Course> enrolledCourses = new List<Course>();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                XmlNodeList studentNodes = xmlDoc.SelectNodes($"/AttendanceData/Class/Students/Student[StudentID='{studentID}']");

                if (studentNodes != null && studentNodes.Count > 0)
                {
                    foreach (XmlNode studentNode in studentNodes)
                    {
                        XmlNode classNode = studentNode.ParentNode.ParentNode; // Get the parent class node

                        if (classNode != null)
                        {
                            string courseID = classNode.SelectSingleNode("ClassID")?.InnerText;
                            string courseName = classNode.SelectSingleNode("ClassName")?.InnerText;

                            if (!string.IsNullOrEmpty(courseID) && !string.IsNullOrEmpty(courseName))
                            {
                                enrolledCourses.Add(new Course
                                {
                                    CourseID = courseID,
                                    CourseName = courseName
                                });
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Student {studentID} not found in any class");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during XML processing: {ex.Message}");
            }

            return enrolledCourses;
        }


        private XmlNode FindClassNode(XmlDocument xmlDoc, string className)
        {
            return xmlDoc.SelectSingleNode($"/AttendanceData/Class[ClassName='{className}']");
        }
/*
        private XmlNode FindStudentNode(XmlDocument xmlDoc, string studentID, string studentName)
        {
            return xmlDoc.SelectSingleNode($"/AttendanceData/Class/Students/Student[StudentID='{studentID}' and StudentName='{studentName}']");
        }*/
        private XmlNode FindStudentNode(XmlDocument xmlDoc, string className, string studentID)
        {
            return xmlDoc.SelectSingleNode($"/AttendanceData/Class[ClassID='{className}']/Students/Student[StudentID='{studentID}']");
        }
        private XmlNode FindStudentNodeByCourseName(XmlDocument xmlDoc, string className, string studentID)
        {
            return xmlDoc.SelectSingleNode($"/AttendanceData/Class[ClassName='{className}']/Students/Student[StudentID='{studentID}']");
        }

        private XmlNode FindAttendanceRecord(XmlNode studentNode, string date)
        {
            if (studentNode != null)
            {
                return studentNode.SelectSingleNode($"AttendanceRecords/Record[Date='{date}']");
            }
            return null;
        }
    }
}
public class AttendanceData
{
    public string StudentID { get; set; }
    public string ClassName { get; set; }
    public string Date { get; set; }
    public string AbsentStatus { get; set; }
}
