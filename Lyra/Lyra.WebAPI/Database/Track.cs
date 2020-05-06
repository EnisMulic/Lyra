using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class Track
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public TimeSpan Length { get; set; }
        public byte[] MP3File { get; set; }
        public ICollection<TrackArtist> TrackArtists { get; set; }
        public ICollection<TrackGenre> TrackGenres { get; set; }
    }
}
