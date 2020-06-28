using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class PlaylistUpsertRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string CreatedAt { get; set; }
        public byte[] Image { get; set; }
        public List<int> Tracks { get; set; } = new List<int>();
        public List<int> TracksToDelete { get; set; } = new List<int>();
        [Required]
        public int UserID { get; set; }
    }
}
