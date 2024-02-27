namespace Attendence_System.Forms.UserControls
{
    partial class UserControlAddTeacher

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAddTeacher));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolTip = new ToolTip(components);
            tabControlAddClass = new TabControl();
            tabPage = new TabPage();
            ErrorPassword = new Label();
            PasswordErrorMsg = new Label();
            EmailErrorMsg = new Label();
            LnameErrorMsg = new Label();
            FnameErrorMsg = new Label();
            showHide = new PictureBox();
            textBoxLastName = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            buttonCancel = new Button();
            label12 = new Label();
            buttonAddTeacher = new Button();
            textBoxFristName = new TextBox();
            labelFname = new Label();
            textBoxPassWord = new TextBox();
            label1Password = new Label();
            tabPageSearchClass = new TabPage();
<<<<<<< HEAD
            textBoxSearchTeacher = new TextBox();
=======
            pictureBox2 = new PictureBox();
            textBoxSearch = new TextBox();
            label3 = new Label();
>>>>>>> 7beb2699acad1f35fc47e72ce1ba50b9b540cf80
            ButtonAddToClass = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            dataGridViewTeacher = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewCheckBoxColumn();
            pictureBox1 = new PictureBox();
            label1 = new Label();
<<<<<<< HEAD
            pictureBox2 = new PictureBox();
=======
>>>>>>> 7beb2699acad1f35fc47e72ce1ba50b9b540cf80
            tabControlAddClass.SuspendLayout();
            tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showHide).BeginInit();
            tabPageSearchClass.SuspendLayout();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacher).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).BeginInit();
