using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesCore.Context;
using DataAccesCore.Mappers;
using DTO.Model;

namespace DataAccesCore.Repositories
{
    public class ArtistRepository
    {
        public static Artist GetArtist(int id)
        {
            using (FestivalContext context = new FestivalContext())
            {
                return ArtistMapper.Map(context.Artists.Find(id));
            }
        }

        public static ObservableCollection<Artist> GetArtists()
        {
            using (FestivalContext context = new FestivalContext())
            {
                return ArtistMapper.Map(context.Artists.ToList());
            }
        }

        public static void EditArtist(Artist artist)
        {
            using (FestivalContext context = new FestivalContext())
            {
                Model.Artist tempArtist = context.Artists.Find(artist.ArtistID);
                tempArtist.Name = artist.Name;
                tempArtist.Salary = artist.Salary;
                context.SaveChanges();
            }
        }

        public static void DeleteArtist(Artist artist)
        {
            using (FestivalContext context = new FestivalContext())
            {
                Model.Artist tempArtist = context.Artists.Find(artist.ArtistID);
                context.Artists.Remove(tempArtist);
                context.SaveChanges();
            }
        }

    }
}
