using Lyra.Mobile.Services;
using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.Mobile.Helpers
{
    public class FavouritesHelper
    {
        private readonly APIService _service = new APIService("User");
        public static List<Track> FavouriteTracks { get; set; } 
        public static List<Album> FavouriteAlbums { get; set; }
        public static List<Artist> FavouriteArtists { get; set; }

        public FavouritesHelper()
        {
            Init();
        }

        private async Task Init()
        {
            FavouriteTracks = await _service.GetFavouriteTracks(SignedInUserHelper.User.ID, null);
            FavouriteAlbums = await _service.GetFavouriteAlbums(SignedInUserHelper.User.ID, null);
            FavouriteArtists = await _service.GetFavouriteArtists(SignedInUserHelper.User.ID, null);
        }


        public static bool Remove(Track item)
        {
            var itemToRemove = FavouriteTracks.Where(i => i.ID == item.ID).FirstOrDefault();
            return FavouriteTracks.Remove(itemToRemove);
        }

        public static bool Remove(Album item)
        {
            var itemToRemove = FavouriteAlbums.Where(i => i.ID == item.ID).FirstOrDefault();
            return FavouriteAlbums.Remove(itemToRemove);
        }

        public static bool Remove(Artist item)
        {
            var itemToRemove = FavouriteArtists.Where(i => i.ID == item.ID).FirstOrDefault();
            return FavouriteArtists.Remove(itemToRemove);
        }

    }
}
