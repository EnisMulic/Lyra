using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class seedAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "CoverArtPath", "Name", "ReleaseYear" },
                values: new object[] { 1, null, "Gorillaz", 2001 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "CoverArtPath", "Name", "ReleaseYear" },
                values: new object[] { 2, null, "Demon Days", 2003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
