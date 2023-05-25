using DataAccesCore.Repositories;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Festival> GetFestivalList() {
            return FestivalRepository.GetFestivals();
        }

        public Artist GetArtist(int id)
        {
            return ArtistRepository.GetArtist(id);
        }

        public ObservableCollection<Artist> GetArtistList()
        {
            return ArtistRepository.GetArtists();
        }

        public ObservableCollection<Artist> GetFestivalArtists(Festival festival)
        {
            return FestivalRepository.GetFestivalArtists(festival);
        }

        public void AddArtistToFestival(Artist artist, Festival festival)
        {
            FestivalRepository.AddArtistToFestival(artist, festival);
        }

        public void RemoveArtistFromFestival(Artist artist, Festival festival)
        {
            festival.RemoveArtist(artist);
        }

        public void EditArtist(Artist artist)
        {
            ArtistRepository.EditArtist(artist);
        }

        public void DeleteArtist(Artist artist)
        {
            ArtistRepository.DeleteArtist(artist);
        }

        public void EditFestival(Festival festival)
        {
            FestivalRepository.EditFestival(festival);
        }

        public void DeleteFestival(Festivals festival)
        {
            FestivalRepository.DeleteFestival(festival);
        }
    }
}
