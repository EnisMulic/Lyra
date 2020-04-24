using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class fixPlaylistList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Playlists_PlaylistID",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_PlaylistID",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "PlaylistID",
                table: "Tracks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaylistID",
                table: "Tracks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_PlaylistID",
                table: "Tracks",
                column: "PlaylistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Playlists_PlaylistID",
                table: "Tracks",
                column: "PlaylistID",
                principalTable: "Playlists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
