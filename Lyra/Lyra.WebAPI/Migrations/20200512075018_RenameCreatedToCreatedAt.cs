using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class RenameCreatedToCreatedAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Playlists");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Playlists",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Playlists");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Playlists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