>>>>>>> 7beb2699acad1f35fc47e72ce1ba50b9b540cf80
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControlAddClass
            // 
            tabControlAddClass.Alignment = TabAlignment.Bottom;
            tabControlAddClass.Controls.Add(tabPage);
            tabControlAddClass.Controls.Add(tabPageSearchClass);
            tabControlAddClass.Location = new Point(0, 0);
            tabControlAddClass.Multiline = true;
            tabControlAddClass.Name = "tabControlAddClass";
            tabControlAddClass.SelectedIndex = 0;
            tabControlAddClass.Size = new Size(1326, 722);
            tabControlAddClass.TabIndex = 0;
            tabControlAddClass.UseWaitCursor = true;
            // 
            // tabPage
            // 
            tabPage.BackColor = Color.FromArgb(250, 250, 250);
            tabPage.Controls.Add(ErrorPassword);
            tabPage.Controls.Add(PasswordErrorMsg);
            tabPage.Controls.Add(EmailErrorMsg);
            tabPage.Controls.Add(LnameErrorMsg);
            tabPage.Controls.Add(FnameErrorMsg);
            tabPage.Controls.Add(showHide);
            tabPage.Controls.Add(textBoxLastName);
            tabPage.Controls.Add(labelEmail);
            tabPage.Controls.Add(textBoxEmail);
            tabPage.Controls.Add(label2);
            tabPage.Controls.Add(buttonCancel);
            tabPage.Controls.Add(label12);
            tabPage.Controls.Add(buttonAddTeacher);
            tabPage.Controls.Add(textBoxFristName);
            tabPage.Controls.Add(labelFname);
            tabPage.Controls.Add(textBoxPassWord);
            tabPage.Controls.Add(label1Password);
            tabPage.Location = new Point(4, 4);
            tabPage.Name = "tabPage";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(1318, 688);
            tabPage.TabIndex = 0;
            tabPage.Text = "Add Teacher";
            tabPage.UseWaitCursor = true;
            // 
            // ErrorPassword
            // 
            ErrorPassword.AutoSize = true;
            ErrorPassword.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorPassword.ForeColor = Color.Red;
            ErrorPassword.Location = new Point(754, 509);
            ErrorPassword.Name = "ErrorPassword";
            ErrorPassword.Size = new Size(523, 20);
            ErrorPassword.TabIndex = 31;
            ErrorPassword.Text = "8 chars ,uppercase , lowercase letter, digit, and  special char";
            ErrorPassword.UseWaitCursor = true;
            ErrorPassword.Visible = false;
            // 
            // PasswordErrorMsg
            // 
            PasswordErrorMsg.AutoSize = true;
            PasswordErrorMsg.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordErrorMsg.ForeColor = Color.Red;
            PasswordErrorMsg.Location = new Point(788, 529);
            PasswordErrorMsg.Name = "PasswordErrorMsg";
            PasswordErrorMsg.Size = new Size(404, 26);
            PasswordErrorMsg.TabIndex = 32;
            PasswordErrorMsg.Text = "Sorry, Plz Enter a valid Password";
            PasswordErrorMsg.UseWaitCursor = true;
            PasswordErrorMsg.Visible = false;
            // 
            // EmailErrorMsg
            // 
            EmailErrorMsg.AutoSize = true;
            EmailErrorMsg.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailErrorMsg.ForeColor = Color.Red;
            EmailErrorMsg.Location = new Point(55, 529);
            EmailErrorMsg.Name = "EmailErrorMsg";
            EmailErrorMsg.Size = new Size(356, 26);
            EmailErrorMsg.TabIndex = 33;
            EmailErrorMsg.Text = "Sorry, Plz Enter a valid Email";
            EmailErrorMsg.UseWaitCursor = true;
            EmailErrorMsg.Visible = false;
            // 
            // LnameErrorMsg
            // 
            LnameErrorMsg.AutoSize = true;
            LnameErrorMsg.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LnameErrorMsg.ForeColor = Color.Red;
            LnameErrorMsg.Location = new Point(788, 257);
            LnameErrorMsg.Name = "LnameErrorMsg";
            LnameErrorMsg.Size = new Size(355, 26);
            LnameErrorMsg.TabIndex = 34;
            LnameErrorMsg.Text = "Sorry, Plz Enter a valid Name";
            LnameErrorMsg.UseWaitCursor = true;
            LnameErrorMsg.Visible = false;
            // 
            // FnameErrorMsg
            // 
            FnameErrorMsg.AutoSize = true;
            FnameErrorMsg.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FnameErrorMsg.ForeColor = Color.Red;
            FnameErrorMsg.Location = new Point(56, 249);
            FnameErrorMsg.Name = "FnameErrorMsg";
            FnameErrorMsg.Size = new Size(355, 26);
            FnameErrorMsg.TabIndex = 35;
            FnameErrorMsg.Text = "Sorry, Plz Enter a valid Name";
            FnameErrorMsg.UseWaitCursor = true;
            FnameErrorMsg.Visible = false;
            // 
            // showHide
            // 
            showHide.BackColor = Color.DarkGray;
            showHide.ErrorImage = (Image)resources.GetObject("showHide.ErrorImage");
            showHide.Image = (Image)resources.GetObject("showHide.Image");
            showHide.Location = new Point(1223, 466);
            showHide.Name = "showHide";
            showHide.Size = new Size(30, 26);
            showHide.TabIndex = 30;
            showHide.TabStop = false;
            showHide.UseWaitCursor = true;
            showHide.Click += showHide_Click;
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
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(52, 73, 94);
            label12.Location = new Point(6, 60);
            label12.Name = "label12";
            label12.Size = new Size(206, 34);
            label12.TabIndex = 22;
            label12.Text = "Add Teacher :";
            label12.UseWaitCursor = true;
            // 
            // buttonAddTeacher
            // 
            buttonAddTeacher.BackColor = Color.FromArgb(0, 87, 146);
            buttonAddTeacher.Location = new Point(285, 595);
            buttonAddTeacher.Name = "buttonAddTeacher";
            buttonAddTeacher.Size = new Size(185, 50);
            buttonAddTeacher.TabIndex = 21;
            buttonAddTeacher.Text = "Add Teacher";
            buttonAddTeacher.UseVisualStyleBackColor = false;
            buttonAddTeacher.UseWaitCursor = true;
            buttonAddTeacher.Click += buttonAddTeacher_Click;
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
            tabPageSearchClass.Controls.Add(textBoxSearchTeacher);
            tabPageSearchClass.Controls.Add(ButtonAddToClass);
            tabPageSearchClass.Controls.Add(label5);
            tabPageSearchClass.Controls.Add(comboBox1);
            tabPageSearchClass.Controls.Add(dataGridViewTeacher);
            tabPageSearchClass.Controls.Add(pictureBox1);
            tabPageSearchClass.Controls.Add(label1);
            tabPageSearchClass.Controls.Add(pictureBox2);
            tabPageSearchClass.Location = new Point(4, 4);
            tabPageSearchClass.Name = "tabPageSearchClass";
            tabPageSearchClass.Padding = new Padding(3);
