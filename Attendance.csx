using System;
using System.Xml;

class Program
{
    public static void Main()
    {
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Attendance.xml");

            // ... Validation code ...

            Console.WriteLine("Validation successful. The XML document is valid against the XSD schema.");

            // Perform CRUD operations
            AddAttendanceRecord(xmlDoc, "CS101", "S003", "2024-02-16", "Present");
            DeleteAttendanceRecord(xmlDoc, "CS101", "S003", "2024-02-16");
            UpdateAttendanceRecord(xmlDoc, "CS101", "S003", "2024-02-16", "Absent");


            // Save changes to the XML file
            xmlDoc.Save("Attendance.xml");

            Console.WriteLine("CRUD operations completed. Modified XML saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception during validation or CRUD operations: {ex.Message}");
        }
    }

    // CRUD operations
    static void AddAttendanceRecord(XmlDocument xmlDoc, string classId, string studentId, string date, string status)
    {
        XmlNode classNode = FindClassNode(xmlDoc, classId);
        if (classNode != null)
        {
            XmlNode studentNode = FindStudentNode(classNode, studentId);

            // Create a new student node if it doesn't exist
            if (studentNode == null)
            {
                studentNode = CreateStudentNode(xmlDoc, classNode, studentId);
                Console.WriteLine($"Student {studentId} added to class {classId}");
            }

            // Check if the record already exists for the given date
            XmlNode existingRecordNode = FindAttendanceRecord(studentNode, date);
            if (existingRecordNode != null)
            {
                // Update the existing record
                UpdateAttendanceRecord(xmlDoc, classId, studentId, date, status);
            }
            else
            {
                // Add a new record
                XmlElement recordElement = xmlDoc.CreateElement("Record");
                XmlElement dateElement = xmlDoc.CreateElement("Date");
                dateElement.InnerText = date;
                XmlElement statusElement = xmlDoc.CreateElement("Status");
                statusElement.InnerText = status;

                recordElement.AppendChild(dateElement);
                recordElement.AppendChild(statusElement);

                studentNode.SelectSingleNode("AttendanceRecords").AppendChild(recordElement);
                Console.WriteLine($"Attendance record added for {studentId} on {date}");
            }
        }
        else
        {
            Console.WriteLine($"Class {classId} not found");
        }
    }

    static void UpdateAttendanceRecord(XmlDocument xmlDoc, string classId, string studentId, string date, string newStatus)
    {
        XmlNode recordNode = FindAttendanceRecord(xmlDoc, classId, studentId, date);
        if (recordNode != null)
        {
            recordNode.SelectSingleNode("Status").InnerText = newStatus;
            Console.WriteLine($"Attendance record updated for {studentId} on {date}");
        }
        else
        {
            Console.WriteLine($"Attendance record not found for {studentId} on {date}");
        }
    }

    static void DeleteAttendanceRecord(XmlDocument xmlDoc, string classId, string studentId, string date)
    {
        XmlNode recordNode = FindAttendanceRecord(xmlDoc, classId, studentId, date);
        if (recordNode != null)
        {
            recordNode.ParentNode.RemoveChild(recordNode);
            Console.WriteLine($"Attendance record deleted for {studentId} on {date}");
        }
        else
        {
            Console.WriteLine($"Attendance record not found for {studentId} on {date}");
        }
    }

    // Helper methods
    static XmlNode FindClassNode(XmlDocument xmlDoc, string classId)
    {
        return xmlDoc.SelectSingleNode($"/AttendanceData/Class[ClassID='{classId}']");
    }

    static XmlNode FindStudentNode(XmlNode classNode, string studentId)
    {
        return classNode.SelectSingleNode($"Students/Student[StudentID='{studentId}']");
    }

    static XmlNode FindAttendanceRecord(XmlDocument xmlDoc, string classId, string studentId, string date)
    {
        XmlNode studentNode = FindStudentNode(FindClassNode(xmlDoc, classId), studentId);
        return FindAttendanceRecord(studentNode, date);
    }

    static XmlNode FindAttendanceRecord(XmlNode studentNode, string date)
    {
        if (studentNode != null)
        {
            return studentNode.SelectSingleNode($"AttendanceRecords/Record[Date='{date}']");
        }
        return null;
    }

    static XmlNode CreateStudentNode(XmlDocument xmlDoc, XmlNode classNode, string studentId)
    {
        XmlElement studentElement = xmlDoc.CreateElement("Student");
        XmlElement studentIdElement = xmlDoc.CreateElement("StudentID");
        studentIdElement.InnerText = studentId;

        // Add other student information here if needed

        // Append the new student node to the class node
        studentElement.AppendChild(studentIdElement);
        studentElement.AppendChild(xmlDoc.CreateElement("AttendanceRecords")); // Initialize AttendanceRecords

        classNode.SelectSingleNode("Students").AppendChild(studentElement);

        return studentElement;
    }
}
Program.Main();
