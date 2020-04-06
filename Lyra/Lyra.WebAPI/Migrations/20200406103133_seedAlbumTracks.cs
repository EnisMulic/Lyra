using Microsoft.EntityFrameworkCore.Migrations;

namespace Lyra.WebAPI.Migrations
{
    public partial class seedAlbumTracks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AlbumTracks",
                columns: new[] { "AlbumID", "TrackID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 13 },
                    { 2, 12 },
                    { 2, 11 },
                    { 2, 10 },
                    { 2, 9 },
                    { 2, 8 },
                    { 2, 7 },
                    { 2, 6 },
                    { 2, 5 },
                    { 2, 4 },
                    { 2, 3 },
                    { 2, 2 },
                    { 2, 1 },
                    { 1, 15 },
                    { 1, 14 },
                    { 1, 13 },
                    { 1, 12 },
                    { 1, 11 },
                    { 1, 10 },
                    { 1, 9 },
                    { 1, 8 },
                    { 1, 7 },
                    { 1, 6 },
                    { 1, 5 },
                    { 1, 4 },
                    { 1, 3 },
                    { 1, 2 },
                    { 2, 14 },
                    { 2, 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "AlbumTracks",
                keyColumns: new[] { "AlbumID", "TrackID" },
                keyValues: new object[] { 2, 15 });
        }
    }
}
