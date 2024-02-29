namespace Attendence_Management_System2
{
    partial class AdminAttendance
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAttendance));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            comboBox1 = new ComboBox();
            dataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            AbsentStatus = new DataGridViewCheckBoxColumn();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            pDFToolStripMenuItem = new ToolStripMenuItem();
            eXCELToolStripMenuItem = new ToolStripMenuItem();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Checked = true;
            dateTimePicker.CustomizableEdges = customizableEdges5;
            dateTimePicker.FillColor = Color.DodgerBlue;
            dateTimePicker.Font = new Font("Segoe UI", 9F);
            dateTimePicker.ForeColor = SystemColors.ButtonFace;
            dateTimePicker.Format = DateTimePickerFormat.Long;
            dateTimePicker.Location = new Point(98, 176);
            dateTimePicker.Margin = new Padding(4);
            dateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dateTimePicker.Size = new Size(388, 45);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.Value = new DateTime(2024, 2, 16, 17, 14, 22, 39);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.ItemHeight = 25;
            comboBox1.Location = new Point(671, 176);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 33);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.ColumnHeadersHeight = 22;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, AbsentStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            dataGrid.GridColor = Color.FromArgb(231, 229, 255);
            dataGrid.Location = new Point(98, 248);
            dataGrid.Margin = new Padding(4);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGrid.RowTemplate.Height = 28;
            dataGrid.ShowCellErrors = false;
            dataGrid.ShowCellToolTips = false;
            dataGrid.ShowEditingIcon = false;
            dataGrid.ShowRowErrors = false;
            dataGrid.Size = new Size(900, 329);
            dataGrid.TabIndex = 9;
            dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGrid.ThemeStyle.BackColor = Color.White;
            dataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.ThemeStyle.HeaderStyle.Height = 22;
            dataGrid.ThemeStyle.ReadOnly = false;
            dataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGrid.ThemeStyle.RowsStyle.Height = 28;
            dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "StudentID";
            StudentID.MinimumWidth = 8;
            StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            StudentName.HeaderText = "StudentName";
            StudentName.MinimumWidth = 8;
            StudentName.Name = "StudentName";
            // 
            // AbsentStatus
            // 
            AbsentStatus.HeaderText = "AbsentStatus";
            AbsentStatus.MinimumWidth = 8;
            AbsentStatus.Name = "AbsentStatus";
            AbsentStatus.Resizable = DataGridViewTriState.False;
            AbsentStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.ImageAlign = HorizontalAlignment.Right;
            guna2Button1.ImageSize = new Size(64, 64);
            guna2Button1.Location = new Point(622, 618);
            guna2Button1.Margin = new Padding(4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(322, 111);
            guna2Button1.TabIndex = 10;
            guna2Button1.Text = "Export to EXCEL";
            guna2Button1.TextAlign = HorizontalAlignment.Left;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Image = (Image)resources.GetObject("guna2Button2.Image");
            guna2Button2.ImageAlign = HorizontalAlignment.Right;
            guna2Button2.ImageSize = new Size(64, 64);
            guna2Button2.Location = new Point(175, 618);
            guna2Button2.Margin = new Padding(4);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(322, 111);
            guna2Button2.TabIndex = 11;
            guna2Button2.Text = "Export to PDF";
            guna2Button2.TextAlign = HorizontalAlignment.Left;
            guna2Button2.UseTransparentBackground = true;
            guna2Button2.Click += guna2Button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Attendence_System.Properties.Resources.time;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(26, 85);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(67, 3, 125);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(25, 149);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 22);
            label3.TabIndex = 24;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(67, 3, 125);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(26, 126);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 23;
            label4.Text = "Time";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1071, 33);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, loadToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(218, 34);
            newToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            loadToolStripMenuItem.Size = new Size(218, 34);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(218, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDFToolStripMenuItem, eXCELToolStripMenuItem });
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            eToolStripMenuItem.Size = new Size(79, 29);
            eToolStripMenuItem.Text = "&Export";
            // 
            // pDFToolStripMenuItem
            // 
            pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            pDFToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            pDFToolStripMenuItem.Size = new Size(222, 34);
            pDFToolStripMenuItem.Text = "PDF";
            pDFToolStripMenuItem.Click += pDFToolStripMenuItem_Click;
            // 
            // eXCELToolStripMenuItem
            // 
            eXCELToolStripMenuItem.Name = "eXCELToolStripMenuItem";
            eXCELToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            eXCELToolStripMenuItem.Size = new Size(222, 34);
            eXCELToolStripMenuItem.Text = "EXCEL";
            eXCELToolStripMenuItem.Click += eXCELToolStripMenuItem_Click;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(996, 13);
            guna2ControlBox1.Margin = new Padding(4);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(50, 36);
            guna2ControlBox1.TabIndex = 27;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // AdminAttendance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 744);
            Controls.Add(guna2ControlBox1);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(guna2Button2);
            Controls.Add(dataGrid);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker);
            Controls.Add(guna2Button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "AdminAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Sheet";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AbsentStatus;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem pDFToolStripMenuItem;
        private ToolStripMenuItem eXCELToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

