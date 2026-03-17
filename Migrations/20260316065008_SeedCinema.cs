using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedCinema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "CinemaId", "CreatedAt", "Hotline", "Location", "Name", "Rating", "UpdatedAt" },
                values: new object[,]
                {
                    { "C001", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "19006017", "Ha Noi", "CGV Vincom Ba Trieu", "4.5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "C002", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1900558899", "Ha Noi", "Lotte Cinema Landmark", "4.6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "C003", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "19002099", "Ha Noi", "BHD Star Pham Ngoc Thach", "4.4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6874), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6879), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6881), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6883), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6885), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6887), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6889), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6892), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6893), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6895), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6897), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6899), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6901), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6903), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6905), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6907), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6908), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6910), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6912), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6914), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6916), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6918), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6920), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6922), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6924), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7080), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7085), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7088), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7091), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7094), new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 50, 8, 41, DateTimeKind.Utc).AddTicks(7272));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "CinemaId",
                keyValue: "C001");

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "CinemaId",
                keyValue: "C002");

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "CinemaId",
                keyValue: "C003");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4169), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4173), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4175), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4177), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4178), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4180), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4182), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4183), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4185), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4186), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4188), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4196), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4198), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4199), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4201), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4202), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4204), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4205), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4207), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4208), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4210), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4212), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4213), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4215), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4216), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4334), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4337), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4340), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4342), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4345), new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4495));
        }
    }
}
