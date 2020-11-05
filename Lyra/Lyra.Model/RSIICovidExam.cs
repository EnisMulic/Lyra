using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
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
