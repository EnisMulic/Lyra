using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class UserActivityPlaylist
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int PlaylistID { get; set; }
        public Playlist Playlist { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
