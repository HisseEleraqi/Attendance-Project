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
        public FormCrudTeacher()
        {
            InitializeComponent();
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
