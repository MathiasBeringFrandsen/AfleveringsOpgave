using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Festival
    {
        public string Name { get; set; }
        public int FestivalID { get; set; }
        public int Tickets { get; set; }

        public Festival(string name, int festivalID, int tickets)
        {
            Name = name;
            FestivalID = festivalID;
            Tickets = tickets;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
