using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserActivityTrackInsertRequest
    {
        public int TrackID { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
