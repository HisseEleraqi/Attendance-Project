﻿namespace Attendence_System.Forms
{
    partial class FormCrudTeacher
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
            password = new Label();
            rePassword = new Label();
            label6 = new Label();
            FstName = new TextBox();
            LstName = new TextBox();
            pass = new TextBox();
            rePass = new TextBox();
            buttonCancel = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
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
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);
            password.ForeColor = Color.CornflowerBlue;
            password.Location = new Point(538, 213);
            password.Name = "password";
            password.Size = new Size(107, 25);
            password.TabIndex = 2;
            password.Text = "Password";
            // 
            // rePassword
            // 
            rePassword.AutoSize = true;
            rePassword.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);
            rePassword.ForeColor = Color.CornflowerBlue;
            rePassword.Location = new Point(539, 278);
            rePassword.Name = "rePassword";
            rePassword.Size = new Size(182, 25);
            rePassword.TabIndex = 3;
            rePassword.Text = "ReEnterPassword";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(257, 44);
            label6.Name = "label6";
            label6.Size = new Size(181, 34);
            label6.TabIndex = 5;
            label6.Text = "Edit Teacher";
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
            // pass
            // 
            pass.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            pass.ForeColor = Color.DarkBlue;
            pass.Location = new Point(220, 210);
            pass.Name = "pass";
            pass.Size = new Size(253, 28);
            pass.TabIndex = 8;
            // 
            // rePass
            // 
            rePass.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            rePass.ForeColor = Color.DarkBlue;
            rePass.Location = new Point(220, 275);
            rePass.Name = "rePass";
            rePass.Size = new Size(253, 28);
            rePass.TabIndex = 9;
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
            // FormCrudTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 440);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCancel);
            Controls.Add(rePass);
            Controls.Add(pass);
            Controls.Add(LstName);
            Controls.Add(FstName);
            Controls.Add(label6);
            Controls.Add(rePassword);
            Controls.Add(password);
            Controls.Add(labelLastName);
            Controls.Add(labelFristName);
            Name = "FormCrudTeacher";
            Text = "FormCrudStudent";
            Load += FormCrudTeacher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFristName;
        private Label labelLastName;
        private Label password;
        private Label rePassword;
        private Label label6;
        private TextBox FstName;
        private TextBox LstName;
        private TextBox pass;
        private TextBox rePass;
        private Button buttonCancel;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}