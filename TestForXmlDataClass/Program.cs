using System.Xml;
using XmlDataManger;

namespace TestForXmlDataClass
{
    class Program
    {
        static void Main()
        {
            // File path for XML data
            string xmlFilePath = "../../../Attendance.xml";

            // Create an instance of XMLDataManager
            XMLDataManager xmlDataManager = new XMLDataManager(xmlFilePath);

            // Add some sample data
            AddSampleData(xmlDataManager);

            // Save the changes
            xmlDataManager.SaveXmlFile(xmlFilePath);
        }

        static void AddSampleData(XMLDataManager xmlDataManager)
        {
            // Example: Add a new attendance record
            XmlNode classNode = xmlDataManager.GetNodes("/AttendanceData/Class").Item(0);
            Console.WriteLine("Class node found: " + classNode?.InnerText);
            if (classNode != null)
            {
                string studentID = "S004";
                string date = "2024-02-17";
                string status = "Present";

                xmlDataManager.AddNode(classNode, "Student");
                XmlNode studentNode = classNode.LastChild;

                xmlDataManager.AddNode(studentNode, "StudentID", studentID);

                XmlNode attendanceRecordsNode = xmlDataManager.GetNodes("/AttendanceData/Class/Students/Student/AttendanceRecords").Item(0);
                Console.WriteLine("AttendanceRecords node found: " + attendanceRecordsNode?.InnerText);
                if (attendanceRecordsNode != null)
                {
                    xmlDataManager.AddNode(attendanceRecordsNode, "Record");
                    XmlNode recordNode = attendanceRecordsNode.LastChild;
                    xmlDataManager.AddNode(recordNode, "Date", date);
                    xmlDataManager.AddNode(recordNode, "Status", status);
                    Console.WriteLine("Sample data added:");
                    Console.WriteLine(new AttendanceRecord(studentID, date, status));
                }
                else
                {
                    Console.WriteLine("Error: AttendanceRecords node not found.");
                }
            }
            else
            {
                Console.WriteLine("Error: Class node not found.");
            }
        }
    }
}
