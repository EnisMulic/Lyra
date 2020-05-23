using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class addPlaylistActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserActivityPlaylists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    PlaylistID = table.Column<int>(nullable: false),
                    InteractedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivityPlaylists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserActivityPlaylists_Playlists_PlaylistID",
                        column: x => x.PlaylistID,
                        principalTable: "Playlists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserActivityPlaylists_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFavouriteTracks_TrackID",
                table: "UserFavouriteTracks",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavouriteArtists_ArtistID",
                table: "UserFavouriteArtists",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavouriteAlbums_AlbumID",
                table: "UserFavouriteAlbums",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityTracks_TrackID",
                table: "UserActivityTracks",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityTracks_UserID",
                table: "UserActivityTracks",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityArtists_ArtistID",
                table: "UserActivityArtists",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityArtists_UserID",
                table: "UserActivityArtists",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityAlbums_AlbumID",
                table: "UserActivityAlbums",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityAlbums_UserID",
                table: "UserActivityAlbums",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityPlaylists_PlaylistID",
                table: "UserActivityPlaylists",
                column: "PlaylistID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityPlaylists_UserID",
                table: "UserActivityPlaylists",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivityAlbums_Albums_AlbumID",
                table: "UserActivityAlbums",
                column: "AlbumID",
                principalTable: "Albums",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivityAlbums_Users_UserID",
                table: "UserActivityAlbums",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivityArtists_Artists_ArtistID",
                table: "UserActivityArtists",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivityArtists_Users_UserID",
                table: "UserActivityArtists",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivityTracks_Tracks_TrackID",
                table: "UserActivityTracks",
                column: "TrackID",
                principalTable: "Tracks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivityTracks_Users_UserID",
                table: "UserActivityTracks",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavouriteAlbums_Albums_AlbumID",
                table: "UserFavouriteAlbums",
                column: "AlbumID",
                principalTable: "Albums",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavouriteAlbums_Users_UserID",
                table: "UserFavouriteAlbums",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavouriteArtists_Artists_ArtistID",
                table: "UserFavouriteArtists",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavouriteArtists_Users_UserID",
                table: "UserFavouriteArtists",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavouriteTracks_Tracks_TrackID",
                table: "UserFavouriteTracks",
                column: "TrackID",
                principalTable: "Tracks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavouriteTracks_Users_UserID",
                table: "UserFavouriteTracks",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserActivityAlbums_Albums_AlbumID",
                table: "UserActivityAlbums");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivityAlbums_Users_UserID",
                table: "UserActivityAlbums");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivityArtists_Artists_ArtistID",
                table: "UserActivityArtists");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivityArtists_Users_UserID",
                table: "UserActivityArtists");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivityTracks_Tracks_TrackID",
                table: "UserActivityTracks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivityTracks_Users_UserID",
                table: "UserActivityTracks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavouriteAlbums_Albums_AlbumID",
                table: "UserFavouriteAlbums");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavouriteAlbums_Users_UserID",
                table: "UserFavouriteAlbums");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavouriteArtists_Artists_ArtistID",
                table: "UserFavouriteArtists");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavouriteArtists_Users_UserID",
                table: "UserFavouriteArtists");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavouriteTracks_Tracks_TrackID",
                table: "UserFavouriteTracks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavouriteTracks_Users_UserID",
                table: "UserFavouriteTracks");

            migrationBuilder.DropTable(
                name: "UserActivityPlaylists");

            migrationBuilder.DropIndex(
                name: "IX_UserFavouriteTracks_TrackID",
                table: "UserFavouriteTracks");

            migrationBuilder.DropIndex(
                name: "IX_UserFavouriteArtists_ArtistID",
                table: "UserFavouriteArtists");

            migrationBuilder.DropIndex(
                name: "IX_UserFavouriteAlbums_AlbumID",
                table: "UserFavouriteAlbums");

            migrationBuilder.DropIndex(
                name: "IX_UserActivityTracks_TrackID",
                table: "UserActivityTracks");

            migrationBuilder.DropIndex(
                name: "IX_UserActivityTracks_UserID",
                table: "UserActivityTracks");

            migrationBuilder.DropIndex(
                name: "IX_UserActivityArtists_ArtistID",
                table: "UserActivityArtists");

            migrationBuilder.DropIndex(
                name: "IX_UserActivityArtists_UserID",
                table: "UserActivityArtists");

            migrationBuilder.DropIndex(
                name: "IX_UserActivityAlbums_AlbumID",
                table: "UserActivityAlbums");

            migrationBuilder.DropIndex(
                name: "IX_UserActivityAlbums_UserID",
                table: "UserActivityAlbums");
        }
    }
}
