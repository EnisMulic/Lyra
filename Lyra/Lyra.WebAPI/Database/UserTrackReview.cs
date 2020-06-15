using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class UserTrackReview
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TrackID { get; set; }
        public int Score { get; set; }
        public User User { get; set; }
        public Track Track { get; set; }
    }
}
