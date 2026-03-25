using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddTypeNotifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: "BLOG005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT003",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT004",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT005",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT006",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT007",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT008",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT009",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT010",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT011",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT012",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT013",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT014",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: "CMT015",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(489), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(493), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(494), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(495), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(496), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN006",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(497), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN007",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(498), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN008",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(499), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN009",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(500), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN010",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(502), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN011",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(503), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN012",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(504), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN013",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(505), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN014",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(506), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN015",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(507), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN016",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(508), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN017",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(509), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN018",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(510), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN019",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(511), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN020",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(512), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN021",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(513), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN022",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(514), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN023",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(515), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN024",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(516), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "GEN025",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(517), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM001",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 23, 42, 35, 548, DateTimeKind.Local).AddTicks(1387), new DateTime(2026, 3, 23, 23, 42, 35, 548, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM002",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 23, 42, 35, 548, DateTimeKind.Local).AddTicks(1397), new DateTime(2026, 3, 23, 23, 42, 35, 548, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM003",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 23, 23, 42, 35, 548, DateTimeKind.Local).AddTicks(1399), new DateTime(2026, 3, 23, 23, 42, 35, 548, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY001",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 23, 42, 35, 548, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "PAY002",
                column: "CreatedDate",
                value: new DateTime(2026, 3, 23, 23, 42, 35, 548, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR001",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(676), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR002",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(679), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR003",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(680), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR004",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(682), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USR005",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(684), new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL001",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL002",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL003",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL004",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL005",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL006",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL007",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL008",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL009",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "WatchLists",
                keyColumn: "WatchListId",
                keyValue: "WL010",
                column: "CreatedAt",
                value: new DateTime(2026, 3, 23, 16, 42, 35, 548, DateTimeKind.Utc).AddTicks(849));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Notifications");

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
