using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public partial class UserRole
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        //public User User { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
