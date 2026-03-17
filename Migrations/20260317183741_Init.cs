using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    CastId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.CastId);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    CinemaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hotline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.CinemaId);
                });

            migrationBuilder.CreateTable(
                name: "FoodCombos",
                columns: table => new
                {
                    FoodComboId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCombos", x => x.FoodComboId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleVn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    PaymentMethodId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "TicketTypes",
                columns: table => new
                {
                    TicketTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTypes", x => x.TicketTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    VoucherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.VoucherId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CinemaId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "CinemaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieCasts",
                columns: table => new
                {
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CastId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CharacterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterAvatar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCasts", x => new { x.MovieId, x.CastId });
                    table.ForeignKey(
                        name: "FK_MovieCasts_Casts_CastId",
                        column: x => x.CastId,
                        principalTable: "Casts",
                        principalColumn: "CastId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieCasts_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => new { x.MovieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posters",
                columns: table => new
                {
                    PosterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posters", x => x.PosterId);
                    table.ForeignKey(
                        name: "FK_Posters_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Showtimes",
                columns: table => new
                {
                    ShowtimeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Showtimes", x => x.ShowtimeId);
                    table.ForeignKey(
                        name: "FK_Showtimes_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Showtimes_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    BlogPostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogPostId);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieRatings",
                columns: table => new
                {
                    MovieRatingId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieRatings", x => x.MovieRatingId);
                    table.ForeignKey(
                        name: "FK_MovieRatings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "WatchLists",
                columns: table => new
                {
                    WatchListId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MovieId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchLists", x => x.WatchListId);
                    table.ForeignKey(
                        name: "FK_WatchLists_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WatchLists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShowtimeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_Showtimes_ShowtimeId",
                        column: x => x.ShowtimeId,
                        principalTable: "Showtimes",
                        principalColumn: "ShowtimeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    SeatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SeatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShowtimeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_Seats_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seats_Showtimes_ShowtimeId",
                        column: x => x.ShowtimeId,
                        principalTable: "Showtimes",
                        principalColumn: "ShowtimeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShowtimeTicketTypes",
                columns: table => new
                {
                    ShowtimeTicketTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShowtimeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TicketTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowtimeTicketTypes", x => x.ShowtimeTicketTypeId);
                    table.ForeignKey(
                        name: "FK_ShowtimeTicketTypes_Showtimes_ShowtimeId",
                        column: x => x.ShowtimeId,
                        principalTable: "Showtimes",
                        principalColumn: "ShowtimeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShowtimeTicketTypes_TicketTypes_TicketTypeId",
                        column: x => x.TicketTypeId,
                        principalTable: "TicketTypes",
                        principalColumn: "TicketTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BlogPostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingFoodCombos",
                columns: table => new
                {
                    BookingFoodComboId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FoodComboId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingFoodCombos", x => x.BookingFoodComboId);
                    table.ForeignKey(
                        name: "FK_BookingFoodCombos_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingFoodCombos_FoodCombos_FoodComboId",
                        column: x => x.FoodComboId,
                        principalTable: "FoodCombos",
                        principalColumn: "FoodComboId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingVouchers",
                columns: table => new
                {
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VoucherId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingVouchers", x => new { x.BookingId, x.VoucherId });
                    table.ForeignKey(
                        name: "FK_BookingVouchers_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingVouchers_Vouchers_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Vouchers",
                        principalColumn: "VoucherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentMethodId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "PaymentMethodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeatLocks",
                columns: table => new
                {
                    SeatLockId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShowtimeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SeatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LockedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiredAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatLocks", x => x.SeatLockId);
                    table.ForeignKey(
                        name: "FK_SeatLocks_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeatLocks_Showtimes_ShowtimeId",
                        column: x => x.ShowtimeId,
                        principalTable: "Showtimes",
                        principalColumn: "ShowtimeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeatLocks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingSeats",
                columns: table => new
                {
                    BookingSeatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SeatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShowtimeTicketTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    QrCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckinTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingSeats", x => x.BookingSeatId);
                    table.ForeignKey(
                        name: "FK_BookingSeats_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingSeats_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingSeats_ShowtimeTicketTypes_ShowtimeTicketTypeId",
                        column: x => x.ShowtimeTicketTypeId,
                        principalTable: "ShowtimeTicketTypes",
                        principalColumn: "ShowtimeTicketTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WatchListId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlogPostId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CommentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookingSeatId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Notifications_BookingSeats_BookingSeatId",
                        column: x => x.BookingSeatId,
                        principalTable: "BookingSeats",
                        principalColumn: "BookingSeatId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Notifications_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_WatchLists_WatchListId",
                        column: x => x.WatchListId,
                        principalTable: "WatchLists",
                        principalColumn: "WatchListId",
                        onDelete: ReferentialAction.SetNull);
                });

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
                table: "Cinemas",
                columns: new[] { "CinemaId", "CreatedAt", "Hotline", "Location", "Name", "Rating", "UpdatedAt" },
                values: new object[,]
                {
                    { "C001", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "19006017", "Ha Noi", "CGV Vincom Ba Trieu", "4.5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "C002", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1900558899", "Ha Noi", "Lotte Cinema Landmark", "4.6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "C003", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "19002099", "Ha Noi", "BHD Star Pham Ngoc Thach", "4.4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "GEN001", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1553), "Action", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1556) },
                    { "GEN002", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1558), "Adventure", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1559) },
                    { "GEN003", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1561), "Animation", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1561) },
                    { "GEN004", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1566), "Biography", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1567) },
                    { "GEN005", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1568), "Comedy", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1569) },
                    { "GEN006", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1571), "Crime", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1572) },
                    { "GEN007", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1573), "Documentary", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1574) },
                    { "GEN008", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1576), "Drama", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1577) },
                    { "GEN009", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1578), "Family", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1579) },
                    { "GEN010", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1581), "Fantasy", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1581) },
                    { "GEN011", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1583), "History", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1584) },
                    { "GEN012", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1585), "Horror", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1586) },
                    { "GEN013", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1588), "Music", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1588) },
                    { "GEN014", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1590), "Mystery", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1591) },
                    { "GEN015", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1593), "Romance", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1594) },
                    { "GEN016", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1595), "Sci-Fi", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1596) },
                    { "GEN017", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1598), "Sport", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1598) },
                    { "GEN018", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1600), "Thriller", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1601) },
                    { "GEN019", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1602), "War", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1603) },
                    { "GEN020", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1605), "Western", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1606) },
                    { "GEN021", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1619), "Superhero", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1620) },
                    { "GEN022", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1622), "Psychological", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1623) },
                    { "GEN023", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1624), "Anime", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1625) },
                    { "GEN024", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1627), "Disaster", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1627) },
                    { "GEN025", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1629), "Martial Arts", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1630) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CreatedAt", "Description", "Director", "Duration", "Rating", "Status", "Title", "TitleVn", "TrailerUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { "MOV001", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Avengers assemble for the final battle against Thanos.", "Anthony Russo, Joe Russo", 181.0, 8.4000000000000004, "NOWSHOWING", "Avengers: Endgame", "Biệt Đội Siêu Anh Hùng: Hồi Kết", "https://www.youtube.com/watch?v=TcMBFSGVi1c", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV002", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man faces villains from different universes.", "Jon Watts", 148.0, 8.1999999999999993, "NOWSHOWING", "Spider-Man: No Way Home", "Người Nhện: Không Còn Nhà", "https://www.youtube.com/watch?v=JfVOs4VSpmA", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV003", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman investigates corruption in Gotham.", "d8", 176.0, 7.9000000000000004, "NOWSHOWING", "The Batman", "Người Dơi", "https://www.youtube.com/watch?v=mqqft2x_Aa4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV004", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor Strange explores the multiverse.", "d7", 126.0, 7.0, "NOWSHOWING", "Doctor Strange in the Multiverse of Madness", "Phù Thủy Tối Thượng: Đa Vũ Trụ Hỗn Loạn", "https://www.youtube.com/watch?v=aWzlQ2N6qqg", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV005", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deadpool meets Wolverine in a chaotic adventure.", "d6", 130.0, 0.0, "COMINGSOON", "Deadpool & Wolverine", "Deadpool & Wolverine", "https://www.youtube.com/watch?v=73_1biulkYk", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV006", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur Fleck continues his descent into madness.", "d5", 138.0, 0.0, "COMINGSOON", "Joker: Folie à Deux", "Joker: Điên Cuồng Hai Người", "https://www.youtube.com/watch?v=xy8aJw1vYHo", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV007", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Po trains a new dragon warrior.", "d4", 95.0, 0.0, "COMINGSOON", "Kung Fu Panda 4", "Kung Fu Panda 4", "https://www.youtube.com/watch?v=_inKs4eeHiI", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV008", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethan Hunt returns for his most dangerous mission.", "d3", 160.0, 0.0, "COMINGSOON", "Mission Impossible 8", "Nhiệm Vụ Bất Khả Thi 8", "https://www.youtube.com/watch?v=avz06PDqDbM", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV009", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jake Sully protects his family on Pandora.", "d2", 192.0, 7.7000000000000002, "NOWSHOWING", "Avatar: The Way of Water", "Avatar: Dòng Chảy Của Nước", "https://www.youtube.com/watch?v=d9MyW72ELq0", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "MOV010", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maverick trains a new generation of pilots.", "d1", 131.0, 8.3000000000000007, "NOWSHOWING", "Top Gun: Maverick", "Top Gun: Maverick", "https://www.youtube.com/watch?v=giXco2jaZ_4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "PaymentMethodId", "CreatedDate", "ImageUrl", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "PM001", new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2853), "https://example.com/creditcard.png", "Credit Card", "ACTIVE", new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2863) },
                    { "PM002", new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2866), "https://example.com/momo.png", "Momo", "ACTIVE", new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2867) },
                    { "PM003", new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2869), "https://example.com/zalopay.png", "ZaloPay", "ACTIVE", new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2870) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { "ROLE001", "ADMIN" },
                    { "ROLE002", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "TicketTypeId", "Name", "Status" },
                values: new object[,]
                {
                    { "TT001", "Standard", "ACTIVE" },
                    { "TT002", "VIP", "ACTIVE" },
                    { "TT003", "Couple", "ACTIVE" }
                });

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

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { "GEN001", "MOV001" },
                    { "GEN016", "MOV001" },
                    { "GEN021", "MOV001" },
                    { "GEN002", "MOV002" },
                    { "GEN010", "MOV002" },
                    { "GEN008", "MOV003" },
                    { "GEN015", "MOV003" },
                    { "GEN012", "MOV004" },
                    { "GEN018", "MOV004" },
                    { "GEN005", "MOV005" },
                    { "GEN009", "MOV005" },
                    { "GEN016", "MOV006" },
                    { "GEN018", "MOV006" },
                    { "GEN001", "MOV007" },
                    { "GEN002", "MOV007" },
                    { "GEN003", "MOV008" },
                    { "GEN023", "MOV008" },
                    { "GEN004", "MOV009" },
                    { "GEN008", "MOV009" },
                    { "GEN018", "MOV010" },
                    { "GEN024", "MOV010" }
                });

            migrationBuilder.InsertData(
                table: "Posters",
                columns: new[] { "PosterId", "ImageUrl", "MovieId", "Title" },
                values: new object[,]
                {
                    { "POS001", "https://image.tmdb.org/t/p/w500/1.jpg", "MOV001", "Avengers Poster" },
                    { "POS002", "https://image.tmdb.org/t/p/w500/2.jpg", "MOV002", "Batman Poster" },
                    { "POS003", "https://image.tmdb.org/t/p/w500/3.jpg", "MOV003", "Titanic Poster" },
                    { "POS004", "https://image.tmdb.org/t/p/w500/4.jpg", "MOV004", "Conjuring Poster" },
                    { "POS005", "https://image.tmdb.org/t/p/w500/5.jpg", "MOV005", "Minions Poster" },
                    { "POS006", "https://image.tmdb.org/t/p/w500/6.jpg", "MOV006", "Interstellar Poster" },
                    { "POS007", "https://image.tmdb.org/t/p/w500/7.jpg", "MOV007", "Fast X Poster" },
                    { "POS008", "https://image.tmdb.org/t/p/w500/8.jpg", "MOV008", "Demon Slayer Poster" },
                    { "POS009", "https://image.tmdb.org/t/p/w500/9.jpg", "MOV009", "Oppenheimer Poster" },
                    { "POS010", "https://image.tmdb.org/t/p/w500/10.jpg", "MOV010", "2012 Poster" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "CinemaId", "Name" },
                values: new object[,]
                {
                    { "R001", "C001", "Room 1" },
                    { "R002", "C001", "Room 2" },
                    { "R003", "C002", "Room 1" },
                    { "R004", "C002", "Room 2" },
                    { "R005", "C003", "Room 1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AvatarUrl", "CreatedAt", "DateOfBirth", "Email", "FullName", "PasswordHash", "Phone", "RoleId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { "USR001", "https://i.pravatar.cc/150?img=1", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1819), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@example.com", "John Smith", "123456", "0900000001", "ROLE002", "ACTIVE", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1820) },
                    { "USR002", "https://i.pravatar.cc/150?img=2", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1825), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma@example.com", "Emma Watson", "123456", "0900000002", "ROLE002", "ACTIVE", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1826) },
                    { "USR003", "https://i.pravatar.cc/150?img=3", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1829), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "robert@example.com", "Robert Downey Jr", "123456", "0900000003", "ROLE002", "ACTIVE", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1829) },
                    { "USR004", "https://i.pravatar.cc/150?img=4", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1832), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "scarlett@example.com", "Scarlett Johansson", "123456", "0900000004", "ROLE002", "ACTIVE", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1833) },
                    { "USR005", "https://i.pravatar.cc/150?img=5", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1836), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chris@example.com", "Chris Evans", "123456", "0900000005", "ROLE002", "ACTIVE", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(1837) }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogPostId", "Content", "CreatedDate", "ImageUrl", "Likes", "Title", "UserId" },
                values: new object[,]
                {
                    { "BLOG001", "Marvel movies have changed the superhero genre forever...", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2106), "https://images.unsplash.com/photo-1", 120, "Top 10 Marvel Movies You Must Watch", "USR001" },
                    { "BLOG002", "Horror movies give audiences a thrilling experience...", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2111), "https://images.unsplash.com/photo-2", 85, "Why Horror Movies Are So Popular", "USR002" },
                    { "BLOG003", "Science fiction movies explore the future and technology...", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2114), "https://images.unsplash.com/photo-3", 95, "Best Sci-Fi Movies of the Decade", "USR003" },
                    { "BLOG004", "These romantic films will make your evening unforgettable...", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2116), "https://images.unsplash.com/photo-4", 60, "Romantic Movies Perfect for Date Night", "USR004" },
                    { "BLOG005", "Many exciting movies are coming to theaters next year...", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2118), "https://images.unsplash.com/photo-5", 150, "Upcoming Blockbusters in 2026", "USR005" }
                });

            migrationBuilder.InsertData(
                table: "MovieRatings",
                columns: new[] { "MovieRatingId", "MovieId", "UserId", "Value" },
                values: new object[,]
                {
                    { "RAT001", "MOV001", "USR001", 8.5 },
                    { "RAT002", "MOV001", "USR002", 9.0 },
                    { "RAT003", "MOV002", "USR003", 7.7999999999999998 },
                    { "RAT004", "MOV002", "USR004", 8.1999999999999993 },
                    { "RAT005", "MOV003", "USR002", 8.5999999999999996 },
                    { "RAT006", "MOV003", "USR005", 8.9000000000000004 },
                    { "RAT007", "MOV004", "USR001", 6.9000000000000004 },
                    { "RAT008", "MOV004", "USR003", 7.4000000000000004 },
                    { "RAT009", "MOV005", "USR002", 7.7000000000000002 },
                    { "RAT010", "MOV005", "USR004", 8.0999999999999996 },
                    { "RAT011", "MOV006", "USR003", 8.6999999999999993 },
                    { "RAT012", "MOV006", "USR005", 9.1999999999999993 },
                    { "RAT013", "MOV007", "USR001", 7.5 },
                    { "RAT014", "MOV007", "USR004", 7.9000000000000004 },
                    { "RAT015", "MOV008", "USR002", 9.0999999999999996 },
                    { "RAT016", "MOV008", "USR003", 8.8000000000000007 },
                    { "RAT017", "MOV009", "USR004", 7.5999999999999996 },
                    { "RAT018", "MOV009", "USR005", 8.0 },
                    { "RAT019", "MOV010", "USR001", 8.4000000000000004 },
                    { "RAT020", "MOV010", "USR002", 8.9000000000000004 }
                });

            migrationBuilder.InsertData(
                table: "Showtimes",
                columns: new[] { "ShowtimeId", "CreatedAt", "EndTime", "MovieId", "RoomId", "StartTime", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { "ST001", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 13, 1, 0, 0, DateTimeKind.Unspecified), "MOV001", "R001", new DateTime(2026, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST002", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 15, 58, 0, 0, DateTimeKind.Unspecified), "MOV002", "R002", new DateTime(2026, 6, 10, 13, 30, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST003", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 19, 26, 0, 0, DateTimeKind.Unspecified), "MOV003", "R003", new DateTime(2026, 6, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST004", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 22, 6, 0, 0, DateTimeKind.Unspecified), "MOV004", "R001", new DateTime(2026, 6, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST005", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 11, 13, 12, 0, 0, DateTimeKind.Unspecified), "MOV009", "R002", new DateTime(2026, 6, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ST006", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 11, 16, 11, 0, 0, DateTimeKind.Unspecified), "MOV010", "R003", new DateTime(2026, 6, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), "AVAILABLE", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WatchLists",
                columns: new[] { "WatchListId", "CreatedAt", "MovieId", "UserId", "type" },
                values: new object[,]
                {
                    { "WL001", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2034), "MOV001", "USR001", "FAVORITE" },
                    { "WL002", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2037), "MOV003", "USR001", "FAVORITE" },
                    { "WL003", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2040), "MOV002", "USR002", "WATCH_LATER" },
                    { "WL004", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2042), "MOV005", "USR002", "WATCH_LATER" },
                    { "WL005", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2044), "MOV004", "USR003", "FAVORITE" },
                    { "WL006", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2047), "MOV007", "USR003", "WATCH_LATER" },
                    { "WL007", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2049), "MOV006", "USR004", "FAVORITE" },
                    { "WL008", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2051), "MOV008", "USR004", "WATCH_LATER" },
                    { "WL009", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2054), "MOV009", "USR005", "FAVORITE" },
                    { "WL010", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2056), "MOV010", "USR005", "WATCH_LATER" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "CreatedAt", "ShowtimeId", "Status", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { "BK001", new DateTime(2026, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), "ST001", "PAID", 15.5, "USR001" },
                    { "BK002", new DateTime(2026, 6, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "ST002", "PAID", 20.0, "USR002" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "BlogPostId", "Content", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { "CMT001", "BLOG001", "Great list! I love Marvel movies.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2161), "USR002" },
                    { "CMT002", "BLOG001", "Avengers Endgame is my favorite.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2164), "USR003" },
                    { "CMT003", "BLOG001", "Nice recommendations!", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2166), "USR004" },
                    { "CMT004", "BLOG002", "Horror movies are so thrilling!", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2169), "USR001" },
                    { "CMT005", "BLOG002", "The Conjuring series is amazing.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2171), "USR005" },
                    { "CMT006", "BLOG002", "I love watching horror at night.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2173), "USR003" },
                    { "CMT007", "BLOG003", "Interstellar is a masterpiece.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2174), "USR001" },
                    { "CMT008", "BLOG003", "Sci-Fi movies inspire imagination.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2176), "USR002" },
                    { "CMT009", "BLOG003", "I love futuristic technology.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2179), "USR005" },
                    { "CMT010", "BLOG004", "Perfect movies for couples.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2181), "USR003" },
                    { "CMT011", "BLOG004", "Titanic will always be iconic.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2183), "USR002" },
                    { "CMT012", "BLOG004", "Romantic movies are emotional.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2185), "USR001" },
                    { "CMT013", "BLOG005", "Can't wait for next year's movies!", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2187), "USR004" },
                    { "CMT014", "BLOG005", "So many exciting releases.", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2189), "USR003" },
                    { "CMT015", "BLOG005", "Hope Marvel releases new films!", new DateTime(2026, 3, 17, 18, 37, 40, 322, DateTimeKind.Utc).AddTicks(2191), "USR002" }
                });

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
                    { "PAY001", 120000.0, "BK001", new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2908), "PM001", "PAID" },
                    { "PAY002", 150000.0, "BK002", new DateTime(2026, 3, 18, 1, 37, 40, 322, DateTimeKind.Local).AddTicks(2912), "PM002", "PAID" }
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
                name: "IX_BlogPosts_UserId",
                table: "BlogPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingFoodCombos_BookingId",
                table: "BookingFoodCombos",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingFoodCombos_FoodComboId",
                table: "BookingFoodCombos",
                column: "FoodComboId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ShowtimeId",
                table: "Bookings",
                column: "ShowtimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSeats_BookingId",
                table: "BookingSeats",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSeats_SeatId_ShowtimeTicketTypeId",
                table: "BookingSeats",
                columns: new[] { "SeatId", "ShowtimeTicketTypeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingSeats_ShowtimeTicketTypeId",
                table: "BookingSeats",
                column: "ShowtimeTicketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingVouchers_VoucherId",
                table: "BookingVouchers",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogPostId",
                table: "Comments",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCasts_CastId",
                table: "MovieCasts",
                column: "CastId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRatings_MovieId",
                table: "MovieRatings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRatings_UserId",
                table: "MovieRatings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_BlogPostId",
                table: "Notifications",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_BookingSeatId",
                table: "Notifications",
                column: "BookingSeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CommentId",
                table: "Notifications",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_WatchListId",
                table: "Notifications",
                column: "WatchListId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BookingId",
                table: "Payments",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Posters_MovieId",
                table: "Posters",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CinemaId",
                table: "Rooms",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatLocks_SeatId",
                table: "SeatLocks",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatLocks_ShowtimeId",
                table: "SeatLocks",
                column: "ShowtimeId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatLocks_UserId",
                table: "SeatLocks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_RoomId",
                table: "Seats",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ShowtimeId",
                table: "Seats",
                column: "ShowtimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Showtimes_MovieId",
                table: "Showtimes",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Showtimes_RoomId",
                table: "Showtimes",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowtimeTicketTypes_ShowtimeId",
                table: "ShowtimeTicketTypes",
                column: "ShowtimeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowtimeTicketTypes_TicketTypeId",
                table: "ShowtimeTicketTypes",
                column: "TicketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGenres_GenreId",
                table: "UserGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchLists_MovieId",
                table: "WatchLists",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchLists_UserId",
                table: "WatchLists",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingFoodCombos");

            migrationBuilder.DropTable(
                name: "BookingVouchers");

            migrationBuilder.DropTable(
                name: "MovieCasts");

            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "MovieRatings");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Posters");

            migrationBuilder.DropTable(
                name: "SeatLocks");

            migrationBuilder.DropTable(
                name: "UserGenres");

            migrationBuilder.DropTable(
                name: "FoodCombos");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "BookingSeats");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "WatchLists");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "ShowtimeTicketTypes");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Showtimes");

            migrationBuilder.DropTable(
                name: "TicketTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Cinemas");
        }
    }
}
