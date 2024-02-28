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
                }
            }

            else
            {
                MessageBox.Show("Plz fill All fileds");
            }
        }

        private void UserControlAddTeacher_loed(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Resources\\Data.xml");
            XmlNodeList nodes = doc.SelectNodes("/school/users/user");
            dataGridViewClass.Rows.Clear();
            foreach (XmlNode node in nodes)
            {
                string id = node.SelectSingleNode("id").InnerText;
                string name = node.SelectSingleNode("username").InnerText;
                string role = node.SelectSingleNode("role").InnerText;
                //change row font color to black

                if (role == "teacher")
                {
                    dataGridViewClass.Rows.Add(id, name, role, "test");
                }
            }
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
    }
}


   