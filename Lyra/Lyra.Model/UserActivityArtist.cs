using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class UserActivityArtist
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
