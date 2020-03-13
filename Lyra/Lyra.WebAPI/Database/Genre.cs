using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class Genre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<TrackGenre> TrackGenres { get; set; }
    }
}
