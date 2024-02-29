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
using System.Globalization;
namespace Attendence_Management_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar");
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            CounterLoader.LoadCountersFromXML("..\\..\\..\\Resources\\Data.xml");
            CounterLoader.LoadCountersFromXML("..\\..\\..\\Resources\\Attendance.xml");
            string? UserName = userName.Text.Trim();
            string? Password = password.Text.Trim();
            ErrorMessage.Visible = false;

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

                        if (role == "Teacher" || role == "teacher ")
                        {
                            Teacher teacher = new Teacher("..\\..\\..\\Resources\\Attendance.xml");
                            teacher.teacherID = userID;
                            teacher.Show();
                        }
                        else if (role == "Student" || role == "student")
                        {
                            Student main = new Student("..\\..\\..\\Resources\\Attendance.xml");
                            main.studentID = userID;
                            main.Show();

                        }
                        else if (role == "Admin" || role == "admin")
                        {
                            Main main = new Main(userName, role);
                            main.Show();
                        }
                        ErrorMessage.Visible = false;
                        this.Hide();


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
                string UserName = userName.Text.Trim();
                string Password = password.Text.Trim();
                ErrorMessage.Visible = false;

                if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                {
                    ErrorMessage.Text = "Please fill all the fields";
                    ErrorMessage.Visible = true;
                }
                else
                {
                    XmlDocument XmlDoc = xmlController.ReadAllDocument();
                    XmlNode userNode = xmlController.GetNode(XmlDoc, "/school/users/user", "email", UserName);

                    if (userNode != null)
                    {
                        string role = userNode.SelectSingleNode("role").InnerText;
                        string userName = userNode.SelectSingleNode("username").InnerText;
                        string userID = userNode.SelectSingleNode("id").InnerText;

                        if (userNode.SelectSingleNode("password").InnerText == Password)
                        {
                            if (role.ToLower() == "teacher")
                            {
                                Teacher teacher = new Teacher("..\\..\\..\\Resources\\Attendance.xml");
                                teacher.teacherID = userID;
                                teacher.Show();
                            }
                            else if (role.ToLower() == "student")
                            {
                                Student main = new Student("..\\..\\..\\Resources\\Attendance.xml");
                                main.studentID = userID;
                                main.Show();
                            }
                            else if (role.ToLower() == "admin")
                            {
                                Main main = new Main(userName, role);
                                main.Show();
                            }

                            ErrorMessage.Visible = false;
                            this.Hide();
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
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void userName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string UserName = userName.Text.Trim();
                string Password = password.Text.Trim();
                ErrorMessage.Visible = false;

                if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                {
                    ErrorMessage.Text = "Please fill all the fields";
                    ErrorMessage.Visible = true;
                }
                else
                {
                    XmlDocument XmlDoc = xmlController.ReadAllDocument();
                    XmlNode userNode = xmlController.GetNode(XmlDoc, "/school/users/user", "email", UserName);

                    if (userNode != null)
                    {
                        string role = userNode.SelectSingleNode("role").InnerText;
                        string userName = userNode.SelectSingleNode("username").InnerText;
                        string userID = userNode.SelectSingleNode("id").InnerText;

                        if (userNode.SelectSingleNode("password").InnerText == Password)
                        {
                            if (role.ToLower() == "teacher")
                            {
                                Teacher teacher = new Teacher("..\\..\\..\\Resources\\Attendance.xml");
                                teacher.teacherID = userID;
                                teacher.Show();
                            }
                            else if (role.ToLower() == "student")
                            {
                                Student main = new Student("..\\..\\..\\Resources\\Attendance.xml");
                                main.studentID = userID;
                                main.Show();
                            }
                            else if (role.ToLower() == "admin")
                            {
                                Main main = new Main(userName, role);
                                main.Show();
                            }

                            ErrorMessage.Visible = false;
                            this.Hide();
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
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timerDate.Start();
        }

       
       

    }
}
