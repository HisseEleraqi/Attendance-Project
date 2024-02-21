// File: ExcelPrinter.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace Attendence_Management_System
{
    public class ExcelPrinter
    {
        public static void Print(DataGridView dataGridView, string filePath)
        {
            // Create a SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "Attendance.xlsx";

            // Show the dialog and get the result
            DialogResult result = saveFileDialog.ShowDialog();

            // If the user clicks OK, proceed with saving the Excel file
            if (result == DialogResult.OK)
            {
                SaveAsExcel(dataGridView, saveFileDialog.FileName);
            }

            // open the file after saving
            System.Diagnostics.Process.Start(saveFileDialog.FileName);
        }

        private static void SaveAsExcel(DataGridView dataGridView, string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Copy DataGridView data to Excel worksheet
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                    for (int j = 1; j <= dataGridView.Rows.Count; j++)
                    {
                        // If it's a CheckBox column, set the value to 1 if checked, 0 if unchecked
                        if (dataGridView.Columns[i - 1] is DataGridViewCheckBoxColumn)
                        {
                            bool isChecked = Convert.ToBoolean(dataGridView.Rows[j - 1].Cells[i - 1].Value);
                            worksheet.Cells[j + 1, i].Value = isChecked ? 1 : 0;
                        }
                        else
                        {
                            worksheet.Cells[j + 1, i].Value = dataGridView.Rows[j - 1].Cells[i - 1].Value;
                        }
                    }
                }

                // Save the Excel file using the provided file path
                package.SaveAs(new FileInfo(filePath));
            }
        }
    }
}
