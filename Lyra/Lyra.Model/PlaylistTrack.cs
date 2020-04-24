using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class PlaylistTrack
    {
        public int PlaylistID { get; set; }
        public int TrackID { get; set; }
        public Track Track { get; set; }
    }
}
