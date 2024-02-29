using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Attendence_Management_System.Forms;

namespace Attendence_Management_System
{
    public partial class Teacher : Form
    {
        public AttendanceXmlController xmlController;

        public string teacherID;

        public string className;
        public Teacher(string xmlFilePath)
        {
            InitializeComponent();
            xmlController = new AttendanceXmlController(xmlFilePath);
            // Fix DateTimePicker MaxDate
            // teacherID = "T001";
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.Items.Add("Arabic");
            // Query and add student data to the DataGridView
            List<Course> courses = xmlController.GetCoursesByTeacherID(teacherID);

            comboBox1.DataSource = courses;
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseName";

            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.MaxDate = DateTime.Now;
            xmlController.AddNewRecordDateForAllStudents(dateTimePicker.Value.ToString("yyyy-MM-dd"));


            Class_Data();


        }

        private void Class_Data()
        {

            // Load if the Teacher Has Courses elese Drop Error Msg and Exit
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("You have no classes to take attendance for");
                Close();
                return;
                // Add a new attendance record date for all students
            }
            else
            {
                string selectedCourseID = comboBox1.SelectedValue.ToString();
                string selectedDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
                AddStudentDataToGrid(selectedCourseID, selectedDate);
                // Lock Colum 3 if the date is not today
                if (dateTimePicker.Value.Date != DateTime.Now.Date)
                {
                    dataGrid.Columns[2].ReadOnly = true;
                }
                else
                {
                    dataGrid.Columns[2].ReadOnly = false;
                }
            }

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
            // only if DataTime Is Today
            if (dateTimePicker.Value.Date == DateTime.Now.Date)
            {
                /*                Console.WriteLine("Cell Clicked");
                */                // Assuming the "AbsentStatus" column is a CheckBox column
                if (e.ColumnIndex == dataGrid.Columns["AbsentStatus"].Index && e.RowIndex >= 0 && e.RowIndex < dataGrid.Rows.Count)
                {
                    // Get the student ID, student name, and date from the clicked row
                    string studentID = dataGrid.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                    string courseName = comboBox1.SelectedValue.ToString();

                    string date = dateTimePicker.Value.ToString("yyyy-MM-dd");

                    // Toggle the "Absent" status in the XML
                    xmlController.ToggleAbsentStatusInXml(courseName, studentID, date);
                }
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Update the DataGridView for the new selected date
            Class_Data();
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

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
