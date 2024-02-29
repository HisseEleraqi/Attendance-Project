
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
            button2 = new Button();
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
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            UserName = new Label();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel8 = new Panel();
            userControlAddClass1 = new Attendence_System.Forms.UserControls.UserControlAddClass();
            userControlAddStudent1 = new Attendence_System.Forms.UserControls.UserControlAddStudent();
            userControDashBoard1 = new Attendence_System.Forms.UserControls.UserControDashBoard();
            userControlAddTeacher1 = new Attendence_System.Forms.UserControls.UserControlAddTeacher();
            timerDateTime = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            panel5.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 62, 80);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(Report);
            panel4.Controls.Add(panelSlide);
            panel4.Controls.Add(buttonAddStudent);
            panel4.Controls.Add(buttonAddClass);
            panel4.Controls.Add(Teacher);
            panel4.Controls.Add(buttonDashBorde);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.White;
            button2.Image = Attendence_System.Properties.Resources.immigration__1_;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Report
            // 
            resources.ApplyResources(Report, "Report");
            Report.FlatAppearance.BorderSize = 0;
            Report.ForeColor = Color.White;
            Report.Image = Attendence_System.Properties.Resources.seo_report__1_;
            Report.Name = "Report";
            Report.UseVisualStyleBackColor = true;
            Report.Click += Report_Click;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            resources.ApplyResources(panelSlide, "panelSlide");
            panelSlide.Name = "panelSlide";
            // 
            // buttonAddStudent
            // 
            resources.ApplyResources(buttonAddStudent, "buttonAddStudent");
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Image = Attendence_System.Properties.Resources.student;
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonAddClass
            // 
            resources.ApplyResources(buttonAddClass, "buttonAddClass");
            buttonAddClass.FlatAppearance.BorderSize = 0;
            buttonAddClass.ForeColor = Color.White;
            buttonAddClass.Image = Attendence_System.Properties.Resources._class;
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.UseVisualStyleBackColor = true;
            buttonAddClass.Click += addClass_Click;
            // 
            // Teacher
            // 
            resources.ApplyResources(Teacher, "Teacher");
            Teacher.FlatAppearance.BorderSize = 0;
            Teacher.ForeColor = Color.White;
            Teacher.Image = Attendence_System.Properties.Resources.teacher;
            Teacher.Name = "Teacher";
            Teacher.UseVisualStyleBackColor = true;
            Teacher.Click += Teacher_Click;
            // 
            // buttonDashBorde
            // 
            resources.ApplyResources(buttonDashBorde, "buttonDashBorde");
            buttonDashBorde.FlatAppearance.BorderSize = 0;
            buttonDashBorde.ForeColor = Color.White;
            buttonDashBorde.Name = "buttonDashBorde";
            toolTip1.SetToolTip(buttonDashBorde, resources.GetString("buttonDashBorde.ToolTip"));
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
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // panel7
            // 
            resources.ApplyResources(panel7, "panel7");
            panel7.Name = "panel7";
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.Name = "panel6";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.FromArgb(52, 73, 94);
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(panelTop);
            resources.ApplyResources(panelBack, "panelBack");
            panelBack.Name = "panelBack";
            // 
            // panelExpand
            // 
            resources.ApplyResources(panelExpand, "panelExpand");
            panelExpand.BackColor = Color.FromArgb(149, 165, 166);
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(panel5);
            panelExpand.Name = "panelExpand";
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.FromArgb(52, 73, 94);
            buttonLogOut.Cursor = Cursors.Hand;
            resources.ApplyResources(buttonLogOut, "buttonLogOut");
            buttonLogOut.ForeColor = Color.White;
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 73, 94);
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonMinimize;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(149, 165, 166);
            panelTop.Controls.Add(pictureBox3);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(UserName);
            panelTop.Controls.Add(pictureBoxExpand);
            panelTop.Controls.Add(pictureBox2);
            resources.ApplyResources(panelTop, "panelTop");
            panelTop.Name = "panelTop";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Attendence_System.Properties.Resources.time;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // UserName
            // 
            resources.ApplyResources(UserName, "UserName");
            UserName.ForeColor = Color.White;
            UserName.Name = "UserName";
            // 
            // pictureBoxExpand
            // 
            resources.ApplyResources(pictureBoxExpand, "pictureBoxExpand");
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // panel8
            // 
            resources.ApplyResources(panel8, "panel8");
            panel8.Name = "panel8";
            // 
            // userControlAddClass1
            // 
            userControlAddClass1.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(userControlAddClass1, "userControlAddClass1");
            userControlAddClass1.ForeColor = Color.White;
            userControlAddClass1.Name = "userControlAddClass1";
            userControlAddClass1.Load += userControlAddClass1_Load;
            // 
            // userControlAddStudent1
            // 
            userControlAddStudent1.BackColor = Color.SeaShell;
            resources.ApplyResources(userControlAddStudent1, "userControlAddStudent1");
            userControlAddStudent1.ForeColor = Color.White;
            userControlAddStudent1.Name = "userControlAddStudent1";
            // 
            // userControDashBoard1
            // 
            userControDashBoard1.BackColor = Color.FromArgb(236, 240, 241);
            resources.ApplyResources(userControDashBoard1, "userControDashBoard1");
            userControDashBoard1.Name = "userControDashBoard1";
            // 
            // userControlAddTeacher1
            // 
            userControlAddTeacher1.BackColor = Color.SeaShell;
            resources.ApplyResources(userControlAddTeacher1, "userControlAddTeacher1");
            userControlAddTeacher1.ForeColor = Color.White;
            userControlAddTeacher1.Name = "userControlAddTeacher1";
            // 
            // timerDateTime
            // 
            timerDateTime.Tick += timerDateTime_Tick;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Controls.Add(userControlAddStudent1);
            Controls.Add(userControlAddClass1);
            Controls.Add(userControlAddTeacher1);
            Controls.Add(userControDashBoard1);
            ForeColor = Color.FromArgb(67, 3, 125);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Panel panel8;
        private Attendence_System.Forms.UserControls.UserControlReports userControlReports1;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timerDateTime;
        private PictureBox pictureBox3;
        private Attendence_System.Forms.UserControls.UserControlAddClass userControlAddClass1;
        private Attendence_System.Forms.UserControls.UserControlAddStudent userControlAddStudent1;
        private Attendence_System.Forms.UserControls.UserControDashBoard userControDashBoard1;
        private Attendence_System.Forms.UserControls.UserControlAddTeacher userControlAddTeacher1;
        private Button button2;
    }
}
