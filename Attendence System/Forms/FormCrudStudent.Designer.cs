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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);
            labelEmail.ForeColor = Color.CornflowerBlue;
            labelEmail.Location = new Point(566, 213);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(76, 25);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "E-mail";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Century Gothic", 12.2F, FontStyle.Bold);
            labelPassword.ForeColor = Color.CornflowerBlue;
            labelPassword.Location = new Point(548, 278);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(107, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
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
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkBlue;
            textBox1.Location = new Point(220, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 28);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            textBox2.ForeColor = Color.DarkBlue;
            textBox2.Location = new Point(220, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 28);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            textBox3.ForeColor = Color.DarkBlue;
            textBox3.Location = new Point(220, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 28);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            textBox4.ForeColor = Color.DarkBlue;
            textBox4.Location = new Point(220, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(253, 28);
            textBox4.TabIndex = 9;
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
            // 
            // FormCrudStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 440);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCancel);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelLastName);
            Controls.Add(labelFristName);
            Name = "FormCrudStudent";
            Text = "FormCrudStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFristName;
        private Label labelLastName;
        private Label labelEmail;
        private Label labelPassword;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button buttonCancel;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}