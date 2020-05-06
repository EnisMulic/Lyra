using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class Track
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Length { get; set; }
        public byte[] MP3File { get; set; }
        public List<TrackArtist> TrackArtists { get; set; }
        public List<TrackGenre> TrackGenres { get; set; }
    }
}
