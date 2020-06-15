using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class UserTrackReview
    {
        public int ID { get; set; }
        public int TrackID { get; set; }
        public int UserID { get; set; }
        public int Score { get; set; }
    }
}
