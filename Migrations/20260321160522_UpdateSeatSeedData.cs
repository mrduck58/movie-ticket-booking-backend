using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeatSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Showtimes_ShowtimeId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_ShowtimeId",
                table: "Seats");

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
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY001");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY002");

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
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "BK001");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: "BK002");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE001");

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
                keyValue: "SE006");

            migrationBuilder.DropColumn(
                name: "SeatType",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "ShowtimeId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Seats");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3254), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3258), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3260), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3262), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3263), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3265), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3267), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3269), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3271), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3272), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3274), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3276), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3278), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3279), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3281), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3283), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3284), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3286), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3288), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3290), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3291), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3293), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3295), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3296), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3298), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM001",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 21, 23, 5, 21, 292, DateTimeKind.Local).AddTicks(5021), new DateTime(2026, 3, 21, 23, 5, 21, 292, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM002",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 21, 23, 5, 21, 292, DateTimeKind.Local).AddTicks(5060), new DateTime(2026, 3, 21, 23, 5, 21, 292, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM003",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 21, 23, 5, 21, 292, DateTimeKind.Local).AddTicks(5062), new DateTime(2026, 3, 21, 23, 5, 21, 292, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "RoomId", "SeatName" },
                values: new object[,]
                {
                    { "SE0001", "R001", "A1" },
                    { "SE0002", "R001", "A2" },
                    { "SE0003", "R001", "A3" },
                    { "SE0004", "R001", "A4" },
                    { "SE0005", "R001", "A5" },
                    { "SE0006", "R001", "A6" },
                    { "SE0007", "R001", "A7" },
                    { "SE0008", "R001", "A8" },
                    { "SE0009", "R001", "A9" },
                    { "SE0010", "R001", "A10" },
                    { "SE0011", "R001", "B1" },
                    { "SE0012", "R001", "B2" },
                    { "SE0013", "R001", "B3" },
                    { "SE0014", "R001", "B4" },
                    { "SE0015", "R001", "B5" },
                    { "SE0016", "R001", "B6" },
                    { "SE0017", "R001", "B7" },
                    { "SE0018", "R001", "B8" },
                    { "SE0019", "R001", "B9" },
                    { "SE0020", "R001", "B10" },
                    { "SE0021", "R001", "C1" },
                    { "SE0022", "R001", "C2" },
                    { "SE0023", "R001", "C3" },
                    { "SE0024", "R001", "C4" },
                    { "SE0025", "R001", "C5" },
                    { "SE0026", "R001", "C6" },
                    { "SE0027", "R001", "C7" },
                    { "SE0028", "R001", "C8" },
                    { "SE0029", "R001", "C9" },
                    { "SE0030", "R001", "C10" },
                    { "SE0031", "R001", "D1" },
                    { "SE0032", "R001", "D2" },
                    { "SE0033", "R001", "D3" },
                    { "SE0034", "R001", "D4" },
                    { "SE0035", "R001", "D5" },
                    { "SE0036", "R001", "D6" },
                    { "SE0037", "R001", "D7" },
                    { "SE0038", "R001", "D8" },
                    { "SE0039", "R001", "D9" },
                    { "SE0040", "R001", "D10" },
                    { "SE0041", "R001", "E1" },
                    { "SE0042", "R001", "E2" },
                    { "SE0043", "R001", "E3" },
                    { "SE0044", "R001", "E4" },
                    { "SE0045", "R001", "E5" },
                    { "SE0046", "R001", "E6" },
                    { "SE0047", "R001", "E7" },
                    { "SE0048", "R001", "E8" },
                    { "SE0049", "R001", "E9" },
                    { "SE0050", "R001", "E10" },
                    { "SE0051", "R001", "F1" },
                    { "SE0052", "R001", "F2" },
                    { "SE0053", "R001", "F3" },
                    { "SE0054", "R001", "F4" },
                    { "SE0055", "R001", "F5" },
                    { "SE0056", "R001", "F6" },
                    { "SE0057", "R001", "F7" },
                    { "SE0058", "R001", "F8" },
                    { "SE0059", "R001", "F9" },
                    { "SE0060", "R001", "F10" },
                    { "SE0061", "R001", "G1" },
                    { "SE0062", "R001", "G2" },
                    { "SE0063", "R001", "G3" },
                    { "SE0064", "R001", "G4" },
                    { "SE0065", "R001", "G5" },
                    { "SE0066", "R001", "G6" },
                    { "SE0067", "R001", "G7" },
                    { "SE0068", "R001", "G8" },
                    { "SE0069", "R001", "G9" },
                    { "SE0070", "R001", "G10" },
                    { "SE0071", "R001", "H1" },
                    { "SE0072", "R001", "H2" },
                    { "SE0073", "R001", "H3" },
                    { "SE0074", "R001", "H4" },
                    { "SE0075", "R001", "H5" },
                    { "SE0076", "R001", "H6" },
                    { "SE0077", "R001", "H7" },
                    { "SE0078", "R001", "H8" },
                    { "SE0079", "R001", "H9" },
                    { "SE0080", "R001", "H10" },
                    { "SE0081", "R002", "A1" },
                    { "SE0082", "R002", "A2" },
                    { "SE0083", "R002", "A3" },
                    { "SE0084", "R002", "A4" },
                    { "SE0085", "R002", "A5" },
                    { "SE0086", "R002", "A6" },
                    { "SE0087", "R002", "A7" },
                    { "SE0088", "R002", "A8" },
                    { "SE0089", "R002", "A9" },
                    { "SE0090", "R002", "A10" },
                    { "SE0091", "R002", "B1" },
                    { "SE0092", "R002", "B2" },
                    { "SE0093", "R002", "B3" },
                    { "SE0094", "R002", "B4" },
                    { "SE0095", "R002", "B5" },
                    { "SE0096", "R002", "B6" },
                    { "SE0097", "R002", "B7" },
                    { "SE0098", "R002", "B8" },
                    { "SE0099", "R002", "B9" },
                    { "SE0100", "R002", "B10" },
                    { "SE0101", "R002", "C1" },
                    { "SE0102", "R002", "C2" },
                    { "SE0103", "R002", "C3" },
                    { "SE0104", "R002", "C4" },
                    { "SE0105", "R002", "C5" },
                    { "SE0106", "R002", "C6" },
                    { "SE0107", "R002", "C7" },
                    { "SE0108", "R002", "C8" },
                    { "SE0109", "R002", "C9" },
                    { "SE0110", "R002", "C10" },
                    { "SE0111", "R002", "D1" },
                    { "SE0112", "R002", "D2" },
                    { "SE0113", "R002", "D3" },
                    { "SE0114", "R002", "D4" },
                    { "SE0115", "R002", "D5" },
                    { "SE0116", "R002", "D6" },
                    { "SE0117", "R002", "D7" },
                    { "SE0118", "R002", "D8" },
                    { "SE0119", "R002", "D9" },
                    { "SE0120", "R002", "D10" },
                    { "SE0121", "R002", "E1" },
                    { "SE0122", "R002", "E2" },
                    { "SE0123", "R002", "E3" },
                    { "SE0124", "R002", "E4" },
                    { "SE0125", "R002", "E5" },
                    { "SE0126", "R002", "E6" },
                    { "SE0127", "R002", "E7" },
                    { "SE0128", "R002", "E8" },
                    { "SE0129", "R002", "E9" },
                    { "SE0130", "R002", "E10" },
                    { "SE0131", "R002", "F1" },
                    { "SE0132", "R002", "F2" },
                    { "SE0133", "R002", "F3" },
                    { "SE0134", "R002", "F4" },
                    { "SE0135", "R002", "F5" },
                    { "SE0136", "R002", "F6" },
                    { "SE0137", "R002", "F7" },
                    { "SE0138", "R002", "F8" },
                    { "SE0139", "R002", "F9" },
                    { "SE0140", "R002", "F10" },
                    { "SE0141", "R002", "G1" },
                    { "SE0142", "R002", "G2" },
                    { "SE0143", "R002", "G3" },
                    { "SE0144", "R002", "G4" },
                    { "SE0145", "R002", "G5" },
                    { "SE0146", "R002", "G6" },
                    { "SE0147", "R002", "G7" },
                    { "SE0148", "R002", "G8" },
                    { "SE0149", "R002", "G9" },
                    { "SE0150", "R002", "G10" },
                    { "SE0151", "R002", "H1" },
                    { "SE0152", "R002", "H2" },
                    { "SE0153", "R002", "H3" },
                    { "SE0154", "R002", "H4" },
                    { "SE0155", "R002", "H5" },
                    { "SE0156", "R002", "H6" },
                    { "SE0157", "R002", "H7" },
                    { "SE0158", "R002", "H8" },
                    { "SE0159", "R002", "H9" },
                    { "SE0160", "R002", "H10" },
                    { "SE0161", "R003", "A1" },
                    { "SE0162", "R003", "A2" },
                    { "SE0163", "R003", "A3" },
                    { "SE0164", "R003", "A4" },
                    { "SE0165", "R003", "A5" },
                    { "SE0166", "R003", "A6" },
                    { "SE0167", "R003", "A7" },
                    { "SE0168", "R003", "A8" },
                    { "SE0169", "R003", "A9" },
                    { "SE0170", "R003", "A10" },
                    { "SE0171", "R003", "B1" },
                    { "SE0172", "R003", "B2" },
                    { "SE0173", "R003", "B3" },
                    { "SE0174", "R003", "B4" },
                    { "SE0175", "R003", "B5" },
                    { "SE0176", "R003", "B6" },
                    { "SE0177", "R003", "B7" },
                    { "SE0178", "R003", "B8" },
                    { "SE0179", "R003", "B9" },
                    { "SE0180", "R003", "B10" },
                    { "SE0181", "R003", "C1" },
                    { "SE0182", "R003", "C2" },
                    { "SE0183", "R003", "C3" },
                    { "SE0184", "R003", "C4" },
                    { "SE0185", "R003", "C5" },
                    { "SE0186", "R003", "C6" },
                    { "SE0187", "R003", "C7" },
                    { "SE0188", "R003", "C8" },
                    { "SE0189", "R003", "C9" },
                    { "SE0190", "R003", "C10" },
                    { "SE0191", "R003", "D1" },
                    { "SE0192", "R003", "D2" },
                    { "SE0193", "R003", "D3" },
                    { "SE0194", "R003", "D4" },
                    { "SE0195", "R003", "D5" },
                    { "SE0196", "R003", "D6" },
                    { "SE0197", "R003", "D7" },
                    { "SE0198", "R003", "D8" },
                    { "SE0199", "R003", "D9" },
                    { "SE0200", "R003", "D10" },
                    { "SE0201", "R003", "E1" },
                    { "SE0202", "R003", "E2" },
                    { "SE0203", "R003", "E3" },
                    { "SE0204", "R003", "E4" },
                    { "SE0205", "R003", "E5" },
                    { "SE0206", "R003", "E6" },
                    { "SE0207", "R003", "E7" },
                    { "SE0208", "R003", "E8" },
                    { "SE0209", "R003", "E9" },
                    { "SE0210", "R003", "E10" },
                    { "SE0211", "R003", "F1" },
                    { "SE0212", "R003", "F2" },
                    { "SE0213", "R003", "F3" },
                    { "SE0214", "R003", "F4" },
                    { "SE0215", "R003", "F5" },
                    { "SE0216", "R003", "F6" },
                    { "SE0217", "R003", "F7" },
                    { "SE0218", "R003", "F8" },
                    { "SE0219", "R003", "F9" },
                    { "SE0220", "R003", "F10" },
                    { "SE0221", "R003", "G1" },
                    { "SE0222", "R003", "G2" },
                    { "SE0223", "R003", "G3" },
                    { "SE0224", "R003", "G4" },
                    { "SE0225", "R003", "G5" },
                    { "SE0226", "R003", "G6" },
                    { "SE0227", "R003", "G7" },
                    { "SE0228", "R003", "G8" },
                    { "SE0229", "R003", "G9" },
                    { "SE0230", "R003", "G10" },
                    { "SE0231", "R003", "H1" },
                    { "SE0232", "R003", "H2" },
                    { "SE0233", "R003", "H3" },
                    { "SE0234", "R003", "H4" },
                    { "SE0235", "R003", "H5" },
                    { "SE0236", "R003", "H6" },
                    { "SE0237", "R003", "H7" },
                    { "SE0238", "R003", "H8" },
                    { "SE0239", "R003", "H9" },
                    { "SE0240", "R003", "H10" },
                    { "SE0241", "R004", "A1" },
                    { "SE0242", "R004", "A2" },
                    { "SE0243", "R004", "A3" },
                    { "SE0244", "R004", "A4" },
                    { "SE0245", "R004", "A5" },
                    { "SE0246", "R004", "A6" },
                    { "SE0247", "R004", "A7" },
                    { "SE0248", "R004", "A8" },
                    { "SE0249", "R004", "A9" },
                    { "SE0250", "R004", "A10" },
                    { "SE0251", "R004", "B1" },
                    { "SE0252", "R004", "B2" },
                    { "SE0253", "R004", "B3" },
                    { "SE0254", "R004", "B4" },
                    { "SE0255", "R004", "B5" },
                    { "SE0256", "R004", "B6" },
                    { "SE0257", "R004", "B7" },
                    { "SE0258", "R004", "B8" },
                    { "SE0259", "R004", "B9" },
                    { "SE0260", "R004", "B10" },
                    { "SE0261", "R004", "C1" },
                    { "SE0262", "R004", "C2" },
                    { "SE0263", "R004", "C3" },
                    { "SE0264", "R004", "C4" },
                    { "SE0265", "R004", "C5" },
                    { "SE0266", "R004", "C6" },
                    { "SE0267", "R004", "C7" },
                    { "SE0268", "R004", "C8" },
                    { "SE0269", "R004", "C9" },
                    { "SE0270", "R004", "C10" },
                    { "SE0271", "R004", "D1" },
                    { "SE0272", "R004", "D2" },
                    { "SE0273", "R004", "D3" },
                    { "SE0274", "R004", "D4" },
                    { "SE0275", "R004", "D5" },
                    { "SE0276", "R004", "D6" },
                    { "SE0277", "R004", "D7" },
                    { "SE0278", "R004", "D8" },
                    { "SE0279", "R004", "D9" },
                    { "SE0280", "R004", "D10" },
                    { "SE0281", "R004", "E1" },
                    { "SE0282", "R004", "E2" },
                    { "SE0283", "R004", "E3" },
                    { "SE0284", "R004", "E4" },
                    { "SE0285", "R004", "E5" },
                    { "SE0286", "R004", "E6" },
                    { "SE0287", "R004", "E7" },
                    { "SE0288", "R004", "E8" },
                    { "SE0289", "R004", "E9" },
                    { "SE0290", "R004", "E10" },
                    { "SE0291", "R004", "F1" },
                    { "SE0292", "R004", "F2" },
                    { "SE0293", "R004", "F3" },
                    { "SE0294", "R004", "F4" },
                    { "SE0295", "R004", "F5" },
                    { "SE0296", "R004", "F6" },
                    { "SE0297", "R004", "F7" },
                    { "SE0298", "R004", "F8" },
                    { "SE0299", "R004", "F9" },
                    { "SE0300", "R004", "F10" },
                    { "SE0301", "R004", "G1" },
                    { "SE0302", "R004", "G2" },
                    { "SE0303", "R004", "G3" },
                    { "SE0304", "R004", "G4" },
                    { "SE0305", "R004", "G5" },
                    { "SE0306", "R004", "G6" },
                    { "SE0307", "R004", "G7" },
                    { "SE0308", "R004", "G8" },
                    { "SE0309", "R004", "G9" },
                    { "SE0310", "R004", "G10" },
                    { "SE0311", "R004", "H1" },
                    { "SE0312", "R004", "H2" },
                    { "SE0313", "R004", "H3" },
                    { "SE0314", "R004", "H4" },
                    { "SE0315", "R004", "H5" },
                    { "SE0316", "R004", "H6" },
                    { "SE0317", "R004", "H7" },
                    { "SE0318", "R004", "H8" },
                    { "SE0319", "R004", "H9" },
                    { "SE0320", "R004", "H10" },
                    { "SE0321", "R005", "A1" },
                    { "SE0322", "R005", "A2" },
                    { "SE0323", "R005", "A3" },
                    { "SE0324", "R005", "A4" },
                    { "SE0325", "R005", "A5" },
                    { "SE0326", "R005", "A6" },
                    { "SE0327", "R005", "A7" },
                    { "SE0328", "R005", "A8" },
                    { "SE0329", "R005", "A9" },
                    { "SE0330", "R005", "A10" },
                    { "SE0331", "R005", "B1" },
                    { "SE0332", "R005", "B2" },
                    { "SE0333", "R005", "B3" },
                    { "SE0334", "R005", "B4" },
                    { "SE0335", "R005", "B5" },
                    { "SE0336", "R005", "B6" },
                    { "SE0337", "R005", "B7" },
                    { "SE0338", "R005", "B8" },
                    { "SE0339", "R005", "B9" },
                    { "SE0340", "R005", "B10" },
                    { "SE0341", "R005", "C1" },
                    { "SE0342", "R005", "C2" },
                    { "SE0343", "R005", "C3" },
                    { "SE0344", "R005", "C4" },
                    { "SE0345", "R005", "C5" },
                    { "SE0346", "R005", "C6" },
                    { "SE0347", "R005", "C7" },
                    { "SE0348", "R005", "C8" },
                    { "SE0349", "R005", "C9" },
                    { "SE0350", "R005", "C10" },
                    { "SE0351", "R005", "D1" },
                    { "SE0352", "R005", "D2" },
                    { "SE0353", "R005", "D3" },
                    { "SE0354", "R005", "D4" },
                    { "SE0355", "R005", "D5" },
                    { "SE0356", "R005", "D6" },
                    { "SE0357", "R005", "D7" },
                    { "SE0358", "R005", "D8" },
                    { "SE0359", "R005", "D9" },
                    { "SE0360", "R005", "D10" },
                    { "SE0361", "R005", "E1" },
                    { "SE0362", "R005", "E2" },
                    { "SE0363", "R005", "E3" },
                    { "SE0364", "R005", "E4" },
                    { "SE0365", "R005", "E5" },
                    { "SE0366", "R005", "E6" },
                    { "SE0367", "R005", "E7" },
                    { "SE0368", "R005", "E8" },
                    { "SE0369", "R005", "E9" },
                    { "SE0370", "R005", "E10" },
                    { "SE0371", "R005", "F1" },
                    { "SE0372", "R005", "F2" },
                    { "SE0373", "R005", "F3" },
                    { "SE0374", "R005", "F4" },
                    { "SE0375", "R005", "F5" },
                    { "SE0376", "R005", "F6" },
                    { "SE0377", "R005", "F7" },
                    { "SE0378", "R005", "F8" },
                    { "SE0379", "R005", "F9" },
                    { "SE0380", "R005", "F10" },
                    { "SE0381", "R005", "G1" },
                    { "SE0382", "R005", "G2" },
                    { "SE0383", "R005", "G3" },
                    { "SE0384", "R005", "G4" },
                    { "SE0385", "R005", "G5" },
                    { "SE0386", "R005", "G6" },
                    { "SE0387", "R005", "G7" },
                    { "SE0388", "R005", "G8" },
                    { "SE0389", "R005", "G9" },
                    { "SE0390", "R005", "G10" },
                    { "SE0391", "R005", "H1" },
                    { "SE0392", "R005", "H2" },
                    { "SE0393", "R005", "H3" },
                    { "SE0394", "R005", "H4" },
                    { "SE0395", "R005", "H5" },
                    { "SE0396", "R005", "H6" },
                    { "SE0397", "R005", "H7" },
                    { "SE0398", "R005", "H8" },
                    { "SE0399", "R005", "H9" },
                    { "SE0400", "R005", "H10" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3434), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3438), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3440), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3443), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3446), new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 16, 5, 21, 292, DateTimeKind.Utc).AddTicks(3618));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0001");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0002");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0003");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0004");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0005");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0006");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0007");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0008");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0009");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0010");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0011");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0012");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0013");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0014");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0015");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0016");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0017");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0018");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0019");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0020");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0021");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0022");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0023");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0024");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0025");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0026");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0027");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0028");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0029");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0030");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0031");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0032");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0033");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0034");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0035");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0036");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0037");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0038");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0039");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0040");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0041");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0042");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0043");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0044");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0045");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0046");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0047");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0048");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0049");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0050");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0051");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0052");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0053");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0054");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0055");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0056");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0057");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0058");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0059");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0060");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0061");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0062");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0063");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0064");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0065");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0066");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0067");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0068");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0069");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0070");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0071");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0072");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0073");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0074");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0075");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0076");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0077");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0078");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0079");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0080");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0081");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0082");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0083");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0084");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0085");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0086");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0087");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0088");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0089");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0090");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0091");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0092");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0093");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0094");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0095");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0096");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0097");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0098");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0099");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0100");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0101");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0102");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0103");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0104");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0105");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0106");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0107");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0108");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0109");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0110");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0111");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0112");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0113");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0114");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0115");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0116");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0117");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0118");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0119");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0120");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0121");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0122");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0123");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0124");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0125");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0126");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0127");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0128");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0129");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0130");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0131");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0132");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0133");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0134");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0135");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0136");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0137");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0138");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0139");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0140");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0141");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0142");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0143");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0144");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0145");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0146");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0147");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0148");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0149");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0150");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0151");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0152");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0153");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0154");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0155");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0156");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0157");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0158");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0159");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0160");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0161");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0162");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0163");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0164");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0165");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0166");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0167");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0168");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0169");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0170");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0171");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0172");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0173");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0174");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0175");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0176");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0177");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0178");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0179");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0180");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0181");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0182");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0183");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0184");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0185");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0186");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0187");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0188");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0189");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0190");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0191");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0192");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0193");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0194");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0195");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0196");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0197");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0198");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0199");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0200");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0201");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0202");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0203");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0204");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0205");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0206");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0207");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0208");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0209");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0210");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0211");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0212");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0213");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0214");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0215");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0216");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0217");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0218");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0219");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0220");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0221");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0222");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0223");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0224");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0225");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0226");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0227");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0228");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0229");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0230");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0231");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0232");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0233");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0234");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0235");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0236");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0237");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0238");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0239");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0240");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0241");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0242");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0243");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0244");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0245");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0246");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0247");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0248");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0249");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0250");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0251");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0252");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0253");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0254");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0255");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0256");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0257");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0258");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0259");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0260");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0261");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0262");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0263");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0264");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0265");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0266");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0267");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0268");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0269");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0270");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0271");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0272");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0273");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0274");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0275");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0276");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0277");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0278");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0279");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0280");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0281");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0282");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0283");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0284");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0285");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0286");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0287");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0288");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0289");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0290");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0291");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0292");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0293");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0294");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0295");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0296");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0297");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0298");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0299");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0300");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0301");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0302");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0303");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0304");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0305");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0306");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0307");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0308");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0309");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0310");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0311");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0312");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0313");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0314");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0315");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0316");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0317");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0318");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0319");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0320");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0321");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0322");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0323");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0324");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0325");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0326");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0327");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0328");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0329");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0330");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0331");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0332");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0333");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0334");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0335");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0336");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0337");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0338");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0339");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0340");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0341");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0342");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0343");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0344");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0345");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0346");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0347");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0348");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0349");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0350");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0351");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0352");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0353");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0354");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0355");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0356");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0357");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0358");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0359");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0360");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0361");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0362");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0363");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0364");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0365");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0366");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0367");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0368");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0369");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0370");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0371");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0372");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0373");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0374");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0375");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0376");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0377");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0378");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0379");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0380");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0381");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0382");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0383");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0384");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0385");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0386");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0387");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0388");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0389");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0390");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0391");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0392");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0393");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0394");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0395");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0396");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0397");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0398");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0399");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: "SE0400");

            migrationBuilder.AddColumn<string>(
                name: "SeatType",
                table: "Seats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShowtimeId",
                table: "Seats",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Seats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8072));

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
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7653), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7659), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7661), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7663), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7664), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7666), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7668), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7670), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7672), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7674), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7675), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7677), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7679), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7681), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7682), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7694), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7695), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7697), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7699), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7701), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7702), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7704), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7706), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7708), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7710), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM001",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8709), new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM002",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8723), new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM003",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8725), new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8726) });

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
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7859), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7863), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7866), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7869), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7872), new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 21, 13, 38, 5, 691, DateTimeKind.Utc).AddTicks(8028));

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

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "BookingId", "CreatedDate", "PaymentMethodId", "Status" },
                values: new object[,]
                {
                    { "PAY001", 120000.0, "BK001", new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8756), "PM001", "PAID" },
                    { "PAY002", 150000.0, "BK002", new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8759), "PM002", "PAID" }
                });

            migrationBuilder.InsertData(
                table: "SeatLocks",
                columns: new[] { "SeatLockId", "ExpiredAt", "LockedAt", "SeatId", "ShowtimeId", "UserId" },
                values: new object[,]
                {
                    { "SL001", new DateTime(2026, 6, 10, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 9, 50, 0, 0, DateTimeKind.Unspecified), "SE001", "ST001", "USR001" },
                    { "SL002", new DateTime(2026, 6, 10, 13, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 13, 20, 0, 0, DateTimeKind.Unspecified), "SE006", "ST002", "USR001" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ShowtimeId",
                table: "Seats",
                column: "ShowtimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Showtimes_ShowtimeId",
                table: "Seats",
                column: "ShowtimeId",
                principalTable: "Showtimes",
                principalColumn: "ShowtimeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
