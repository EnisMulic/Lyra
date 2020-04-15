using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class TrackGenre
    {
        public int TrackID { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }
}
