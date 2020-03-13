using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class TrackGenre
    {
        [Key]
        public int TrackID { get; set; }
        public Track Track { get; set; }
        [Key]
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }
}
