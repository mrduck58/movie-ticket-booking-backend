using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedSeatsAndSeatLocks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(967), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(978), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(983), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(988), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(992), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(996), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1000), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1004), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1008), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1013), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1017), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1021), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1026), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1030), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1034), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1052), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1057), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1061), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1065), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1069), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1073), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1077), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1081), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1085), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1089), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "RoomId", "SeatName", "SeatType", "ShowtimeId", "Status" },
                values: new object[,]
                {
                    { "SE001", "R001", "A1", "NORMAL", "ST001", "AVAILABLE" },
                    { "SE002", "R001", "A2", "NORMAL", "ST001", "AVAILABLE" },
                    { "SE003", "R001", "A3", "VIP", "ST001", "AVAILABLE" },
                    { "SE004", "R001", "A4", "VIP", "ST001", "AVAILABLE" },
                    { "SE005", "R002", "B1", "NORMAL", "ST002", "AVAILABLE" },
                    { "SE006", "R002", "B2", "NORMAL", "ST002", "AVAILABLE" },
                    { "SE007", "R002", "B3", "VIP", "ST002", "AVAILABLE" },
                    { "SE008", "R002", "B4", "VIP", "ST002", "AVAILABLE" },
                    { "SE009", "R003", "C1", "NORMAL", "ST003", "AVAILABLE" },
                    { "SE010", "R003", "C2", "NORMAL", "ST003", "AVAILABLE" },
                    { "SE011", "R003", "C3", "VIP", "ST003", "AVAILABLE" },
                    { "SE012", "R003", "C4", "VIP", "ST003", "AVAILABLE" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1501), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1509), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1517), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1523), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1530), new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 10, 42, 44, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.InsertData(
                table: "SeatLocks",
                columns: new[] { "SeatLockId", "ExpiredAt", "LockedAt", "SeatId", "ShowtimeId", "UserId" },
                values: new object[,]
                {
                    { "SL001", new DateTime(2026, 6, 10, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 9, 50, 0, 0, DateTimeKind.Unspecified), "SE001", "ST001", "USR001" },
                    { "SL002", new DateTime(2026, 6, 10, 13, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 13, 20, 0, 0, DateTimeKind.Unspecified), "SE006", "ST002", "USR001" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SeatLocks",
                keyColumn: "SeatLockId",
                keyValue: "SL001");

            migrationBuilder.DeleteData(
                table: "SeatLocks",
                keyColumn: "SeatLockId",
                keyValue: "SL002");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE002");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE003");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE004");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE005");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE007");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE008");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE009");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE010");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE011");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE012");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE001");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE006");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5581), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5587), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5589), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5599), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5601), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5603), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5605), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5607), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5609), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5610), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5612), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5614), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5617), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5619), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5621), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5623), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5624), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5626), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5628), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5630), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5632), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5633), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5635), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5637), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5639), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5932), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5937), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5940), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5943), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5947), new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 5, 25, 179, DateTimeKind.Utc).AddTicks(6137));
        }
    }
}
