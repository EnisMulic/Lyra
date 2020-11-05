using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model.Requests
{
    public class RSIICovidExamUpsertRequest
    {
        public int UserID { get; set; }
        public DateTime DateTested { get; set; }
        public bool TestPositive { get; set; }
    }
}
