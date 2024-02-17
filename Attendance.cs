using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DGVPrinterHelper;
using OfficeOpenXml;
using System.IO;
using System.Xml;
using System.Drawing;

namespace Attendance_Sheet
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Query and add student data to the DataGridView
            string className = "Computer Science 101";
            List<Course> courseList = new List<Course>
        {
            new Course { CourseID = "CS101", CourseName = "Computer Science 101" },
            new Course { CourseID = "ENG201", CourseName = "English 201" },
        };

            comboBox1.DataSource = courseList;
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseName";
            Class_Data();
        }

        private void Class_Data()
        {
 
            string selectedCourseID = comboBox1.SelectedValue.ToString();
            string selectedDate = dateTimePicker.Value.ToString("yyyy-MM-dd");

            AddStudentDataToGrid(dataGrid, selectedCourseID, selectedDate);
        }

        private List<StudentData> GetStudentDataByClassName(string xmlFilePath, string className, string selectedDate)
        {
            List<StudentData> studentList = new List<StudentData>();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

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
        // Add student data to the DataGridView from the XML file
        private void AddStudentDataToGrid(DataGridView dataGridView, string className, string selectedDate)
        {
            List<StudentData> studentList = GetStudentDataByClassName("../../Attendance.xml", className, selectedDate);

            // Clear existing rows
            dataGridView.Rows.Clear();

            // Add student data to the DataGridView
            foreach (var student in studentList)
            {
                dataGridView.Rows.Add(student.StudentID, student.StudentName, student.AbsentStatus=="Present");
            }
        }

        // Print PDF
        private void Print()
        {
            // Create a DGVPrinter
            DGVPrinter printer = new DGVPrinter();

            // Title
            printer.Title = "Attendance Sheet";
            printer.SubTitle = "hello";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            // Footer
            printer.Footer = "Attendance";
            printer.FooterSpacing = 15;

            // Print the DataGridView
            printer.PrintDataGridView(dataGrid);
        }
        
        private void Print2()
        {
            // Create a SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "Attendance.xlsx";

            // Show the dialog and get the result
            DialogResult result = saveFileDialog.ShowDialog();

            // If the user clicks OK, proceed with saving the Excel file
            if (result == DialogResult.OK)
            {
                SaveAsExcel(dataGrid, saveFileDialog.FileName);
            }
            // open the file after saving
            System.Diagnostics.Process.Start(saveFileDialog.FileName);
        }
        // Save DataGridView data to an Excel file
        private void SaveAsExcel(DataGridView dataGridView, string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Copy DataGridView data to Excel worksheet
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                    for (int j = 1; j <= dataGridView.Rows.Count; j++)
                    {
                        // If it's a CheckBox column, set the value to 1 if checked, 0 if unchecked
                        if (dataGridView.Columns[i - 1] is DataGridViewCheckBoxColumn)
                        {
                            bool isChecked = Convert.ToBoolean(dataGridView.Rows[j - 1].Cells[i - 1].Value);
                            worksheet.Cells[j + 1, i].Value = isChecked ? 1 : 0;
                        }
                        else
                        {
                            worksheet.Cells[j + 1, i].Value = dataGridView.Rows[j - 1].Cells[i - 1].Value;
                        }
                    }
                }

                // Save the Excel file using the provided file path
                package.SaveAs(new FileInfo(filePath));
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Print2();
        }
        static XmlNode FindClassNode(XmlDocument xmlDoc, string className)
        {
            return xmlDoc.SelectSingleNode($"/AttendanceData/Class[ClassName='{className}']");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class_Data();
        }


        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming the "AbsentStatus" column is a CheckBox column
            if (e.ColumnIndex == dataGrid.Columns["AbsentStatus"].Index && e.RowIndex >= 0 && e.RowIndex < dataGrid.Rows.Count)
            {
                // Get the student ID, student name, and date from the clicked row
                string studentID = dataGrid.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                string studentName = dataGrid.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                string date= dateTimePicker.Value.ToString("yyyy-MM-dd");

                // Toggle the "Absent" status in the XML
                ToggleAbsentStatusInXml(studentID, studentName, date);

               
            }
        }

        private void ToggleAbsentStatusInXml(string studentID, string studentName, string date)
        {
           
            // Load XML document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../Attendance.xml");

            // Find the student node
            XmlNode studentNode = FindStudentNode(xmlDoc, studentID, studentName);

            if (studentNode != null)
            {
                // Find the attendance record for the specified date
                XmlNode recordNode = FindAttendanceRecord(studentNode, date);

                if (recordNode != null)
                {
                    // Toggle the "AbsentStatus" value
                    string currentStatus = recordNode.SelectSingleNode("Status").InnerText;
                    recordNode.SelectSingleNode("Status").InnerText = (currentStatus == "Present") ? "Absent" : "Present";

                    // Save changes to XML
                    xmlDoc.Save("../../Attendance.xml");
                }
            }
        }

        private XmlNode FindStudentNode(XmlDocument xmlDoc, string studentID, string studentName)
        {
            return xmlDoc.SelectSingleNode($"/AttendanceData/Class/Students/Student[StudentID='{studentID}' and StudentName='{studentName}']");
        }

        private XmlNode FindAttendanceRecord(XmlNode studentNode, string date)
        {
            if (studentNode != null)
            {
                return studentNode.SelectSingleNode($"AttendanceRecords/Record[Date='{date}']");
            }
            return null;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Update the DataGridView for the new selected date
            Class_Data();

            // Add a new attendance record date for all students
            AddNewRecordDateForAllStudents(dateTimePicker.Value.ToString("yyyy-MM-dd"));
        }

        private void AddNewRecordDateForAllStudents(string newDate)
        {
            // Load XML document
            XmlDocument xmlDoc = new XmlDocument();
            
            xmlDoc.Load("../../Attendance.xml");

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
                xmlDoc.Save("../../Attendance.xml");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Print2();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Print();
        }
    }
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }

        public override string ToString()
        {
            return $"{CourseID} - {CourseName}";
        }
    }
    public class StudentData
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string AbsentStatus { get; set; }


    }
}
