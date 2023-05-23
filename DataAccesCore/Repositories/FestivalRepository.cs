using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesCore.Context;
using DataAccesCore.Mappers;
using DTO.Model;

namespace DataAccesCore.Repositories
{
    public class FestivalRepository
    {
        public static Festival GetFestival(int id)
        {
            using (FestivalContext context = new FestivalContext())
            {
                return FestivalMapper.Map(context.Festivals.Find(id));
            }
        }

        public static List<Festival> getFestivals()
        {
            using(FestivalContext context = new FestivalContext())
            {
                return FestivalMapper.Map(context.Festivals.ToList());
            }
        }

       
    }
}
