using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserActivityArtistInsertRequest
    {
        public int ArtistID { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
