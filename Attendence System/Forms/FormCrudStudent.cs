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

namespace Attendence_System.Forms
{
    public partial class FormCrudStudent : Form
    {
        string ID;
        public FormCrudStudent(string ID)
        {
            InitializeComponent();
            this.ID = ID;
            xmlController xmlController = new xmlController();
            List<string> student = xmlController.GetStudent(ID);
            Console.WriteLine(student[0]);
            FstName.Text = student[0].Split(' ')[0];
            LstName.Text = student[0].Split(' ')[1];


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string? firstName = FstName.Text.Trim();
            string? lastName = LstName.Text.Trim();
            string? Password = password.Text.Trim();
            string? RePassword = rePassword.Text.Trim();
            string? fullName;
            if (firstName == "" || lastName == "")
            {
                MessageBox.Show("name is required");
            }
            else if (Password != RePassword)
            {
                MessageBox.Show("Password and Re-Password does not match");
            }
            else
            {
                Validator validator = new Validator();
                if (!validator.validateName(firstName))
                {
                    MessageBox.Show("First Name is not valid");
                    return;
                }
                if (!validator.validateName(lastName))
                {
                    MessageBox.Show("Last Name is not valid");
                    return;
                }
                if(Password != "")
                {
                    if (!validator.validatePassword(Password))
                    {
                        MessageBox.Show("Password is not valid");
                        return;
                    }

                }
                fullName = firstName + " " + lastName;
                xmlController xmlController = new xmlController();
                xmlController.editUserInXML(ID, fullName, Password, "student");
                MessageBox.Show("Student Updated");

                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this student?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                xmlController xmlController = new xmlController();
                XmlDocument XmlDoc = xmlController.ReadSecondDocument();

                XmlNodeList StudentNodes = XmlDoc.SelectNodes($"//*[StudentID=\"{ID}\"]");
                if(StudentNodes.Count > 0)
                {
                    if(MessageBox.Show("this student is assigned to classes Are u sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        xmlController.deleteUserInXML(ID);
                        MessageBox.Show("Student Deleted");
                        this.Close();
                    }
                }
               else
                {
                    xmlController.deleteUserInXML(ID);
                    MessageBox.Show("Student Deleted");
                    this.Close();
                }
              
            }
        }

        private void FormCrudStudent_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.Items.Add("Arabic");
        }
    }
}
