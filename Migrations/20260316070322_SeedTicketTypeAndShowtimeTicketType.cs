using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedTicketTypeAndShowtimeTicketType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Name", "Status" },
                values: new object[,]
                {
                    { "TT001", "Standard", "ACTIVE" },
                    { "TT002", "VIP", "ACTIVE" },
                    { "TT003", "Couple", "ACTIVE" }
                });

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

            migrationBuilder.InsertData(
                table: "ShowtimeTicketTypes",
                columns: new[] { "ShowtimeTicketTypeId", "Price", "ShowtimeId", "TicketTypeId" },
                values: new object[,]
                {
                    { "STT001", 80000.0, "ST001", "TT001" },
                    { "STT002", 120000.0, "ST001", "TT002" },
                    { "STT003", 85000.0, "ST002", "TT001" },
                    { "STT004", 125000.0, "ST002", "TT002" },
                    { "STT005", 90000.0, "ST003", "TT001" },
                    { "STT006", 130000.0, "ST003", "TT002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT001");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT002");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT003");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT004");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT005");

            migrationBuilder.DeleteData(
                table: "ShowtimeTicketTypes",
                keyColumn: "ShowtimeTicketTypeId",
                keyValue: "STT006");

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: "TT003");

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: "TT001");

            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "TicketTypeId",
                keyValue: "TT002");

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
    }
}
