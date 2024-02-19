namespace Attendence_Management_System
{
    public partial class Main : Form
    {
        public string userName;
        public string Role;

        public Main(string userName)
        {

            InitializeComponent();
            this.userName = userName;
            UserName.Text = userName;

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
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
        }

        private void addClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Teacher);
        }

        private void Report_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Report);
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            { panelExpand.Visible = false; }
            else { panelExpand.Visible = true; }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            UserName.Text = userName;
            if (Role == "Usre")
            {
                buttonDashBorde.Hide();
                buttonAddStudent.Hide();
                buttonAddClass.Hide();
                
            }
        }
    }
}
