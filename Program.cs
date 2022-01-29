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
                db.People.Add(new Data.Entities.Person { Name = "Robert", Surname = "Svon", Age = 34, PhoneNumber = "+380508965845" ,Email = "Robert@gmail.com", });
                db.People.Add(new Data.Entities.Person { Name = "Harry", Surname = "Potter", Age = 40, PhoneNumber = "+380966596585" ,Email = "Harry@gmail.com", });
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
