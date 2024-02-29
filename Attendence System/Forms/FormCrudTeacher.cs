using Attendence_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LstName.Text = teacher[0].Split(' ')[1];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string? firstName = FstName.Text.Trim();
            string? lastName = LstName.Text.Trim();
            string? Password = pass.Text.Trim();
            string? RePassword = rePass.Text.Trim();
            string? fullName;
            if (firstName == "" || lastName == "" || Password == "" || RePassword == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else if (Password != RePassword)
            {
                MessageBox.Show("Password and Re-Password does not match");
            }
            else
            {
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
                xmlController.deleteUserInXML(ID);
                MessageBox.Show("Teacher Deleted");
                this.Close();
            }

        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCrudTeacher_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.Items.Add("Arabic");
        }
    }
}
