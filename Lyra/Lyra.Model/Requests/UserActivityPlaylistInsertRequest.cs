using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserActivityPlaylistInsertRequest
    {
        public int PlaylistID { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
