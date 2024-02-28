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

namespace Attendence_System.Forms.UserControls
{
    public partial class UserControDashBoard : UserControl
    {
        public UserControDashBoard()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControDashBoard_Load(object sender, EventArgs e)
        {
            studentCount.Text = new xmlController().GetStudentCount();
            teacherCount.Text  = new xmlController().GetTeacherCount();
            classsCount.Text = new xmlController().GetClassCount();
        }
    }
}
