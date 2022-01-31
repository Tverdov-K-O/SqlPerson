using Microsoft.Data.SqlClient;
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
        //public SqlConnectionStringBuilder stringBuilder;
        public AppDBContext(/*SqlConnectionStringBuilder sb*/)
        {
            Database.EnsureCreated();
            //stringBuilder = new SqlConnectionStringBuilder();
            //stringBuilder.DataSource = sb.DataSource;
            //stringBuilder.AttachDBFilename = sb.AttachDBFilename;
            //stringBuilder.IntegratedSecurity = sb.IntegratedSecurity;
            //stringBuilder.UserID = sb.UserID;
            //stringBuilder.Password = sb.Password;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(Program.Log.Info);

            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tverd\source\repos\SqlPerson\DBFiles\DBPerson.mdf;Integrated Security=True");
        }

    }
}