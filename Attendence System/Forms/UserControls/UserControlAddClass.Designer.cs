﻿namespace Attendence_System.Forms.UserControls
{
    partial class UserControlAddClass
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolTip = new ToolTip(components);
            tabControlAddClass = new TabControl();
            tabPage = new TabPage();
            button2 = new Button();
            label12 = new Label();
            button1 = new Button();
            ClassID = new TextBox();
            label10 = new Label();
            ClassName = new TextBox();
            label11 = new Label();
            tabPageSearchClass = new TabPage();
            comboBoxClassName = new ComboBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            textBoxSearch = new TextBox();
            dataGridViewClass = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label1 = new Label();
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
            tabControlAddClass.Size = new Size(1260, 675);
            tabControlAddClass.TabIndex = 0;
            tabControlAddClass.UseWaitCursor = true;
            tabControlAddClass.SelectedIndexChanged += tabControlAddClass_SelectedIndexChanged;
            // 
            // tabPage
            // 
            tabPage.BackColor = Color.FromArgb(250, 250, 250);
            tabPage.Controls.Add(button2);
            tabPage.Controls.Add(label12);
            tabPage.Controls.Add(button1);
            tabPage.Controls.Add(ClassID);
            tabPage.Controls.Add(label10);
            tabPage.Controls.Add(ClassName);
            tabPage.Controls.Add(label11);
            tabPage.Location = new Point(4, 4);
            tabPage.Name = "tabPage";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(1252, 641);
            tabPage.TabIndex = 0;
            tabPage.Text = "Add Class";
            tabPage.UseWaitCursor = true;
            tabPage.Click += tabPage_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(965, 516);
            button2.Name = "button2";
            button2.Size = new Size(185, 50);
            button2.TabIndex = 23;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(52, 73, 94);
            label12.Location = new Point(6, 60);
            label12.Name = "label12";
            label12.Size = new Size(167, 34);
            label12.TabIndex = 22;
            label12.Text = "Add Class :";
            label12.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 87, 146);
            button1.Location = new Point(215, 516);
            button1.Name = "button1";
            button1.Size = new Size(185, 50);
            button1.TabIndex = 21;
            button1.Text = "Add Class";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // ClassID
            // 
            ClassID.BackColor = Color.FromArgb(189, 195, 199);
            ClassID.BorderStyle = BorderStyle.FixedSingle;
            ClassID.Location = new Point(453, 237);
            ClassID.Name = "ClassID";
            ClassID.Size = new Size(526, 28);
            ClassID.TabIndex = 15;
            ClassID.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(52, 73, 94);
            label10.Location = new Point(453, 186);
            label10.Name = "label10";
            label10.Size = new Size(122, 34);
            label10.TabIndex = 14;
            label10.Text = "Class ID";
            label10.UseWaitCursor = true;
            // 
            // ClassName
            // 
            ClassName.BackColor = Color.FromArgb(189, 195, 199);
            ClassName.BorderStyle = BorderStyle.FixedSingle;
            ClassName.Location = new Point(453, 392);
            ClassName.Name = "ClassName";
            ClassName.Size = new Size(526, 28);
            ClassName.TabIndex = 13;
            ClassName.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(52, 73, 94);
            label11.Location = new Point(453, 337);
            label11.Name = "label11";
            label11.Size = new Size(185, 34);
            label11.TabIndex = 12;
            label11.Text = "Class Name:";
            label11.UseWaitCursor = true;
            // 
            // tabPageSearchClass
            // 
            tabPageSearchClass.BackColor = Color.FromArgb(250, 250, 250);
            tabPageSearchClass.Controls.Add(comboBoxClassName);
            tabPageSearchClass.Controls.Add(label2);
            tabPageSearchClass.Controls.Add(pictureBox2);
            tabPageSearchClass.Controls.Add(textBoxSearch);
            tabPageSearchClass.Controls.Add(dataGridViewClass);
            tabPageSearchClass.Controls.Add(pictureBox1);
            tabPageSearchClass.Controls.Add(label1);
            tabPageSearchClass.Location = new Point(4, 4);
            tabPageSearchClass.Name = "tabPageSearchClass";
            tabPageSearchClass.Padding = new Padding(3);
            tabPageSearchClass.Size = new Size(1252, 641);
            tabPageSearchClass.TabIndex = 1;
            tabPageSearchClass.Text = "Crud Class";
            tabPageSearchClass.UseWaitCursor = true;
            tabPageSearchClass.Click += tabPageSearchClass_Click;
            // 
            // comboBoxClassName
            // 
            comboBoxClassName.BackColor = Color.FromArgb(189, 195, 199);
            comboBoxClassName.FormattingEnabled = true;
            comboBoxClassName.Location = new Point(396, 128);
            comboBoxClassName.Name = "comboBoxClassName";
            comboBoxClassName.Size = new Size(442, 29);
            comboBoxClassName.TabIndex = 12;
            comboBoxClassName.UseWaitCursor = true;
            comboBoxClassName.SelectedIndexChanged += comboBoxClassName_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(505, 46);
            label2.Name = "label2";
            label2.Size = new Size(193, 34);
            label2.TabIndex = 11;
            label2.Text = "Class Name :";
            label2.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ixkfkncp;
            pictureBox2.Location = new Point(6, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(189, 195, 199);
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.ForeColor = Color.FromArgb(189, 195, 199);
            textBoxSearch.Location = new Point(49, 102);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(173, 28);
            textBoxSearch.TabIndex = 9;
            textBoxSearch.UseWaitCursor = true;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
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
            dataGridViewClass.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column3 });
            dataGridViewClass.Location = new Point(84, 230);
            dataGridViewClass.Name = "dataGridViewClass";
            dataGridViewClass.ReadOnly = true;
            dataGridViewClass.RowHeadersWidth = 51;
            dataGridViewClass.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewClass.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClass.ShowCellErrors = false;
            dataGridViewClass.ShowCellToolTips = false;
            dataGridViewClass.ShowEditingIcon = false;
            dataGridViewClass.ShowRowErrors = false;
            dataGridViewClass.Size = new Size(1104, 324);
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
            Column4.HeaderText = "Students Name";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Class Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
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
            label1.Size = new Size(205, 34);
            label1.TabIndex = 0;
            label1.Text = "Search Class :";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // UserControlAddClass
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(tabControlAddClass);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlAddClass";
            RightToLeft = RightToLeft.No;
            Size = new Size(1260, 675);
            Load += UserControlAddClass_Load;
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
        private Button button1;
        private TextBox ClassID;
        private Label label10;
        private TextBox ClassName;
        private Label label11;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewClass;
        private Button button2;
        private PictureBox pictureBox2;
        private TextBox textBoxSearch;
        private ComboBox comboBoxClassName;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
    }
}
