using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class addassociationtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlbumTracks",
                columns: table => new
                {
                    AlbumID = table.Column<int>(nullable: false),
                    TrackID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumTracks", x => new { x.AlbumID, x.TrackID });
                    table.ForeignKey(
                        name: "FK_AlbumTracks_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumTracks_Tracks_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Tracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistTracks",
                columns: table => new
                {
                    PlaylistID = table.Column<int>(nullable: false),
                    TrackID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistTracks", x => new { x.PlaylistID, x.TrackID });
                    table.ForeignKey(
                        name: "FK_PlaylistTracks_Playlists_PlaylistID",
                        column: x => x.PlaylistID,
                        principalTable: "Playlists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistTracks_Tracks_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Tracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumTracks_TrackID",
                table: "AlbumTracks",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTracks_TrackID",
                table: "PlaylistTracks",
                column: "TrackID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumTracks");

            migrationBuilder.DropTable(
                name: "PlaylistTracks");
        }
    }
}
