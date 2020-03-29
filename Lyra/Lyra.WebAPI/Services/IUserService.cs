using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface IUserService : ICRUDService<Model.User, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>
    {
        Task<Model.User> Authenticate(string username, string password);
    }
}
