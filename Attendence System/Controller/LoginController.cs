/*using System;

public class LoginController
{
	public LoginController()
	{
	}
    public static IUser AuthenticateUser(string username, string password)
    {
        IUser user = XmlUserRepository.GetUserByUsername(username);

        if (user != null && SecurityManager.VerifyPassword(password, user.PasswordHash))
        {

            switch (user.Role)
            {
                case "Admin":
                    return new Admin { Username = user.Username, PasswordHash = user.PasswordHash };
                case "Teacher":
                    return new Teacher { Username = user.Username, PasswordHash = user.PasswordHash };
                case "Student":
                    return new Student { Username = user.Username, PasswordHash = user.PasswordHash };
                default:
                    return null; // Role not recognized
            }
        }
        return null; // Authentication failed
    }

}
*/