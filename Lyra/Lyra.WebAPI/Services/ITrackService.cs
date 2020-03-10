using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface ITrackService
    {
        IList<Model.Track> Get();
        Model.Track GetById(int id);
        Model.Track Insert(Model.Requests.TrackInsertRequest request);
    }
}
