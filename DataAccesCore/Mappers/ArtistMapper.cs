using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesCore.Model;

namespace DataAccesCore.Mappers
{
    internal class ArtistMapper
    {
        public static DTO.Model.Artist Map(Artist artist)
        {
            return new DTO.Model.Artist(artist.Name, artist.Salary);
        }

        public static Artist Artist(DTO.Model.Artist artist)
        {
            return new Artist(artist.Name, artist.Salary);
        }

        public static List<DTO.Model.Artist> Map(List<Artist> artists)
        {
            List<DTO.Model.Artist> retur = new List<DTO.Model.Artist>();
            foreach (Artist artist in artists)
            {
                retur.Add(Map(artist));
            }
            return retur;
        }
    }
}
