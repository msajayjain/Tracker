using Microsoft.EntityFrameworkCore;
using ProductServices.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server;


namespace ProductServices.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DBproductlist> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS; Database = productlist; Integrated Security = SSPI; Encrypt = False; Trusted_Connection = True;");
            optionsBuilder.UseSqlServer("Server =host.docker.internal\\SQLEXPRESS,1433; Database = productlist; Integrated Security = false; Encrypt = False; Trusted_Connection = false; User Id=sa;Password=;");

        }
    }
}

