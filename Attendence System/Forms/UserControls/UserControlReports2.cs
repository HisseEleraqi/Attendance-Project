using Attendence_System.Controller;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Attendence_System.Forms.UserControls
{
    public partial class UserControlReports2 : UserControl
    {
        public UserControlReports2()
        {
            InitializeComponent();
            // Move the logic from userControlReports_Load here
            List<string> classIDs = new AttendanceXmlController("..\\..\\..\\Resources\\Attendance.xml").GetAllClassIDs();
            guna2ComboBox1.DataSource = classIDs;

            // Lock the Date Picker to the current date
            StartDate_Picker.MaxDate = DateTime.Now;
            EndDate_Picker.MaxDate = DateTime.Now;
        }

        public class AttendanceData
        {
            public List<Class>? Classes { get; set; }
        }

        public class Class
        {
            public string? ClassID { get; set; }
            public string? ClassName { get; set; }
            public string? TeacherID { get; set; }
            public string? TeacherName { get; set; }
            public List<Student>? Students { get; set; }
        }

        public class Student
        {
            public string? StudentID { get; set; }
            public string? StudentName { get; set; }
            public List<Record>? AttendanceRecords { get; set; }
        }

        public class Record
        {
            public DateTime Date { get; set; }
            public string? Status { get; set; }
        }

        public class AttendanceXmlController
        {
            private readonly XDocument xmlDoc;

            public AttendanceXmlController(string xmlFilePath)
            {
                xmlDoc = XDocument.Load(xmlFilePath);
            }

            public List<Class> GetAllClasses()
            {
                return xmlDoc.Descendants("Class")
                    .Select(classElement => new Class
                    {
                        ClassID = classElement.Element("ClassID").Value,
                        ClassName = classElement.Element("ClassName").Value,
                        TeacherID = classElement.Element("TeacherID").Value,
                        TeacherName = classElement.Element("TeacherName").Value,
                        Students = classElement.Elements("Students")
                            .Elements("Student")
                            .Select(studentElement => new Student
                            {
                                StudentID = studentElement.Element("StudentID").Value,
                                StudentName = studentElement.Element("StudentName").Value,
                                AttendanceRecords = studentElement.Elements("AttendanceRecords")
                                    .Elements("Record")
                                    .Select(recordElement => new Record
                                    {
                                        Date = DateTime.Parse(recordElement.Element("Date").Value),
                                        Status = recordElement.Element("Status").Value
                                    })
                                    .ToList()
                            })
                            .ToList()
                    })
                    .ToList();
            }
            public List<string> GetAllClassIDs()
            {

                return xmlDoc.Descendants("Class")
                    .Select(classElement => classElement.Element("ClassID").Value)
                    .ToList();
            }


            public void PrintWeeklyAttendanceToExcel(string classID, DateTime startDate, DateTime endDate, string filePath)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("WeeklyAttendance");

                    // Header Style
                    using (var range = worksheet.Cells[1, 1, 1, endDate.Subtract(startDate).Days + 5])
                    {
                        range.Style.Font.Bold = true;

                    }

                    // funcition to edit Cell color
                    void EditCellColor(int row, int col, string color)
                    {
                        using (var range = worksheet.Cells[row, col])
                        {
                            range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromName(color));
                        }
                    }
                    // Edit Present to Green
                    EditCellColor(1, endDate.Subtract(startDate).Days + 3, "Green");
                    // Edit Abssent to Red
                    EditCellColor(1, endDate.Subtract(startDate).Days + 4, "Red");
                    // Edit Remaining Days to Yellow
                    EditCellColor(1, endDate.Subtract(startDate).Days + 5, "Yellow");

                    // Header
                    worksheet.Cells[1, 1].Value = "Student Name";

                    // Dates Header
                    int col = 2;
                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        worksheet.Cells[1, col].Value = date.ToString("M/d");
                        col++;
                    }

                    // Total Attended, Total Absent, and Remaining Days Headers
                    worksheet.Cells[1, col].Value = "Total Attended";
                    worksheet.Cells[1, col + 1].Value = "Total Absent";
                    worksheet.Cells[1, col + 2].Value = "Remaining Days";

                    // Data
                    var allClasses = GetAllClasses();
                    var selectedClass = allClasses.FirstOrDefault(c => c.ClassID == classID);

                    if (selectedClass != null)
                    {
                        int row = 2;
                        foreach (var student in selectedClass.Students)
                        {
                            worksheet.Cells[row, 1].Value = student.StudentName;

                            // Fill the attendance status for each date
                            col = 2;
                            int totalAttended = 0;
                            int totalAbsent = 0;

                            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                            {
                                var record = student.AttendanceRecords
                                    .FirstOrDefault(r => r.Date.Date == date.Date);

                                worksheet.Cells[row, col].Value = string.IsNullOrEmpty(record?.Status) ? null : ((record?.Status == "Present") ? 1 : 0);

                                if (record?.Status == "Present")
                                    totalAttended++;
                                else if (record?.Status == "Absent")
                                    totalAbsent++;

                                col++;
                            }

                            // Total Attended, Total Absent, and Remaining Days
                            worksheet.Cells[row, col].Value = totalAttended;
                            worksheet.Cells[row, col + 1].Value = totalAbsent > 5 ? 5 : totalAbsent; // Max days to be absent is 5
                            worksheet.Cells[row, col + 2].Value = 5 - (totalAbsent > 5 ? 5 : totalAbsent); // Remaining Days

                            row++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Class with ID {classID} not found.");
                    }

                    // Remove empty columns
                    for (int i = worksheet.Dimension.End.Column; i >= 2; i--)
                    {
                        var colIsEmpty = worksheet.Cells[2, i, worksheet.Dimension.End.Row, i].All(cell => cell.Value == null || cell.Text == "");
                        if (colIsEmpty)
                        {
                            worksheet.DeleteColumn(i);
                        }
                    }


                    // Auto-size columns and add cell formatting
                    worksheet.Cells.AutoFitColumns();
                    worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                    // Save the Excel file
                    package.SaveAs(new FileInfo(filePath));
                }

                Console.WriteLine("Weekly attendance Excel file has been created successfully!");
            }


        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Generate button clicked"); // Add this line for debugging

            // Specify your XML file path
            string xmlFilePath = "..\\..\\..\\Resources\\Attendance.xml";

            // Create an instance of AttendanceXmlController
            AttendanceXmlController xmlController = new AttendanceXmlController(xmlFilePath);

            // Specify the start date and end date for weekly attendance
            DateTime startDate = StartDate_Picker.Value;
            DateTime endDate = EndDate_Picker.Value;

            // Basic validation for date pickers
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be greater than end date.", "Date Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Specify the class ID you want to filter from the ComboBo xguna2ComboBox1
            string classIDToFilter = guna2ComboBox1.Text;

            // Create a SaveFileDialog to choose the location and filename for saving the Excel file
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Weekly Attendance Report";
                saveFileDialog.FileName = guna2ComboBox1.Text + "_" + startDate.ToString("yyyy-MM-dd") + "_" + endDate.ToString("yyyy-MM-dd");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path from the SaveFileDialog
                    string weeklyAttendanceExcelFilePath = saveFileDialog.FileName;

                    try
                    {
                        // Print weekly attendance to Excel for the specified class
                        xmlController.PrintWeeklyAttendanceToExcel(classIDToFilter, startDate, endDate, weeklyAttendanceExcelFilePath);

                        MessageBox.Show("Weekly attendance report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}


   