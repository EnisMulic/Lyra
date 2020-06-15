using Lyra.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI
{
    public class SetupService
    {
        public static void Init(LyraContext context)
        {
            context.Database.Migrate();
        }
    }
}
