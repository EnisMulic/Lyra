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
        public DbSet<PlaylistTrack> PlaylistTracks { get; set; }
        public DbSet<AlbumTracks> AlbumTracks { get; set; }
        public DbSet<Role> Roles  { get; set; }
        public DbSet<UserRoles> UserRoles  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrackGenre>()
                .HasKey(k => new { k.GenreID, k.TrackID });
            modelBuilder.Entity<PlaylistTrack>()
                .HasKey(k => new { k.PlaylistID, k.TrackID });
            modelBuilder.Entity<AlbumTracks>()
                .HasKey(k => new { k.AlbumID, k.TrackID });
        }
    }
}
