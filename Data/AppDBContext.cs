using Microsoft.EntityFrameworkCore;
using SqlPerson.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlPerson.Data
{
    class AppDBContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public AppDBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(Program.Log.Info);
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tverd\source\repos\SqlPerson\DBFiles\DBPerson.mdf;Integrated Security=True");
        }

    }
}
