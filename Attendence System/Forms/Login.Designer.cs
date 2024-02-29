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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
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
            timerDate = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.MidnightBlue;
            label2.Name = "label2";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = SystemColors.Highlight;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += closeButton_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.DarkBlue;
            label1.Name = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(ErrorMessage);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(closeButton);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            panel2.Paint += panel2_Paint_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Attendence_System.Properties.Resources.time;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(67, 3, 125);
            label3.Name = "label3";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(67, 3, 125);
            label4.Name = "label4";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Attendence_System.Properties.Resources.exit;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox1_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(showHide);
            panel4.Controls.Add(password);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox1_Click_1;
            // 
            // showHide
            // 
            showHide.BackColor = Color.Transparent;
            resources.ApplyResources(showHide, "showHide");
            showHide.Name = "showHide";
            showHide.TabStop = false;
            showHide.Click += showHide_Click_1;
            // 
            // password
            // 
            resources.ApplyResources(password, "password");
            password.ForeColor = Color.DarkBlue;
            password.Name = "password";
            password.KeyDown += password_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(userName);
            panel3.Controls.Add(pictureBox1);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // userName
            // 
            resources.ApplyResources(userName, "userName");
            userName.ForeColor = Color.DarkBlue;
            userName.Name = "userName";
            userName.TextChanged += userName_TextChanged_1;
            userName.KeyDown += userName_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // ErrorMessage
            // 
            resources.ApplyResources(ErrorMessage, "ErrorMessage");
            ErrorMessage.BackColor = Color.Transparent;
            ErrorMessage.ForeColor = Color.DarkBlue;
            ErrorMessage.Name = "ErrorMessage";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.AliceBlue;
            closeButton.Cursor = Cursors.Hand;
            resources.ApplyResources(closeButton, "closeButton");
            closeButton.ForeColor = Color.DodgerBlue;
            closeButton.Name = "closeButton";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // timerDate
            // 
            timerDate.Tick += timerDate_Tick;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timerDate;
    }
}