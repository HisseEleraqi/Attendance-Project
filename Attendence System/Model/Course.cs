﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence_Management_System
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }

        public override string ToString()
        {
            return $"{CourseID} - {CourseName}";
        }
    }

}
