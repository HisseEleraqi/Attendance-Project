namespace Attendence_System.Forms.UserControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAddStudent));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolTip = new ToolTip(components);
            tabControlAddClass = new TabControl();
            tabPage = new TabPage();
            showHide2 = new PictureBox();
            showHide = new PictureBox();
            ErrorPassword = new Label();
            PasswordErrorMsg = new Label();
            EmailErrorMsg = new Label();
            LnameErrorMsg = new Label();
            FnameErrorMsg = new Label();
            textBoxLastName = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            buttonCancel = new Button();
            label12 = new Label();
            buttonAddStudent = new Button();
            textBoxFristName = new TextBox();
            labelFname = new Label();
            textBoxPassRep = new TextBox();
            textBoxPassWord = new TextBox();
            label4 = new Label();
            label1Password = new Label();
            tabPageSearchClass = new TabPage();
            label5 = new Label();
            comboBox1 = new ComboBox();
            dataGridViewClass = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewCheckBoxColumn();
            Update = new DataGridViewButtonColumn();
            pictureBox1 = new PictureBox();
            textBoxSearchStudent = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tabControlAddClass.SuspendLayout();
            tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showHide2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showHide).BeginInit();
            tabPageSearchClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            tabControlAddClass.Size = new Size(1322, 718);
            tabControlAddClass.TabIndex = 0;
            tabControlAddClass.UseWaitCursor = true;
            // 
            // tabPage
            // 
            tabPage.BackColor = Color.FromArgb(250, 250, 250);
            tabPage.Controls.Add(showHide2);
            tabPage.Controls.Add(showHide);
            tabPage.Controls.Add(ErrorPassword);
            tabPage.Controls.Add(PasswordErrorMsg);
            tabPage.Controls.Add(EmailErrorMsg);
            tabPage.Controls.Add(LnameErrorMsg);
            tabPage.Controls.Add(FnameErrorMsg);
            tabPage.Controls.Add(textBoxLastName);
            tabPage.Controls.Add(labelEmail);
            tabPage.Controls.Add(textBoxEmail);
            tabPage.Controls.Add(label2);
            tabPage.Controls.Add(buttonCancel);
            tabPage.Controls.Add(label12);
            tabPage.Controls.Add(buttonAddStudent);
            tabPage.Controls.Add(textBoxFristName);
            tabPage.Controls.Add(labelFname);
            tabPage.Controls.Add(textBoxPassRep);
            tabPage.Controls.Add(textBoxPassWord);
            tabPage.Controls.Add(label4);
            tabPage.Controls.Add(label1Password);
            tabPage.Location = new Point(4, 4);
            tabPage.Name = "tabPage";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(1314, 684);
            tabPage.TabIndex = 0;
            tabPage.Text = "Add Student";
            tabPage.UseWaitCursor = true;
            tabPage.Click += tabPage_Click;
            // 
            // showHide2
            // 
            showHide2.BackColor = Color.DarkGray;
            showHide2.ErrorImage = (Image)resources.GetObject("showHide2.ErrorImage");
            showHide2.Image = (Image)resources.GetObject("showHide2.Image");
            showHide2.Location = new Point(1218, 659);
            showHide2.Name = "showHide2";
            showHide2.Size = new Size(25, 28);
            showHide2.TabIndex = 29;
            showHide2.TabStop = false;
            showHide2.UseWaitCursor = true;
            showHide2.Visible = false;
            showHide2.Click += showHide2_Click;
            // 
            // showHide
            // 
            showHide.BackColor = Color.DarkGray;
            showHide.ErrorImage = (Image)resources.GetObject("showHide.ErrorImage");
            showHide.Image = (Image)resources.GetObject("showHide.Image");
            showHide.Location = new Point(1237, 466);
            showHide.Name = "showHide";
            showHide.Size = new Size(30, 26);
            showHide.TabIndex = 29;
            showHide.TabStop = false;
            showHide.UseWaitCursor = true;
            showHide.Click += showHide_Click;
            // 
            // ErrorPassword
            // 
            ErrorPassword.AutoSize = true;
            ErrorPassword.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorPassword.ForeColor = Color.Red;
            ErrorPassword.Location = new Point(744, 498);
            ErrorPassword.Name = "ErrorPassword";
            ErrorPassword.Size = new Size(523, 20);
            ErrorPassword.TabIndex = 28;
            ErrorPassword.Text = "8 chars ,uppercase , lowercase letter, digit, and  special char";
            ErrorPassword.UseWaitCursor = true;
            ErrorPassword.Visible = false;
            // 
            // PasswordErrorMsg
            // 
            PasswordErrorMsg.AutoSize = true;
            PasswordErrorMsg.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordErrorMsg.ForeColor = Color.Red;
            PasswordErrorMsg.Location = new Point(778, 518);
            PasswordErrorMsg.Name = "PasswordErrorMsg";
            PasswordErrorMsg.Size = new Size(404, 26);
            PasswordErrorMsg.TabIndex = 28;
            PasswordErrorMsg.Text = "Sorry, Plz Enter a valid Password";
            PasswordErrorMsg.UseWaitCursor = true;
            PasswordErrorMsg.Visible = false;
            // 
            // EmailErrorMsg
            // 
            EmailErrorMsg.AutoSize = true;
            EmailErrorMsg.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailErrorMsg.ForeColor = Color.Red;
            EmailErrorMsg.Location = new Point(46, 518);
            EmailErrorMsg.Name = "EmailErrorMsg";
            EmailErrorMsg.Size = new Size(356, 26);
            EmailErrorMsg.TabIndex = 28;
            EmailErrorMsg.Text = "Sorry, Plz Enter a valid Email";
            EmailErrorMsg.UseWaitCursor = true;
            EmailErrorMsg.Visible = false;
            // 
            // LnameErrorMsg
            // 
            LnameErrorMsg.AutoSize = true;
            LnameErrorMsg.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LnameErrorMsg.ForeColor = Color.Red;
            LnameErrorMsg.Location = new Point(779, 269);
            LnameErrorMsg.Name = "LnameErrorMsg";
            LnameErrorMsg.Size = new Size(355, 26);
            LnameErrorMsg.TabIndex = 28;
            LnameErrorMsg.Text = "Sorry, Plz Enter a valid Name";
            LnameErrorMsg.UseWaitCursor = true;
            LnameErrorMsg.Visible = false;
            // 
            // FnameErrorMsg
            // 
            FnameErrorMsg.AutoSize = true;
            FnameErrorMsg.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FnameErrorMsg.ForeColor = Color.Red;
            FnameErrorMsg.Location = new Point(46, 252);
            FnameErrorMsg.Name = "FnameErrorMsg";
            FnameErrorMsg.Size = new Size(355, 26);
            FnameErrorMsg.TabIndex = 28;
            FnameErrorMsg.Text = "Sorry, Plz Enter a valid Name";
            FnameErrorMsg.UseWaitCursor = true;
            FnameErrorMsg.Visible = false;
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
            buttonAddStudent.Click += buttonAddStudent_Click;
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
            textBoxFristName.TextChanged += textBoxFristName_TextChanged;
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
            // textBoxPassRep
            // 
            textBoxPassRep.BackColor = Color.FromArgb(189, 195, 199);
            textBoxPassRep.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassRep.Location = new Point(830, 660);
            textBoxPassRep.Name = "textBoxPassRep";
            textBoxPassRep.Size = new Size(413, 28);
            textBoxPassRep.TabIndex = 13;
            textBoxPassRep.UseWaitCursor = true;
            textBoxPassRep.Visible = false;
            textBoxPassRep.TextChanged += textBoxPassWord_TextChanged;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.BackColor = Color.FromArgb(189, 195, 199);
            textBoxPassWord.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassWord.Location = new Point(779, 464);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.Size = new Size(488, 28);
            textBoxPassWord.TabIndex = 13;
            textBoxPassWord.UseWaitCursor = true;
            textBoxPassWord.TextChanged += textBoxPassWord_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(52, 73, 94);
            label4.Location = new Point(643, 653);
            label4.Name = "label4";
            label4.Size = new Size(177, 34);
            label4.TabIndex = 12;
            label4.Text = "Pass Repeat";
            label4.UseWaitCursor = true;
            label4.Visible = false;
            // 
            // label1Password
            // 
            label1Password.AutoSize = true;
            label1Password.BackColor = Color.Transparent;
            label1Password.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Password.ForeColor = Color.FromArgb(52, 73, 94);
            label1Password.Location = new Point(681, 400);
            label1Password.Name = "label1Password";
            label1Password.Size = new Size(140, 34);
            label1Password.TabIndex = 12;
            label1Password.Text = "Password";
            label1Password.UseWaitCursor = true;
            // 
            // tabPageSearchClass
            // 
            tabPageSearchClass.BackColor = Color.FromArgb(250, 250, 250);
            tabPageSearchClass.Controls.Add(label5);
            tabPageSearchClass.Controls.Add(comboBox1);
            tabPageSearchClass.Controls.Add(dataGridViewClass);
            tabPageSearchClass.Controls.Add(pictureBox1);
            tabPageSearchClass.Controls.Add(textBoxSearchStudent);
            tabPageSearchClass.Controls.Add(label1);
            tabPageSearchClass.Controls.Add(pictureBox2);
            tabPageSearchClass.Location = new Point(4, 4);
            tabPageSearchClass.Name = "tabPageSearchClass";
            tabPageSearchClass.Padding = new Padding(3);
            tabPageSearchClass.Size = new Size(1314, 684);
            tabPageSearchClass.TabIndex = 1;
            tabPageSearchClass.Text = "Crud Student";
            tabPageSearchClass.UseWaitCursor = true;
            tabPageSearchClass.Click += tabPageSearchClass_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(914, 68);
            label5.Name = "label5";
            label5.Size = new Size(134, 23);
            label5.TabIndex = 9;
            label5.Text = "Select Class:";
            label5.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1068, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 29);
            comboBox1.TabIndex = 8;
            comboBox1.UseWaitCursor = true;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // dataGridViewClass
            // 
            dataGridViewClass.AllowUserToAddRows = false;
            dataGridViewClass.AllowUserToResizeColumns = false;
            dataGridViewClass.AllowUserToResizeRows = false;
            dataGridViewClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClass.BackgroundColor = Color.WhiteSmoke;
            dataGridViewClass.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewClass.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClass.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column3, Column2, Column5, Update });
            dataGridViewClass.Location = new Point(84, 269);
            dataGridViewClass.Name = "dataGridViewClass";
            dataGridViewClass.ReadOnly = true;
            dataGridViewClass.RowHeadersWidth = 51;
            dataGridViewClass.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewClass.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewClass.ShowCellErrors = false;
            dataGridViewClass.ShowCellToolTips = false;
            dataGridViewClass.ShowEditingIcon = false;
            dataGridViewClass.ShowRowErrors = false;
            dataGridViewClass.Size = new Size(1175, 334);
            dataGridViewClass.TabIndex = 6;
            dataGridViewClass.UseWaitCursor = true;
            dataGridViewClass.CellContentClick += dataGridViewClass_CellContentClick;
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
            // Column5
            // 
            Column5.HeaderText = "Add To Class";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Update
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Red;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Update.DefaultCellStyle = dataGridViewCellStyle3;
            Update.HeaderText = "UpdateStudent";
            Update.MinimumWidth = 6;
            Update.Name = "Update";
            Update.ReadOnly = true;
            Update.Text = "UpdateStudent";
            Update.ToolTipText = "UpdateStudent";
            Update.UseColumnTextForButtonValue = true;
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
            // textBoxSearchStudent
            // 
            textBoxSearchStudent.BackColor = Color.FromArgb(189, 195, 199);
            textBoxSearchStudent.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchStudent.ForeColor = Color.Black;
            textBoxSearchStudent.Location = new Point(549, 215);
            textBoxSearchStudent.Name = "textBoxSearchStudent";
            textBoxSearchStudent.Size = new Size(307, 28);
            textBoxSearchStudent.TabIndex = 3;
            textBoxSearchStudent.UseWaitCursor = true;
            textBoxSearchStudent.TextChanged += textBoxSearchStudent_TextChanged;
            textBoxSearchStudent.KeyDown += textBoxSearchStudent_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 73, 94);
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(227, 34);
            label1.TabIndex = 0;
            label1.Text = "Search Student:";
            label1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ixkfkncp;
            pictureBox2.Location = new Point(491, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            pictureBox2.Click += pictureBox2_Click;
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
            Size = new Size(1322, 718);
            Load += UserControlAddStudent_Load;
            tabControlAddClass.ResumeLayout(false);
            tabPage.ResumeLayout(false);
            tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showHide2).EndInit();
            ((System.ComponentModel.ISupportInitialize)showHide).EndInit();
            tabPageSearchClass.ResumeLayout(false);
            tabPageSearchClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private TextBox textBoxSearchStudent;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewClass;
        private PictureBox pictureBox2;
        private Button buttonCancel;
        private TextBox textBoxLastName;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label label2;
        private Label FnameErrorMsg;
        private Label EmailErrorMsg;
        private Label LnameErrorMsg;
        private Label PasswordErrorMsg;
        private Label ErrorPassword;
        private PictureBox showHide;
        private PictureBox showHide2;
        private TextBox textBoxPassRep;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column5;
        private DataGridViewButtonColumn Update;
    }
}
