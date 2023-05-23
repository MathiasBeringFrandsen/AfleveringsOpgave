using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesCore.Model
{
    internal class Artist
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int ArtistID { get; set; }

        public Artist(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

    }
}
