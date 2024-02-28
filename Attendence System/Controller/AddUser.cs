using Attendence_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence_System.Controller
{
    public class AddUser
    {
        private static int studentCounter = 0;
        private static int teacherCounter = 0;
        private string UserName;
        private string Role;
        private string Password;
        private string Email;
        private string ID;
        private xmlController xmlController;

        public static int GetStudentCounter() => studentCounter;
        public static int GetTeacherCounter() => teacherCounter;

        public static void SetStudentCounter(int value) => studentCounter = value;
        public static void SetTeacherCounter(int value) => teacherCounter = value;

        public AddUser(string userName, string role, string password, string email)
        {
            UserName = userName;
            Role = role.ToLower();
            Password = password;
            Email = email;

            if (Role == "student")
            {
                studentCounter++;
                ID = "ST-" + studentCounter.ToString();
            }
            else if (Role == "teacher")
            {
                teacherCounter++;
                ID = "TE-" + teacherCounter.ToString();
            }
            else
            {
                throw new ArgumentException("Invalid user role");
            }
        }

        public string GetUserName() => UserName;
        public string GetRole() => Role;
        public string GetPassword() => Password;
        public string GetEmail() => Email;
        public string GetID() => ID;

        public override string ToString() =>
            $"UserName: {UserName} Role: {Role} Password: {Password} Email: {Email} ID: {ID}";

        public void AddUserToXML()
        {
            xmlController.XMLAddUser(UserName, Role, Password, Email, ID);
        }
        
    }
}
