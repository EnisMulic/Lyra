using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class UserActivityPlaylist
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int PlaylistID { get; set; }
        public Playlist Playlist { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
