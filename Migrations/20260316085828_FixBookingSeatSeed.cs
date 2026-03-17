using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class FixBookingSeatSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "CreatedAt", "ShowtimeId", "Status", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { "BK001", new DateTime(2026, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), "ST001", "PAID", 15.5, "USR001" },
                    { "BK002", new DateTime(2026, 6, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "ST002", "PAID", 20.0, "USR002" }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1287), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1292), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1294), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1296), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1297), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1299), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1301), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1303), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1305), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1307), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1308), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1310), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1311), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1313), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1314), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1316), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1317), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1319), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1320), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1321), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1323), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1324), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1326), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1327), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1329), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1470), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1474), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1476), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1479), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1482), new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 58, 28, 345, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.InsertData(
                table: "BookingFoodCombos",
                columns: new[] { "BookingFoodComboId", "BookingId", "FoodComboId", "Quantity" },
                values: new object[,]
                {
                    { "BFC001", "BK001", "FC001", 1 },
                    { "BFC002", "BK002", "FC002", 2 }
                });

            migrationBuilder.InsertData(
                table: "BookingSeats",
                columns: new[] { "BookingSeatId", "BookingId", "CheckinTime", "Price", "QrCode", "SeatId", "ShowtimeTicketTypeId", "Status" },
                values: new object[,]
                {
                    { "BKS001", "BK001", new DateTime(2026, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 7.5, "QR001", "SE001", "STT001", "BOOKED" },
                    { "BKS002", "BK001", new DateTime(2026, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 8.0, "QR002", "SE002", "STT001", "BOOKED" },
                    { "BKS003", "BK002", new DateTime(2026, 6, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 10.0, "QR003", "SE003", "STT002", "BOOKED" }
                });

            migrationBuilder.InsertData(
                table: "BookingVouchers",
                columns: new[] { "BookingId", "VoucherId" },
                values: new object[,]
                {
                    { "BK001", "VC001" },
                    { "BK002", "VC002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingFoodCombos",
                keyColumn: "BookingFoodComboId",
                keyValue: "BFC001");

            migrationBuilder.DeleteData(
                table: "BookingFoodCombos",
                keyColumn: "BookingFoodComboId",
                keyValue: "BFC002");

            migrationBuilder.DeleteData(
                table: "BookingSeats",
                keyColumn: "BookingSeatId",
                keyValue: "BKS001");

            migrationBuilder.DeleteData(
                table: "BookingSeats",
                keyColumn: "BookingSeatId",
                keyValue: "BKS002");

            migrationBuilder.DeleteData(
                table: "BookingSeats",
                keyColumn: "BookingSeatId",
                keyValue: "BKS003");

            migrationBuilder.DeleteData(
                table: "BookingVouchers",
                keyColumns: new[] { "BookingId", "VoucherId" },
                keyValues: new object[] { "BK001", "VC001" });

            migrationBuilder.DeleteData(
                table: "BookingVouchers",
                keyColumns: new[] { "BookingId", "VoucherId" },
                keyValues: new object[] { "BK002", "VC002" });

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "BK001");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "BK002");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6032), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6042), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6044), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6046), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6047), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6202), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6204), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6206), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6209), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6212), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6213), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6214), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6216), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6217), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6219), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6220), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6222), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6223), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6224), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6227), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6229), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6231), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6232), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6234), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6235), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6562), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6568), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6571), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6574), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6577), new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 8, 50, 52, 968, DateTimeKind.Utc).AddTicks(6773));
        }
    }
}
