using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class AddArtistToAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "Albums",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistID",
                table: "Albums",
                column: "ArtistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistID",
                table: "Albums",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistID",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_ArtistID",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "Albums");
        }
    }
}
