using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class UserFavouriteAlbum
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int AlbumID { get; set; }
        public Album Album { get; set; }
    }
}
