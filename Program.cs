using SqlPerson.Data;
using System;

namespace SqlPerson
{
    class Program
    {
        public static NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Log.Info("Start");
            using (AppDBContext db = new AppDBContext())
            {
                db.People.Add(new Data.Entities.Person { Name = "Alex", Surname = "Edison", Age = 45, PhoneNumber = "+380668613391" ,Email = "Alex@gmail.com", });
                db.People.Add(new Data.Entities.Person { Name = "Jake", Surname = "Patison", Age = 35, PhoneNumber = "+380995487123" ,Email = "Jake@gmail.com", });
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
