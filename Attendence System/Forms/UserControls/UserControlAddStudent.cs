using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendence_Management_System;
using System.Xml;
using Attendence_System.Forms;
using Attendence_System.Controller;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using OfficeOpenXml.FormulaParsing.Excel.Functions;
using Microsoft.VisualBasic;

namespace Attendence_System.Forms.UserControls
{
    public partial class UserControlAddStudent : UserControl
    {
        public UserControlAddStudent()
        {
            InitializeComponent();
        }
        private object originalCellValue;

        private void textBoxFristName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {

            string? firstName = textBoxFristName.Text.Trim();
            string? lastName = textBoxLastName.Text.Trim();
            string? Email = textBoxEmail.Text.Trim();
            string? Password = textBoxPassWord.Text.Trim();
            string? fullName;
            Validator validator = new Validator();
            FnameErrorMsg.Visible = false;
            LnameErrorMsg.Visible = false;
            EmailErrorMsg.Visible = false;
            PasswordErrorMsg.Visible = false;
            ErrorPassword.Visible = false;
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password))
            {
                if (!validator.validateName(firstName))
                {
                    FnameErrorMsg.Visible = true;
                }
                else if (!validator.validateName(lastName))
                {
                    LnameErrorMsg.Visible = true;
                }
                else if (!validator.validateEmail(Email))
                {
                    //MessageBox.Show("Invalid Email");
                    EmailErrorMsg.Visible = true;
                }
                else if (!validator.validatePassword(Password))
                {
                    PasswordErrorMsg.Visible = true;

                    ErrorPassword.Visible = true;
                }
                else if (!validator.validateEmail(Email))
                {
                    FnameErrorMsg.Visible = true;
                }
                else if (validator.CheckDuplicateEmail(Email))
                {
                    MessageBox.Show("Email already exists");
                }
                else
                {
                    fullName = firstName + " " + lastName;
                    AddUser newUser = new AddUser(fullName, "student", Password, Email);
                    newUser.AddUserToXML();
                    MessageBox.Show("Student Added");
                    textBoxFristName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxPassWord.Text = "";
                }
            }

