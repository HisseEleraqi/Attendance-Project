using System.Windows.Forms;

namespace Attendence_Management_System.Forms
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            showHide = new PictureBox();
            password = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            userName = new TextBox();
            pictureBox1 = new PictureBox();
            ErrorMessage = new Label();
            closeButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 530);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(21, 241);
            label2.Name = "label2";
            label2.Size = new Size(244, 26);
            label2.TabIndex = 0;
            label2.Text = "Welcome To Viaro sys";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(398, -18);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Condensed", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 7, true);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(77, 100);
            label1.Name = "label1";
            label1.Size = new Size(296, 31);
            label1.TabIndex = 0;
            label1.Text = "Login To Your Account";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(ErrorMessage);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(closeButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 530);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(49, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 27);
            textBox1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Attendence_System.Properties.Resources.exit;
            pictureBox2.Location = new Point(399, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 51);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox1_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(showHide);
            panel4.Controls.Add(password);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 253);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 45);
            panel4.TabIndex = 1;
            // 
            // showHide
            // 
            showHide.BackColor = Color.Transparent;
            showHide.ErrorImage = (Image)resources.GetObject("showHide.ErrorImage");
            showHide.Image = (Image)resources.GetObject("showHide.Image");
            showHide.Location = new Point(408, 8);
            showHide.Name = "showHide";
            showHide.Size = new Size(39, 37);
            showHide.TabIndex = 2;
            showHide.TabStop = false;
            showHide.Click += showHide_Click_1;
            // 
            // password
            // 
            password.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = SystemColors.ScrollBar;
            password.Location = new Point(49, 1);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(401, 42);
            password.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(5, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 42);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(userName);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(3, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 45);
            panel3.TabIndex = 1;
            // 
            // userName
            // 
            userName.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.ForeColor = SystemColors.ScrollBar;
            userName.Location = new Point(46, 3);
            userName.Multiline = true;
            userName.Name = "userName";
            userName.Size = new Size(404, 42);
            userName.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 42);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.BackColor = Color.Transparent;
            ErrorMessage.Font = new Font("Algerian", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ErrorMessage.ForeColor = Color.Crimson;
            ErrorMessage.Location = new Point(87, 322);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(238, 20);
            ErrorMessage.TabIndex = 0;
            ErrorMessage.Text = "Login To Your Account";
            ErrorMessage.Click += label1_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Gainsboro;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.DodgerBlue;
            closeButton.Location = new Point(146, 371);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(128, 52);
            closeButton.TabIndex = 0;
            closeButton.Text = "Login";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Logincs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button closeButton;
        private Label label2;
        private Button button1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private TextBox userName;
        private TextBox password;
        private PictureBox showHide;
        private Label ErrorMessage;
    }
}