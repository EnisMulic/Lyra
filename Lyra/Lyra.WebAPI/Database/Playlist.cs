using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class Playlist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[] Image { get; set; }
        public ICollection<PlaylistTrack> PlaylistTracks { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
