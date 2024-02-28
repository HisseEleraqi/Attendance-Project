namespace Attendence_System.Forms.UserControls
{
    partial class UserControlReports2

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolTip = new ToolTip(components);
            tabControlAddClass = new TabControl();
            tabPage = new TabPage();
            EndDate_Picker = new DateTimePicker();
            StartDate_Picker = new DateTimePicker();
            guna2ComboBox1 = new ComboBox();
            Generate = new Button();
            tabPageSearchClass = new TabPage();
            textBoxSearchTeacher = new TextBox();
            ButtonAddToClass = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            dataGridViewClass = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewCheckBoxColumn();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tabControlAddClass.SuspendLayout();
            tabPage.SuspendLayout();
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
            tabPage.Controls.Add(EndDate_Picker);
            tabPage.Controls.Add(StartDate_Picker);
            tabPage.Controls.Add(guna2ComboBox1);
            tabPage.Controls.Add(Generate);
            tabPage.Location = new Point(4, 4);
            tabPage.Name = "tabPage";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(1318, 686);
            tabPage.TabIndex = 0;
            tabPage.Text = "Add Teacher";
            tabPage.UseWaitCursor = true;
            // 
            // EndDate_Picker
            // 
            EndDate_Picker.Location = new Point(348, 263);
            EndDate_Picker.Name = "EndDate_Picker";
            EndDate_Picker.Size = new Size(300, 33);
            EndDate_Picker.TabIndex = 24;
            EndDate_Picker.UseWaitCursor = true;
            // 
            // StartDate_Picker
            // 
            StartDate_Picker.Location = new Point(348, 182);
            StartDate_Picker.Name = "StartDate_Picker";
            StartDate_Picker.Size = new Size(300, 33);
            StartDate_Picker.TabIndex = 23;
            StartDate_Picker.UseWaitCursor = true;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.FormattingEnabled = true;
            guna2ComboBox1.Location = new Point(405, 104);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.Size = new Size(182, 31);
            guna2ComboBox1.TabIndex = 22;
            guna2ComboBox1.UseWaitCursor = true;
            // 
            // Generate
            // 
            Generate.BackColor = Color.FromArgb(0, 87, 146);
            Generate.Location = new Point(402, 398);
            Generate.Name = "Generate";
            Generate.Size = new Size(185, 50);
            Generate.TabIndex = 21;
            Generate.Text = "Add Teacher";
            Generate.UseVisualStyleBackColor = false;
            Generate.UseWaitCursor = true;
            Generate.Click += Generate_Click;
            // 
            // tabPageSearchClass
            // 
            tabPageSearchClass.BackColor = Color.FromArgb(250, 250, 250);
            tabPageSearchClass.Controls.Add(textBoxSearchTeacher);
            tabPageSearchClass.Controls.Add(ButtonAddToClass);
            tabPageSearchClass.Controls.Add(label5);
            tabPageSearchClass.Controls.Add(comboBox1);
            tabPageSearchClass.Controls.Add(dataGridViewClass);
            tabPageSearchClass.Controls.Add(pictureBox1);
            tabPageSearchClass.Controls.Add(label1);
            tabPageSearchClass.Controls.Add(pictureBox2);
            tabPageSearchClass.Location = new Point(4, 4);
            tabPageSearchClass.Name = "tabPageSearchClass";
            tabPageSearchClass.Padding = new Padding(3);
            tabPageSearchClass.Size = new Size(1318, 684);
            tabPageSearchClass.TabIndex = 1;
            tabPageSearchClass.Text = "Search Teacher";
            tabPageSearchClass.UseWaitCursor = true;
            // 
            // textBoxSearchTeacher
            // 
            textBoxSearchTeacher.BackColor = Color.FromArgb(189, 195, 199);
            textBoxSearchTeacher.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchTeacher.ForeColor = Color.Black;
            textBoxSearchTeacher.Location = new Point(552, 187);
            textBoxSearchTeacher.Name = "textBoxSearchTeacher";
            textBoxSearchTeacher.Size = new Size(292, 33);
            textBoxSearchTeacher.TabIndex = 21;
            textBoxSearchTeacher.UseWaitCursor = true;
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
            label5.Size = new Size(159, 28);
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
            comboBox1.Size = new Size(191, 31);
            comboBox1.TabIndex = 17;
            comboBox1.UseWaitCursor = true;
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
            label1.Size = new Size(277, 39);
            label1.TabIndex = 0;
            label1.Text = "Search Teacher:";
            label1.UseWaitCursor = true;
            // 
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
            // UserControlReports2
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(tabControlAddClass);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlReports2";
            RightToLeft = RightToLeft.No;
            Size = new Size(1340, 725);
            tabControlAddClass.ResumeLayout(false);
            tabPage.ResumeLayout(false);
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
        private Button Generate;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewClass;
        private PictureBox pictureBox2;
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
        private ComboBox guna2ComboBox1;
        private DateTimePicker StartDate_Picker;
        private DateTimePicker EndDate_Picker;
    }
}
