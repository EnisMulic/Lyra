using Lyra.Model;
using Lyra.WebAPI.Services;

namespace Lyra.WebAPI.Controllers
{
    public class RoleController : BaseController<Role, object>
    {
        public RoleController(IBaseService<Role, object> service) : base(service)
        {
        }
    }
}