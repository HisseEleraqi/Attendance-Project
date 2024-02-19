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
                    if (userNode.SelectSingleNode("password").InnerText == Password)
                    {
                        MessageBox.Show("Login Success");
                        //Console.WriteLine(userNode.SelectSingleNode("role").InnerText);
                         if (userNode.SelectSingleNode("role").InnerText.ToLower() == "teacher")
                        {
                            Teacher teacher = new Teacher();
                            teacher.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {
            // sho
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

    }
}
