using AutoMapper;
using Lyra.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class RoleService : BaseService<Model.Role, object, Database.Role>
    {
        public RoleService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
