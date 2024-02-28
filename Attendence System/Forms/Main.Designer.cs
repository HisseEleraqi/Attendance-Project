
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
            panelTop = new Panel();
            UserName = new Label();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            userControlAddStudent1 = new Attendence_System.Forms.UserControls.UserControlAddStudent();
            userControDashBoard1 = new Attendence_System.Forms.UserControls.UserControDashBoard();
            userControlAddTeacher1 = new Attendence_System.Forms.UserControls.UserControlAddTeacher();
            panel8 = new Panel();
            userControlAddClass1 = new Attendence_System.Forms.UserControls.UserControlAddClass();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            panel5.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(258, 871);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 691);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 62, 80);
            panel4.Controls.Add(Report);
            panel4.Controls.Add(panelSlide);
            panel4.Controls.Add(buttonAddStudent);
            panel4.Controls.Add(buttonAddClass);
            panel4.Controls.Add(Teacher);
            panel4.Controls.Add(buttonDashBorde);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 691);
            panel4.TabIndex = 2;
            // 
            // Report
            // 
            Report.Dock = DockStyle.Top;
            Report.FlatAppearance.BorderSize = 0;
            Report.FlatStyle = FlatStyle.Flat;
            Report.ForeColor = Color.White;
            Report.Location = new Point(0, 188);
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
            panelSlide.Size = new Size(10, 50);
            panelSlide.TabIndex = 0;
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
            buttonAddStudent.Text = "Student";
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
            buttonAddClass.Text = "Class";
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
            panel2.BackColor = Color.FromArgb(236, 240, 241);
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
            label1.BackColor = Color.FromArgb(52, 73, 94);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 142);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 1;
            label1.Text = "Attdance System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(panelTop);
            panelBack.Location = new Point(258, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(942, 165);
            panelBack.TabIndex = 1;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.FromArgb(149, 165, 166);
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(panel5);
            panelExpand.Location = new Point(733, 74);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(200, 88);
            panelExpand.TabIndex = 4;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.FromArgb(52, 73, 94);
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
            button1.BackColor = Color.FromArgb(52, 73, 94);
            button1.Dock = DockStyle.Top;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 39);
            button1.TabIndex = 0;
            button1.Text = "Minimize";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonMinimize;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(149, 165, 166);
            panelTop.Controls.Add(UserName);
            panelTop.Controls.Add(pictureBoxExpand);
            panelTop.Controls.Add(pictureBox2);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(942, 162);
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
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Image = (Image)resources.GetObject("pictureBoxExpand.Image");
            pictureBoxExpand.Location = new Point(780, 43);
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
            pictureBox2.Location = new Point(789, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // userControlAddStudent1
            // 
            userControlAddStudent1.BackColor = Color.SeaShell;
            userControlAddStudent1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlAddStudent1.ForeColor = Color.White;
            userControlAddStudent1.Location = new Point(258, 166);
            userControlAddStudent1.Margin = new Padding(4, 3, 4, 3);
            userControlAddStudent1.Name = "userControlAddStudent1";
            userControlAddStudent1.RightToLeft = RightToLeft.No;
            userControlAddStudent1.Size = new Size(1675, 906);
            userControlAddStudent1.TabIndex = 3;
            // 
            // userControDashBoard1
            // 
            userControDashBoard1.BackColor = Color.FromArgb(236, 240, 241);
            userControDashBoard1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControDashBoard1.Location = new Point(258, 166);
            userControDashBoard1.Margin = new Padding(4, 3, 4, 3);
            userControDashBoard1.Name = "userControDashBoard1";
            userControDashBoard1.Size = new Size(1442, 859);
            userControDashBoard1.TabIndex = 4;
            // 
            // userControlAddTeacher1
            // 
            userControlAddTeacher1.BackColor = Color.SeaShell;
            userControlAddTeacher1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlAddTeacher1.ForeColor = Color.White;
            userControlAddTeacher1.Location = new Point(258, 164);
            userControlAddTeacher1.Margin = new Padding(4, 3, 4, 3);
            userControlAddTeacher1.Name = "userControlAddTeacher1";
            userControlAddTeacher1.RightToLeft = RightToLeft.No;
            userControlAddTeacher1.Size = new Size(1675, 906);
            userControlAddTeacher1.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.Location = new Point(261, 169);
            panel8.Name = "panel8";
            panel8.Size = new Size(1183, 777);
            panel8.TabIndex = 2;
            // 
            // userControlAddClass1
            // 
            userControlAddClass1.BackColor = SystemColors.ActiveCaption;
            userControlAddClass1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlAddClass1.ForeColor = Color.White;
            userControlAddClass1.Location = new Point(258, 164);
            userControlAddClass1.Margin = new Padding(4, 3, 4, 3);
            userControlAddClass1.Name = "userControlAddClass1";
            userControlAddClass1.RightToLeft = RightToLeft.No;
            userControlAddClass1.Size = new Size(1700, 871);
            userControlAddClass1.TabIndex = 6;
            userControlAddClass1.Load += userControlAddClass1_Load;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1700, 871);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Controls.Add(userControlAddClass1);
            Controls.Add(userControlAddTeacher1);
            Controls.Add(userControDashBoard1);
            Controls.Add(userControlAddStudent1);
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
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private ToolTip toolTip1;
        private Panel panel6;
        private Panel panelTop;
        private Panel panel7;
        private Attendence_System.Forms.UserControls.UserControlAddStudent userControlAddStudent1;
        private Attendence_System.Forms.UserControls.UserControDashBoard userControDashBoard1;
        private Attendence_System.Forms.UserControls.UserControlAddTeacher userControlAddTeacher1;
        private Panel panel8;
        private Attendence_System.Forms.UserControls.UserControlReports userControlReports1;
        private Attendence_System.Forms.UserControls.UserControlAddClass userControlAddClass1;
    }
}
