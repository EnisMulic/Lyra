using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class RSIICovidExamSearchRequest
    {
        public string Username { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public bool? TestPositive { get; set; }
    }
}
