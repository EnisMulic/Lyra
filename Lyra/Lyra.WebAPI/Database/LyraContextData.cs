using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public partial class LyraContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData
                (
                    new User
                    {
                        ID = 1,
                        FirstName = "Admin",
                        LastName = "Admin",
                        Username = "desktop",
                        Email = "desktop@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "lBBltcw3F3qXbxEowUrAuyVhZK5clfqUwHpilv9VQ4B9PfDvccS1JMCLMz2qqz1A0GqQ6hed/XDoUorJ2wF57A==",
                        PasswordSalt = "Ae3WLIGFNTk61fZSCXUrKg==",
                    },
                    new User
                    {
                        ID = 2,
                        FirstName = "Admin",
                        LastName = "Admin",
                        Username = "Admin",
                        Email = "admin@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "gkNXYGb8gZCoWdbufwae++291qCCriJf+TSNl2nGgp0JfSD2KpbXRGwFAwoY3wvM75mdxxZjegCZ9fWYJ2TPZQ==",
                        PasswordSalt = "EJe2jpdzhy6aTev1GAgVug==",
                    },
                    new User
                    {
                        ID = 3,
                        FirstName = "Mobile",
                        LastName = "User",
                        Username = "mobile",
                        Email = "mobile@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "yBgqiUkyj2lgGeOEQ+V1bg+z70rkUNDwdxgjVL0J6mEGwkI73yK1NGyFYQlm7SWvb3xSB4kMHY4OyWhL2MxBFg==",
                        PasswordSalt = "FcdULJgi4SMRjcYx/m6PCA==",
                    },
                    new User
                    {
                        ID = 4,
                        FirstName = "User1",
                        LastName = "User1",
                        Username = "User1",
                        Email = "user1@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "zin9wFowbqkTeAdsWGnh/3b6YMzNFMZ5gDoh41yIRkrheUza6HCVVMLse4K1s9i9RZ2ETw1x6yyWdu0wrdkZBg==",
                        PasswordSalt = "Ar+YYZlRwZsogOzIMOJ5GA==",
                    },
                    new User
                    {
                        ID = 5,
                        FirstName = "User2",
                        LastName = "User2",
                        Username = "User2",
                        Email = "user2@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "x0N2UmD0Z9Hx6h+Qv38WngvQ1iK/5v889JBjlNOYa3O5vcb752p/7HGd/cQSjNYHxaw/ghIbQShUJSUGu10C5g==",
                        PasswordSalt = "ZpTZ95Gczbh2OssbrcvySg==",
                    },
                    new User
                    {
                        ID = 6,
                        FirstName = "User3",
                        LastName = "User3",
                        Username = "User3",
                        Email = "user3@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "8PX+A5LPvxUODl+s8bACttbfKo4PExoS/ICwmubV1ZCwfsiySyljunVGydA9bYSinDH1DG7yjdIj3Ci8dDnABw==",
                        PasswordSalt = "EbTAe1562N25eb0KamwKNQ==",
                    },
                    new User
                    {
                        ID = 7,
                        FirstName = "User4",
                        LastName = "User4",
                        Username = "User4",
                        Email = "user4@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "EKu3v3kAK1H/DaOCW71NJ0BELVF/MBXzSfoXxRDKY7CiDnIi0MvL7XLTE+em0hvw1mkxYfPQAdWztGjTBOX/GQ==",
                        PasswordSalt = "l6kr9WS22w4c0djg8F7aVA==",
                    },
                    new User
                    {
                        ID = 8,
                        FirstName = "User5",
                        LastName = "User5",
                        Username = "User5",
                        Email = "user5@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "4A5IlcSVp7Ou/cDwunLxEW67NfUOo1tQtxEWAKilS3Ii85lJ/9qek5j+Z4dIhu4kRBjlFehipF0cAhlWawuTUg==",
                        PasswordSalt = "hMWDSmn2hV3HAYtPhL5sCw==",
                    },
                    new User
                    {
                        ID = 9,
                        FirstName = "User6",
                        LastName = "User6",
                        Username = "User6",
                        Email = "user6@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "ClcPhlwl6QFZT/RiNGtL25QUL/vO1hUu+gwJ+kFSuOTVMAq9FLqFKx6UF7QcLWGOLmBz9EsvtVJW8QwFyBhPaw==",
                        PasswordSalt = "6aYJGOXyozg0kcUuw/0drw==",
                    },
                    new User
                    {
                        ID = 10,
                        FirstName = "User7",
                        LastName = "User7",
                        Username = "User7",
                        Email = "user7@lyra.com",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Users/profile-picture.png")),
                        PasswordHash = "8LqW0nDq3BNurvNBGH3eq45Kjo92cmkCQUy4grx8d0s30/2PIFsfvEm3sBgFqh3UxNG89G8lxq3NS4NUkerJvg==",
                        PasswordSalt = "z8iyx1lxdzKeWZQ0MFal5Q==",
                    }
                );


            modelBuilder.Entity<Role>()
                .HasData
                (
                    new Role { ID = 1, Name = "Administrator" },
                    new Role { ID = 2, Name = "User" }
                );

            modelBuilder.Entity<UserRole>()
                .HasData
                (
                    new UserRole { UserID = 1, RoleID = 1 },
                    new UserRole { UserID = 2, RoleID = 1 },
                    new UserRole { UserID = 3, RoleID = 2 },
                    new UserRole { UserID = 4, RoleID = 2 },
                    new UserRole { UserID = 5, RoleID = 2 },
                    new UserRole { UserID = 6, RoleID = 2 },
                    new UserRole { UserID = 7, RoleID = 2 },
                    new UserRole { UserID = 8, RoleID = 2 },
                    new UserRole { UserID = 9, RoleID = 2 },
                    new UserRole { UserID = 10, RoleID = 2 }
                );

            modelBuilder.Entity<Artist>()
                .HasData
                (
                    new Artist
                    {
                        ID = 1,
                        Name = "Gorillaz",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Artists/gorillaz.jpg"))
                    },
                    new Artist
                    {
                        ID = 2,
                        Name = "Audioslave",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Artists/audioslave.jpg"))
                    },
                    new Artist
                    {
                        ID = 3,
                        Name = "Gojira",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Artists/gojira.jpg"))
                    }
                );

            modelBuilder.Entity<Album>()
                .HasData
                (
                    new Album
                    {
                        ID = 1,
                        Name = "Gorillaz",
                        ReleaseYear = 2001,
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Albums/gorillaz.jpg")),
                        ArtistID = 1,
                    },
                    new Album
                    {
                        ID = 2,
                        Name = "Demon Days",
                        ReleaseYear = 2003,
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Albums/demon_days.jpg")),
                        ArtistID = 1
                    },
                    new Album
                    {
                        ID = 3,
                        Name = "Audioslave",
                        ReleaseYear = 2002,
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Albums/audioslave.jpg")),
                        ArtistID = 2
                    },
                    new Album
                    {
                        ID = 4,
                        Name = "From Mars To Sirius",
                        ReleaseYear = 2006,
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Albums/from_mars_to_sirius.jpg")),
                        ArtistID = 3
                    }
                );
            modelBuilder.Entity<Track>()
                .HasData
                (
                    new Track
                    {
                        ID = 1,
                        Length = new TimeSpan(0, 3, 32),
                        Name = "Re-Hash"
                    },
                    new Track
                    {
                        ID = 2,
                        Length = new TimeSpan(0, 2, 35),
                        Name = "5/4"
                    },
                    new Track
                    {
                        ID = 3,
                        Length = new TimeSpan(0, 3, 7),
                        Name = "Tomorrow Comes Today"
                    },
                    new Track
                    {
                        ID = 4,
                        Length = new TimeSpan(0, 3, 51),
                        Name = "New Genious (Brother)"
                    },
                    new Track
                    {
                        ID = 5,
                        Length = new TimeSpan(0, 5, 32),
                        Name = "Clint Eastwood"
                    },
                    new Track
                    {
                        ID = 6,
                        Length = new TimeSpan(0, 4, 22),
                        Name = "Man Research (Clapper)"
                    },
                    new Track
                    {
                        ID = 7,
                        Length = new TimeSpan(0, 1, 33),
                        Name = "Punk"
                    },
                    new Track
                    {
                        ID = 8,
                        Length = new TimeSpan(0, 4, 32),
                        Name = "Sound Check (Gravity)"
                    },
                    new Track
                    {
                        ID = 9,
                        Length = new TimeSpan(0, 4, 36),
                        Name = "Double Bass"
                    },
                    new Track
                    {
                        ID = 10,
                        Length = new TimeSpan(0, 4, 1),
                        Name = "Rock The House"
                    },
                    new Track
                    {
                        ID = 11,
                        Length = new TimeSpan(0, 3, 21),
                        Name = "19-2000"
                    },
                    new Track
                    {
                        ID = 12,
                        Length = new TimeSpan(0, 3, 30),
                        Name = "Latin Simone (Que Pasa Contigo)"
                    },
                    new Track
                    {
                        ID = 13,
                        Length = new TimeSpan(0, 3, 25),
                        Name = "Starshine"
                    },
                    new Track
                    {
                        ID = 14,
                        Length = new TimeSpan(0, 3, 29),
                        Name = "Slow Country"
                    },
                    new Track
                    {
                        ID = 15,
                        Length = new TimeSpan(0, 10, 21),
                        Name = "M1 A1"
                    },

                    new Track
                    {
                        ID = 16,
                        Length = new TimeSpan(0, 1, 1),
                        Name = "Intro"
                    },
                    new Track
                    {
                        ID = 17,
                        Length = new TimeSpan(0, 3, 4),
                        Name = "Last Living Soul"
                    },
                    new Track
                    {
                        ID = 18,
                        Length = new TimeSpan(0, 3, 39),
                        Name = "Kids With Guns"
                    },
                    new Track
                    {
                        ID = 19,
                        Length = new TimeSpan(0, 4, 24),
                        Name = "O Green World"
                    },
                    new Track
                    {
                        ID = 20,
                        Length = new TimeSpan(0, 3, 37),
                        Name = "Dirty Harry"
                    },
                    new Track
                    {
                        ID = 21,
                        Length = new TimeSpan(0, 3, 34),
                        Name = "Feel Good Inc."
                    },
                    new Track
                    {
                        ID = 22,
                        Length = new TimeSpan(0, 3, 43),
                        Name = "El Manana"
                    },
                    new Track
                    {
                        ID = 23,
                        Length = new TimeSpan(0, 4, 44),
                        Name = "Every Planet We Reach Is Dead"
                    },
                    new Track
                    {
                        ID = 24,
                        Length = new TimeSpan(0, 2, 36),
                        Name = "November Has Come"
                    },
                    new Track
                    {
                        ID = 25,
                        Length = new TimeSpan(0, 3, 23),
                        Name = "All Alone"
                    },
                    new Track
                    {
                        ID = 26,
                        Length = new TimeSpan(0, 2, 4),
                        Name = "White Light"
                    },
                    new Track
                    {
                        ID = 27,
                        Length = new TimeSpan(0, 3, 57),
                        Name = "DARE"
                    },
                    new Track
                    {
                        ID = 28,
                        Length = new TimeSpan(0, 3, 10),
                        Name = "Fire Comming Out Of The Monkeys Head"
                    },
                    new Track
                    {
                        ID = 29,
                        Length = new TimeSpan(0, 1, 56),
                        Name = "Don't Get Lost In Heaven"
                    },
                    new Track
                    {
                        ID = 30,
                        Length = new TimeSpan(0, 4, 21),
                        Name = "Demon Days"
                    },

                    new Track
                    {
                        ID = 31,
                        Length = new TimeSpan(0, 3, 42),
                        Name = "Cochise"
                    },
                    new Track
                    {
                        ID = 32,
                        Length = new TimeSpan(0, 4, 37),
                        Name = "Show Me How to Live"
                    },
                    new Track
                    {
                        ID = 33,
                        Length = new TimeSpan(0, 4, 39),
                        Name = "Gasoline"
                    },
                    new Track
                    {
                        ID = 34,
                        Length = new TimeSpan(0, 4, 9),
                        Name = "What You Are"
                    },
                    new Track
                    {
                        ID = 35,
                        Length = new TimeSpan(0, 4, 54),
                        Name = "Like A Stone"
                    },
                    new Track
                    {
                        ID = 36,
                        Length = new TimeSpan(0, 4, 23),
                        Name = "Set It Off"
                    },
                    new Track
                    {
                        ID = 37,
                        Length = new TimeSpan(0, 5, 43),
                        Name = "Shadow Of The Sun"
                    },
                    new Track
                    {
                        ID = 38,
                        Length = new TimeSpan(0, 5, 34),
                        Name = "I Am The Highway"
                    },
                    new Track
                    {
                        ID = 39,
                        Length = new TimeSpan(0, 3, 26),
                        Name = "Exploder"
                    },
                    new Track
                    {
                        ID = 40,
                        Length = new TimeSpan(0, 3, 26),
                        Name = "Hyptonize"
                    },
                    new Track
                    {
                        ID = 41,
                        Length = new TimeSpan(0, 5, 3),
                        Name = "Light My Way"
                    },
                    new Track
                    {
                        ID = 42,
                        Length = new TimeSpan(0, 4, 59),
                        Name = "Getaway Car"
                    },
                    new Track
                    {
                        ID = 43,
                        Length = new TimeSpan(0, 5, 17),
                        Name = "The Last Remaining Light"
                    },
                    new Track
                    {
                        ID = 44,
                        Length = new TimeSpan(0, 4, 0),
                        Name = "Give"
                    },

                    new Track { ID = 45, Length = new TimeSpan(0, 5, 32), Name = "Ocean Planet" },
                    new Track { ID = 46, Length = new TimeSpan(0, 4, 18), Name = "Backbone" },
                    new Track { ID = 47, Length = new TimeSpan(0, 5, 48), Name = "From The Sky" },
                    new Track { ID = 48, Length = new TimeSpan(0, 2, 9), Name = "Unicorn" },
                    new Track { ID = 49, Length = new TimeSpan(0, 6, 54), Name = "Where Dragons Dwell" },
                    new Track { ID = 50, Length = new TimeSpan(0, 3, 57), Name = "The Heaviest Matter Of The Universe" },
                    new Track { ID = 51, Length = new TimeSpan(0, 7, 44), Name = "Flying Whales" },
                    new Track { ID = 52, Length = new TimeSpan(0, 7, 47), Name = "In The Wilderness" },
                    new Track { ID = 53, Length = new TimeSpan(0, 6, 52), Name = "World To Come" },
                    new Track { ID = 54, Length = new TimeSpan(0, 2, 24), Name = "From Mars" },
                    new Track { ID = 55, Length = new TimeSpan(0, 5, 37), Name = "To Sirius" },
                    new Track { ID = 56, Length = new TimeSpan(0, 7, 50), Name = "Global Warming" }
                );

            modelBuilder.Entity<TrackArtist>()
                .HasData
                (
                    new TrackArtist { ArtistID = 1, TrackID = 1, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 2, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 3, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 4, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 5, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 6, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 7, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 8, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 9, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 10, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 11, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 12, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 13, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 14, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 15, TrackArtistRole = TrackArtistRole.Main },

                    new TrackArtist { ArtistID = 1, TrackID = 16, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 17, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 18, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 19, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 20, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 21, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 22, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 23, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 24, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 25, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 26, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 27, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 28, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 29, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 1, TrackID = 30, TrackArtistRole = TrackArtistRole.Main },

                    new TrackArtist { ArtistID = 2, TrackID = 31, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 32, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 33, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 34, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 35, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 36, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 37, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 38, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 39, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 40, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 41, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 42, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 43, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 2, TrackID = 44, TrackArtistRole = TrackArtistRole.Main },

                    new TrackArtist { ArtistID = 3, TrackID = 46, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 47, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 48, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 49, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 50, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 51, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 52, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 53, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 54, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 55, TrackArtistRole = TrackArtistRole.Main },
                    new TrackArtist { ArtistID = 3, TrackID = 56, TrackArtistRole = TrackArtistRole.Main }
                );


            modelBuilder.Entity<AlbumTrack>()
                .HasData
                (
                    new AlbumTrack { AlbumID = 1, TrackID = 1 },
                    new AlbumTrack { AlbumID = 1, TrackID = 2 },
                    new AlbumTrack { AlbumID = 1, TrackID = 3 },
                    new AlbumTrack { AlbumID = 1, TrackID = 4 },
                    new AlbumTrack { AlbumID = 1, TrackID = 5 },
                    new AlbumTrack { AlbumID = 1, TrackID = 6 },
                    new AlbumTrack { AlbumID = 1, TrackID = 7 },
                    new AlbumTrack { AlbumID = 1, TrackID = 8 },
                    new AlbumTrack { AlbumID = 1, TrackID = 9 },
                    new AlbumTrack { AlbumID = 1, TrackID = 10 },
                    new AlbumTrack { AlbumID = 1, TrackID = 11 },
                    new AlbumTrack { AlbumID = 1, TrackID = 12 },
                    new AlbumTrack { AlbumID = 1, TrackID = 13 },
                    new AlbumTrack { AlbumID = 1, TrackID = 14 },
                    new AlbumTrack { AlbumID = 1, TrackID = 15 },

                    new AlbumTrack { AlbumID = 2, TrackID = 16 },
                    new AlbumTrack { AlbumID = 2, TrackID = 17 },
                    new AlbumTrack { AlbumID = 2, TrackID = 18 },
                    new AlbumTrack { AlbumID = 2, TrackID = 19 },
                    new AlbumTrack { AlbumID = 2, TrackID = 20 },
                    new AlbumTrack { AlbumID = 2, TrackID = 21 },
                    new AlbumTrack { AlbumID = 2, TrackID = 22 },
                    new AlbumTrack { AlbumID = 2, TrackID = 23 },
                    new AlbumTrack { AlbumID = 2, TrackID = 24 },
                    new AlbumTrack { AlbumID = 2, TrackID = 25 },
                    new AlbumTrack { AlbumID = 2, TrackID = 26 },
                    new AlbumTrack { AlbumID = 2, TrackID = 27 },
                    new AlbumTrack { AlbumID = 2, TrackID = 28 },
                    new AlbumTrack { AlbumID = 2, TrackID = 29 },
                    new AlbumTrack { AlbumID = 2, TrackID = 30 },

                    new AlbumTrack { AlbumID = 3, TrackID = 31 },
                    new AlbumTrack { AlbumID = 3, TrackID = 32 },
                    new AlbumTrack { AlbumID = 3, TrackID = 33 },
                    new AlbumTrack { AlbumID = 3, TrackID = 34 },
                    new AlbumTrack { AlbumID = 3, TrackID = 35 },
                    new AlbumTrack { AlbumID = 3, TrackID = 36 },
                    new AlbumTrack { AlbumID = 3, TrackID = 37 },
                    new AlbumTrack { AlbumID = 3, TrackID = 38 },
                    new AlbumTrack { AlbumID = 3, TrackID = 39 },
                    new AlbumTrack { AlbumID = 3, TrackID = 40 },
                    new AlbumTrack { AlbumID = 3, TrackID = 41 },
                    new AlbumTrack { AlbumID = 3, TrackID = 42 },
                    new AlbumTrack { AlbumID = 3, TrackID = 43 },
                    new AlbumTrack { AlbumID = 3, TrackID = 44 },

                    new AlbumTrack { AlbumID = 4, TrackID = 45 },
                    new AlbumTrack { AlbumID = 4, TrackID = 46 },
                    new AlbumTrack { AlbumID = 4, TrackID = 47 },
                    new AlbumTrack { AlbumID = 4, TrackID = 48 },
                    new AlbumTrack { AlbumID = 4, TrackID = 49 },
                    new AlbumTrack { AlbumID = 4, TrackID = 50 },
                    new AlbumTrack { AlbumID = 4, TrackID = 51 },
                    new AlbumTrack { AlbumID = 4, TrackID = 52 },
                    new AlbumTrack { AlbumID = 4, TrackID = 53 },
                    new AlbumTrack { AlbumID = 4, TrackID = 54 },
                    new AlbumTrack { AlbumID = 4, TrackID = 55 },
                    new AlbumTrack { AlbumID = 4, TrackID = 56 }
                );

            modelBuilder.Entity<Genre>()
                .HasData
                (
                    new Genre { ID = 1, Name = "Rock" },
                    new Genre { ID = 2, Name = "Rap" },
                    new Genre { ID = 3, Name = "Hip-Hop" },
                    new Genre { ID = 4, Name = "Pop" },
                    new Genre { ID = 5, Name = "Metal" }
                );

            modelBuilder.Entity<Playlist>()
                .HasData
                (
                    new Playlist
                    {
                        ID = 1,
                        Name = "Test Playlist",
                        Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "SeedFiles/Images/Playlists/playlist.jpg")),
                        UserID = 3,
                        CreatedAt = DateTime.Now
                    }
                );

            modelBuilder.Entity<PlaylistTrack>()
                .HasData
                (
                    new PlaylistTrack { PlaylistID = 1, TrackID = 1 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 3 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 5 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 7 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 16 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 18 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 20 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 22 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 33 },
                    new PlaylistTrack { PlaylistID = 1, TrackID = 37 }
                );

            modelBuilder.Entity<UserTrackReview>()
                .HasData
                (
                    new UserTrackReview { ID = 1, UserID = 3, TrackID = 1, Score = 5 },
                    new UserTrackReview { ID = 2, UserID = 3, TrackID = 2, Score = 4 },
                    new UserTrackReview { ID = 3, UserID = 3, TrackID = 3, Score = 4 },
                    new UserTrackReview { ID = 4, UserID = 3, TrackID = 4, Score = 4 },
                    new UserTrackReview { ID = 5, UserID = 3, TrackID = 5, Score = 5 },

                    new UserTrackReview { ID = 6, UserID = 4, TrackID = 2, Score = 4 },
                    new UserTrackReview { ID = 7, UserID = 4, TrackID = 3, Score = 5 },
                    new UserTrackReview { ID = 8, UserID = 4, TrackID = 7, Score = 3 },
                    new UserTrackReview { ID = 9, UserID = 4, TrackID = 26, Score = 2 },

                    new UserTrackReview { ID = 10, UserID = 5, TrackID = 2, Score = 3 },
                    new UserTrackReview { ID = 11, UserID = 5, TrackID = 16, Score = 2 },

                    new UserTrackReview { ID = 12, UserID = 6, TrackID = 2, Score = 4 },
                    new UserTrackReview { ID = 13, UserID = 6, TrackID = 14, Score = 3 },
                    new UserTrackReview { ID = 14, UserID = 6, TrackID = 17, Score = 3 },

                    new UserTrackReview { ID = 15, UserID = 7, TrackID = 3, Score = 4 },
                    new UserTrackReview { ID = 16, UserID = 7, TrackID = 32, Score = 1 },

                    new UserTrackReview { ID = 17, UserID = 8, TrackID = 4, Score = 4 },
                    new UserTrackReview { ID = 18, UserID = 8, TrackID = 23, Score = 2 },

                    new UserTrackReview { ID = 19, UserID = 9, TrackID = 4, Score = 5 },
                    new UserTrackReview { ID = 20, UserID = 9, TrackID = 21, Score = 5 },

                    new UserTrackReview { ID = 21, UserID = 10, TrackID = 5, Score = 1 },
                    new UserTrackReview { ID = 22, UserID = 10, TrackID = 6, Score = 1 }
                );
        }
    }
}
