namespace Attendence_System.Forms.UserControls
{
    partial class UserREPORTS

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            StartDate_Picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            EndDate_Picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Generate = new Guna.UI2.WinForms.Guna2Button();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // StartDate_Picker
            // 
            StartDate_Picker.Checked = true;
            StartDate_Picker.CustomizableEdges = customizableEdges1;
            StartDate_Picker.Font = new Font("Segoe UI", 9F);
            StartDate_Picker.Format = DateTimePickerFormat.Long;
            StartDate_Picker.Location = new Point(518, 292);
            StartDate_Picker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            StartDate_Picker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            StartDate_Picker.Name = "StartDate_Picker";
            StartDate_Picker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            StartDate_Picker.Size = new Size(250, 45);
            StartDate_Picker.TabIndex = 0;
            StartDate_Picker.Value = new DateTime(2024, 2, 22, 18, 33, 55, 802);
            // 
            // EndDate_Picker
            // 
            EndDate_Picker.Checked = true;
            EndDate_Picker.CustomizableEdges = customizableEdges3;
            EndDate_Picker.Font = new Font("Segoe UI", 9F);
            EndDate_Picker.Format = DateTimePickerFormat.Long;
            EndDate_Picker.Location = new Point(518, 412);
            EndDate_Picker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            EndDate_Picker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            EndDate_Picker.Name = "EndDate_Picker";
            EndDate_Picker.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EndDate_Picker.Size = new Size(250, 45);
            EndDate_Picker.TabIndex = 1;
            EndDate_Picker.Value = new DateTime(2024, 2, 22, 18, 33, 59, 757);
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(600, 362);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(86, 25);
            guna2HtmlLabel2.TabIndex = 4;
            guna2HtmlLabel2.Text = "End Date :\r\n";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(595, 242);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(96, 25);
            guna2HtmlLabel3.TabIndex = 5;
            guna2HtmlLabel3.Text = "Start Date :\r\n";
            // 
            // Generate
            // 
            Generate.CustomizableEdges = customizableEdges5;
            Generate.DisabledState.BorderColor = Color.DarkGray;
            Generate.DisabledState.CustomBorderColor = Color.DarkGray;
            Generate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Generate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Generate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Generate.ForeColor = Color.White;
            Generate.Location = new Point(545, 482);
            Generate.Name = "Generate";
            Generate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Generate.Size = new Size(196, 56);
            Generate.TabIndex = 6;
            Generate.Text = "Generate";
            Generate.Click += Generate_Click_1;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges7;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(518, 181);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ComboBox1.Size = new Size(250, 36);
            guna2ComboBox1.TabIndex = 7;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(610, 131);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(67, 25);
            guna2HtmlLabel1.TabIndex = 8;
            guna2HtmlLabel1.Text = "Course :";
            // 
            // UserControlReports
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2ComboBox1);
            Controls.Add(Generate);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(EndDate_Picker);
            Controls.Add(StartDate_Picker);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlReports";
            Size = new Size(1456, 713);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker StartDate_Picker;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDate_Picker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button Generate;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
