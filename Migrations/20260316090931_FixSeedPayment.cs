using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8433), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8437), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8438), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8439), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8440), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8441), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8442), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8443), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8444), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8445), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8446), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8447), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8448), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8449), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8450), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8451), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8452), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8453), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8454), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8455), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8457), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8458), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8459), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8460), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8461), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8462) });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "PaymentMethodId", "CreatedDate", "ImageUrl", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "PM001", new DateTime(2026, 3, 16, 16, 9, 31, 360, DateTimeKind.Local).AddTicks(9033), "https://example.com/creditcard.png", "Credit Card", "ACTIVE", new DateTime(2026, 3, 16, 16, 9, 31, 360, DateTimeKind.Local).AddTicks(9041) },
                    { "PM002", new DateTime(2026, 3, 16, 16, 9, 31, 360, DateTimeKind.Local).AddTicks(9042), "https://example.com/momo.png", "Momo", "ACTIVE", new DateTime(2026, 3, 16, 16, 9, 31, 360, DateTimeKind.Local).AddTicks(9043) },
                    { "PM003", new DateTime(2026, 3, 16, 16, 9, 31, 360, DateTimeKind.Local).AddTicks(9044), "https://example.com/zalopay.png", "ZaloPay", "ACTIVE", new DateTime(2026, 3, 16, 16, 9, 31, 360, DateTimeKind.Local).AddTicks(9044) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8541), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8543), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8545), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8547), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8549), new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 9, 9, 31, 360, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "BookingId", "CreatedDate", "PaymentMethodId", "Status" },
                values: new object[,]
                {
                    { "PAY001", 120000.0, "BK001", new DateTime(2026, 3, 16, 16, 9, 31, 360, DateTimeKind.Local).AddTicks(9059), "PM001", "PAID" },
                    { "PAY002", 150000.0, "BK002", new DateTime(2026, 3, 16, 16, 9, 31, 360, DateTimeKind.Local).AddTicks(9067), "PM002", "PAID" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM003");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY001");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY002");

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM001");

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM002");

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
        }
    }
}
