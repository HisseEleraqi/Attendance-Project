// File: DataGridViewPrinter.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Attendence_Management_System
{
    public class DataGridViewPrinter
    {
        public static void Print(DataGridView dataGridView)
        {
            // Create a DGVPrinter
            DGVPrinter printer = new DGVPrinter();

            // Title
            printer.Title = "Attendance Sheet";
            printer.SubTitle = "hello";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            // Footer
            printer.Footer = "Attendance";
            printer.FooterSpacing = 15;

            // Print the DataGridView
            printer.PrintDataGridView(dataGridView);
        }
    }
}
