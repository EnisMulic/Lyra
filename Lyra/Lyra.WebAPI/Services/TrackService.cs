using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class TrackService : ITrackService
    {
        public IList<Track> Get()
        {
            var list = new List<Track>()
            {
                new Track()
                {
                    ID = 1,
                    Name = "Demon Days",
                    Lenght = new TimeSpan(0, 4, 21)
                },
                new Track()
                {
                    ID = 2,
                    Name = "DARE",
                    Lenght = new TimeSpan(0, 3, 57)
                }
            };

            return list;
        }

        public Track GetById(int id)
        {
            var item = new Track()
            {
                ID = 1,
                Name = "Demon Days",
                Lenght = new TimeSpan(0, 4, 21)
            };

            return item;
        }
    }
}
