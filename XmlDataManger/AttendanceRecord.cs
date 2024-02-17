using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlDataManger
{
    public class AttendanceRecord
    {
        public string StudentID { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }

        public AttendanceRecord(string studentID, string date, string status)
        {
            StudentID = studentID;
            Date = date;
            Status = status;
        }

        public override string ToString()
        {
            return $"StudentID: {StudentID}, Date: {Date}, Status: {Status}";
        }
    }
}
