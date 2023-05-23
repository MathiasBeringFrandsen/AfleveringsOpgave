using DataAccesCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesCore.Mappers
{
    internal class FestivalMapper
    {
        public static DTO.Model.Festival Map(Festival festival)
        {
            return new DTO.Model.Festival(festival.Name, festival.FestivalID, festival.Tickets);
        }
        public static Festival Map(DTO.Model.Festival festival)
        {
            return new Festival(festival.Name, festival.FestivalID, festival.Tickets);
        }

        public static List<DTO.Model.Festival> Map(List<Festival> festivals)
        {
            List<DTO.Model.Festival> retur = new List<DTO.Model.Festival>();
            foreach (Festival festival in festivals)
            {
                retur.Add(Map(festival));
            }
            return retur;
        }
    }
}
