using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Model
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}
