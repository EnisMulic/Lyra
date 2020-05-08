using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class PageRequest
    {
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
    }
}
