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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelstudent = new Label();
            label2 = new Label();
            label3 = new Label();
            labelTeachers = new Label();
            labelClasss = new Label();
            labelClasses = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dww2wts5;
            pictureBox1.Location = new Point(151, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pu5wzv181;
            pictureBox2.Location = new Point(577, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.x6fraj8f;
            pictureBox3.Location = new Point(316, 372);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(284, 147);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // labelstudent
            // 
            labelstudent.AutoSize = true;
            labelstudent.BackColor = Color.Tan;
            labelstudent.Location = new Point(213, 298);
            labelstudent.Name = "labelstudent";
            labelstudent.Size = new Size(74, 21);
            labelstudent.TabIndex = 3;
            labelstudent.Text = "student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 334);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 4;
            label2.Text = "{?}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 543);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 6;
            label3.Text = "{?}";
            // 
            // labelTeachers
            // 
            labelTeachers.AutoSize = true;
            labelTeachers.BackColor = Color.Tan;
            labelTeachers.Location = new Point(419, 522);
            labelTeachers.Name = "labelTeachers";
            labelTeachers.Size = new Size(78, 21);
            labelTeachers.TabIndex = 5;
            labelTeachers.Text = "Teacher";
            // 
            // labelClasss
            // 
            labelClasss.AutoSize = true;
            labelClasss.Location = new Point(683, 334);
            labelClasss.Name = "labelClasss";
            labelClasss.Size = new Size(33, 21);
            labelClasss.TabIndex = 8;
            labelClasss.Text = "{?}";
            // 
            // labelClasses
            // 
            labelClasses.AutoSize = true;
            labelClasses.BackColor = Color.Tan;
            labelClasses.Location = new Point(657, 298);
            labelClasses.Name = "labelClasses";
            labelClasses.Size = new Size(68, 21);
            labelClasses.TabIndex = 7;
            labelClasses.Text = "classes";
            // 
            // UserControDashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(labelClasss);
            Controls.Add(labelClasses);
            Controls.Add(label3);
            Controls.Add(labelTeachers);
            Controls.Add(label2);
            Controls.Add(labelstudent);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControDashBoard";
            Size = new Size(993, 687);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labelstudent;
        private Label label2;
        private Label label3;
        private Label labelTeachers;
        private Label labelClasss;
        private Label labelClasses;
    }
}
