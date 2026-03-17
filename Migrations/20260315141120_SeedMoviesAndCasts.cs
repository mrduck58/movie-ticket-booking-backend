using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoviesAndCasts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "CastId", "AvatarUrl", "Name" },
                values: new object[,]
                {
                    { "CAST001", "https://image.tmdb.org/t/p/w500/rdj.jpg", "Robert Downey Jr." },
                    { "CAST002", "https://image.tmdb.org/t/p/w500/cevans.jpg", "Chris Evans" },
                    { "CAST003", "https://image.tmdb.org/t/p/w500/scarlett.jpg", "Scarlett Johansson" },
                    { "CAST004", "https://image.tmdb.org/t/p/w500/tomholland.jpg", "Tom Holland" },
                    { "CAST005", "https://image.tmdb.org/t/p/w500/zendaya.jpg", "Zendaya" },
                    { "CAST006", "https://image.tmdb.org/t/p/w500/pattinson.jpg", "Robert Pattinson" },
                    { "CAST007", "https://image.tmdb.org/t/p/w500/zoe.jpg", "Zoë Kravitz" },
                    { "CAST008", "https://image.tmdb.org/t/p/w500/cumberbatch.jpg", "Benedict Cumberbatch" },
                    { "CAST009", "https://image.tmdb.org/t/p/w500/olsen.jpg", "Elizabeth Olsen" },
                    { "CAST010", "https://image.tmdb.org/t/p/w500/reynolds.jpg", "Ryan Reynolds" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CreatedAt", "Description", "Duration", "Rating", "Status", "Title", "TrailerUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { "MOV001", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Avengers assemble for the final battle against Thanos.", 181.0, 8.4000000000000004, "NOWSHOWING", "Avengers: Endgame", "https://www.youtube.com/watch?v=TcMBFSGVi1c", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV002", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man faces villains from different universes.", 148.0, 8.1999999999999993, "NOWSHOWING", "Spider-Man: No Way Home", "https://www.youtube.com/watch?v=JfVOs4VSpmA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV003", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman investigates corruption in Gotham.", 176.0, 7.9000000000000004, "NOWSHOWING", "The Batman", "https://www.youtube.com/watch?v=mqqft2x_Aa4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV004", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor Strange explores the multiverse.", 126.0, 7.0, "NOWSHOWING", "Doctor Strange in the Multiverse of Madness", "https://www.youtube.com/watch?v=aWzlQ2N6qqg", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV005", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deadpool meets Wolverine in a chaotic adventure.", 130.0, 0.0, "COMINGSOON", "Deadpool & Wolverine", "https://www.youtube.com/watch?v=73_1biulkYk", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV006", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur Fleck continues his descent into madness.", 138.0, 0.0, "COMINGSOON", "Joker: Folie à Deux", "https://www.youtube.com/watch?v=xy8aJw1vYHo", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV007", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Po trains a new dragon warrior.", 95.0, 0.0, "COMINGSOON", "Kung Fu Panda 4", "https://www.youtube.com/watch?v=_inKs4eeHiI", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV008", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan Hunt returns for his most dangerous mission.", 160.0, 0.0, "COMINGSOON", "Mission Impossible 8", "https://www.youtube.com/watch?v=avz06PDqDbM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV009", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jake Sully protects his family on Pandora.", 192.0, 7.7000000000000002, "NOWSHOWING", "Avatar: The Way of Water", "https://www.youtube.com/watch?v=d9MyW72ELq0", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV010", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maverick trains a new generation of pilots.", 131.0, 8.3000000000000007, "NOWSHOWING", "Top Gun: Maverick", "https://www.youtube.com/watch?v=giXco2jaZ_4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MovieCasts",
                columns: new[] { "CastId", "MovieId", "CharacterAvatar", "CharacterName" },
                values: new object[,]
                {
                    { "CAST001", "MOV001", "", "Iron Man" },
                    { "CAST002", "MOV001", "", "Captain America" },
                    { "CAST003", "MOV001", "", "Black Widow" },
                    { "CAST004", "MOV002", "", "Spider-Man" },
                    { "CAST005", "MOV002", "", "MJ" },
                    { "CAST006", "MOV003", "", "Batman" },
                    { "CAST007", "MOV003", "", "Catwoman" },
                    { "CAST008", "MOV004", "", "Doctor Strange" },
                    { "CAST009", "MOV004", "", "Scarlet Witch" },
                    { "CAST010", "MOV005", "", "Deadpool" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST001", "MOV001" });

            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST002", "MOV001" });

            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST003", "MOV001" });

            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST004", "MOV002" });

            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST005", "MOV002" });

            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST006", "MOV003" });

            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST007", "MOV003" });

            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST008", "MOV004" });

            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST009", "MOV004" });

            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastId", "MovieId" },
                keyValues: new object[] { "CAST010", "MOV005" });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV006");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV007");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV008");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV009");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV010");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST001");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST002");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST003");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST004");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST005");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST006");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST007");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST008");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST009");

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "CastId",
                keyValue: "CAST010");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV001");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV002");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV003");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV004");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: "MOV005");
        }
    }
}
