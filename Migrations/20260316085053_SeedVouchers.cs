using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedVouchers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "VoucherId", "Code", "CreatedDate", "Description", "ExpiredDate", "Status", "Title", "Value" },
                values: new object[,]
                {
                    { "VC001", "WELCOME10", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10% discount for new users", new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACTIVE", "Welcome Discount", 10.0 },
                    { "VC002", "MOVIE50K", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get 50,000 VND discount on booking", new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACTIVE", "50K Off", 50000.0 },
                    { "VC003", "WEEKEND20", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "20% off for weekend bookings", new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACTIVE", "Weekend Discount", 20.0 },
                    { "VC004", "STUDENT15", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15% discount for students", new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACTIVE", "Student Offer", 15.0 },
                    { "VC005", "COMBO30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "30% off when buying food combo", new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACTIVE", "Combo Discount", 30.0 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherId",
                keyValue: "VC001");

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherId",
                keyValue: "VC002");

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherId",
                keyValue: "VC003");

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherId",
                keyValue: "VC004");

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherId",
                keyValue: "VC005");

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
        }
    }
}
