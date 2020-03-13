using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class addmaintables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumID",
                table: "Tracks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaylistID",
                table: "Tracks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Albums",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TrackGenres",
                columns: table => new
                {
                    TrackID = table.Column<int>(nullable: false),
                    GenreID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackGenres", x => new { x.GenreID, x.TrackID });
                    table.ForeignKey(
                        name: "FK_TrackGenres_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackGenres_Tracks_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Tracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Playlists_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumID",
                table: "Tracks",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_PlaylistID",
                table: "Tracks",
                column: "PlaylistID");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_UserID",
                table: "Playlists",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackGenres_TrackID",
                table: "TrackGenres",
                column: "TrackID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumID",
                table: "Tracks",
                column: "AlbumID",
                principalTable: "Albums",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Playlists_PlaylistID",
                table: "Tracks",
                column: "PlaylistID",
                principalTable: "Playlists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumID",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Playlists_PlaylistID",
                table: "Tracks");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "TrackGenres");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_AlbumID",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_PlaylistID",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "AlbumID",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "PlaylistID",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Albums");
        }
    }
}
