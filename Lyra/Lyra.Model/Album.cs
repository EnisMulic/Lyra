using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class Album
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        public ICollection<AlbumTrack> AlbumTracks { get; set; }
    }
}
