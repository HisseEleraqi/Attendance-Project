using Attendence_Management_System2;
using Attendence_System.Forms;
using Attendence_System.Forms.UserControls;
using Attendence_System.Properties;
using System.ComponentModel;
using System.Globalization;

namespace Attendence_Management_System
{
    public partial class Main : Form
    {
        public string userName;
        public string Role;

        public Main(string userName, string role)
        {

            InitializeComponent();
            this.userName = userName;
            UserName.Text = userName;
            Role = role;
        }



        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to Log Out ?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }

        }

        private void buttonMinimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void MoveSidePanel(Button button)
        {
            // This will align the top of the sliding panel with the top of the button.
            panelSlide.Top = button.Top;

            // If you want the sliding panel to move with animation, you can use the following:
            panelSlide.BringToFront();
            panelSlide.Height = button.Height; // If you want to match the button's height
            var slidePanelAnimation = panelSlide.BeginInvoke(new Action(() =>
            {
                panelSlide.Location = new Point(button.Location.X, button.Location.Y);
            }));
        }
        private void buttonDashBorde_Click(object sender, EventArgs e)
        {

            MoveSidePanel(buttonDashBorde);
            userControDashBoard1.Visible = true;
            userControlAddClass1.Visible = false;

            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;
            //     userControlReports1.Visible = false;





        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = true;
            // userControlReports1.Visible = false;


        }

        private void addClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = true;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;
            //    userControlReports1.Visible = false;


        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Teacher);
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = true;
            //  userControlReports1.Visible = false;



        }

        private void Report_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Report);
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;

            // userControlReports1.Visible = true;
            using (Reports popup =new Reports())
            {
                popup.ShowDialog();


            }

        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            { panelExpand.Visible = false; }
            else { panelExpand.Visible = true; }
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;
            //  userControlReports1.Visible = false;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            timerDateTime.Start();
            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.Items.Add("Arabic");
            panelExpand.Hide();
            UserName.Text = userName;
            /*if (Role.ToLower() == "admin")
            {
                buttonDashBorde.Hide();
                buttonAddStudent.Hide();
                buttonAddClass.Hide();

            }*/
            userControDashBoard1.Visible = true;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;
            //     userControlReports1.Visible = false;

        }

        private void userControDashBoard1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void userControlAddClass1_Load(object sender, EventArgs e)
        {

        }

        private void userControlReports1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedItem.ToString() == "Arabic")
            {
                SwitchLanguage("ar");
            }
            else
            {
                // Switch back to English or handle other languages
                SwitchLanguage("en");

            }
        }
        private void SwitchLanguage(string languageCode)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(SwitchLanguage), languageCode);
                return;
            }

            CultureInfo culture = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            this.RightToLeft = culture.TextInfo.IsRightToLeft ? RightToLeft.Yes : RightToLeft.No;
            this.RightToLeftLayout = culture.TextInfo.IsRightToLeft;

            this.Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}


