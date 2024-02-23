using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Attendence_Management_System;
using Microsoft.VisualBasic.ApplicationServices;


namespace Attendence_System.Controller
{

    public class Validator
    {
       
        public bool validateName(string name)
        {

            var regex = new Regex("^[a-zA-Z'-]+$");
            return regex.IsMatch(name);
        }

        public bool validatePassword(string password)
        {
            //Password must be at least 8 characters including a number, an uppercase letter, a lowercase letter, and a special character (!@#$%^&*)

            var regex = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*]).{8,}$");
            return regex.IsMatch(password);
        }

        public bool validateEmail(string email)
        {
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(email);
        }
        public bool CheckDuplicateEmail(string email)
        {
                string nodePath = "/school/users/user";
                string target = "email";
                var userNode = xmlController.GetNode(nodePath, target, email);
                return userNode != null;
            
        }
        public bool CheckDuplicateClassName(string className)
        {
            string nodePath = "/school/classes/class";
            string target = "name";
            var classNode = xmlController.GetNode(nodePath, target, className);
            return classNode != null;
        }
        //validate className
        public bool validateClassName(string className)
        {
            var regex = new Regex("^[a-zA-Z0-9]+$");
            return regex.IsMatch(className);
        }


    }


}
