using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedShowtime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1155), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1161), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1163), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1165), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1168), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1170), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1172), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1175), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1177), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1179), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1182), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1184), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1186), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1188), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1191), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1201), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1204), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1206), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1208), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1210), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1212), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1215), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1217), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1219), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1221), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.InsertData(
                table: "Showtimes",
                columns: new[] { "ShowtimeId", "CreatedAt", "EndTime", "MovieId", "RoomId", "StartTime", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { "ST001", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 13, 1, 0, 0, DateTimeKind.Unspecified), "MOV001", "R001", new DateTime(2026, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST002", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 15, 58, 0, 0, DateTimeKind.Unspecified), "MOV002", "R002", new DateTime(2026, 6, 10, 13, 30, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST003", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 19, 26, 0, 0, DateTimeKind.Unspecified), "MOV003", "R003", new DateTime(2026, 6, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST004", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 22, 6, 0, 0, DateTimeKind.Unspecified), "MOV004", "R001", new DateTime(2026, 6, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST005", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 11, 13, 12, 0, 0, DateTimeKind.Unspecified), "MOV009", "R002", new DateTime(2026, 6, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST006", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 11, 16, 11, 0, 0, DateTimeKind.Unspecified), "MOV010", "R003", new DateTime(2026, 6, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1419), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1425), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1429), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1440), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1443), new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 59, 54, 409, DateTimeKind.Utc).AddTicks(1646));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST001");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST002");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST003");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST004");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST005");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST006");

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
    }
}
