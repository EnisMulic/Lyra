using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class PlaylistSearchRequest : PageRequest
    {
        public int UserID { get; set; }
        public string Name { get; set; }
    }
}
