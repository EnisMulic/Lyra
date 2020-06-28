using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class TrackUpsertRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"/(?:[01]\d|2[0-3]):(?:[0-5]\d):(?:[0-5]\d)/")]
        public string Length { get; set; }
        public byte[] MP3File { get; set; }
        [Required]
        public int MainArtist { get; set; }
        public List<int> FeaturedArtists { get; set; }
        public List<int> ArtistsToDelete { get; set; }
        public List<int> Genres { get; set; }
        public List<int> GenresToDelete { get; set; }
    }
}
