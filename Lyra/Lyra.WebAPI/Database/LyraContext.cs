using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public class LyraContext : DbContext
    {
        public LyraContext(DbContextOptions<LyraContext> options) :
            base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<TrackGenre> TrackGenres { get; set; }
        public DbSet<TrackArtist> TrackArtists { get; set; }
        public DbSet<PlaylistTrack> PlaylistTracks { get; set; }
        public DbSet<AlbumTrack> AlbumTracks { get; set; }
        public DbSet<Role> Roles  { get; set; }
        public DbSet<UserRole> UserRoles  { get; set; }
        public DbSet<UserFavouriteArtist> UserFavouriteArtists { get; set; }
        public DbSet<UserFavouriteAlbum> UserFavouriteAlbums { get; set; }
        public DbSet<UserFavouriteTrack> UserFavouriteTracks { get; set; }
        public DbSet<UserActivityArtist> UserActivityArtists { get; set; }
        public DbSet<UserActivityAlbum> UserActivityAlbums { get; set; }
        public DbSet<UserActivityTrack> UserActivityTracks  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrackGenre>()
                .HasKey(k => new { k.GenreID, k.TrackID });
            modelBuilder.Entity<PlaylistTrack>()
                .HasKey(k => new { k.PlaylistID, k.TrackID });
            modelBuilder.Entity<AlbumTrack>()
                .HasKey(k => new { k.AlbumID, k.TrackID });
            modelBuilder.Entity<TrackArtist>()
                .HasKey(k => new { k.TrackID, k.ArtistID });
            modelBuilder.Entity<UserRole>()
                .HasKey(k => new { k.UserID, k.RoleID });
            modelBuilder.Entity<UserFavouriteArtist>()
                .HasKey(k => new { k.UserID, k.ArtistID });
            modelBuilder.Entity<UserFavouriteAlbum>()
                .HasKey(k => new { k.UserID, k.AlbumID });
            modelBuilder.Entity<UserFavouriteTrack>()
                .HasKey(k => new { k.UserID, k.TrackID });

            modelBuilder.Entity<Artist>()
                .HasData
                (
                    new Artist { ID = 1, Name = "Gorillaz" },
                    new Artist { ID = 2, Name = "Audioslave" },
                    new Artist { ID = 3, Name = "Deftones" },
                    new Artist { ID = 4, Name = "Childish Gambino" },
                    new Artist { ID = 5, Name = "Of Monsters and Men" }
                );
            modelBuilder.Entity<Album>()
                .HasData
                (
                    new Album 
                    { 
                        ID = 1,
                        Name = "Gorillaz", 
                        ReleaseYear = 2001
                    },
                    new Album
                    {
                        ID = 2,
                        Name = "Demon Days",
                        ReleaseYear = 2003
                    }
                );
            modelBuilder.Entity<Track>()
                .HasData
                (
                    new Track { ID  = 1, Length = new TimeSpan(0, 3, 32), Name = "Re-Hash" },
                    new Track { ID  = 2, Length = new TimeSpan(0, 2, 35), Name = "5/4" },
                    new Track { ID  = 3, Length = new TimeSpan(0, 3, 7), Name = "Tomorrow Comes Today" },
                    new Track { ID  = 4, Length = new TimeSpan(0, 3, 51), Name = "New Genious (Brother)" },
                    new Track { ID  = 5, Length = new TimeSpan(0, 5, 32), Name = "Clint Eastwood" },
                    new Track { ID  = 6, Length = new TimeSpan(0, 4, 22), Name = "Man Research (Clapper)" },
                    new Track { ID  = 7, Length = new TimeSpan(0, 1, 33), Name = "Punk" },
                    new Track { ID  = 8, Length = new TimeSpan(0, 4, 32), Name = "Sound Check (Gravity)" },
                    new Track { ID  = 9, Length = new TimeSpan(0, 4, 36), Name = "Double Bass" },
                    new Track { ID  = 10, Length = new TimeSpan(0, 4, 1), Name = "Rock The House" },
                    new Track { ID  = 11, Length = new TimeSpan(0, 3, 21), Name = "19-2000" },
                    new Track { ID  = 12, Length = new TimeSpan(0, 3, 30), Name = "Latin Simone (Que Pasa Contigo)" },
                    new Track { ID  = 13, Length = new TimeSpan(0, 3, 25), Name = "Starshine" },
                    new Track { ID  = 14, Length = new TimeSpan(0, 3, 29), Name = "Slow Country" },
                    new Track { ID  = 15, Length = new TimeSpan(0, 10, 21), Name = "M1 A1" },
                    new Track { ID  = 16, Length = new TimeSpan(0, 1, 1), Name = "Intro" },
                    new Track { ID  = 17, Length = new TimeSpan(0, 3, 4), Name = "Last Living Soul" },
                    new Track { ID  = 18, Length = new TimeSpan(0, 3, 39), Name = "Kids With Guns" },
                    new Track { ID  = 19, Length = new TimeSpan(0, 4, 24), Name = "O Green World" },
                    new Track { ID  = 20, Length = new TimeSpan(0, 3, 37), Name = "Dirty Harry" },
                    new Track { ID  = 21, Length = new TimeSpan(0, 3, 34), Name = "Feel Good Inc." },
                    new Track { ID  = 22, Length = new TimeSpan(0, 3, 43), Name = "El Manana" },
                    new Track { ID  = 23, Length = new TimeSpan(0, 4, 44), Name = "Every Planet We Reach Is Dead" },
                    new Track { ID  = 24, Length = new TimeSpan(0, 2, 36), Name = "November Has Come" },
                    new Track { ID  = 25, Length = new TimeSpan(0, 3, 23), Name = "All Alone" },
                    new Track { ID  = 26, Length = new TimeSpan(0, 2, 4), Name = "White Light" },
                    new Track { ID  = 27, Length = new TimeSpan(0, 3, 57), Name = "DARE" },
                    new Track { ID  = 28, Length = new TimeSpan(0, 3, 10), Name = "Fire Comming Out Of The Monkeys Head" },
                    new Track { ID  = 29, Length = new TimeSpan(0, 1, 56), Name = "Don't Get Lost In Heaven" },
                    new Track { ID  = 30, Length = new TimeSpan(0, 4, 21), Name = "Demon Days" }
                );
            modelBuilder.Entity<AlbumTrack>()
                .HasData
                (
                    new AlbumTrack { AlbumID = 1, TrackID = 1},
                    new AlbumTrack { AlbumID = 1, TrackID = 2},
                    new AlbumTrack { AlbumID = 1, TrackID = 3},
                    new AlbumTrack { AlbumID = 1, TrackID = 4},
                    new AlbumTrack { AlbumID = 1, TrackID = 5},
                    new AlbumTrack { AlbumID = 1, TrackID = 6},
                    new AlbumTrack { AlbumID = 1, TrackID = 7},
                    new AlbumTrack { AlbumID = 1, TrackID = 8},
                    new AlbumTrack { AlbumID = 1, TrackID = 9},
                    new AlbumTrack { AlbumID = 1, TrackID = 10},
                    new AlbumTrack { AlbumID = 1, TrackID = 11},
                    new AlbumTrack { AlbumID = 1, TrackID = 12},
                    new AlbumTrack { AlbumID = 1, TrackID = 13},
                    new AlbumTrack { AlbumID = 1, TrackID = 14},
                    new AlbumTrack { AlbumID = 1, TrackID = 15},
                    new AlbumTrack { AlbumID = 2, TrackID = 1 },
                    new AlbumTrack { AlbumID = 2, TrackID = 2 },
                    new AlbumTrack { AlbumID = 2, TrackID = 3 },
                    new AlbumTrack { AlbumID = 2, TrackID = 4 },
                    new AlbumTrack { AlbumID = 2, TrackID = 5 },
                    new AlbumTrack { AlbumID = 2, TrackID = 6 },
                    new AlbumTrack { AlbumID = 2, TrackID = 7 },
                    new AlbumTrack { AlbumID = 2, TrackID = 8 },
                    new AlbumTrack { AlbumID = 2, TrackID = 9 },
                    new AlbumTrack { AlbumID = 2, TrackID = 10 },
                    new AlbumTrack { AlbumID = 2, TrackID = 11 },
                    new AlbumTrack { AlbumID = 2, TrackID = 12 },
                    new AlbumTrack { AlbumID = 2, TrackID = 13 },
                    new AlbumTrack { AlbumID = 2, TrackID = 14 },
                    new AlbumTrack { AlbumID = 2, TrackID = 15 }
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

        }
    }
}
