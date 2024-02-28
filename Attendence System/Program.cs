using  Attendence_Management_System2;
namespace Attendence_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Main("hussein"));
               // run student form
            //Application.Run(new Student("../../../Resources/Attendance.xml"));
/*            Application.Run(new AdminAttendance("..\\..\\..\\Resources\\Attendance.xml"));
*/            //Application.Run(new Reports());
            Application.Run(new Forms.Login());

        }
    }
}