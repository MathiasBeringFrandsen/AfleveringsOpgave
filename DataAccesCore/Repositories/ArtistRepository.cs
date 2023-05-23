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
    internal class ArtistRepository
    {
        public static Artist getArtist(int id)
        {
            using (ArtistContext context = new ArtistContext())
            {
                return ArtistMapper.Map(context.Artists.Find(id));
            }
        }

        public static List<Artist> GetArtists()
        {
            using (ArtistContext context = new ArtistContext())
            {
                return ArtistMapper.Map(context.Artists.ToList());
            }
        }
    }
}
