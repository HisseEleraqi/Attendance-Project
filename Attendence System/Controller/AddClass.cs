using Attendence_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Attendence_System.Controller
{
    public class AddClass
    {
        //the class has id , name 
       public string Name { get; set; }
       public string ID = Guid.NewGuid().ToString();
        public void AddClassToXML()
        {
            xmlController.XMLAddClass(ID, Name);
        }

    }
}
