using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using Attendence_Management_System.Forms;
namespace Attendence_Management_System2
{
    public partial class AdminAttendance : Form
    {
        public Attendence_Management_System.AttendanceXmlController xmlController;

        public string teacherID;
        private string currentXmlFilePath;
        private System.Timers.Timer backupTimer;


        public string className;
        public AdminAttendance(string xmlFilePath)
        {
            InitializeComponent();
            xmlController = new Attendence_Management_System.AttendanceXmlController(xmlFilePath);
            currentXmlFilePath = xmlFilePath;

            backupTimer = new System.Timers.Timer(60 * 60 * 1000); 
            backupTimer.Elapsed += (sender, e) => Backup();
            backupTimer.Start();
        }
        //Implementing Backup Functionality to backup Attendance.xml file every hour
        private void Backup()
        {
            try
            {
                // Ensure the Backup directory exists
                string backupDirectory = Path.Combine(Path.GetDirectoryName(currentXmlFilePath), "Backup");

                if (!Directory.Exists(backupDirectory))
                {
                    Directory.CreateDirectory(backupDirectory);
                }

                // Create a timestamp for the backup file name
                string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");

                // Construct the destination path with the timestamp
                string destinationFileName = $"AttendanceBackup_{timeStamp}.xml";
                string destinationPath = Path.Combine(backupDirectory, destinationFileName);

                // Copy the file to the backup location
                System.IO.File.Copy(currentXmlFilePath, destinationPath, true);

                // Optionally, you can display a message or log the backup
                MessageBox.Show($"Backup created: {destinationPath}", "Backup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show($"Backup failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Query and add student data to the DataGridView
            List<Attendence_Management_System.Course> courses = xmlController.GetCourses();

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
                /*if (dateTimePicker.Value.Date != DateTime.Now.Date)
                {
                    dataGrid.Columns[2].ReadOnly = true;
                }
                else
                {
                    dataGrid.Columns[2].ReadOnly = false;
                }*/
            }

        }

        private void AddStudentDataToGrid(string className, string selectedDate)
        {
            List<Attendence_Management_System.StudentData> studentList = xmlController.GetStudentDataByClassName(className, selectedDate);

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
            Attendence_Management_System.DataGridViewPrinter.Print(dataGrid);
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
                Attendence_Management_System.ExcelPrinter.SaveAsExcel(dataGrid, saveFileDialog.FileName);
            }

            
        }




        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();

        }

        private void eXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print2();
        }

        

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implement functionality for loading a new XML
            // You may want to prompt the user for the file path
            string newXmlFilePath = GetXmlFilePathFromUser();  // Implement GetXmlFilePathFromUser method
            xmlController = new Attendence_Management_System.AttendanceXmlController(newXmlFilePath);
            currentXmlFilePath = newXmlFilePath;
            Class_Data();  // Refresh the UI for the loaded XML
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implement functionality for saving the current XML to another location
            string newSaveFilePath = GetSaveFilePath();  // Implement GetSaveFilePath method
            xmlController.SaveXml(newSaveFilePath);
            currentXmlFilePath = newSaveFilePath;
        }

        // ... (existing code)

        private string GetNewXmlFilePath()
        {
            // Implement logic to get a new XML file path, e.g., prompt the user for a new location
            // Example: Use SaveFileDialog or input box
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.Title = "Save New XML File";
            saveFileDialog.FileName = "NewAttendance.xml";

            // Show the dialog and get the result
            DialogResult result = saveFileDialog.ShowDialog();

            // If the user clicks OK, return the selected file path
            if (result == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            // Return null or throw an exception if the operation is canceled
            return null;
        }

        private string GetXmlFilePathFromUser()
        {
            // Implement logic to get an existing XML file path, e.g., prompt the user to choose a file
            // Example: Use OpenFileDialog or input box
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.Title = "Open XML File";

            // Show the dialog and get the result
            DialogResult result = openFileDialog.ShowDialog();

            // If the user clicks OK, return the selected file path
            if (result == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            // Return null or throw an exception if the operation is canceled
            return null;
        }

        private string GetSaveFilePath()
        {
            // Implement logic to get a new save location, e.g., prompt the user for a new location
            // Example: Use SaveFileDialog or input box
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.Title = "Save XML File As";
            saveFileDialog.FileName = "AttendanceCopy.xml";  // Default file name

            // Show the dialog and get the result
            DialogResult result = saveFileDialog.ShowDialog();

            // If the user clicks OK, return the selected file path
            if (result == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            // Return null or throw an exception if the operation is canceled
            return null;
        }
    }
}
