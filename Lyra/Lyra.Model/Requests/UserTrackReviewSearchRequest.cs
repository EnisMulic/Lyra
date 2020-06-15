using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserTrackReviewSearchRequest
    {
        public int UserID { get; set; }
        public int TrackID { get; set; }
        public int Score { get; set; }
    }
}
