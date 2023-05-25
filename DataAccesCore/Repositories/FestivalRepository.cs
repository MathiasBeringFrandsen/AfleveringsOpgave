using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using DataAccesCore.Context;
using DataAccesCore.Mappers;
using DTO.Model;
using Microsoft.IdentityModel.Tokens;

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

        public static ObservableCollection<Festival> GetFestivals()
        {
            using(FestivalContext context = new FestivalContext())
            {
                return FestivalMapper.Map(context.Festivals.ToList());
            }
        }

        public static ObservableCollection<Artist> GetFestivalArtists(Festival festival)
        {
            using(FestivalContext context = new FestivalContext())
            {
                return ArtistMapper.Map(context.Artists.Where(a => a.Festival.FestivalID == festival.FestivalID).ToList());
            }
        }

        public static void AddArtistToFestival(Artist artist, Festival festival)
        {
            using (FestivalContext context = new FestivalContext())
            {
                Model.Artist thisArtist = context.Artists.Find(artist.ArtistID);
                Model.Festival thisFestival = context.Festivals.Find(festival.FestivalID);

                if (thisArtist != null && thisFestival != null)
                {
                    thisArtist.Festival = thisFestival;
                    thisFestival.AddArtist(thisArtist);
                    context.SaveChanges();
                }

            }
        }

        public static void EditFestival(Festival festival)
        {
            using (FestivalContext context = new FestivalContext())
            {
                Model.Festival tempFestival = context.Festivals.Find(festival.FestivalID);
                tempFestival.Name = festival.Name;
                tempFestival.Tickets = festival.Tickets;
                tempFestival.TicketPrice = festival.TicketPrice;
                context.SaveChanges();
            }
        }

        public static void DeleteFestival(FestivalContext festival)
        {
            using (FestivalContext context = new FestivalContext())
            {
                Model.Festival tempfestival = context.Festivals.Find(festival.FestivalID);
                context.Festivals.Remove(tempFestival);
                context.SaveChanges();
            }
        }

    }
}