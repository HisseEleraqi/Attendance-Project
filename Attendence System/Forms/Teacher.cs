using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Attendence_Management_System
{
    public partial class Teacher : Form
    {
        public  AttendanceXmlController xmlController;

        public string teacherID;

        public string className;
        public Teacher(string xmlFilePath)
        {
            InitializeComponent();
            xmlController = new AttendanceXmlController(xmlFilePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Query and add student data to the DataGridView
            List<Course> courses = xmlController.GetCoursesByTeacherID(teacherID);

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
            string selectedDate = dateTimePicker.Value.ToString("yyyy-MM-dd");

            AddStudentDataToGrid(selectedCourseID, selectedDate);
        }

        private void AddStudentDataToGrid(string className, string selectedDate)
        {
            List<StudentData> studentList = xmlController.GetStudentDataByClassName(className, selectedDate);

            // Clear existing rows
            dataGrid.Rows.Clear();

            // Add student data to the DataGridView
            foreach (var student in studentList)
            {
                dataGrid.Rows.Add(student.StudentID, student.StudentName, student.AbsentStatus == "Present");
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
            // Assuming the "AbsentStatus" column is a CheckBox column
            if (e.ColumnIndex == dataGrid.Columns["AbsentStatus"].Index && e.RowIndex >= 0 && e.RowIndex < dataGrid.Rows.Count)
            {
                // Get the student ID, student name, and date from the clicked row
                string studentID = dataGrid.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                string studentName = dataGrid.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
                string date = dateTimePicker.Value.ToString("yyyy-MM-dd");

                // Toggle the "Absent" status in the XML
                xmlController.ToggleAbsentStatusInXml(studentID, studentName, date);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Update the DataGridView for the new selected date
            Class_Data();

            // Add a new attendance record date for all students
            xmlController.AddNewRecordDateForAllStudents(dateTimePicker.Value.ToString("yyyy-MM-dd"));
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
