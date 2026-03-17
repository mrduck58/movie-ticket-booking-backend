using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedBlogPostsAndComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "Content", "CreatedDate", "ImageUrl", "Likes", "Title", "UserId" },
                values: new object[,]
                {
                    { "BLOG001", "Marvel movies have changed the superhero genre forever...", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4530), "https://images.unsplash.com/photo-1", 120, "Top 10 Marvel Movies You Must Watch", "USR001" },
                    { "BLOG002", "Horror movies give audiences a thrilling experience...", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4532), "https://images.unsplash.com/photo-2", 85, "Why Horror Movies Are So Popular", "USR002" },
                    { "BLOG003", "Science fiction movies explore the future and technology...", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4533), "https://images.unsplash.com/photo-3", 95, "Best Sci-Fi Movies of the Decade", "USR003" },
                    { "BLOG004", "These romantic films will make your evening unforgettable...", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4535), "https://images.unsplash.com/photo-4", 60, "Romantic Movies Perfect for Date Night", "USR004" },
                    { "BLOG005", "Many exciting movies are coming to theaters next year...", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4536), "https://images.unsplash.com/photo-5", 150, "Upcoming Blockbusters in 2026", "USR005" }
                });

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

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "BlogPostId", "Content", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { "CMT001", "BLOG001", "Great list! I love Marvel movies.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4561), "USR002" },
                    { "CMT002", "BLOG001", "Avengers Endgame is my favorite.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4563), "USR003" },
                    { "CMT003", "BLOG001", "Nice recommendations!", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4564), "USR004" },
                    { "CMT004", "BLOG002", "Horror movies are so thrilling!", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4566), "USR001" },
                    { "CMT005", "BLOG002", "The Conjuring series is amazing.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4567), "USR005" },
                    { "CMT006", "BLOG002", "I love watching horror at night.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4568), "USR003" },
                    { "CMT007", "BLOG003", "Interstellar is a masterpiece.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4570), "USR001" },
                    { "CMT008", "BLOG003", "Sci-Fi movies inspire imagination.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4571), "USR002" },
                    { "CMT009", "BLOG003", "I love futuristic technology.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4572), "USR005" },
                    { "CMT010", "BLOG004", "Perfect movies for couples.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4574), "USR003" },
                    { "CMT011", "BLOG004", "Titanic will always be iconic.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4575), "USR002" },
                    { "CMT012", "BLOG004", "Romantic movies are emotional.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4576), "USR001" },
                    { "CMT013", "BLOG005", "Can't wait for next year's movies!", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4578), "USR004" },
                    { "CMT014", "BLOG005", "So many exciting releases.", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4579), "USR003" },
                    { "CMT015", "BLOG005", "Hope Marvel releases new films!", new DateTime(2026, 3, 16, 6, 27, 16, 36, DateTimeKind.Utc).AddTicks(4581), "USR002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1254), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1258), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1260), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1262), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1264), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1265), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1267), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1268), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1270), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1271), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1273), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1275), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1276), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1278), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1279), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1281), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1282), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1284), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1285), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1287), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1288), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1290), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1291), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1293), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1294), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1420), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1424), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1426), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1429), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1431), new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 16, 6, 21, 45, 251, DateTimeKind.Utc).AddTicks(1566));
        }
    }
}
