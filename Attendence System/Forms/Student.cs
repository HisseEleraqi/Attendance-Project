using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Attendence_Management_System
{
    public partial class Student : Form
    {
        public  AttendanceXmlController xmlController;

        public string studentID;

        public string className;
        public Student(string xmlFilePath)
        {
            InitializeComponent();
            xmlController = new AttendanceXmlController(xmlFilePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Query and add student data to the DataGridView
            List<Course> courses = xmlController.GetCoursesByStudentID(studentID);

            /*foreach (Course course in courses)
            {
                Console.WriteLine(course);
            }

            List<Course> courseList = new List<Course>
            {
                new Course { CourseID = "CS101", CourseName = "Computer Science 101" },
                new Course { CourseID = "ENG201", CourseName = "English 201" },
            };*/

            comboBox1.DataSource = courses;
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseName";
            Class_Data();
        }

        private void Class_Data()
        {
            string selectedCourseID = comboBox1.SelectedValue.ToString();

            AddStudentDataToGrid(studentID, selectedCourseID);
        }

        private void AddStudentDataToGrid(string studentID, string className)
        {

            
            List<AttendanceData> attendanceList = xmlController.GetAttendanceDataByStudentIDAndClassName(studentID, comboBox1.SelectedValue.ToString());

            // Clear existing rows
            dataGrid.Rows.Clear();

            // Add attendance records to the DataGridView
            foreach (var record in attendanceList)
            {
                dataGrid.Rows.Add(record.Date, record.AbsentStatus);
            }
        }


        private void Print()
        {
            DataGridViewPrinter.Print(dataGrid);
        }

        private void Print2()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "Attendance.xlsx";

            // Show the dialog and get the result
            DialogResult result = saveFileDialog.ShowDialog();

            // If the user clicks OK, proceed with saving the Excel file
            if (result == DialogResult.OK)
            {
                // Access the existing excelPrinter instance, don't create a new one
                ExcelPrinter.Print(dataGrid, saveFileDialog.FileName);
            }

            // Open the file after saving
            System.Diagnostics.Process.Start(saveFileDialog.FileName);
        }


        

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Print2();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class_Data();

        }
    }
}