<<<<<<< HEAD
            tabPageSearchClass.Size = new Size(1318, 688);
=======
            tabPageSearchClass.Size = new Size(1332, 692);
>>>>>>> 7beb2699acad1f35fc47e72ce1ba50b9b540cf80
            tabPageSearchClass.TabIndex = 1;
            tabPageSearchClass.Text = "Search Teacher";
            tabPageSearchClass.UseWaitCursor = true;
            // 
<<<<<<< HEAD
            // textBoxSearchTeacher
            // 
            textBoxSearchTeacher.BackColor = Color.FromArgb(189, 195, 199);
            textBoxSearchTeacher.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchTeacher.ForeColor = Color.Black;
            textBoxSearchTeacher.Location = new Point(552, 187);
            textBoxSearchTeacher.Name = "textBoxSearchTeacher";
            textBoxSearchTeacher.Size = new Size(292, 28);
            textBoxSearchTeacher.TabIndex = 21;
            textBoxSearchTeacher.UseWaitCursor = true;
            textBoxSearchTeacher.KeyDown += textBoxSearchTeacher_KeyDown;
=======
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ixkfkncp;
            pictureBox2.Location = new Point(479, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(189, 195, 199);
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.ForeColor = Color.FromArgb(189, 195, 199);
            textBoxSearch.Location = new Point(479, 187);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(365, 28);
            textBoxSearch.TabIndex = 21;
            textBoxSearch.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(52, 73, 94);
            label3.Location = new Point(479, 192);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 20;
            label3.Text = "Name:";
            label3.UseWaitCursor = true;
>>>>>>> 7beb2699acad1f35fc47e72ce1ba50b9b540cf80
            // 
            // ButtonAddToClass
            // 
            ButtonAddToClass.BackColor = Color.SpringGreen;
            ButtonAddToClass.FlatAppearance.BorderColor = Color.White;
            ButtonAddToClass.FlatAppearance.BorderSize = 99;
            ButtonAddToClass.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            ButtonAddToClass.ForeColor = SystemColors.InactiveCaptionText;
            ButtonAddToClass.Location = new Point(1060, 99);
            ButtonAddToClass.Name = "ButtonAddToClass";
            ButtonAddToClass.Size = new Size(137, 41);
            ButtonAddToClass.TabIndex = 19;
            ButtonAddToClass.Text = "Add to Class";
            ButtonAddToClass.UseVisualStyleBackColor = false;
            ButtonAddToClass.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(882, 50);
            label5.Name = "label5";
            label5.Size = new Size(134, 23);
            label5.TabIndex = 18;
            label5.Text = "Select Class:";
            label5.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Add Class " });
            comboBox1.Location = new Point(1036, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 29);
            comboBox1.TabIndex = 17;
            comboBox1.UseWaitCursor = true;
            // 
            // dataGridViewTeacher
            // 
<<<<<<< HEAD
            dataGridViewTeacher.AllowUserToAddRows = false;
            dataGridViewTeacher.AllowUserToDeleteRows = false;
            dataGridViewTeacher.AllowUserToResizeColumns = false;
            dataGridViewTeacher.AllowUserToResizeRows = false;
            dataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeacher.BackgroundColor = Color.WhiteSmoke;
            dataGridViewTeacher.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewTeacher.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeacher.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column3, Column2, Column5 });
            dataGridViewTeacher.Location = new Point(61, 255);
            dataGridViewTeacher.Name = "dataGridViewTeacher";
            dataGridViewTeacher.ReadOnly = true;
            dataGridViewTeacher.RowHeadersWidth = 51;
            dataGridViewTeacher.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewTeacher.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTeacher.ShowCellErrors = false;
            dataGridViewTeacher.ShowCellToolTips = false;
            dataGridViewTeacher.ShowEditingIcon = false;
            dataGridViewTeacher.ShowRowErrors = false;
            dataGridViewTeacher.Size = new Size(1247, 412);
            dataGridViewTeacher.TabIndex = 6;
            dataGridViewTeacher.UseWaitCursor = true;
            dataGridViewTeacher.CellBeginEdit += dataGridViewTeacher_CellBeginEdit;
            dataGridViewTeacher.CellEndEdit += dataGridViewTeacher_CellEndEdit;
            dataGridViewTeacher.KeyDown += dataGridViewTeacher_KeyDown;
