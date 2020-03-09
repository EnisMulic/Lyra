using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface ITrackService
    {
        IList<Track> Get();
        Track GetById(int id);
    }
}
