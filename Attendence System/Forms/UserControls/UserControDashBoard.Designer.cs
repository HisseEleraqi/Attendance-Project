﻿namespace Attendence_System.Forms.UserControls
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
            label2 = new Label();
            label3 = new Label();
            labelTeachers = new Label();
            labelClasss = new Label();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 347);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 4;
            label2.Text = "{?}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 575);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 6;
            label3.Text = "{?}";
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
            // labelClasss
            // 
            labelClasss.AutoSize = true;
            labelClasss.Location = new Point(672, 334);
            labelClasss.Name = "labelClasss";
            labelClasss.Size = new Size(33, 21);
            labelClasss.TabIndex = 8;
            labelClasss.Text = "{?}";
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
            Controls.Add(labelClasss);
            Controls.Add(labelClasses);
            Controls.Add(label3);
            Controls.Add(labelTeachers);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label labelTeachers;
        private Label labelClasss;
        private Label labelClasses;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private ComboBox comboBoxLanguage;
    }
}
