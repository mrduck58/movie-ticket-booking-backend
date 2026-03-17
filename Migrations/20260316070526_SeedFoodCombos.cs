using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedFoodCombos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "FoodCombos",
                columns: new[] { "FoodComboId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "FC001", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Large Popcorn + 1 Coke", "https://example.com/images/combo_popcorn_coke.jpg", "Popcorn + Coke", 75000.0, "ACTIVE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "FC002", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Large Popcorn + 2 Drinks", "https://example.com/images/combo_couple.jpg", "Couple Combo", 120000.0, "ACTIVE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "FC003", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 Large Popcorn + 4 Drinks", "https://example.com/images/combo_family.jpg", "Family Combo", 200000.0, "ACTIVE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "FC004", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nachos + 1 Coke", "https://example.com/images/combo_nachos.jpg", "Nachos Combo", 85000.0, "ACTIVE", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC001");

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC002");

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC003");

            migrationBuilder.DeleteData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC004");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9001), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9010), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9012), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9014), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9016), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9018), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9019), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9021), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9026), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9028), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9029), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9031), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9032), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9034), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9036), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9037), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9039), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9040), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9042), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9043), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9045), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9047), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9048), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9050), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9051), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9173), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9176), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9179), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9181), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9185), new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 7, 3, 21, 687, DateTimeKind.Utc).AddTicks(9326));
        }
    }
}
