using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class UserActivityAlbum
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int AlbumID { get; set; }
        public Album Album { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
