namespace Attendence_System.Forms.UserControls
{
    partial class UserControDashBoard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControDashBoard));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelstudent = new Label();
            studentCount = new Label();
            teacherCount = new Label();
            labelTeachers = new Label();
            classsCount = new Label();
            labelClasses = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            comboBoxLanguage = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(577, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelstudent
            // 
            labelstudent.AutoSize = true;
            labelstudent.BackColor = Color.DarkGray;
            labelstudent.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelstudent.Location = new Point(193, 298);
            labelstudent.Name = "labelstudent";
            labelstudent.Size = new Size(96, 27);
            labelstudent.TabIndex = 3;
            labelstudent.Text = "student";
            // 
            // studentCount
            // 
            studentCount.AutoSize = true;
            studentCount.Location = new Point(225, 347);
            studentCount.Name = "studentCount";
            studentCount.Size = new Size(33, 21);
            studentCount.TabIndex = 4;
            studentCount.Text = "{?}";
            studentCount.Click += label2_Click;
            // 
            // teacherCount
            // 
            teacherCount.AutoSize = true;
            teacherCount.Location = new Point(444, 575);
            teacherCount.Name = "teacherCount";
            teacherCount.Size = new Size(33, 21);
            teacherCount.TabIndex = 6;
            teacherCount.Text = "{?}";
            // 
            // labelTeachers
            // 
            labelTeachers.AutoSize = true;
            labelTeachers.BackColor = Color.DarkGray;
            labelTeachers.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTeachers.Location = new Point(410, 522);
            labelTeachers.Name = "labelTeachers";
            labelTeachers.Size = new Size(105, 27);
            labelTeachers.TabIndex = 5;
            labelTeachers.Text = "Teacher";
            // 
            // classsCount
            // 
            classsCount.AutoSize = true;
            classsCount.Location = new Point(672, 334);
            classsCount.Name = "classsCount";
            classsCount.Size = new Size(33, 21);
            classsCount.TabIndex = 8;
            classsCount.Text = "{?}";
            // 
            // labelClasses
            // 
            labelClasses.AutoSize = true;
            labelClasses.BackColor = Color.DarkGray;
            labelClasses.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClasses.Location = new Point(647, 298);
            labelClasses.Name = "labelClasses";
            labelClasses.Size = new Size(91, 27);
            labelClasses.TabIndex = 0;
            labelClasses.Text = "classes";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(351, 347);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(222, 154);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(52, 73, 94);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 666);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 11;
            label1.Text = "Attdance System";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 536);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(112, 111);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(788, 22);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(170, 29);
            comboBoxLanguage.TabIndex = 12;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // UserControDashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            Controls.Add(comboBoxLanguage);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(classsCount);
            Controls.Add(labelClasses);
            Controls.Add(teacherCount);
            Controls.Add(labelTeachers);
            Controls.Add(studentCount);
            Controls.Add(labelstudent);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControDashBoard";
            Size = new Size(993, 687);
            Load += UserControDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelstudent;
        private Label studentCount;
        private Label teacherCount;
        private Label labelTeachers;
        private Label classsCount;
        private Label labelClasses;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private ComboBox comboBoxLanguage;
    }
}
