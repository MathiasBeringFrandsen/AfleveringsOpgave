using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            return new DTO.Model.Artist(artist.Name, artist.ArtistID, artist.Salary);
        }

        public static Artist Map(DTO.Model.Artist artist)
        {
            return new Artist(artist.Name, artist.ArtistID, artist.Salary);
        }

        public static ObservableCollection<DTO.Model.Artist> Map(List<Artist> artists)
        {
            ObservableCollection<DTO.Model.Artist> retur = new ObservableCollection<DTO.Model.Artist>();
            foreach (Artist artist in artists)
            {
                retur.Add(Map(artist));
            }
            return retur;
        }
    }
}
