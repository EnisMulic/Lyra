using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class rs2ispit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RSIICovidExams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    DateTested = table.Column<DateTime>(nullable: false),
                    TestPositive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSIICovidExams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RSIICovidExams_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 952, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 956, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 956, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 1,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 2,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 3,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 4,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 5,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 6,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 7,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 8,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 9,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 10,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 11,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 12,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 13,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 14,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 15,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 16,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 17,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 18,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 19,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 20,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 21,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 22,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 23,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 24,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 25,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 26,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 27,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 28,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 29,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 30,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 31,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 32,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 1,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 2,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 3,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 4,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 5,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 6,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 7,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 8,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 9,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 10,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 11,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 12,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 13,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 14,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 15,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 16,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 17,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 18,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 19,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 20,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 21,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 22,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 23,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 24,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 25,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 26,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 27,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 28,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 29,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 30,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 31,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 32,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 1,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 2,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 3,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 4,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 5,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 6,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 7,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 8,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 9,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 10,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 11,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 12,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 13,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 14,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 15,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 16,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 17,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 18,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 19,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 20,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 21,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 22,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 23,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 24,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 25,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 26,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 27,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 28,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 29,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 30,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 31,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 32,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 958, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 1,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 2,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 3,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 4,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 5,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 6,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 7,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 8,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 9,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 10,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 11,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 12,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 13,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 14,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 15,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 16,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 17,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 18,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 19,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 20,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 21,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 22,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 23,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 24,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 25,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 26,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 27,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 28,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 29,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 30,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 31,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 32,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 33,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 34,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 35,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 36,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 37,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 38,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 39,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 40,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 41,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 42,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 43,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 44,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 45,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 46,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 47,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 48,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 49,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 50,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 51,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 52,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 53,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 54,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 55,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 56,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 57,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 58,
                column: "InteractedAt",
                value: new DateTime(2020, 11, 5, 11, 1, 46, 957, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "lkF6PJAhtB/O/8BC6XS5h5ePXxGbTiZBorwtLxUbHRCeT9XNZxGbemJwMgHa3Rh0GaJUOmPw5GLeVo7i7MYHSQ==", "0z/mJpSWKVglyZTDD95Z3w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "PGqFSWODllYdREFLkmQ7PEg+LW8qe1mFM8+7oBlUIAoHUtJIrwVqw6U+9Q90Muq6w9HZscWkQXcnhyeUg/h6yw==", "jFhjcF5Y/8nN8OMWqSL+jA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "FtK2BItjHWSpv8syzuCPP9eA795J2341OVIsIoVsVp9GafZbl4rxbv5rc8L7DAozQF7kiwUo4I8iCo7jbOQvfA==", "ih1QyzNzhPezrcUTmQ3Sog==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "SfZkU3POiTkSQSC05vvHjDJeZMwIss6YHggZ0hr9XZ9VyEeo0JqWg3ho48+C9c053EiMpIgVGEL7UlD+ulwI+w==", "rHtktt2pUSUvBo7ie3jXuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "JJEsrrs5EIC+p6m12QKSWjJujY1RDAhgOtXpReY7IcOypkCE1DhrdfpKceBKvqyoDB9rmiOlr22IBTevbjfeFg==", "TvNIKmTx7tw4DWUm5nkfTA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "JgBqWORfVLHRorU1EcjJs0wWPTutjxgxRO290DtD52f2YLaCE111eEAS4xaHIW5nbxFW3vqzRjjr1s919ADcfA==", "1o831aLfiMPyYLhFN/nHSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "aSoBS58syeeY3YXMS3OxVj28G3RiUzk8OBAiaz58bN8oQEh2GPtw5rQuFdSqBL4zX099wrXQ89PzlhfY2rLp5A==", "Px0iNx7935IZqf3TCTMhVA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zfIOBvzT66Wkcq5ChtL/ANhE2QF0wM6mmDfheLCfd5syh7wDOb5htbqXPyzZyC7mzGuTa/C48XkP0niq7ngnPg==", "x5/9iy9RuDEAxp/b9KW5bA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "VsaYEOfQqdLRgn/ohZuosvEJv2U1rqSBSr8kCD4nPqGHiHIxstjCS4eQ7euI14oGuAf2hwRj4IwFTqceZucT+Q==", "/KZG1nFp6+WpcbwCKQ/B7w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QJAJry4JH1MqgSp72kYbbpDAIkVebLBZ/s7TNa6OR5exBz0X/zsyiIGZCmUNKzGKjBo7DG4xcmx1zsT6U7eKWg==", "BY0eH12CZt69Ve1mehYVeg==" });

            migrationBuilder.CreateIndex(
                name: "IX_RSIICovidExams_UserID",
                table: "RSIICovidExams",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RSIICovidExams");

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 416, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 419, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Playlists",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 1,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 2,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 3,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 4,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 5,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 6,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 7,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 8,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 9,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 10,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 11,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 12,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 13,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 14,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 15,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 16,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 17,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 18,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 19,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 20,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 21,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 22,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 23,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 24,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 25,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 26,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 27,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 28,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 29,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 30,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 31,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "UserActivityAlbums",
                keyColumn: "ID",
                keyValue: 32,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 1,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 2,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 3,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 4,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 5,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 6,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 7,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 8,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 9,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 10,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 11,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 12,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 13,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 14,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 15,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 16,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 17,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 18,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 19,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 20,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 21,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 22,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 23,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 24,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 25,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 26,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 27,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 28,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 29,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 30,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 31,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "UserActivityArtists",
                keyColumn: "ID",
                keyValue: 32,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 1,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 2,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 3,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 4,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 5,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 6,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 7,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 8,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 9,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 10,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 11,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 12,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 13,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 14,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 15,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 16,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 17,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 18,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 19,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 20,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 21,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 22,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 23,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 24,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 25,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 26,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 27,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 28,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 29,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 30,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 31,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "UserActivityPlaylists",
                keyColumn: "ID",
                keyValue: 32,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 421, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 1,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 2,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 3,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 4,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 5,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 6,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 7,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 8,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 9,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 10,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 11,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 12,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 13,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 14,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 15,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 16,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 17,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 18,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 19,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 20,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 21,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 22,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 23,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 24,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 25,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 26,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 27,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 28,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 29,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 30,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 31,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 32,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 33,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 34,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 35,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 36,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 37,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 38,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 39,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 40,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 41,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 42,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 43,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 44,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 45,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 46,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 47,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 48,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 49,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 50,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 51,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 52,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 53,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 54,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 55,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 56,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 57,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "UserActivityTracks",
                keyColumn: "ID",
                keyValue: 58,
                column: "InteractedAt",
                value: new DateTime(2020, 6, 24, 12, 26, 32, 420, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "s7DKHDm+t0j7raTgHRRud7H1pGfcVgxpKMT9vHw20yoZ/zhgB4oPaolmXVg3WW7+NAfLWc6PLA3L0dUaxA13ig==", "LDATPJW6cdiWc8BNTWA42Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "sxqz+ekBuay58+dxb74mbI/8orwVkaN5B6vXFsPs6I7TTttC4RiB9+RtCuxiZyzIQMeCNtUrPTrnPg7JMd8aUQ==", "xG1VLbSkjafyzZR9EgiKVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Ltm4h/F9Zt8BCvBibmYjcP3aEzhTFEvWskqDVDx+UO8XoMOCyPnv7kEH6cz88H0LMlq9L4cmmjmPSox07yS+yQ==", "ohFdsbVoUB5GBOSOZtpoVQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "kTwW9LDeLjUDlo9fsj7AwVFhBJuFkelzzYp9HLUWRp6ncxYH37AFVkaD95KFAcaabQXND4K44LbFbTEeIgnAmg==", "TgT4qhmPh7DEqYE+glBTbw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "St0iRe2oTcple0JLSGmWv245O7SI3X+5/P+7ktK443V66vH+1lNq2QDLx8gRa5s3JquLKZGEJS/Q7KxjBwRm6w==", "pTC7sQmDs24tnCscoex3uw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "stobHVUXicaDeezaldoJClrWjvH8vsLUu+43r+yYjZE9d5ihxZHbbA20CZUYQG4HzFfDoGmXLaAedzINOQdhGw==", "aSmcYbuasEUgV7P0SZjipA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "GLbXsHK/2NyNZ2wXy2Gr30bei8pQWdgOh0U0O3HZw4Gmv3m+ZC6jWfVnGmXJZVTx4MMSH8VR9JViorDgQ7ZWWQ==", "Kp+9j3rfjpS/7Jh5i2DxJA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "24+Txnq4umkL0Z+GRf+yLCzPHbJq5EkKZLfLplKnYVXDtid2IXu7Njgox4jOwbAdfSSItqXF6T3t9g6e2n8lPQ==", "FU00n80G1q2ho8Eiq+Wz/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "XuEun2Rb+hFy0gn4YsZ4qFHyBcuYE9h3xWBMGUo+/G6sk8To+zKU2b2JhTtMXjM3Q/GwFJ4sTlo18xSc2/MFWg==", "WAXOiRTkDCi8l0uD0IjVyQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "UDgrBbwwSo8v4gzD9QlJyMHCeGe3cdpaU48RyqcMKkn2EHfBhEpOUp7fYgnWZXLL/5TeHNq2oS2qnbS8G8j60w==", "f5merIDRI8V8mJIaWhQKcw==" });
        }
    }
}
