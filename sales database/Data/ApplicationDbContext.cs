using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_database
{

    public class ApplicationDbContext : DbContext
    {

       public DbSet<customer>  customers {  get; set; }
        public DbSet<product>  produc { get; set; }

        public DbSet<store> stores { get; set; }

        public DbSet<sale> sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=salesdatabase;Integrated Security=True;TrustServerCertificate=True"
);
        }
    }
}
