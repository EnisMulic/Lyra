using AutoMapper;
using Lyra.WebAPI.Database;
using Lyra.WebAPI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Test
{
    public class TestDatabase : IDisposable
    {
        protected readonly LyraContext _context;
        
        public TestDatabase()
        {
            var options = new DbContextOptionsBuilder<LyraContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;

            

            _context = new LyraContext(options);
            _context.Database.EnsureCreated();

            
            var Users = new List<User>()
            {
                new User
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    Username = "Admin",
                    Email = "admin@admin.com",
                    PhoneNumber = "000",
                    PasswordSalt = "",
                    PasswordHash = ""
                },
                new User
                {
                    FirstName = "User",
                    LastName = "User",
                    Username = "User",
                    Email = "user@user.com",
                    PhoneNumber = "001",
                    PasswordSalt = "",
                    PasswordHash = ""
                }
            };

            _context.AddRange(Users);
            _context.SaveChanges();

        }

        public object MapperConfig { get; set; }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}
