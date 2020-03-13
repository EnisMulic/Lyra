using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string ImagePath { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}
