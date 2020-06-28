using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserActivityPlaylistInsertRequest
    {
        [Required]
        public int PlaylistID { get; set; }
        [Required]
        public DateTime InteractedAt { get; set; }
    }
}
