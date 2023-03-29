using System.IO;

namespace Payroll_Project_2.Backend
{
    public static class DbSettings
    {
        //public static readonly string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Assigmnets\Payroll_Project_2\Payroll_Project_2\Database\Database.mdf;Integrated Security=True";
        public static readonly string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Database", "Database.mdf") + ";Integrated Security=True";
    }
}
