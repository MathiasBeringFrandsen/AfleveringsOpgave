using DataAccesCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccesCore.Context
{
    internal class FestivalContext : DbContext
    {
        public FestivalContext()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-G31MV79\\SQLEXPRESS;Initial Catalog=Festivals; Integrated Security=SSPI; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Festival>().HasData(new Festival[] {
                new Festival{FestivalID=-1,Name="Crossroads Guitar Festival"},
                new Festival{FestivalID=-2,Name="Roskilde Festival"},
                new Festival{FestivalID=-3,Name="Glastonbury Festival"}
            });
        }
        public DbSet<Festival> Festivals { get; set; }
    }
}
