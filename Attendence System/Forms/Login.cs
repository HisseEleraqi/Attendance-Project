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
namespace Attendence_Management_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            string? UserName = userName.Text;
            string? Password = password.Text;
            ErrorMessage.Visible = false;
            //XmlDocument XmlDoc = xmlController.ReadAllDocument(); //test document
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage.Text = "Please fill all the fields";
                ErrorMessage.Visible = true;

            }
            else
            {
                XmlDocument XmlDoc = xmlController.ReadAllDocument();
                XmlNode? userNode = xmlController.GetNode(XmlDoc, "/school/users/user", "email", UserName);
                if (userNode != null)
                {
                    string? role = userNode.SelectSingleNode("role").InnerText;
                    string userName = userNode.SelectSingleNode("username").InnerText;
                    string userID = userNode.SelectSingleNode("id").InnerText;
                    if (userNode.SelectSingleNode("password").InnerText == Password)
                    {

                        if (role == "Teacher" || role=="teacher ")
                        {
                            Teacher teacher = new Teacher("..\\..\\..\\Resources\\Attendance.xml");
                            teacher.teacherID = userID;
                            teacher.Show();
                        }
                        else if(role == "Student" || role=="student" )
                        {
                            Main main = new Main(userName, role);
                            main.Show();

                        }
                        else if(role == "Admin" || role =="admin")
                        {
                            Main main = new Main(userName, role);
                            main.Show();
                        }
                        ErrorMessage.Visible = false;
                        this.Hide();
                        AddUser newUser = new AddUser("test", "student", "123","hema@example.com");
                        newUser.AddUserToXML();
                    }
                    else
                    {

                        ErrorMessage.Text = "Invalid Password";
                        ErrorMessage.Visible = true;

                    }
                }
                else
                {

                    ErrorMessage.Text = "Invalid UserName";
                    ErrorMessage.Visible = true;

                }
            }



        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void showHide_Click_1(object sender, EventArgs e)
        {
            if (password.PasswordChar == '*')
            {
                password.PasswordChar = '\0';
                showHide.Image = Image.FromFile(@"../../../Resources/eye.png");
            }
            else
            {
                password.PasswordChar = '*';
                showHide.Image = Image.FromFile(@"../../../Resources/blind.png");
            }
        }

        // when press enter key on password field it will fire the login button
        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                closeButton_Click(sender, e);
            }
        }
    }
}
