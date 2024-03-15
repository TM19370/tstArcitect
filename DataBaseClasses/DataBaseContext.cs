using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClasses
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.121.78;Database=ArcitectDB;User=is;Password=1;TrustServerCertificate=True");
        }

        public DbSet<Account> accounts { get; set; }
    }
}
