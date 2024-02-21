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
        private string UserName;
        private string Role;
        private string Password;
        private string Email;
        private string ID;
        private xmlController xmlController;


        public AddUser(string userName, string role, string password, string email)
        {
            UserName = userName;
            Role = role;
            Password = password;
            Email = email;
            ID = Guid.NewGuid().ToString();
        }
        public string GetUserName()
        {
            return UserName;
        }
        public string GetRole()
        {
            return Role;
        }
        public string GetPassword()
        {
            return Password;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetID()
        {
            return ID;
        }
        public string toString()
        {
            return "UserName: " + UserName + " Role: " + Role + " Password: " + Password + " Email: " + Email + " ID: " + ID;
        }
        public void AddUserToXML()
        {
             xmlController.XMLAddUser(UserName, Role, Password, Email, ID);
        }
        
    }
}
