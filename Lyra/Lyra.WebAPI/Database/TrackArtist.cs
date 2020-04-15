using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public enum TrackArtistRole
    {
        Main = 0,
        Feature = 1
    }
    public class TrackArtist
    {
        [Key]
        public int TrackID { get; set; }
        public Track Track { get; set; }
        [Key]
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        public TrackArtistRole TrackArtistRole { get; set; }
    }
}
