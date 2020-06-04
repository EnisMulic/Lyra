using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserActivityAlbumInsertRequest
    {
        public int AlbumID { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
