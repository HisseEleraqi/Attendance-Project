﻿namespace Attendence_System.Forms.UserControls
{
    partial class UserControlAddStudent
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
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);
            tabControlAddClass = new TabControl();
            tabPage = new TabPage();
            textBoxLastName = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            buttonCancel = new Button();
            label12 = new Label();
            buttonAddStudent = new Button();
            textBoxFristName = new TextBox();
            labelFname = new Label();
            textBoxPassWord = new TextBox();
            label1Password = new Label();
            tabPageSearchClass = new TabPage();
            pictureBox2 = new PictureBox();
            dataGridViewClass = new DataGridView();
            pictureBox1 = new PictureBox();
            textBoxSearch = new TextBox();
            label3 = new Label();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            tabControlAddClass.SuspendLayout();
            tabPage.SuspendLayout();
            tabPageSearchClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControlAddClass
            // 
            tabControlAddClass.Alignment = TabAlignment.Bottom;
            tabControlAddClass.Controls.Add(tabPage);
            tabControlAddClass.Controls.Add(tabPageSearchClass);
            tabControlAddClass.Dock = DockStyle.Fill;
            tabControlAddClass.Location = new Point(0, 0);
            tabControlAddClass.Multiline = true;
            tabControlAddClass.Name = "tabControlAddClass";
            tabControlAddClass.SelectedIndex = 0;
            tabControlAddClass.Size = new Size(1340, 725);
            tabControlAddClass.TabIndex = 0;
            tabControlAddClass.UseWaitCursor = true;
            // 
            // tabPage
            // 
            tabPage.BackColor = Color.FromArgb(250, 250, 250);
            tabPage.Controls.Add(textBoxLastName);
            tabPage.Controls.Add(labelEmail);
            tabPage.Controls.Add(textBoxEmail);
            tabPage.Controls.Add(label2);
            tabPage.Controls.Add(buttonCancel);
            tabPage.Controls.Add(label12);
            tabPage.Controls.Add(buttonAddStudent);
            tabPage.Controls.Add(textBoxFristName);
            tabPage.Controls.Add(labelFname);
            tabPage.Controls.Add(textBoxPassWord);
            tabPage.Controls.Add(label1Password);
            tabPage.Location = new Point(4, 4);
            tabPage.Name = "tabPage";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(1332, 691);
            tabPage.TabIndex = 0;
            tabPage.Text = "Add Student";
            tabPage.UseWaitCursor = true;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.FromArgb(189, 195, 199);
            textBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName.Location = new Point(727, 226);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(526, 28);
            textBoxLastName.TabIndex = 27;
            textBoxLastName.UseWaitCursor = true;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(52, 73, 94);
            labelEmail.Location = new Point(29, 400);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(88, 34);
            labelEmail.TabIndex = 26;
            labelEmail.Text = "Email";
            labelEmail.UseWaitCursor = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(189, 195, 199);
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(29, 466);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(526, 28);
            textBoxEmail.TabIndex = 25;
            textBoxEmail.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(52, 73, 94);
            label2.Location = new Point(727, 158);
            label2.Name = "label2";
            label2.Size = new Size(156, 34);
            label2.TabIndex = 24;
            label2.Text = "Last Name";
            label2.UseWaitCursor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Red;
            buttonCancel.Location = new Point(812, 595);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(185, 50);
            buttonCancel.TabIndex = 23;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(52, 73, 94);
            label12.Location = new Point(6, 60);
            label12.Name = "label12";
            label12.Size = new Size(189, 34);
            label12.TabIndex = 22;
            label12.Text = "Add Student:";
            label12.UseWaitCursor = true;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.BackColor = Color.FromArgb(0, 87, 146);
            buttonAddStudent.Location = new Point(285, 595);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(185, 50);
            buttonAddStudent.TabIndex = 21;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.UseWaitCursor = true;
            // 
            // textBoxFristName
            // 
            textBoxFristName.BackColor = Color.FromArgb(189, 195, 199);
            textBoxFristName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFristName.Location = new Point(29, 209);
            textBoxFristName.Name = "textBoxFristName";
            textBoxFristName.Size = new Size(526, 28);
            textBoxFristName.TabIndex = 15;
            textBoxFristName.UseWaitCursor = true;
            // 
            // labelFname
            // 
            labelFname.AutoSize = true;
            labelFname.BackColor = Color.Transparent;
            labelFname.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFname.ForeColor = Color.FromArgb(52, 73, 94);
            labelFname.Location = new Point(29, 158);
            labelFname.Name = "labelFname";
            labelFname.Size = new Size(155, 34);
            labelFname.TabIndex = 14;
            labelFname.Text = "Frist Name";
            labelFname.UseWaitCursor = true;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.BackColor = Color.FromArgb(189, 195, 199);
            textBoxPassWord.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassWord.Location = new Point(727, 466);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.Size = new Size(526, 28);
            textBoxPassWord.TabIndex = 13;
            textBoxPassWord.UseWaitCursor = true;
            // 
            // label1Password
            // 
            label1Password.AutoSize = true;
            label1Password.BackColor = Color.Transparent;
            label1Password.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Password.ForeColor = Color.FromArgb(52, 73, 94);
            label1Password.Location = new Point(727, 400);
            label1Password.Name = "label1Password";
            label1Password.Size = new Size(140, 34);
            label1Password.TabIndex = 12;
            label1Password.Text = "Password";
            label1Password.UseWaitCursor = true;
            // 
            // tabPageSearchClass
            // 
            tabPageSearchClass.BackColor = Color.FromArgb(250, 250, 250);
            tabPageSearchClass.Controls.Add(pictureBox2);
            tabPageSearchClass.Controls.Add(dataGridViewClass);
            tabPageSearchClass.Controls.Add(pictureBox1);
            tabPageSearchClass.Controls.Add(textBoxSearch);
            tabPageSearchClass.Controls.Add(label3);
            tabPageSearchClass.Controls.Add(label1);
            tabPageSearchClass.Location = new Point(4, 4);
            tabPageSearchClass.Name = "tabPageSearchClass";
            tabPageSearchClass.Padding = new Padding(3);
            tabPageSearchClass.Size = new Size(1332, 691);
            tabPageSearchClass.TabIndex = 1;
            tabPageSearchClass.Text = "Search Update Student";
            tabPageSearchClass.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ixkfkncp;
            pictureBox2.Location = new Point(924, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // dataGridViewClass
            // 
            dataGridViewClass.AllowUserToAddRows = false;
            dataGridViewClass.AllowUserToDeleteRows = false;
            dataGridViewClass.AllowUserToResizeColumns = false;
            dataGridViewClass.AllowUserToResizeRows = false;
            dataGridViewClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClass.BackgroundColor = Color.WhiteSmoke;
            dataGridViewClass.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewClass.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClass.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column3, Column2 });
            dataGridViewClass.Location = new Point(61, 133);
            dataGridViewClass.Name = "dataGridViewClass";
            dataGridViewClass.ReadOnly = true;
            dataGridViewClass.RowHeadersWidth = 51;
            dataGridViewClass.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewClass.ShowCellErrors = false;
            dataGridViewClass.ShowCellToolTips = false;
            dataGridViewClass.ShowEditingIcon = false;
            dataGridViewClass.ShowRowErrors = false;
            dataGridViewClass.Size = new Size(1247, 534);
            dataGridViewClass.TabIndex = 6;
            dataGridViewClass.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ixkfkncp;
            pictureBox1.Location = new Point(877, 394);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(189, 195, 199);
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.ForeColor = Color.FromArgb(189, 195, 199);
            textBoxSearch.Location = new Point(322, 99);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(596, 28);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(52, 73, 94);
            label3.Location = new Point(291, 74);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            label3.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 73, 94);
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(236, 34);
            label1.TabIndex = 0;
            label1.Text = "Search Teacher:";
            label1.UseWaitCursor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Student Name";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Email";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Class Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(tabControlAddClass);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlAddStudent";
            RightToLeft = RightToLeft.No;
            Size = new Size(1340, 725);
            tabControlAddClass.ResumeLayout(false);
            tabPage.ResumeLayout(false);
            tabPage.PerformLayout();
            tabPageSearchClass.ResumeLayout(false);
            tabPageSearchClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private TabControl tabControlAddClass;
        private TabPage tabPage;
        private TabPage tabPageSearchClass;
        private Label label1;
        private Label label12;
        private Button buttonAddStudent;
        private TextBox textBoxFristName;
        private Label labelFname;
        private TextBox textBoxPassWord;
        private Label label1Password;
        private TextBox textBoxSearch;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewClass;
        private PictureBox pictureBox2;
        private Button buttonCancel;
        private TextBox textBoxLastName;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
    }
}
