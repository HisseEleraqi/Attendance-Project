using Attendence_System.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendence_System.Forms.UserControls
{
    public partial class UserControlAddClass : UserControl
    {
        public UserControlAddClass()
        {
            InitializeComponent();
        }

        private void tabControlAddClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? className = ClassName.Text.Trim();
            string? classID = ClassID.Text.Trim();
            if (!string.IsNullOrEmpty(className) && !string.IsNullOrEmpty(classID))
            {
                Validator validator = new Validator();
                if (!validator.validateClassName(className))
                {
                    MessageBox.Show("Invalid Class Name");
                    className = className.ToUpper();
                    return;
                }
                else if (validator.CheckDuplicateClassName(className))
                {
                    MessageBox.Show("Class Name Already Exists");
                    return;
                }
                else
                {
                    AddClass addClass = new AddClass();
                    addClass.Name = className;
                    //addClass.ID = classID;
                    addClass.AddClassToXML();
                    MessageBox.Show("Class Added Successfully");
                }

            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Resources\\Data.xml");
            XmlNodeList nodes = doc.SelectNodes("/school/classes/class");
            dataGridViewClass.Rows.Clear(); //
            foreach (XmlNode node in nodes)
            {
                string id = node.SelectSingleNode("id").InnerText;
                string name = node.SelectSingleNode("name").InnerText;

                XmlNodeList students = doc.SelectNodes("/school/classes/class/student");
                dataGridViewClass.Rows.Add(id, name, students.Count);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClassName.Text != "" || ClassID.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to clear the fields?", "Clear Fields", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ClassName.Text = "";
                    ClassID.Text = "";
                }
            }

        }

        private void comboBoxClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGrid();
        }
        public void fillDataGrid()
        {
            dataGridViewClass.Rows.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Resources\\Attendance.xml");
            XmlNodeList students = doc.SelectNodes($"/AttendanceData/Class[ClassName=\"{comboBoxClassName.SelectedItem}\"]/Students/Student");
            Console.WriteLine($"/AttendanceData/Class[ClassName=\"{comboBoxClassName.SelectedItem}\"]/Students/Student");
            foreach (XmlNode student in students)
            {
                string id = student.SelectSingleNode("StudentID").InnerText;
                string name = student.SelectSingleNode("StudentName").InnerText;
                dataGridViewClass.Rows.Add(id, name, comboBoxClassName.SelectedItem.ToString());
            }
        }
        public void FillCompoBox()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Resources\\Attendance.xml");
            XmlNodeList nodes = doc.SelectNodes("/AttendanceData/Class");
 
            foreach (XmlNode node in nodes)
            {
                string name = node.SelectSingleNode("ClassName").InnerText;
                comboBoxClassName.Items.Add(name);
            }
            comboBoxClassName.SelectedIndex = 0;
        }
        private void UserControlAddClass_Load(object sender, EventArgs e)
        {
            FillCompoBox();
            fillDataGrid();

        }

        private void tabPageSearchClass_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }
    }
}
