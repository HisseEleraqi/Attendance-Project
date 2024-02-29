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
using Attendence_Management_System;
namespace Attendence_System.Forms
{
    public partial class FormCrudTeacher : Form
    {
        string ID;

        public FormCrudTeacher(string iD)
        {
            InitializeComponent();
            ID = iD;
            xmlController xmlCont = new xmlController();
            List<string> teacher = xmlCont.GetTeacher(ID);
            FstName.Text = teacher[0].Split(' ')[0];
            if (teacher[0].Split(' ')[1] != null)
            {
                LstName.Text = teacher[0].Split(' ')[1];
            }
            else
            {
                LstName.Text = " ";
            }
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string? firstName = FstName.Text.Trim();
            string? lastName = LstName.Text.Trim();
            string? Password = pass.Text.Trim();
            string? RePassword = rePass.Text.Trim();
            string? fullName;
            if (firstName == "" || lastName == "")
            {
                MessageBox.Show("name is required");
            }
            if (firstName == "" || lastName == "" && Password == "" && RePassword == "")

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
                fullName = firstName + " " + lastName;
                xmlController xmlController = new xmlController();
                xmlController.editUserInXML(ID, fullName, Password, "teacher");
                MessageBox.Show("Teacher Updated");
                return;
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
                if (Password != "")
                {
                    if (!validator.validatePassword(Password))
                    {
                        MessageBox.Show("Password is not valid");
                        return;
                    }

                }
                fullName = firstName + " " + lastName;
                xmlController xmlController = new xmlController();
                xmlController.editUserInXML(ID, fullName, Password, "teacher");
                MessageBox.Show("Teacher Updated");

                this.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                xmlController xmlController = new xmlController();
                XmlDocument XmlDoc = xmlController.ReadSecondDocument();
                XmlNode TeacherIDNode = XmlDoc.SelectSingleNode($"//*[TeacherID=\"{ID}\"]/TeacherID");
                if (TeacherIDNode != null)
                {
                    MessageBox.Show("Teacher is assigned to a class, cannot delete");
                }
                else
                {
                    xmlController.deleteUserInXML(ID);
                    MessageBox.Show("Teacher Deleted");
                    this.Close();
                }

            }


        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCrudTeacher_Load(object sender, EventArgs e)
        {
            
        }
    }
}
