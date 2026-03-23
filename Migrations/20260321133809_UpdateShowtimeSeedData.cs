using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateShowtimeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 21, 20, 38, 5, 691, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R001",
                column: "Name",
                value: "Auditorium 1");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R002",
                column: "Name",
                value: "Auditorium 2");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R003",
                columns: new[] { "CinemaId", "Name" },
                values: new object[] { "C001", "Auditorium 3" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R004",
                columns: new[] { "CinemaId", "Name" },
                values: new object[] { "C001", "Auditorium 4" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R005",
                columns: new[] { "CinemaId", "Name" },
                values: new object[] { "C001", "Auditorium 5" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "CinemaId", "Name" },
                values: new object[,]
                {
                    { "R006", "C002", "Auditorium 1" },
                    { "R007", "C002", "Auditorium 2" },
                    { "R008", "C002", "Auditorium 3" },
                    { "R009", "C002", "Auditorium 4" },
                    { "R010", "C002", "Auditorium 5" },
                    { "R011", "C003", "Auditorium 1" },
                    { "R012", "C003", "Auditorium 2" },
                    { "R013", "C003", "Auditorium 3" },
                    { "R014", "C003", "Auditorium 4" },
                    { "R015", "C003", "Auditorium 5" }
                });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT001",
                column: "Price",
                value: 120000.0);

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT002",
                columns: new[] { "ShowtimeId", "TicketTypeId" },
                values: new object[] { "ST002", "TT001" });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT003",
                columns: new[] { "Price", "ShowtimeId" },
                values: new object[] { 120000.0, "ST003" });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT004",
                columns: new[] { "Price", "ShowtimeId", "TicketTypeId" },
                values: new object[] { 120000.0, "ST004", "TT001" });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT005",
                columns: new[] { "Price", "ShowtimeId", "TicketTypeId" },
                values: new object[] { 170000.0, "ST005", "TT002" });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT006",
                columns: new[] { "Price", "ShowtimeId" },
                values: new object[] { 170000.0, "ST006" });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST001",
                column: "EndTime",
                value: new DateTime(2026, 6, 10, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST002",
                columns: new[] { "EndTime", "MovieId", "RoomId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), "MOV001", "R001", new DateTime(2026, 6, 10, 12, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST003",
                columns: new[] { "EndTime", "MovieId", "RoomId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", "R001", new DateTime(2026, 6, 10, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST004",
                columns: new[] { "EndTime", "MovieId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 10, 19, 30, 0, 0, DateTimeKind.Unspecified), "MOV001", new DateTime(2026, 6, 10, 17, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST005",
                columns: new[] { "EndTime", "MovieId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", new DateTime(2026, 6, 10, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST006",
                columns: new[] { "EndTime", "MovieId", "RoomId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", "R002", new DateTime(2026, 6, 10, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Showtimes",
                columns: new[] { "ShowtimeId", "CreatedAt", "EndTime", "MovieId", "RoomId", "StartTime", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { "ST007", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", "R003", new DateTime(2026, 6, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST008", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", "R001", new DateTime(2026, 6, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST009", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 23, 14, 30, 0, 0, DateTimeKind.Unspecified), "MOV001", "R001", new DateTime(2026, 6, 23, 12, 30, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST010", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", "R002", new DateTime(2026, 6, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST011", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", "R003", new DateTime(2026, 6, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST012", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", "R001", new DateTime(2026, 6, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST013", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", "R002", new DateTime(2026, 6, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST014", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), "MOV001", "R003", new DateTime(2026, 6, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: "TT002",
                column: "Name",
                value: "IMAX");

            migrationBuilder.UpdateData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: "TT003",
                column: "Name",
                value: "Dolby Cinema");

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
                table: "ShowtimeTicketTypes",
                columns: new[] { "ShowtimeTicketTypeId", "Price", "ShowtimeId", "TicketTypeId" },
                values: new object[,]
                {
                    { "STT007", 220000.0, "ST007", "TT003" },
                    { "STT008", 120000.0, "ST008", "TT001" },
                    { "STT009", 120000.0, "ST009", "TT001" },
                    { "STT010", 170000.0, "ST010", "TT002" },
                    { "STT011", 220000.0, "ST011", "TT003" },
                    { "STT012", 120000.0, "ST012", "TT001" },
                    { "STT013", 170000.0, "ST013", "TT002" },
                    { "STT014", 220000.0, "ST014", "TT003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R006");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R007");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R008");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R009");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R010");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R011");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R012");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R013");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R014");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R015");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT007");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT008");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT009");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT010");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT011");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT012");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT013");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT014");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST007");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST008");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST009");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST010");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST011");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST012");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST013");

            migrationBuilder.DeleteData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST014");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1553), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1558), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1561), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1566), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1568), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1571), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1573), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1576), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1578), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1581), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1583), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1585), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1588), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1590), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1593), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1595), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1598), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1600), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1602), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1605), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1619), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1622), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1624), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1627), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1629), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM001",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2853), new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM002",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2866), new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM003",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2869), new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R001",
                column: "Name",
                value: "Room 1");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R002",
                column: "Name",
                value: "Room 2");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R003",
                columns: new[] { "CinemaId", "Name" },
                values: new object[] { "C002", "Room 1" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R004",
                columns: new[] { "CinemaId", "Name" },
                values: new object[] { "C002", "Room 2" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: "R005",
                columns: new[] { "CinemaId", "Name" },
                values: new object[] { "C003", "Room 1" });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT001",
                column: "Price",
                value: 80000.0);

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT002",
                columns: new[] { "ShowtimeId", "TicketTypeId" },
                values: new object[] { "ST001", "TT002" });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT003",
                columns: new[] { "Price", "ShowtimeId" },
                values: new object[] { 85000.0, "ST002" });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT004",
                columns: new[] { "Price", "ShowtimeId", "TicketTypeId" },
                values: new object[] { 125000.0, "ST002", "TT002" });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT005",
                columns: new[] { "Price", "ShowtimeId", "TicketTypeId" },
                values: new object[] { 90000.0, "ST003", "TT001" });

            migrationBuilder.UpdateData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT006",
                columns: new[] { "Price", "ShowtimeId" },
                values: new object[] { 130000.0, "ST003" });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST001",
                column: "EndTime",
                value: new DateTime(2026, 6, 10, 13, 1, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST002",
                columns: new[] { "EndTime", "MovieId", "RoomId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 10, 15, 58, 0, 0, DateTimeKind.Unspecified), "MOV002", "R002", new DateTime(2026, 6, 10, 13, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST003",
                columns: new[] { "EndTime", "MovieId", "RoomId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 10, 19, 26, 0, 0, DateTimeKind.Unspecified), "MOV003", "R003", new DateTime(2026, 6, 10, 16, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST004",
                columns: new[] { "EndTime", "MovieId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 10, 22, 6, 0, 0, DateTimeKind.Unspecified), "MOV004", new DateTime(2026, 6, 10, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST005",
                columns: new[] { "EndTime", "MovieId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 11, 13, 12, 0, 0, DateTimeKind.Unspecified), "MOV009", new DateTime(2026, 6, 11, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Showtimes",
                keyColumn: "ShowtimeId",
                keyValue: "ST006",
                columns: new[] { "EndTime", "MovieId", "RoomId", "StartTime" },
                values: new object[] { new DateTime(2026, 6, 11, 16, 11, 0, 0, DateTimeKind.Unspecified), "MOV010", "R003", new DateTime(2026, 6, 11, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: "TT002",
                column: "Name",
                value: "VIP");

            migrationBuilder.UpdateData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: "TT003",
                column: "Name",
                value: "Couple");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1819), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1825), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1829), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1832), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1836), new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2056));
        }
    }
}
