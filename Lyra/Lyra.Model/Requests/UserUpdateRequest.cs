using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserUpdateRequest
    {

        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string PhoneNumber { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }

        [MinLength(8)]
        public string Password { get; set; }
        
        public string PasswordConfirmation { get; set; }

        public List<int> Roles { get; set; } = new List<int>();
        public List<int> RolesToDelete { get; set; } = new List<int>();
    }
}
