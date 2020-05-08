using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class PlaylistSearchRequest : PageRequest
    {
        public string Name { get; set; }
    }
}
