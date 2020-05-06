using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class TrackUpsertRequest
    {
        public string Name { get; set; }
        public string Length { get; set; }
        public byte[] MP3File { get; set; }
        public int MainArtist { get; set; }
        public List<int> FeaturedArtists { get; set; }
        public List<int> ArtistsToDelete { get; set; }
        public List<int> Genres { get; set; }
        public List<int> GenresToDelete { get; set; }
    }
}
