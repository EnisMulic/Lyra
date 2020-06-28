using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserActivityAlbumInsertRequest
    {
        [Required]
        public int AlbumID { get; set; }
        [Required]
        public DateTime InteractedAt { get; set; }
    }
}
