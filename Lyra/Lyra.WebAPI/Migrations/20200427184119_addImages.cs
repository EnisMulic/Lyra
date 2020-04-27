using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class addImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverArtPath",
                table: "Albums");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Playlists",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Artists",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Albums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Albums");

            migrationBuilder.AddColumn<string>(
                name: "CoverArtPath",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
