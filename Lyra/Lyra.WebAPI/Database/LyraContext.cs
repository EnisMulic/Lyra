using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Database
{
    public partial class LyraContext : DbContext
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
