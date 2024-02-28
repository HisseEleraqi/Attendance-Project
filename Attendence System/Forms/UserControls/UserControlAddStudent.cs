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

namespace Attendence_System.Forms.UserControls
{
    public partial class UserControlAddStudent : UserControl
    {
        public UserControlAddStudent()
        {
            InitializeComponent();
        }

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
                    AddUser newUser = new AddUser(fullName, "student", Password, Email);
                    newUser.AddUserToXML();
                    MessageBox.Show("Student Added");
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


        private void UserControlAddStudent_Load(object sender, EventArgs e)
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

                if (role == "student")
                {
                    dataGridViewClass.Rows.Add(id, name, role, "test");
                }
            }
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
    }
    
}
