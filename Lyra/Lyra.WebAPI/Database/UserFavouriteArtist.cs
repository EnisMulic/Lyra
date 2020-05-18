using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class UserFavouriteArtist
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}
