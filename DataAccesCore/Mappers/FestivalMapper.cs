using DataAccesCore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesCore.Mappers
{
    internal class FestivalMapper
    {
        public static DTO.Model.Festival Map(Festival festival)
        {
            return new DTO.Model.Festival(festival.Name, festival.FestivalID, festival.Tickets, festival.TicketPrice);
        }
        public static Festival Map(DTO.Model.Festival festival)
        {
            return new Festival(festival.Name, festival.FestivalID, festival.Tickets, festival.TicketPrice);
        }

        public static ObservableCollection<DTO.Model.Festival> Map(List<Festival> festivals)
        {
            ObservableCollection<DTO.Model.Festival> retur = new ObservableCollection<DTO.Model.Festival>();
            foreach (Festival festival in festivals)
            {
                retur.Add(Map(festival));
            }
            return retur;
        }
    }
}
