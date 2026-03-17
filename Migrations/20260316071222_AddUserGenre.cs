using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddUserGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserGenres",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGenres", x => new { x.UserId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_UserGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserGenres_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserGenres_GenreId",
                table: "UserGenres",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGenres");
        }
    }
}
