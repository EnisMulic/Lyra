using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class Album
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string CoverArtPath { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        public ICollection<AlbumTrack> AlbumTracks { get; set; }
    }
}
