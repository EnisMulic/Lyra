using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class seedTracks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "ID", "AlbumID", "Length", "Name", "PlaylistID" },
                values: new object[,]
                {
                    { 1, null, new TimeSpan(0, 0, 3, 32, 0), "Re-Hash", null },
                    { 28, null, new TimeSpan(0, 0, 3, 10, 0), "Fire Comming Out Of The Monkeys Head", null },
                    { 27, null, new TimeSpan(0, 0, 3, 57, 0), "DARE", null },
                    { 26, null, new TimeSpan(0, 0, 2, 4, 0), "White Light", null },
                    { 25, null, new TimeSpan(0, 0, 3, 23, 0), "All Alone", null },
                    { 24, null, new TimeSpan(0, 0, 2, 36, 0), "November Has Come", null },
                    { 23, null, new TimeSpan(0, 0, 4, 44, 0), "Every Planet We Reach Is Dead", null },
                    { 22, null, new TimeSpan(0, 0, 3, 43, 0), "El Manana", null },
                    { 21, null, new TimeSpan(0, 0, 3, 34, 0), "Feel Good Inc.", null },
                    { 20, null, new TimeSpan(0, 0, 3, 37, 0), "Dirty Harry", null },
                    { 19, null, new TimeSpan(0, 0, 4, 24, 0), "O Green World", null },
                    { 18, null, new TimeSpan(0, 0, 3, 39, 0), "Kids With Guns", null },
                    { 17, null, new TimeSpan(0, 0, 3, 4, 0), "Last Living Soul", null },
                    { 16, null, new TimeSpan(0, 0, 1, 1, 0), "Intro", null },
                    { 15, null, new TimeSpan(0, 0, 10, 21, 0), "M1 A1", null },
                    { 14, null, new TimeSpan(0, 0, 3, 29, 0), "Slow Country", null },
                    { 13, null, new TimeSpan(0, 0, 3, 25, 0), "Starshine", null },
                    { 12, null, new TimeSpan(0, 0, 3, 30, 0), "Latin Simone (Que Pasa Contigo)", null },
                    { 11, null, new TimeSpan(0, 0, 3, 21, 0), "19-2000", null },
                    { 10, null, new TimeSpan(0, 0, 4, 1, 0), "Rock The House", null },
                    { 9, null, new TimeSpan(0, 0, 4, 36, 0), "Double Bass", null },
                    { 8, null, new TimeSpan(0, 0, 4, 32, 0), "Sound Check (Gravity)", null },
                    { 7, null, new TimeSpan(0, 0, 1, 33, 0), "Punk", null },
                    { 6, null, new TimeSpan(0, 0, 4, 22, 0), "Man Research (Clapper)", null },
                    { 5, null, new TimeSpan(0, 0, 5, 32, 0), "Clint Eastwood", null },
                    { 4, null, new TimeSpan(0, 0, 3, 51, 0), "New Genious (Brother)", null },
                    { 3, null, new TimeSpan(0, 0, 3, 7, 0), "Tomorrow Comes Today", null },
                    { 2, null, new TimeSpan(0, 0, 2, 35, 0), "5/4", null },
                    { 29, null, new TimeSpan(0, 0, 1, 56, 0), "Don't Get Lost In Heaven", null },
                    { 30, null, new TimeSpan(0, 0, 4, 21, 0), "Demon Days", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "ID",
                keyValue: 30);
        }
    }
}
