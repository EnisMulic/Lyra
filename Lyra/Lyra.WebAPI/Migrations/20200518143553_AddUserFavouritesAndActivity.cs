using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class AddUserFavouritesAndActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserActivityAlbums",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    AlbumID = table.Column<int>(nullable: false),
                    InteractedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivityAlbums", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserActivityArtists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    ArtistID = table.Column<int>(nullable: false),
                    InteractedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivityArtists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserActivityTracks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    TrackID = table.Column<int>(nullable: false),
                    InteractedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivityTracks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserFavouriteAlbums",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    AlbumID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavouriteAlbums", x => new { x.UserID, x.AlbumID });
                });

            migrationBuilder.CreateTable(
                name: "UserFavouriteArtists",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    ArtistID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavouriteArtists", x => new { x.UserID, x.ArtistID });
                });

            migrationBuilder.CreateTable(
                name: "UserFavouriteTracks",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    TrackID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavouriteTracks", x => new { x.UserID, x.TrackID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActivityAlbums");

            migrationBuilder.DropTable(
                name: "UserActivityArtists");

            migrationBuilder.DropTable(
                name: "UserActivityTracks");

            migrationBuilder.DropTable(
                name: "UserFavouriteAlbums");

            migrationBuilder.DropTable(
                name: "UserFavouriteArtists");

            migrationBuilder.DropTable(
                name: "UserFavouriteTracks");
        }
    }
}
