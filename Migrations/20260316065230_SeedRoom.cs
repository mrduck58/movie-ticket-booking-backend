using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5385), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5390), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5391), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5393), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5394), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5396), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5397), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5399), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5400), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5402), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5403), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5405), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5406), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5408), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5409), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5411), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5412), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5414), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5415), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5417), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5418), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5420), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5421), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5423), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5424), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5425) });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "CinemaId", "Name" },
                values: new object[,]
                {
                    { "R001", "C001", "Room 1" },
                    { "R002", "C001", "Room 2" },
                    { "R003", "C002", "Room 1" },
                    { "R004", "C002", "Room 2" },
                    { "R005", "C003", "Room 1" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5544), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5547), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5550), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5552), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5555), new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 52, 29, 441, DateTimeKind.Utc).AddTicks(5696));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R001");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R002");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R003");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R004");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R005");

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
    }
}
