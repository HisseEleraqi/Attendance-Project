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

        private void MoveSidePanel(Control Button)
        {
            panelSlide.Location = new Point(Button.Location.X, Button.Location.Y - 180);
        }
        private void buttonDashBorde_Click(object sender, EventArgs e)
        {

            MoveSidePanel(buttonDashBorde);
            userControDashBoard1.Visible = true;
            userControlAddClass1.Visible = false;
            userControlReports.Visible = false;



        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlReports.Visible = false;


        }

        private void addClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = true;
            userControlReports.Visible = false;


        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Teacher);
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = false;

            userControlReports.Visible = false;

        }

        private void Report_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Report);
            userControlReports.Visible = true;
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = false;


        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            { panelExpand.Visible = false; }
            else { panelExpand.Visible = true; }
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlReports.Visible = false;


        }

        private void Main_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            UserName.Text = userName;
            /*if (Role.ToLower() == "admin")
            {
                buttonDashBorde.Hide();
                buttonAddStudent.Hide();
                buttonAddClass.Hide();

            }*/
            userControDashBoard1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlReports.Visible = false;


        }
        
        private void userControDashBoard1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
