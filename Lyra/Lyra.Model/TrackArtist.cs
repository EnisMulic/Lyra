using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class TrackArtist
    {
        public int TrackID { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        public string TrackArtistRole { get; set; }
    }
}
