using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Artist
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int ArtistID { get; set; }
        public Festival? Festival { get; set; }

        public Artist() { }

        public Artist(string name, int id, int salary)
        {
            ArtistID = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
