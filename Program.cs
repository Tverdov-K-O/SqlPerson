using SqlPerson.Data;
using Microsoft.Data.SqlClient;
using System;

namespace SqlPerson
{
    class Program
    {
        public static NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            
            //SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            //stringBuilder.AttachDBFilename = @"C:\Users\tverd\source\repos\SqlPerson\DBFiles\DBPerson.mdf";
            //stringBuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            //stringBuilder.IntegratedSecurity = true;
            //stringBuilder.UserID = "Gucci";
            //stringBuilder.Password = "123321";
            //Console.WriteLine(stringBuilder.ConnectionString);
            
            Log.Info("Start");
            using (AppDBContext db = new AppDBContext(/*stringBuilder*/))
            {
                db.People.Add(new Data.Entities.Person { Name = "Robert", Surname = "Svon", Age = 34, PhoneNumber = "+380508965845", Email = "Robert@gmail.com", });
                db.People.Add(new Data.Entities.Person { Name = "Harry", Surname = "Potter", Age = 40, PhoneNumber = "+380966596585", Email = "Harry@gmail.com", });
                db.SaveChanges();
            }


            Console.ReadKey();
        }
    }
}
