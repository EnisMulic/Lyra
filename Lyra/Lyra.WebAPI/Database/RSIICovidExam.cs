using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class RSIICovidExam
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public DateTime DateTested { get; set; }
        public bool TestPositive { get; set; }
    }
}
