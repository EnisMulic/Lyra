﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class TrackSearchRequest : PageRequest
    {
        public int ArtistID { get; set; }
        public string Name { get; set; }
    }
}
