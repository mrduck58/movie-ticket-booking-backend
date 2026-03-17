using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "GEN001", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3609), "Action", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3613) },
                    { "GEN002", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3614), "Adventure", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3615) },
                    { "GEN003", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3616), "Animation", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3617) },
                    { "GEN004", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3618), "Biography", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3619) },
                    { "GEN005", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3620), "Comedy", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3621) },
                    { "GEN006", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3622), "Crime", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3622) },
                    { "GEN007", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3624), "Documentary", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3624) },
                    { "GEN008", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3626), "Drama", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3626) },
                    { "GEN009", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3627), "Family", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3628) },
                    { "GEN010", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3629), "Fantasy", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3630) },
                    { "GEN011", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3631), "History", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3631) },
                    { "GEN012", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3633), "Horror", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3633) },
                    { "GEN013", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3634), "Music", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3635) },
                    { "GEN014", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3636), "Mystery", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3637) },
                    { "GEN015", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3638), "Romance", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3639) },
                    { "GEN016", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3640), "Sci-Fi", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3640) },
                    { "GEN017", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3642), "Sport", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3642) },
                    { "GEN018", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3643), "Thriller", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3644) },
                    { "GEN019", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3645), "War", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3646) },
                    { "GEN020", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3647), "Western", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3648) },
                    { "GEN021", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3649), "Superhero", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3649) },
                    { "GEN022", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3651), "Psychological", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3651) },
                    { "GEN023", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3652), "Anime", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3653) },
                    { "GEN024", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3654), "Disaster", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3655) },
                    { "GEN025", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3656), "Martial Arts", new DateTime(2026, 3, 16, 6, 0, 1, 779, DateTimeKind.Utc).AddTicks(3656) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025");
        }
    }
}
