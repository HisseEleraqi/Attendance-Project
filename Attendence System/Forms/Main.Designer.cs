
namespace Attendence_Management_System

{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            Report = new Button();
            panelSlide = new Panel();
            buttonAttdance = new Button();
            buttonAddStudent = new Button();
            buttonAddClass = new Button();
            Teacher = new Button();
            buttonDashBorde = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelBack = new Panel();
            panelExpand = new Panel();
            buttonLogOut = new Button();
            panel5 = new Panel();
            button1 = new Button();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            panelTop = new Panel();
            UserName = new Label();
            userControDashBoard1 = new Attendence_System.Forms.UserControls.UserControDashBoard();
            toolTip1 = new ToolTip(components);
            userControlAddClass1 = new Attendence_System.Forms.UserControls.UserControlAddClass();
            panel8 = new Panel();
            userControlReports = new Attendence_System.Forms.UserControls.UserControlReports();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 923);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 743);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 224, 192);
            panel4.Controls.Add(Report);
            panel4.Controls.Add(panelSlide);
            panel4.Controls.Add(buttonAttdance);
            panel4.Controls.Add(buttonAddStudent);
            panel4.Controls.Add(buttonAddClass);
            panel4.Controls.Add(Teacher);
            panel4.Controls.Add(buttonDashBorde);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 743);
            panel4.TabIndex = 2;
            // 
            // Report
            // 
            Report.Dock = DockStyle.Top;
            Report.FlatAppearance.BorderSize = 0;
            Report.FlatStyle = FlatStyle.Flat;
            Report.ForeColor = Color.White;
            Report.Location = new Point(0, 235);
            Report.Name = "Report";
            Report.Size = new Size(258, 47);
            Report.TabIndex = 3;
            Report.Text = "Report";
            Report.TextImageRelation = TextImageRelation.ImageAboveText;
            Report.UseVisualStyleBackColor = true;
            Report.Click += Report_Click;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(8, 47);
            panelSlide.TabIndex = 0;
            // 
            // buttonAttdance
            // 
            buttonAttdance.Dock = DockStyle.Top;
            buttonAttdance.FlatAppearance.BorderSize = 0;
            buttonAttdance.FlatStyle = FlatStyle.Flat;
            buttonAttdance.ForeColor = Color.White;
            buttonAttdance.Location = new Point(0, 188);
            buttonAttdance.Name = "buttonAttdance";
            buttonAttdance.Size = new Size(258, 47);
            buttonAttdance.TabIndex = 0;
            buttonAttdance.Text = "Attdance";
            buttonAttdance.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonAttdance.UseVisualStyleBackColor = true;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Dock = DockStyle.Top;
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.FlatStyle = FlatStyle.Flat;
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Location = new Point(0, 141);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(258, 47);
            buttonAddStudent.TabIndex = 0;
            buttonAddStudent.Text = "Add student";
            buttonAddStudent.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Dock = DockStyle.Top;
            buttonAddClass.FlatAppearance.BorderSize = 0;
            buttonAddClass.FlatStyle = FlatStyle.Flat;
            buttonAddClass.ForeColor = Color.White;
            buttonAddClass.Location = new Point(0, 94);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(258, 47);
            buttonAddClass.TabIndex = 1;
            buttonAddClass.Text = "Add class";
            buttonAddClass.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonAddClass.UseVisualStyleBackColor = true;
            buttonAddClass.Click += addClass_Click;
            // 
            // Teacher
            // 
            Teacher.Dock = DockStyle.Top;
            Teacher.FlatAppearance.BorderSize = 0;
            Teacher.FlatStyle = FlatStyle.Flat;
            Teacher.ForeColor = Color.White;
            Teacher.Location = new Point(0, 47);
            Teacher.Name = "Teacher";
            Teacher.Size = new Size(258, 47);
            Teacher.TabIndex = 2;
            Teacher.Text = "Teacher";
            Teacher.TextImageRelation = TextImageRelation.ImageAboveText;
            Teacher.UseVisualStyleBackColor = true;
            Teacher.Click += Teacher_Click;
            // 
            // buttonDashBorde
            // 
            buttonDashBorde.Dock = DockStyle.Top;
            buttonDashBorde.FlatAppearance.BorderSize = 0;
            buttonDashBorde.FlatStyle = FlatStyle.Flat;
            buttonDashBorde.ForeColor = Color.White;
            buttonDashBorde.Location = new Point(0, 0);
            buttonDashBorde.Name = "buttonDashBorde";
            buttonDashBorde.Size = new Size(258, 47);
            buttonDashBorde.TabIndex = 0;
            buttonDashBorde.Text = "Dashbord";
            buttonDashBorde.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonDashBorde.UseVisualStyleBackColor = true;
            buttonDashBorde.Click += buttonDashBorde_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 180);
            panel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Location = new Point(258, 161);
            panel7.Name = "panel7";
            panel7.Size = new Size(1186, 514);
            panel7.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Location = new Point(258, 158);
            panel6.Name = "panel6";
            panel6.Size = new Size(1130, 765);
            panel6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 87);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 1;
            label1.Text = "Attdance System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Attendence_System.Properties.Resources.logo;
            pictureBox1.Location = new Point(55, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(panelTop);
            panelBack.Location = new Point(258, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(942, 165);
            panelBack.TabIndex = 1;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.Firebrick;
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(panel5);
            panelExpand.Location = new Point(733, 74);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(200, 88);
            panelExpand.TabIndex = 4;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.IndianRed;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.Dock = DockStyle.Bottom;
            buttonLogOut.ForeColor = Color.White;
            buttonLogOut.Location = new Point(0, 45);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(200, 43);
            buttonLogOut.TabIndex = 1;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 39);
            panel5.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Dock = DockStyle.Top;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 49);
            button1.TabIndex = 0;
            button1.Text = "Minimize";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonMinimize;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Image = (Image)resources.GetObject("pictureBoxExpand.Image");
            pictureBoxExpand.Location = new Point(846, 44);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(27, 24);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 2;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Attendence_System.Properties.Resources.logo;
            pictureBox2.Location = new Point(733, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DarkSalmon;
            panelTop.Controls.Add(UserName);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 77);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(942, 88);
            panelTop.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(36, 25);
            UserName.Name = "UserName";
            UserName.Size = new Size(121, 23);
            UserName.TabIndex = 3;
            UserName.Text = "Welcome:?";
            // 
            // userControDashBoard1
            // 
            userControDashBoard1.BackColor = Color.Tan;
            userControDashBoard1.Dock = DockStyle.Fill;
            userControDashBoard1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControDashBoard1.Location = new Point(0, 0);
            userControDashBoard1.Margin = new Padding(4, 3, 4, 3);
            userControDashBoard1.Name = "userControDashBoard1";
            userControDashBoard1.Size = new Size(1183, 777);
            userControDashBoard1.TabIndex = 0;
            userControDashBoard1.Load += userControDashBoard1_Load;
            // 
            // userControlAddClass1
            // 
            userControlAddClass1.BackColor = Color.Tan;
            userControlAddClass1.Dock = DockStyle.Fill;
            userControlAddClass1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlAddClass1.Location = new Point(0, 0);
            userControlAddClass1.Margin = new Padding(4, 3, 4, 3);
            userControlAddClass1.Name = "userControlAddClass1";
            userControlAddClass1.RightToLeft = RightToLeft.No;
            userControlAddClass1.Size = new Size(1183, 777);
            userControlAddClass1.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Controls.Add(userControlReports);
            panel8.Controls.Add(userControDashBoard1);
            panel8.Controls.Add(userControlAddClass1);
            panel8.Location = new Point(261, 169);
            panel8.Name = "panel8";
            panel8.Size = new Size(1183, 777);
            panel8.TabIndex = 2;
            // 
            // userControlReports
            // 
            userControlReports.BackColor = Color.SeaShell;
            userControlReports.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlReports.Location = new Point(-3, -5);
            userControlReports.Margin = new Padding(4, 3, 4, 3);
            userControlReports.Name = "userControlReports";
            userControlReports.Size = new Size(1241, 859);
            userControlReports.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1444, 923);
            Controls.Add(panel8);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = Color.FromArgb(67, 3, 125);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attdance Mangment System";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBack.ResumeLayout(false);
            panelExpand.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelBack;
        private Panel panel3;
        private Panel panel4;
        private Panel panelSlide;
        private Button buttonDashBorde;
        private Button buttonAttdance;
        private Button buttonAddClass;
        private Button buttonAddStudent;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxExpand;
        private Panel panelExpand;
        private Label UserName;
        private Panel panel5;
        private Button button1;
        private Button buttonLogOut;
        private Button Teacher;
        private Button Report;
        private Attendence_System.Forms.UserControls.UserControDashBoard userControDashBoard1;
        private ToolTip toolTip1;
        private Panel panel6;
        private Attendence_System.Forms.UserControls.UserControlAddClass userControlAddClass1;
        private Panel panelTop;
        private Panel panel7;
        private Panel panel8;
        private Attendence_System.Forms.UserControls.UserControlReports userControlReports;
    }
}
