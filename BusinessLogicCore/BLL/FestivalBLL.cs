using DataAccesCore.Repositories;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Festivals
{
    public class FestivalBLL
    {
        public Festival GetFestival(int id)
        {
            return FestivalRepository.GetFestival(id);
        }

        public List<Festival> GetFestivalList() {
            return FestivalRepository.getFestivals();
        }
    }
}
