using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class AlbumTrack
    {
        public int AlbumID { get; set; }
        public int TrackID { get; set; }
        public Track Track { get; set; }
    }
}
