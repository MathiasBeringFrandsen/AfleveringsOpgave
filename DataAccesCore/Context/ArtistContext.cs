using DataAccesCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesCore.Context
{
    internal class ArtistContext : DbContext
    {
        public ArtistContext()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-G31MV79\\SQLEXPRESS;Initial Catalog=Artists; Integrated Security=SSPI; TrustServerCertificate=true");
        }

        public DbSet<Artist> Artists { get; set; }
    }
}