            else
            {
                MessageBox.Show("Plz fill All fileds");

            }
        }

        private void textBoxPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void showHide_Click(object sender, EventArgs e)
        {
            if (textBoxPassWord.PasswordChar == '*')
            {
                textBoxPassWord.PasswordChar = '\0';
                showHide.Image = Image.FromFile(@"../../../Resources/eye.png");
            }
            else
            {
                textBoxPassWord.PasswordChar = '*';
                showHide.Image = Image.FromFile(@"../../../Resources/blind.png");
            }
        }
        private void showHide2_Click(object sender, EventArgs e)
        {
            if (textBoxPassRep.PasswordChar == '*')
            {
                textBoxPassRep.PasswordChar = '\0';
                showHide2.Image = Image.FromFile(@"../../../Resources/eye.png");
            }
            else
            {
                textBoxPassRep.PasswordChar = '*';
                showHide2.Image = Image.FromFile(@"../../../Resources/blind.png");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFristName.Text) || !string.IsNullOrEmpty(textBoxLastName.Text) || !string.IsNullOrEmpty(textBoxEmail.Text) || !string.IsNullOrEmpty(textBoxPassWord.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    textBoxFristName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxPassWord.Text = "";
                    textBoxPassRep.Text = "";
                }
            }
            else
            {
                textBoxFristName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                textBoxPassWord.Text = "";
                textBoxPassRep.Text = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSearchClass_Click(object sender, EventArgs e)
        {

        }
        private void SaveEditToXml(int rowIndex, int columnIndex)
        {
            string userId = dataGridViewClass.Rows[rowIndex].Cells[0].Value.ToString(); 
            string newValue = dataGridViewClass.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Resources\\Data.xml"); 

            XmlNode userNode = doc.SelectSingleNode($"/school/users/user[id='{userId}']");

            if (userNode != null)
            {
                switch (columnIndex)
                {
                    case 1:
                        userNode.SelectSingleNode("username").InnerText = newValue;
                        break;
                    case 2:
                        userNode.SelectSingleNode("role").InnerText = newValue;
                        break;

                }

                // Save the updated XML document
                doc.Save("..\\..\\..\\Resources\\Data.xml");
            }
        }
        public void FillCompoBox()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Resources\\Attendance.xml");
            XmlNodeList nodes = doc.SelectNodes("/AttendanceData/Class");
            foreach (XmlNode node in nodes)
            {
                string name = node.SelectSingleNode("ClassName").InnerText;
                comboBox1.Items.Add(name);
            }
            comboBox1.SelectedIndex = 0;
        }
        public void FillDataGrid()
        {
            dataGridViewClass.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Resources\\Data.xml");
            XmlNodeList nodes = doc.SelectNodes("/school/users/user");
            dataGridViewClass.Rows.Clear();
            bool flag;
            foreach (XmlNode node in nodes)
            {
                string id = node.SelectSingleNode("id").InnerText;
                string name = node.SelectSingleNode("username").InnerText;
                string role = node.SelectSingleNode("role").InnerText;
                string email = node.SelectSingleNode("email").InnerText;
                 flag  = false;
                if (role == "student")
                {
                    if (comboBox1.SelectedItem != null)
                    {
                        string selectedClass = comboBox1.SelectedItem.ToString();
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load("..\\..\\..\\Resources\\Attendance.xml");

                        XmlNodeList classNodes = xmlDocument.SelectNodes("/AttendanceData/Class");
                        foreach (XmlNode classNode in classNodes)
                        {
                            
                            if (classNode.SelectSingleNode("ClassName").InnerText == selectedClass)
                            {

                                if (classNode.SelectSingleNode($"Students/Student[StudentID=\"{id}\"]/StudentID") != null)
                                {
                                    dataGridViewClass.Rows.Add(id, name, email, selectedClass, true);
                                    flag = true;
                                    
                                }
                                
                            }


                        }
                        if(flag == false)
                        {
                            dataGridViewClass.Rows.Add(id, name, email, "not Erolled", false);
                        }
                    }
                    else
                    {
                        dataGridViewClass.Rows.Add(id, name, email, "No Class choosed", false);
                    }
                }
            }


        }
        private void UserControlAddStudent_Load(object sender, EventArgs e)
        {
            FillCompoBox();
            FillDataGrid();

        }

        private void textBoxSearchStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchValue = textBoxSearchStudent.Text.ToLower();
                dataGridViewClass.ClearSelection();

                try
                {
                    int rowCount = dataGridViewClass.Rows.Count;
                    for (int i = 0; i < rowCount - 1; i++)
                    {
                        DataGridViewRow row = dataGridViewClass.Rows[i];

                        if (!row.IsNewRow)
                        {
                            bool rowVisible = false;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchValue))
                                {
                                    rowVisible = true;
                                    break;
                                }
                            }

                            row.Visible = rowVisible;

                            if (rowVisible)
                            {
                                dataGridViewClass.Rows[row.Index].Selected = true;

                            }
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }



        private void DeleteUserFromXml(string userId)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Resources\\Data.xml"); // Adjust the path as necessary

            // XPath to find the user node by ID. Adjust XPath according to your XML structure if needed.
            XmlNode userNode = doc.SelectSingleNode($"/school/users/user[id='{userId}']");
            if (userNode != null)
            {
                // Remove the found node from its parent
                userNode.ParentNode.RemoveChild(userNode);

                // Save the XML document back to the file
                doc.Save("..\\..\\..\\Resources\\Data.xml");
            }
        }


        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0) 
            {
                string userId = dataGridViewClass.Rows[e.RowIndex].Cells[0].Value.ToString();
                using (FormCrudStudent popup = new FormCrudStudent(userId))
                {
                    popup.ShowDialog();
                }
            }
            if (e.ColumnIndex == 4 && e.RowIndex >= 0) 
            {
                if (dataGridViewClass.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    if ((bool)dataGridViewClass.Rows[e.RowIndex].Cells[4].Value == true)
                    {
                        string userId = dataGridViewClass.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string className = dataGridViewClass.Rows[e.RowIndex].Cells[3].Value.ToString();
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student from the class?", "Delete", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load("..\\..\\..\\Resources\\Attendance.xml");
                            XmlNodeList nodes = doc.SelectNodes($"/AttendanceData/Class[ClassName=\"{className}\"]/Students/Student");
                            foreach (XmlNode node in nodes)
                            {
                                if (node.SelectSingleNode("StudentID").InnerText == userId)
                                {
                                    node.ParentNode.RemoveChild(node);
                                    doc.Save("..\\..\\..\\Resources\\Attendance.xml");
                                    dataGridViewClass.Rows[e.RowIndex].Cells[4].Value = false;
                                    MessageBox.Show("Student Deleted");
                                    FillDataGrid();

                                }
                            }
                        }
                    }
                    else
                    {
                        string userId = dataGridViewClass.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string className = comboBox1.SelectedItem.ToString();
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this student to the class?", "Add", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load("..\\..\\..\\Resources\\Attendance.xml");
                            XmlNode node = doc.SelectSingleNode($"/AttendanceData/Class[ClassName=\"{className}\"]/Students");
                            
                            XmlElement student = doc.CreateElement("Student");
                            student.InnerXml = $"<StudentID>{userId}</StudentID>";
                            XmlElement studentName = doc.CreateElement("StudentName");
                            studentName.InnerText = dataGridViewClass.Rows[e.RowIndex].Cells[1].Value.ToString();
                            student.AppendChild(studentName);
                            XmlElement attendanceRecords = doc.CreateElement("AttendanceRecords");
                            List<string> absentDates = new List<string> { "2024-02-15", "2024-02-14", "2024-02-16", "2024-02-17", "2024-02-28", "2024-02-23", "2024-02-20", "2024-02-08", "2024-02-13", "2024-02-22", "2024-03-01" };

                                foreach (string date in absentDates)
                                {
                                    XmlElement record = doc.CreateElement("Record");

                                    XmlElement dateElement = doc.CreateElement("Date");
                                    dateElement.InnerText = date;
                                    record.AppendChild(dateElement);

                                    XmlElement statusElement = doc.CreateElement("Status");
                                    statusElement.InnerText = "Absent";
                                    record.AppendChild(statusElement);

                                    attendanceRecords.AppendChild(record);
                                }

                        student.AppendChild(attendanceRecords);
                        node.AppendChild(student);

                        doc.Save("..\\..\\..\\Resources\\Attendance.xml");
                        dataGridViewClass.Rows[e.RowIndex].Cells[4].Value = true;
                        MessageBox.Show("Student Added");
                        FillDataGrid();
                        }
                        
                    }
                }
            }

            //private void dataGridViewClass_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
            //{
            //    originalCellValue = dataGridViewClass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            //}

            //private void dataGridViewClass_KeyDown(object sender, KeyEventArgs e)
            //{
            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        dataGridViewClass.EndEdit();
            //        e.Handled = true;
            //    }
            //}

            //private void dataGridViewClass_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            //{
            //    var currentValue = dataGridViewClass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //    if (currentValue != null && originalCellValue != null && !Equals(currentValue, originalCellValue))
            //    {
            //        SaveEditToXml(e.RowIndex, e.ColumnIndex);
            //    }
            //}
        }

        private void ButtonAddToClass_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillDataGrid();
        }
    }
}
