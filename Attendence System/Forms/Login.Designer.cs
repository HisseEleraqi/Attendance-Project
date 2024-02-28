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
            pictureBox3 = new PictureBox();
            showHide = new PictureBox();
            password = new TextBox();
            panel3 = new Panel();
            userName = new TextBox();
            pictureBox1 = new PictureBox();
            ErrorMessage = new Label();
            closeButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showHide).BeginInit();
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
            panel1.Size = new Size(300, 531);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(50, 22);
            label2.Name = "label2";
            label2.Size = new Size(181, 29);
            label2.TabIndex = 0;
            label2.Text = "Wlcome to EHE";
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
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(66, 100);
            label1.Name = "label1";
            label1.Size = new Size(319, 34);
            label1.TabIndex = 0;
            label1.Text = "Login To Your Account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(ErrorMessage);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(closeButton);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(296, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 531);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
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
            pictureBox2.Location = new Point(403, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 51);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox1_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(showHide);
            panel4.Controls.Add(password);
            panel4.Location = new Point(15, 252);
            panel4.Name = "panel4";
            panel4.Size = new Size(427, 45);
            panel4.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox1_Click_1;
            // 
            // showHide
            // 
            showHide.BackColor = Color.Transparent;
            showHide.Dock = DockStyle.Right;
            showHide.ErrorImage = (Image)resources.GetObject("showHide.ErrorImage");
            showHide.Image = (Image)resources.GetObject("showHide.Image");
            showHide.Location = new Point(388, 0);
            showHide.Name = "showHide";
            showHide.Size = new Size(39, 45);
            showHide.SizeMode = PictureBoxSizeMode.Zoom;
            showHide.TabIndex = 2;
            showHide.TabStop = false;
            showHide.Click += showHide_Click_1;
            // 
            // password
            // 
            password.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.ForeColor = Color.DarkBlue;
            password.Location = new Point(36, 0);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(414, 45);
            password.TabIndex = 4;
            password.KeyDown += password_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(userName);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(15, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 45);
            panel3.TabIndex = 1;
            // 
            // userName
            // 
            userName.Dock = DockStyle.Right;
            userName.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.ForeColor = Color.DarkBlue;
            userName.Location = new Point(36, 0);
            userName.Multiline = true;
            userName.Name = "userName";
            userName.Size = new Size(391, 45);
            userName.TabIndex = 3;
            userName.TextChanged += userName_TextChanged_1;
            userName.KeyDown += userName_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.BackColor = Color.Transparent;
            ErrorMessage.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ErrorMessage.ForeColor = Color.DarkBlue;
            ErrorMessage.Location = new Point(122, 322);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(206, 22);
            ErrorMessage.TabIndex = 0;
            ErrorMessage.Text = "Login To Your Account";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.AliceBlue;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.DodgerBlue;
            closeButton.Location = new Point(161, 371);
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
            ClientSize = new Size(750, 531);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)showHide).EndInit();
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