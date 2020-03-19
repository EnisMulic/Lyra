using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;

namespace Lyra.WebAPI.Services
{
    public class UserService : CRUDService<Model.User, UserSearchRequest, User, UserUpsertRequest, UserUpsertRequest>
    {
        public UserService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
