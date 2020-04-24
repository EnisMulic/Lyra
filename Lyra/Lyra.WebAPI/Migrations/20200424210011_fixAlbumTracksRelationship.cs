using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class fixAlbumTracksRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumID",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_AlbumID",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "AlbumID",
                table: "Tracks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumID",
                table: "Tracks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumID",
                table: "Tracks",
                column: "AlbumID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumID",
                table: "Tracks",
                column: "AlbumID",
                principalTable: "Albums",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
