using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class Page
    {
        public int Limit { get; set; }
        public int Skip { get; set; }
    }
}
