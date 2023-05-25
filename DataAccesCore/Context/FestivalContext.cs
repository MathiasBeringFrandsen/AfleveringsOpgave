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
                new Festival{FestivalID=-1,Name="Crossroads Guitar Festival", Tickets=30000, TicketPrice=1500},
                new Festival{FestivalID=-2,Name="Roskilde Festival", Tickets=90000, TicketPrice= 1050},
                new Festival{FestivalID=-3,Name="Glastonbury Festival", Tickets=150000, TicketPrice=1300}
            });
            modelBuilder.Entity<Artist>().HasData(new Artist[]
            {
                new Artist{ArtistID=-1, Name="Foo Fighters", Salary=5000000},
                new Artist{ArtistID=-2, Name="Stevie Ray Vaughan", Salary=10000000},
                new Artist{ArtistID=-3, Name="BB King", Salary=2500000}
            });
        }
        public DbSet<Festival> Festivals { get; set; }

        public DbSet<Artist> Artists { get; set; }
    }
}
