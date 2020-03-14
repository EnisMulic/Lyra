using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface IAlbumService
    {
        IList<Model.Album> Get(AlbumSearchRequest request);
        Model.Album GetById(int id);
        Model.Album Insert(Model.Requests.AlbumInsertRequest request);
    }
}
