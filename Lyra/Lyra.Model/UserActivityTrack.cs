using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class UserActivityTrack
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int TrackID { get; set; }
        public Track Track { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
