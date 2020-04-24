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
        public string CreatedAt { get; set; }
        public List<int> Tracks { get; set; } = new List<int>();
        public List<int> TracksToDelete { get; set; } = new List<int>();
        public int UserID { get; set; }
    }
}