=======
            dataGridViewClass.AllowUserToAddRows = false;
            dataGridViewClass.AllowUserToDeleteRows = false;
            dataGridViewClass.AllowUserToResizeColumns = false;
            dataGridViewClass.AllowUserToResizeRows = false;
            dataGridViewClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClass.BackgroundColor = Color.WhiteSmoke;
            dataGridViewClass.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewClass.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClass.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column3, Column2, Column5 });
            dataGridViewClass.Location = new Point(61, 255);
            dataGridViewClass.Name = "dataGridViewClass";
            dataGridViewClass.ReadOnly = true;
            dataGridViewClass.RowHeadersWidth = 51;
            dataGridViewClass.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewClass.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClass.ShowCellErrors = false;
            dataGridViewClass.ShowCellToolTips = false;
            dataGridViewClass.ShowEditingIcon = false;
            dataGridViewClass.ShowRowErrors = false;
            dataGridViewClass.Size = new Size(1247, 412);
            dataGridViewClass.TabIndex = 6;
            dataGridViewClass.UseWaitCursor = true;
>>>>>>> 7beb2699acad1f35fc47e72ce1ba50b9b540cf80
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
            Column4.HeaderText = "Teacher Name";
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
            // Column5
            // 
            Column5.HeaderText = "Add To Classes";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.ThreeState = true;
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
<<<<<<< HEAD
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ixkfkncp;
            pictureBox2.Location = new Point(494, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
=======
>>>>>>> 7beb2699acad1f35fc47e72ce1ba50b9b540cf80
            // UserControlAddTeacher
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(tabControlAddClass);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlAddTeacher";
            RightToLeft = RightToLeft.No;
            Size = new Size(1340, 725);
            Load += UserControlAddTeacher_loed;
            tabControlAddClass.ResumeLayout(false);
            tabPage.ResumeLayout(false);
            tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showHide).EndInit();
            tabPageSearchClass.ResumeLayout(false);
            tabPageSearchClass.PerformLayout();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacher).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).EndInit();
>>>>>>> 7beb2699acad1f35fc47e72ce1ba50b9b540cf80
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
        private Button buttonAddTeacher;
        private TextBox textBoxFristName;
        private Label labelFname;
        private TextBox textBoxPassWord;
        private Label label1Password;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewTeacher;
        private PictureBox pictureBox2;
        private Button buttonCancel;
        private TextBox textBoxLastName;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label label2;
        private PictureBox showHide;
        private Label ErrorPassword;
        private Label PasswordErrorMsg;
        private Label EmailErrorMsg;
        private Label LnameErrorMsg;
        private Label FnameErrorMsg;
        private Button ButtonAddToClass;
        private TextBox textBoxSearch;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBoxSearchTeacher;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column5;
    }
}
