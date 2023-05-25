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
        public int TicketPrice { get; set; }
        public List<Artist> artists = new List<Artist>();


        public Festival(string name, int festivalID, int tickets, int ticketPrice)
        {
            Name = name;
            FestivalID = festivalID;
            Tickets = tickets;
            TicketPrice = ticketPrice;
        }

        public void AddArtist(Artist artist)
        {
            if (!artists.Contains(artist))
            {
                artists.Add(artist);
            }
        }
        public void RemoveArtist(Artist artist)
        {
            if (artists.Contains(artist))
            {
                artists.Remove(artist);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
