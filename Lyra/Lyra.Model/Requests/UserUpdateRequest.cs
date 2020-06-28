using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserUpdateRequest
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression(@"^(\+)?([0-9]){9,16}$")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [MinLength(8)]
        public string PasswordConfirmation { get; set; }
        public byte[] Image { get; set; }
        public List<int> Roles { get; set; } = new List<int>();
        public List<int> RolesToDelete { get; set; } = new List<int>();
    }
}
