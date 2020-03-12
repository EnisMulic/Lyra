using Lyra.Model;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface ITrackService
    {
        IList<Model.Track> Get(TrackSearchRequest request);
        Model.Track GetById(int id);
        Model.Track Insert(Model.Requests.TrackInsertRequest request);
    }
}
