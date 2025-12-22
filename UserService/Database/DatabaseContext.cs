using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting.Server;

namespace UserService.Database
  
{
    public class DatabaseContext: DbContext

    {

        

        public DbSet<DBUserDetails> Ajay { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            //var DBHost = Environment.GetEnvironmentVariable("DB_Host");
            //var DBName = Environment.GetEnvironmentVariable("DB_Name");
            //var dbpassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD");

            //var connectingString = $"Data Source={DBHost}; Intial Catalog ={DBName}; User ID=sa; Password={dbpassword}";
            optionsBuilder.UseSqlServer("Server =host.docker.internal\\SQLEXPRESS,1433; Database = UserDetails; Integrated Security = false; Encrypt = False; Trusted_Connection = false; User Id=sa;Password=;");
            // optionsBuilder.UseSqlServer("Server ={dbHost}; Database = UserDetails; Integrated Security = SSPI; Encrypt = False; Trusted_Connection = True;");

            //optionsBuilder.UseSqlServer(@"Data Source =dd; Initial Catalog = UserDetails; Integrated Security = SSPI; Encrypt = False; Trusted_Connection = True;");

        }
    }
}
