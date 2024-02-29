namespace Attendence_Management_System
{
    partial class Student
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            teacherPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label1 = new Label();
            comboBoxLanguage = new ComboBox();
            pictureBox1 = new PictureBox();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            comboBox1 = new ComboBox();
            dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Attendance = new DataGridViewTextBoxColumn();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            teacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // teacherPanel
            // 
            teacherPanel.Controls.Add(guna2ControlBox2);
            teacherPanel.Controls.Add(guna2ControlBox1);
            teacherPanel.Controls.Add(label1);
            teacherPanel.Controls.Add(comboBoxLanguage);
            teacherPanel.Controls.Add(pictureBox1);
            teacherPanel.CustomizableEdges = customizableEdges11;
            teacherPanel.Dock = DockStyle.Top;
            teacherPanel.Location = new Point(0, 0);
            teacherPanel.Name = "teacherPanel";
            teacherPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            teacherPanel.Size = new Size(857, 65);
            teacherPanel.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox2.CustomizableEdges = customizableEdges7;
            guna2ControlBox2.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(750, 21);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ControlBox2.Size = new Size(40, 29);
            guna2ControlBox2.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges9;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(806, 21);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2ControlBox1.Size = new Size(40, 29);
            guna2ControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(67, 3, 125);
            label1.Location = new Point(116, 14);
            label1.Name = "label1";
            label1.Size = new Size(171, 34);
            label1.TabIndex = 2;
            label1.Text = "Welcom {?}";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(545, 21);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(170, 28);
            comboBoxLanguage.TabIndex = 10;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Attendence_System.Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 3;
            guna2Separator1.Location = new Point(-19, 56);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(837, 10);
            guna2Separator1.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = teacherPanel;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(149, 165, 166);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.ItemHeight = 20;
            comboBox1.Location = new Point(78, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(720, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGrid.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGrid.ColumnHeadersHeight = 22;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Date, Attendance });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            dataGrid.GridColor = Color.FromArgb(231, 229, 255);
            dataGrid.Location = new Point(78, 198);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGrid.RowTemplate.Height = 28;
            dataGrid.ShowCellErrors = false;
            dataGrid.ShowCellToolTips = false;
            dataGrid.ShowEditingIcon = false;
            dataGrid.ShowRowErrors = false;
            dataGrid.Size = new Size(720, 351);
            dataGrid.TabIndex = 9;
            dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGrid.ThemeStyle.BackColor = Color.FromArgb(192, 192, 255);
            dataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.ThemeStyle.HeaderStyle.Height = 22;
            dataGrid.ThemeStyle.ReadOnly = true;
            dataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGrid.ThemeStyle.RowsStyle.Height = 28;
            dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Attendance
            // 
            Attendance.HeaderText = "Attendance";
            Attendance.MinimumWidth = 8;
            Attendance.Name = "Attendance";
            Attendance.ReadOnly = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Attendence_System.Properties.Resources.time;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(12, 61);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(67, 3, 125);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(11, 112);
            label3.Name = "label3";
            label3.Size = new Size(43, 18);
            label3.TabIndex = 21;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(67, 3, 125);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(12, 94);
            label4.Name = "label4";
            label4.Size = new Size(42, 18);
            label4.TabIndex = 20;
            label4.Text = "Time";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(857, 595);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dataGrid);
            Controls.Add(comboBox1);
            Controls.Add(guna2Separator1);
            Controls.Add(teacherPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Sheet";
            Load += Form1_Load;
            teacherPanel.ResumeLayout(false);
            teacherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel teacherPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Attendance;
        private ComboBox comboBoxLanguage;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

