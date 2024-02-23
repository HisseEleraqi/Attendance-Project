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

        private void pictureBox2_Click(object sender, EventArgs e)
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
    }
}
