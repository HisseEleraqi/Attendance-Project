using Attendence_Management_System;
using Attendence_System.Controller;
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

namespace Attendence_System.Forms.UserControls
{
    public partial class UserControlAddTeacher : UserControl
    {
        public UserControlAddTeacher()
        {
            InitializeComponent();
        }

        private object originalCellValue;

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

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {

            string? firstName = textBoxFristName.Text;
            string? lastName = textBoxLastName.Text;
            string? Email = textBoxEmail.Text;
            string? Password = textBoxPassWord.Text;
            string? fullName;
            // call validateEmail from Validator class
            Validator validator = new Validator();
            FnameErrorMsg.Visible = false;
            LnameErrorMsg.Visible = false;
            EmailErrorMsg.Visible = false;
            PasswordErrorMsg.Visible = false;
            ErrorPassword.Visible = false;
            // check if all fields not empty
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
                    AddUser newUser = new AddUser(fullName, "teacher", Password, Email);
                    newUser.AddUserToXML();
                    MessageBox.Show("Teacher Added");
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
        public void fillTeacherData()
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
                flag = false;
                if (role == "teacher")
                {
                    if (comboBox1.SelectedItem != null)
                    {
                        string selectedClass = comboBox1.SelectedItem.ToString();
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load("..\\..\\..\\Resources\\Attendance.xml");
                        XmlNode superVisorNode = xmlDocument.SelectSingleNode($"//*[ClassName=\"{selectedClass}\"][TeacherID='{id}']");
                        if(superVisorNode != null)
                        {
                            dataGridViewClass.Rows.Add(id, name, email, selectedClass, true);
                            flag = true;
                        }
               
                        {
                        }
                        if (flag == false)
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
        public void fillCompoBox()
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
        private void UserControlAddTeacher_loed(object sender, EventArgs e)
        {
            fillTeacherData();
            fillCompoBox();

        }

        private void textBoxSearchTeacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchValue = textBoxSearchTeacher.Text.ToLower();
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

        private void dataGridViewTeacher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTeacher_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {


        }

        private void SaveEditToXml(int rowIndex, int columnIndex)
        {
            string userId = dataGridViewClass.Rows[rowIndex].Cells[0].Value.ToString(); // Adjust if your ID is in a different column
            string newValue = dataGridViewClass.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Resources\\Data.xml"); // Adjust the path as necessary

            XmlNode userNode = doc.SelectSingleNode($"/school/users/user[id='{userId}']");

            if (userNode != null)
            {
                switch (columnIndex)
                {
                    case 1:
                        userNode.SelectSingleNode("username").InnerText = newValue;
                        break;

                }

                // Save the updated XML document
                doc.Save("..\\..\\..\\Resources\\Data.xml");
            }
        }


        private void dataGridViewTeacher_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void dataGridViewClass_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            originalCellValue = dataGridViewClass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

        }

        private void dataGridViewClass_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentValue = dataGridViewClass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (!Equals(currentValue, originalCellValue))
            {
                SaveEditToXml(e.RowIndex, e.ColumnIndex);
            }
            else
            {
                dataGridViewClass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = originalCellValue;
            }
        }

        private void dataGridViewClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewClass.EndEdit();
                e.Handled = true;
            }

        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                string ID = dataGridViewClass.Rows[e.RowIndex].Cells[0].Value.ToString();
                using (FormCrudTeacher popup = new FormCrudTeacher(ID))
                {
                    popup.ShowDialog();
                    fillTeacherData();

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
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Teacher from the class?", "Delete", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load("..\\..\\..\\Resources\\Attendance.xml");
                            XmlNode TeacherIDNode = doc.SelectSingleNode($"//*[ClassName=\"{className}\"][TeacherID=\"{userId}\"]/TeacherID");

                           // Console.WriteLine($"//*[ClassName=\"{className}\"][TeacherID=\"{userId}\"]/TeacherID");
                            if (TeacherIDNode != null)
                            {
                                Console.WriteLine(TeacherIDNode.InnerText);
                                XmlNode parent = TeacherIDNode.ParentNode;
                                if (TeacherIDNode.NextSibling != null)
                                {
                                    parent.RemoveChild(TeacherIDNode.NextSibling);
                                }
                                parent.RemoveChild(TeacherIDNode);


                                doc.Save("..\\..\\..\\Resources\\Attendance.xml");
                                dataGridViewClass.Rows[e.RowIndex].Cells[4].Value = false;
                                MessageBox.Show("Teacher Deleted");
                            }
                            else
                            {
                                MessageBox.Show("Teacher not found");
                            }
                        }
                    }
                    else
                    {
                        string userId = dataGridViewClass.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string className = comboBox1.SelectedItem.ToString();
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add assign This Teacher to the class?", "Add", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load("..\\..\\..\\Resources\\Attendance.xml");
                            XmlNode nodeParent = doc.SelectSingleNode($"/AttendanceData/Class[ClassName=\"{className}\"]");

                            XmlElement TeacherID = doc.CreateElement("TeacherID");
                            TeacherID.InnerText = userId; 
                            XmlElement TeacherName = doc.CreateElement("TeacherName");
                            TeacherName.InnerText = dataGridViewClass.Rows[e.RowIndex].Cells[1].Value.ToString();
                            XmlNode ClassName = nodeParent.SelectSingleNode("ClassName");

                            //insert after ClassName node
                            nodeParent.InsertAfter(TeacherID, ClassName);

                            nodeParent.InsertAfter(TeacherName, TeacherID);




                            doc.Save("..\\..\\..\\Resources\\Attendance.xml");
                            dataGridViewClass.Rows[e.RowIndex].Cells[4].Value = true;
                            dataGridViewClass.Rows[e.RowIndex].Cells[3].Value = className;
                            MessageBox.Show("Teacher Added");
                            
                        }

                    }
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxFristName.Text) && string.IsNullOrEmpty(textBoxLastName.Text) && string.IsNullOrEmpty(textBoxEmail.Text) && string.IsNullOrEmpty(textBoxPassWord.Text))
            {
                textBoxFristName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                textBoxPassWord.Text = "";
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear all fields?", "Clear Fields", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    textBoxFristName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxPassWord.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTeacherData();
            Console.WriteLine("changed");
        }
    }
}


   