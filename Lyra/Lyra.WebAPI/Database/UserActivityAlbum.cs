using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class UserActivityAlbum
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int AlbumID { get; set; }
        public DateTime InteractedAt { get; set; }
    }
}
