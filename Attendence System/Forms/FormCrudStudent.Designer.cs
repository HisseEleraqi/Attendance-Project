namespace Attendence_System.Forms
{
    partial class FormCrudStudent
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
            labelFristName = new Label();
            labelLastName = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            label6 = new Label();
            FstName = new TextBox();
            LstName = new TextBox();
            password = new TextBox();
            rePassword = new TextBox();
            buttonCancel = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            comboBoxLanguage = new ComboBox();
            SuspendLayout();
            // 
            // labelFristName
            // 
            labelFristName.AutoSize = true;
            labelFristName.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);
            labelFristName.ForeColor = Color.CornflowerBlue;
            labelFristName.Location = new Point(538, 116);
            labelFristName.Name = "labelFristName";
            labelFristName.Size = new Size(118, 25);
            labelFristName.TabIndex = 0;
            labelFristName.Text = "Frist Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);
            labelLastName.ForeColor = Color.CornflowerBlue;
            labelLastName.Location = new Point(539, 161);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(119, 25);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);
            labelEmail.ForeColor = Color.CornflowerBlue;
            labelEmail.Location = new Point(538, 213);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(107, 25);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Password";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);
            labelPassword.ForeColor = Color.CornflowerBlue;
            labelPassword.Location = new Point(538, 278);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(182, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "ReEnterPassword";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(257, 44);
            label6.Name = "label6";
            label6.Size = new Size(172, 34);
            label6.TabIndex = 5;
            label6.Text = "Edit Student";
            // 
            // FstName
            // 
            FstName.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FstName.ForeColor = Color.DarkBlue;
            FstName.Location = new Point(220, 116);
            FstName.Name = "FstName";
            FstName.Size = new Size(253, 28);
            FstName.TabIndex = 6;
            // 
            // LstName
            // 
            LstName.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            LstName.ForeColor = Color.DarkBlue;
            LstName.Location = new Point(220, 161);
            LstName.Name = "LstName";
            LstName.Size = new Size(253, 28);
            LstName.TabIndex = 7;
            // 
            // password
            // 
            password.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            password.ForeColor = Color.DarkBlue;
            password.Location = new Point(220, 210);
            password.Name = "password";
            password.Size = new Size(253, 28);
            password.TabIndex = 8;
            // 
            // rePassword
            // 
            rePassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            rePassword.ForeColor = Color.DarkBlue;
            rePassword.Location = new Point(220, 275);
            rePassword.Name = "rePassword";
            rePassword.Size = new Size(253, 28);
            rePassword.TabIndex = 9;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkOrange;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(66, 390);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(121, 38);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.LightGreen;
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(510, 390);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(119, 37);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(12, 61);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(122, 46);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(538, 44);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(170, 28);
            comboBoxLanguage.TabIndex = 14;
            // 
            // FormCrudStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 440);
            Controls.Add(comboBoxLanguage);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCancel);
            Controls.Add(rePassword);
            Controls.Add(password);
            Controls.Add(LstName);
            Controls.Add(FstName);
            Controls.Add(label6);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelLastName);
            Controls.Add(labelFristName);
            Name = "FormCrudStudent";
            Text = "FormCrudStudent";
            Load += FormCrudStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFristName;
        private Label labelLastName;
        private Label labelEmail;
        private Label labelPassword;
        private Label label6;
        private TextBox FstName;
        private TextBox LstName;
        private TextBox password;
        private TextBox rePassword;
        private Button buttonCancel;
        private Button buttonUpdate;
        private Button buttonDelete;
        private ComboBox comboBoxLanguage;
    }
}