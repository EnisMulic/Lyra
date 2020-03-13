using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class addimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverArtPath",
                table: "Albums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CoverArtPath",
                table: "Albums");
        }
    }
}
