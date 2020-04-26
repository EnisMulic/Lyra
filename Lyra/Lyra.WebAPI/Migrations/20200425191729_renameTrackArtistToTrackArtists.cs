using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class renameTrackArtistToTrackArtists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackArtist_Artists_ArtistID",
                table: "TrackArtist");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackArtist_Tracks_TrackID",
                table: "TrackArtist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrackArtist",
                table: "TrackArtist");

            migrationBuilder.RenameTable(
                name: "TrackArtist",
                newName: "TrackArtists");

            migrationBuilder.RenameIndex(
                name: "IX_TrackArtist_ArtistID",
                table: "TrackArtists",
                newName: "IX_TrackArtists_ArtistID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrackArtists",
                table: "TrackArtists",
                columns: new[] { "TrackID", "ArtistID" });

            migrationBuilder.AddForeignKey(
                name: "FK_TrackArtists_Artists_ArtistID",
                table: "TrackArtists",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackArtists_Tracks_TrackID",
                table: "TrackArtists",
                column: "TrackID",
                principalTable: "Tracks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackArtists_Artists_ArtistID",
                table: "TrackArtists");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackArtists_Tracks_TrackID",
                table: "TrackArtists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrackArtists",
                table: "TrackArtists");

            migrationBuilder.RenameTable(
                name: "TrackArtists",
                newName: "TrackArtist");

            migrationBuilder.RenameIndex(
                name: "IX_TrackArtists_ArtistID",
                table: "TrackArtist",
                newName: "IX_TrackArtist_ArtistID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrackArtist",
                table: "TrackArtist",
                columns: new[] { "TrackID", "ArtistID" });

            migrationBuilder.AddForeignKey(
                name: "FK_TrackArtist_Artists_ArtistID",
                table: "TrackArtist",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackArtist_Tracks_TrackID",
                table: "TrackArtist",
                column: "TrackID",
                principalTable: "Tracks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
