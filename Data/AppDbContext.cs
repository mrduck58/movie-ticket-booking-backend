using Microsoft.EntityFrameworkCore;
using Movie_Ticket_Booking_Backend.Domain.Blogs;
using Movie_Ticket_Booking_Backend.Domain.Bookings;
using Movie_Ticket_Booking_Backend.Domain.Cinemas;
using Movie_Ticket_Booking_Backend.Domain.Foods;
using Movie_Ticket_Booking_Backend.Domain.Movies;
using Movie_Ticket_Booking_Backend.Domain.Notificaions;
using Movie_Ticket_Booking_Backend.Domain.Payments;
using Movie_Ticket_Booking_Backend.Domain.Showtimes;
using Movie_Ticket_Booking_Backend.Domain.Users;
using Movie_Ticket_Booking_Backend.Domain.Vouchers;

namespace Movie_Ticket_Booking_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //User and Role tables for authentication and authorization
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        //Movie related tables
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }

        //Cinema related tables
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatLock> SeatLocks { get; set; }

        //Showtime and ticket related tables
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<ShowtimeTicketType> ShowtimeTicketTypes { get; set; }

        //Booking related tables
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingSeat> BookingSeats { get; set; }
        public DbSet<BookingVoucher> BookingVouchers { get; set; }
        public DbSet<BookingFoodCombo> BookingFoodCombos { get; set; }

        //Payment related tables
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        //Food and combo related tables
        public DbSet<FoodCombo> FoodCombos { get; set; }

        //Voucher related tables
        public DbSet<Voucher> Vouchers { get; set; }

        //Blog related tables
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserGenre> UserGenres { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // ========================
            // USER - ROLE
            // ========================
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            // ========================
            // MOVIE - GENRE (MANY TO MANY)
            // ========================
            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => new { mg.MovieId, mg.GenreId });

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(mg => mg.MovieId);

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(g => g.MovieGenres)
                .HasForeignKey(mg => mg.GenreId);

            // ========================
            // MOVIE - CAST (MANY TO MANY)
            // ========================
            modelBuilder.Entity<MovieCast>()
                .HasKey(mc => new { mc.MovieId, mc.CastId });

            modelBuilder.Entity<MovieCast>()
                .HasOne(mc => mc.Movie)
                .WithMany(m => m.MovieCasts)
                .HasForeignKey(mc => mc.MovieId);

            modelBuilder.Entity<MovieCast>()
                .HasOne(mc => mc.Cast)
                .WithMany(c => c.MovieCasts)
                .HasForeignKey(mc => mc.CastId);

            // ========================
            // MOVIE - POSTER
            // ========================
            modelBuilder.Entity<Poster>()
                .HasOne(p => p.Movie)
                .WithMany(m => m.Posters)
                .HasForeignKey(p => p.MovieId);

            // ========================
            // CINEMA - ROOM
            // ========================
            modelBuilder.Entity<Room>()
                .HasOne(r => r.Cinema)
                .WithMany(c => c.Rooms)
                .HasForeignKey(r => r.CinemaId);

            // ========================
            // ROOM - SEAT
            // ========================
            modelBuilder.Entity<Seat>()
                .HasOne(s => s.Room)
                .WithMany(r => r.Seats)
                .HasForeignKey(s => s.RoomId);

            // ========================
            // SEAT LOCK
            // ========================
            modelBuilder.Entity<SeatLock>()
                .HasOne(sl => sl.Seat)
                .WithMany(s => s.SeatLocks)
                .HasForeignKey(sl => sl.SeatId);

            modelBuilder.Entity<SeatLock>()
                .HasOne(sl => sl.User)
                .WithMany(u => u.SeatLocks)
                .HasForeignKey(sl => sl.UserId);

            modelBuilder.Entity<SeatLock>()
                .HasOne(sl => sl.Showtime)
                .WithMany(st => st.SeatLocks)
                .HasForeignKey(sl => sl.ShowtimeId);

            // ========================
            // SHOWTIME
            // ========================
            modelBuilder.Entity<Showtime>()
                .HasOne(st => st.Movie)
                .WithMany(m => m.Showtimes)
                .HasForeignKey(st => st.MovieId);

            modelBuilder.Entity<Showtime>()
                .HasOne(st => st.Room)
                .WithMany(r => r.Showtimes)
                .HasForeignKey(st => st.RoomId);

            // ========================
            // SHOWTIME - TICKET TYPE
            // ========================
            modelBuilder.Entity<ShowtimeTicketType>()
                .HasOne(stt => stt.Showtime)
                .WithMany(st => st.ShowtimeTicketTypes)
                .HasForeignKey(stt => stt.ShowtimeId);

            modelBuilder.Entity<ShowtimeTicketType>()
                .HasOne(stt => stt.TicketType)
                .WithMany(tt => tt.ShowtimeTicketTypes)
                .HasForeignKey(stt => stt.TicketTypeId);

            // ========================
            // BOOKING
            // ========================
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Showtime)
                .WithMany(st => st.Bookings)
                .HasForeignKey(b => b.ShowtimeId);

            // ========================
            // BOOKING SEAT
            // ========================
            modelBuilder.Entity<BookingSeat>()
                .HasOne(bs => bs.Booking)
                .WithMany(b => b.BookingSeats)
                .HasForeignKey(bs => bs.BookingId);

            modelBuilder.Entity<BookingSeat>()
                .HasOne(bs => bs.Seat)
                .WithMany(s => s.BookingSeats)
                .HasForeignKey(bs => bs.SeatId);

            modelBuilder.Entity<BookingSeat>()
                .HasOne(bs => bs.ShowtimeTicketType)
                .WithMany(stt => stt.BookingSeats)
                .HasForeignKey(bs => bs.ShowtimeTicketTypeId);

            // ========================
            // BOOKING FOOD COMBO
            // ========================
            modelBuilder.Entity<BookingFoodCombo>()
                .HasKey(bfc => bfc.BookingFoodComboId);

            modelBuilder.Entity<BookingFoodCombo>()
                .HasOne(bfc => bfc.Booking)
                .WithMany(b => b.BookingFoodCombos)
                .HasForeignKey(bfc => bfc.BookingId);

            modelBuilder.Entity<BookingFoodCombo>()
                .HasOne(bfc => bfc.FoodCombo)
                .WithMany(fc => fc.BookingFoodCombos)
                .HasForeignKey(bfc => bfc.FoodComboId);

            // ========================
            // BOOKING VOUCHER
            // ========================
            modelBuilder.Entity<BookingVoucher>()
                .HasKey(bv => new { bv.BookingId, bv.VoucherId });

            modelBuilder.Entity<BookingVoucher>()
                .HasOne(bv => bv.Booking)
                .WithMany(b => b.BookingVouchers)
                .HasForeignKey(bv => bv.BookingId);

            modelBuilder.Entity<BookingVoucher>()
                .HasOne(bv => bv.Voucher)
                .WithMany(v => v.BookingVouchers)
                .HasForeignKey(bv => bv.VoucherId);

            // ========================
            // PAYMENT (1-1 BOOKING)
            // ========================
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Booking)
                .WithOne(b => b.Payment)
                .HasForeignKey<Payment>(p => p.BookingId);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.PaymentMethod)
                .WithMany(pm => pm.Payments)
                .HasForeignKey(p => p.PaymentMethodId);

            // ========================
            // BLOG
            // ========================
            modelBuilder.Entity<BlogPost>()
                .HasOne(bp => bp.User)
                .WithMany(u => u.BlogPosts)
                .HasForeignKey(bp => bp.UserId);
            //.OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);
            //.OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.BlogPost)
                .WithMany(bp => bp.Comments)
                .HasForeignKey(c => c.BlogPostId);
            //.OnDelete(DeleteBehavior.Cascade);

            // ========================
            // MOVIE RATING
            // ========================
            modelBuilder.Entity<MovieRating>()
                .HasOne(mr => mr.Movie)
                .WithMany(m => m.MovieRatings)
                .HasForeignKey(mr => mr.MovieId);

            modelBuilder.Entity<MovieRating>()
                .HasOne(mr => mr.User)
                .WithMany(u => u.MovieRatings)
                .HasForeignKey(mr => mr.UserId);

            // ========================
            // WatchList
            // ========================
            modelBuilder.Entity<WatchList>()
            .HasOne(w => w.User)
            .WithMany(u => u.WatchLists)
            .HasForeignKey(w => w.UserId);

            modelBuilder.Entity<WatchList>()
            .HasOne(w => w.Movie)
            .WithMany(m => m.WatchLists)
            .HasForeignKey(w => w.MovieId);
            
            // ========================
            // UserGenre
            // ========================
            modelBuilder.Entity<UserGenre>()
           .HasKey(ug => new { ug.UserId, ug.GenreId });

            modelBuilder.Entity<UserGenre>()
                .HasOne(ug => ug.User)
                .WithMany(u => u.UserGenres)
                .HasForeignKey(ug => ug.UserId);

            modelBuilder.Entity<UserGenre>()
                .HasOne(ug => ug.Genre)
                .WithMany(g => g.UserGenres)
                .HasForeignKey(ug => ug.GenreId);
                
            // ========================
            // Notification
            // ========================
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.WatchList)
                .WithMany(w => w.Notifications)
                .HasForeignKey(n => n.WatchListId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.BlogPost)
                .WithMany(b => b.Notifications)
                .HasForeignKey(n => n.BlogPostId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Comment)
                .WithMany(c => c.Notifications)
                .HasForeignKey(n => n.CommentId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.BookingSeat)
                .WithMany(b => b.Notifications)
                .HasForeignKey(n => n.BookingSeatId)
                .OnDelete(DeleteBehavior.SetNull);

            // ========================
            // Indexes and constraints
            // ========================
            modelBuilder.Entity<BookingSeat>()
                .HasIndex(bs => new { bs.SeatId, bs.ShowtimeTicketTypeId })
                .IsUnique();
            // ========================
            // SEED MOVIES
            // ========================

            modelBuilder.Entity<Movie>().HasData(

            new Movie
            {
                MovieId = "MOV001",
                Title = "Avengers: Endgame",
                TitleVn = "Biệt Đội Siêu Anh Hùng: Hồi Kết",
                Description = "The Avengers assemble for the final battle against Thanos.",
                TrailerUrl = "https://www.youtube.com/watch?v=TcMBFSGVi1c",
                Duration = 181,
                Director = "Anthony Russo, Joe Russo",
                Rating = 8.4,
                Status = "NOWSHOWING",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            },

            new Movie
            {
                MovieId = "MOV002",
                Title = "Spider-Man: No Way Home",
                TitleVn = "Người Nhện: Không Còn Nhà",
                Description = "Spider-Man faces villains from different universes.",
                TrailerUrl = "https://www.youtube.com/watch?v=JfVOs4VSpmA",
                Duration = 148,
                Director = "Jon Watts",
                Rating = 8.2,
                Status = "NOWSHOWING",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            },

            new Movie
            {
                MovieId = "MOV003",
                Title = "The Batman",
                TitleVn = "Người Dơi",
                Description = "Batman investigates corruption in Gotham.",
                TrailerUrl = "https://www.youtube.com/watch?v=mqqft2x_Aa4",
                Duration = 176,
                Director = "d8",
                Rating = 7.9,
                Status = "NOWSHOWING",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            },

            new Movie
            {
                MovieId = "MOV004",
                Title = "Doctor Strange in the Multiverse of Madness",
                TitleVn = "Phù Thủy Tối Thượng: Đa Vũ Trụ Hỗn Loạn",
                Description = "Doctor Strange explores the multiverse.",
                TrailerUrl = "https://www.youtube.com/watch?v=aWzlQ2N6qqg",
                Duration = 126,
                Director = "d7",
                Rating = 7.0,
                Status = "NOWSHOWING",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            },

            new Movie
            {
                MovieId = "MOV005",
                Title = "Deadpool & Wolverine",
                TitleVn = "Deadpool & Wolverine",
                Description = "Deadpool meets Wolverine in a chaotic adventure.",
                TrailerUrl = "https://www.youtube.com/watch?v=73_1biulkYk",
                Duration = 130,
                Director = "d6",
                Rating = 0,
                Status = "COMINGSOON",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            },

            new Movie
            {
                MovieId = "MOV006",
                Title = "Joker: Folie à Deux",
                TitleVn = "Joker: Điên Cuồng Hai Người",
                Description = "Arthur Fleck continues his descent into madness.",
                TrailerUrl = "https://www.youtube.com/watch?v=xy8aJw1vYHo",
                Duration = 138,
                Director = "d5",
                Rating = 0,
                Status = "COMINGSOON",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            },

            new Movie
            {
                MovieId = "MOV007",
                Title = "Kung Fu Panda 4",
                TitleVn = "Kung Fu Panda 4",
                Description = "Po trains a new dragon warrior.",
                TrailerUrl = "https://www.youtube.com/watch?v=_inKs4eeHiI",
                Duration = 95,
                Director = "d4",
                Rating = 0,
                Status = "COMINGSOON",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            },

            new Movie
            {
                MovieId = "MOV008",
                Title = "Mission Impossible 8",
                TitleVn = "Nhiệm Vụ Bất Khả Thi 8",
                Description = "Ethan Hunt returns for his most dangerous mission.",
                TrailerUrl = "https://www.youtube.com/watch?v=avz06PDqDbM",
                Duration = 160,
                Director = "d3",
                Rating = 0,
                Status = "COMINGSOON",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            },

            new Movie
            {
                MovieId = "MOV009",
                Title = "Avatar: The Way of Water",
                TitleVn = "Avatar: Dòng Chảy Của Nước",
                Description = "Jake Sully protects his family on Pandora.",
                TrailerUrl = "https://www.youtube.com/watch?v=d9MyW72ELq0",
                Duration = 192,
                Director = "d2",
                Rating = 7.7,
                Status = "NOWSHOWING",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            },

            new Movie
            {
                MovieId = "MOV010",
                Title = "Top Gun: Maverick",
                TitleVn = "Top Gun: Maverick",
                Description = "Maverick trains a new generation of pilots.",
                TrailerUrl = "https://www.youtube.com/watch?v=giXco2jaZ_4",
                Duration = 131,
                Director = "d1",
                Rating = 8.3,
                Status = "NOWSHOWING",
                CreatedAt = new DateTime(2024, 1, 1),
                UpdatedAt = new DateTime(2024, 1, 1)
            }

            );

            // ========================
            // SEED CAST
            // ========================

            modelBuilder.Entity<Cast>().HasData(

            new Cast { CastId = "CAST001", Name = "Robert Downey Jr.", AvatarUrl = "https://image.tmdb.org/t/p/w500/rdj.jpg" },
            new Cast { CastId = "CAST002", Name = "Chris Evans", AvatarUrl = "https://image.tmdb.org/t/p/w500/cevans.jpg" },
            new Cast { CastId = "CAST003", Name = "Scarlett Johansson", AvatarUrl = "https://image.tmdb.org/t/p/w500/scarlett.jpg" },
            new Cast { CastId = "CAST004", Name = "Tom Holland", AvatarUrl = "https://image.tmdb.org/t/p/w500/tomholland.jpg" },
            new Cast { CastId = "CAST005", Name = "Zendaya", AvatarUrl = "https://image.tmdb.org/t/p/w500/zendaya.jpg" },
            new Cast { CastId = "CAST006", Name = "Robert Pattinson", AvatarUrl = "https://image.tmdb.org/t/p/w500/pattinson.jpg" },
            new Cast { CastId = "CAST007", Name = "Zoë Kravitz", AvatarUrl = "https://image.tmdb.org/t/p/w500/zoe.jpg" },
            new Cast { CastId = "CAST008", Name = "Benedict Cumberbatch", AvatarUrl = "https://image.tmdb.org/t/p/w500/cumberbatch.jpg" },
            new Cast { CastId = "CAST009", Name = "Elizabeth Olsen", AvatarUrl = "https://image.tmdb.org/t/p/w500/olsen.jpg" },
            new Cast { CastId = "CAST010", Name = "Ryan Reynolds", AvatarUrl = "https://image.tmdb.org/t/p/w500/reynolds.jpg" }

            );

            // ========================
            // SEED MOVIE CAST
            // ========================

            modelBuilder.Entity<MovieCast>().HasData(

            new MovieCast { MovieId = "MOV001", CastId = "CAST001", CharacterName = "Iron Man", CharacterAvatar = "" },
            new MovieCast { MovieId = "MOV001", CastId = "CAST002", CharacterName = "Captain America", CharacterAvatar = "" },
            new MovieCast { MovieId = "MOV001", CastId = "CAST003", CharacterName = "Black Widow", CharacterAvatar = "" },

            new MovieCast { MovieId = "MOV002", CastId = "CAST004", CharacterName = "Spider-Man", CharacterAvatar = "" },
            new MovieCast { MovieId = "MOV002", CastId = "CAST005", CharacterName = "MJ", CharacterAvatar = "" },

            new MovieCast { MovieId = "MOV003", CastId = "CAST006", CharacterName = "Batman", CharacterAvatar = "" },
            new MovieCast { MovieId = "MOV003", CastId = "CAST007", CharacterName = "Catwoman", CharacterAvatar = "" },

            new MovieCast { MovieId = "MOV004", CastId = "CAST008", CharacterName = "Doctor Strange", CharacterAvatar = "" },
            new MovieCast { MovieId = "MOV004", CastId = "CAST009", CharacterName = "Scarlet Witch", CharacterAvatar = "" },

            new MovieCast { MovieId = "MOV005", CastId = "CAST010", CharacterName = "Deadpool", CharacterAvatar = "" }

            );
            modelBuilder.Entity<Genre>().HasData(

new Genre { GenreId = "GEN001", Name = "Action", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN002", Name = "Adventure", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN003", Name = "Animation", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN004", Name = "Biography", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN005", Name = "Comedy", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },

new Genre { GenreId = "GEN006", Name = "Crime", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN007", Name = "Documentary", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN008", Name = "Drama", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN009", Name = "Family", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN010", Name = "Fantasy", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },

new Genre { GenreId = "GEN011", Name = "History", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN012", Name = "Horror", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN013", Name = "Music", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN014", Name = "Mystery", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN015", Name = "Romance", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },

new Genre { GenreId = "GEN016", Name = "Sci-Fi", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN017", Name = "Sport", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN018", Name = "Thriller", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN019", Name = "War", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN020", Name = "Western", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },

new Genre { GenreId = "GEN021", Name = "Superhero", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN022", Name = "Psychological", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN023", Name = "Anime", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN024", Name = "Disaster", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
new Genre { GenreId = "GEN025", Name = "Martial Arts", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }


);
            modelBuilder.Entity<MovieGenre>().HasData(

new MovieGenre { MovieId = "MOV001", GenreId = "GEN001" }, // Action
new MovieGenre { MovieId = "MOV001", GenreId = "GEN021" }, // Superhero
new MovieGenre { MovieId = "MOV001", GenreId = "GEN016" }, // Sci-Fi

new MovieGenre { MovieId = "MOV002", GenreId = "GEN002" }, // Adventure
new MovieGenre { MovieId = "MOV002", GenreId = "GEN010" }, // Fantasy

new MovieGenre { MovieId = "MOV003", GenreId = "GEN015" }, // Romance
new MovieGenre { MovieId = "MOV003", GenreId = "GEN008" }, // Drama

new MovieGenre { MovieId = "MOV004", GenreId = "GEN012" }, // Horror
new MovieGenre { MovieId = "MOV004", GenreId = "GEN018" }, // Thriller

new MovieGenre { MovieId = "MOV005", GenreId = "GEN005" }, // Comedy
new MovieGenre { MovieId = "MOV005", GenreId = "GEN009" }, // Family

new MovieGenre { MovieId = "MOV006", GenreId = "GEN016" }, // Sci-Fi
new MovieGenre { MovieId = "MOV006", GenreId = "GEN018" }, // Thriller

new MovieGenre { MovieId = "MOV007", GenreId = "GEN001" }, // Action
new MovieGenre { MovieId = "MOV007", GenreId = "GEN002" }, // Adventure

new MovieGenre { MovieId = "MOV008", GenreId = "GEN023" }, // Anime
new MovieGenre { MovieId = "MOV008", GenreId = "GEN003" }, // Animation

new MovieGenre { MovieId = "MOV009", GenreId = "GEN004" }, // Biography
new MovieGenre { MovieId = "MOV009", GenreId = "GEN008" }, // Drama

new MovieGenre { MovieId = "MOV010", GenreId = "GEN024" }, // Disaster
new MovieGenre { MovieId = "MOV010", GenreId = "GEN018" }  // Thriller

);
            modelBuilder.Entity<Role>().HasData(

new Role
{
    RoleId = "ROLE001",
    Name = "ADMIN"
},

new Role
{
    RoleId = "ROLE002",
    Name = "CUSTOMER"
}

);
            modelBuilder.Entity<User>().HasData(

new User
{
    UserId = "USR001",
    Phone = "0900000001",
    Email = "john@example.com",
    PasswordHash = "123456",
    FullName = "John Smith",
    AvatarUrl = "https://i.pravatar.cc/150?img=1",
    Status = "ACTIVE",
    CreatedAt = DateTime.UtcNow,
    UpdatedAt = DateTime.UtcNow,
    RoleId = "ROLE002"
},

new User
{
    UserId = "USR002",
    Phone = "0900000002",
    Email = "emma@example.com",
    PasswordHash = "123456",
    FullName = "Emma Watson",
    AvatarUrl = "https://i.pravatar.cc/150?img=2",
    Status = "ACTIVE",
    CreatedAt = DateTime.UtcNow,
    UpdatedAt = DateTime.UtcNow,
    RoleId = "ROLE002"
},

new User
{
    UserId = "USR003",
    Phone = "0900000003",
    Email = "robert@example.com",
    PasswordHash = "123456",
    FullName = "Robert Downey Jr",
    AvatarUrl = "https://i.pravatar.cc/150?img=3",
    Status = "ACTIVE",
    CreatedAt = DateTime.UtcNow,
    UpdatedAt = DateTime.UtcNow,
    RoleId = "ROLE002"
},

new User
{
    UserId = "USR004",
    Phone = "0900000004",
    Email = "scarlett@example.com",
    PasswordHash = "123456",
    FullName = "Scarlett Johansson",
    AvatarUrl = "https://i.pravatar.cc/150?img=4",
    Status = "ACTIVE",
    CreatedAt = DateTime.UtcNow,
    UpdatedAt = DateTime.UtcNow,
    RoleId = "ROLE002"
},

new User
{
    UserId = "USR005",
    Phone = "0900000005",
    Email = "chris@example.com",
    PasswordHash = "123456",
    FullName = "Chris Evans",
    AvatarUrl = "https://i.pravatar.cc/150?img=5",
    Status = "ACTIVE",
    CreatedAt = DateTime.UtcNow,
    UpdatedAt = DateTime.UtcNow,
    RoleId = "ROLE002"
}

);
            modelBuilder.Entity<MovieRating>().HasData(

new MovieRating { MovieRatingId = "RAT001", MovieId = "MOV001", UserId = "USR001", Value = 8.5 },
new MovieRating { MovieRatingId = "RAT002", MovieId = "MOV001", UserId = "USR002", Value = 9.0 },

new MovieRating { MovieRatingId = "RAT003", MovieId = "MOV002", UserId = "USR003", Value = 7.8 },
new MovieRating { MovieRatingId = "RAT004", MovieId = "MOV002", UserId = "USR004", Value = 8.2 },

new MovieRating { MovieRatingId = "RAT005", MovieId = "MOV003", UserId = "USR002", Value = 8.6 },
new MovieRating { MovieRatingId = "RAT006", MovieId = "MOV003", UserId = "USR005", Value = 8.9 },

new MovieRating { MovieRatingId = "RAT007", MovieId = "MOV004", UserId = "USR001", Value = 6.9 },
new MovieRating { MovieRatingId = "RAT008", MovieId = "MOV004", UserId = "USR003", Value = 7.4 },

new MovieRating { MovieRatingId = "RAT009", MovieId = "MOV005", UserId = "USR002", Value = 7.7 },
new MovieRating { MovieRatingId = "RAT010", MovieId = "MOV005", UserId = "USR004", Value = 8.1 },

new MovieRating { MovieRatingId = "RAT011", MovieId = "MOV006", UserId = "USR003", Value = 8.7 },
new MovieRating { MovieRatingId = "RAT012", MovieId = "MOV006", UserId = "USR005", Value = 9.2 },

new MovieRating { MovieRatingId = "RAT013", MovieId = "MOV007", UserId = "USR001", Value = 7.5 },
new MovieRating { MovieRatingId = "RAT014", MovieId = "MOV007", UserId = "USR004", Value = 7.9 },

new MovieRating { MovieRatingId = "RAT015", MovieId = "MOV008", UserId = "USR002", Value = 9.1 },
new MovieRating { MovieRatingId = "RAT016", MovieId = "MOV008", UserId = "USR003", Value = 8.8 },

new MovieRating { MovieRatingId = "RAT017", MovieId = "MOV009", UserId = "USR004", Value = 7.6 },
new MovieRating { MovieRatingId = "RAT018", MovieId = "MOV009", UserId = "USR005", Value = 8.0 },

new MovieRating { MovieRatingId = "RAT019", MovieId = "MOV010", UserId = "USR001", Value = 8.4 },
new MovieRating { MovieRatingId = "RAT020", MovieId = "MOV010", UserId = "USR002", Value = 8.9 }

);
            modelBuilder.Entity<Poster>().HasData(

new Poster { PosterId = "POS001", Title = "Avengers Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/1.jpg", MovieId = "MOV001" },
new Poster { PosterId = "POS002", Title = "Batman Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/2.jpg", MovieId = "MOV002" },
new Poster { PosterId = "POS003", Title = "Titanic Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/3.jpg", MovieId = "MOV003" },
new Poster { PosterId = "POS004", Title = "Conjuring Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/4.jpg", MovieId = "MOV004" },
new Poster { PosterId = "POS005", Title = "Minions Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/5.jpg", MovieId = "MOV005" },

new Poster { PosterId = "POS006", Title = "Interstellar Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/6.jpg", MovieId = "MOV006" },
new Poster { PosterId = "POS007", Title = "Fast X Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/7.jpg", MovieId = "MOV007" },
new Poster { PosterId = "POS008", Title = "Demon Slayer Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/8.jpg", MovieId = "MOV008" },
new Poster { PosterId = "POS009", Title = "Oppenheimer Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/9.jpg", MovieId = "MOV009" },
new Poster { PosterId = "POS010", Title = "2012 Poster", ImageUrl = "https://image.tmdb.org/t/p/w500/10.jpg", MovieId = "MOV010" }

);
            modelBuilder.Entity<WatchList>().HasData(

new WatchList { WatchListId = "WL001", UserId = "USR001", MovieId = "MOV001", type = "FAVORITE", CreatedAt = DateTime.UtcNow },
new WatchList { WatchListId = "WL002", UserId = "USR001", MovieId = "MOV003", type = "FAVORITE", CreatedAt = DateTime.UtcNow },

new WatchList { WatchListId = "WL003", UserId = "USR002", MovieId = "MOV002", type = "WATCH_LATER", CreatedAt = DateTime.UtcNow },
new WatchList { WatchListId = "WL004", UserId = "USR002", MovieId = "MOV005", type = "WATCH_LATER", CreatedAt = DateTime.UtcNow },

new WatchList { WatchListId = "WL005", UserId = "USR003", MovieId = "MOV004", type = "FAVORITE", CreatedAt = DateTime.UtcNow },
new WatchList { WatchListId = "WL006", UserId = "USR003", MovieId = "MOV007", type = "WATCH_LATER", CreatedAt = DateTime.UtcNow },

new WatchList { WatchListId = "WL007", UserId = "USR004", MovieId = "MOV006", type = "FAVORITE", CreatedAt = DateTime.UtcNow },
new WatchList { WatchListId = "WL008", UserId = "USR004", MovieId = "MOV008", type = "WATCH_LATER", CreatedAt = DateTime.UtcNow },

new WatchList { WatchListId = "WL009", UserId = "USR005", MovieId = "MOV009", type = "FAVORITE", CreatedAt = DateTime.UtcNow },
new WatchList { WatchListId = "WL010", UserId = "USR005", MovieId = "MOV010", type = "WATCH_LATER", CreatedAt = DateTime.UtcNow }

);
            modelBuilder.Entity<BlogPost>().HasData(

            new BlogPost
            {
                BlogPostId = "BLOG001",
                UserId = "USR001",
                Title = "Top 10 Marvel Movies You Must Watch",
                Content = "Marvel movies have changed the superhero genre forever...",
                ImageUrl = "https://images.unsplash.com/photo-1",
                Likes = 120,
                CreatedDate = DateTime.UtcNow
            },

            new BlogPost
            {
                BlogPostId = "BLOG002",
                UserId = "USR002",
                Title = "Why Horror Movies Are So Popular",
                Content = "Horror movies give audiences a thrilling experience...",
                ImageUrl = "https://images.unsplash.com/photo-2",
                Likes = 85,
                CreatedDate = DateTime.UtcNow
            },

            new BlogPost
            {
                BlogPostId = "BLOG003",
                UserId = "USR003",
                Title = "Best Sci-Fi Movies of the Decade",
                Content = "Science fiction movies explore the future and technology...",
                ImageUrl = "https://images.unsplash.com/photo-3",
                Likes = 95,
                CreatedDate = DateTime.UtcNow
            },

            new BlogPost
            {
                BlogPostId = "BLOG004",
                UserId = "USR004",
                Title = "Romantic Movies Perfect for Date Night",
                Content = "These romantic films will make your evening unforgettable...",
                ImageUrl = "https://images.unsplash.com/photo-4",
                Likes = 60,
                CreatedDate = DateTime.UtcNow
            },

            new BlogPost
            {
                BlogPostId = "BLOG005",
                UserId = "USR005",
                Title = "Upcoming Blockbusters in 2026",
                Content = "Many exciting movies are coming to theaters next year...",
                ImageUrl = "https://images.unsplash.com/photo-5",
                Likes = 150,
                CreatedDate = DateTime.UtcNow
            }

            );
            modelBuilder.Entity<Comment>().HasData(

new Comment { CommentId = "CMT001", UserId = "USR002", BlogPostId = "BLOG001", Content = "Great list! I love Marvel movies.", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT002", UserId = "USR003", BlogPostId = "BLOG001", Content = "Avengers Endgame is my favorite.", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT003", UserId = "USR004", BlogPostId = "BLOG001", Content = "Nice recommendations!", CreatedDate = DateTime.UtcNow },

new Comment { CommentId = "CMT004", UserId = "USR001", BlogPostId = "BLOG002", Content = "Horror movies are so thrilling!", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT005", UserId = "USR005", BlogPostId = "BLOG002", Content = "The Conjuring series is amazing.", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT006", UserId = "USR003", BlogPostId = "BLOG002", Content = "I love watching horror at night.", CreatedDate = DateTime.UtcNow },

new Comment { CommentId = "CMT007", UserId = "USR001", BlogPostId = "BLOG003", Content = "Interstellar is a masterpiece.", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT008", UserId = "USR002", BlogPostId = "BLOG003", Content = "Sci-Fi movies inspire imagination.", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT009", UserId = "USR005", BlogPostId = "BLOG003", Content = "I love futuristic technology.", CreatedDate = DateTime.UtcNow },

new Comment { CommentId = "CMT010", UserId = "USR003", BlogPostId = "BLOG004", Content = "Perfect movies for couples.", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT011", UserId = "USR002", BlogPostId = "BLOG004", Content = "Titanic will always be iconic.", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT012", UserId = "USR001", BlogPostId = "BLOG004", Content = "Romantic movies are emotional.", CreatedDate = DateTime.UtcNow },

new Comment { CommentId = "CMT013", UserId = "USR004", BlogPostId = "BLOG005", Content = "Can't wait for next year's movies!", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT014", UserId = "USR003", BlogPostId = "BLOG005", Content = "So many exciting releases.", CreatedDate = DateTime.UtcNow },
new Comment { CommentId = "CMT015", UserId = "USR002", BlogPostId = "BLOG005", Content = "Hope Marvel releases new films!", CreatedDate = DateTime.UtcNow }

);
            modelBuilder.Entity<Cinema>().HasData(

             new Cinema
             {
                 CinemaId = "C001",
                 Name = "CGV Vincom Ba Trieu",
                 Location = "Ha Noi",
                 Rating = "4.5",
                 Hotline = "19006017",
                 CreatedAt = new DateTime(2024, 1, 1),
                 UpdatedAt = new DateTime(2024, 1, 1)
             },

             new Cinema
             {
                 CinemaId = "C002",
                 Name = "Lotte Cinema Landmark",
                 Location = "Ha Noi",
                 Rating = "4.6",
                 Hotline = "1900558899",
                 CreatedAt = new DateTime(2024, 1, 1),
                 UpdatedAt = new DateTime(2024, 1, 1)
             },

             new Cinema
             {
                 CinemaId = "C003",
                 Name = "BHD Star Pham Ngoc Thach",
                 Location = "Ha Noi",
                 Rating = "4.4",
                 Hotline = "19002099",
                 CreatedAt = new DateTime(2024, 1, 1),
                 UpdatedAt = new DateTime(2024, 1, 1)
             }
         );
            modelBuilder.Entity<Room>().HasData(

    new Room
    {
        RoomId = "R001",
        Name = "Room 1",
        CinemaId = "C001"
    },

    new Room
    {
        RoomId = "R002",
        Name = "Room 2",
        CinemaId = "C001"
    },

    new Room
    {
        RoomId = "R003",
        Name = "Room 1",
        CinemaId = "C002"
    },

    new Room
    {
        RoomId = "R004",
        Name = "Room 2",
        CinemaId = "C002"
    },

    new Room
    {
        RoomId = "R005",
        Name = "Room 1",
        CinemaId = "C003"
    }

);
            modelBuilder.Entity<Showtime>().HasData(

        new Showtime
        {
            ShowtimeId = "ST001",
            MovieId = "MOV001",
            RoomId = "R001",
            StartTime = new DateTime(2026, 6, 10, 10, 0, 0),
            EndTime = new DateTime(2026, 6, 10, 13, 1, 0), // 181 phút
            Status = "AVAILABLE",
            CreatedAt = new DateTime(2026, 1, 1),
            UpdatedAt = new DateTime(2026, 1, 1)
        },

        new Showtime
        {
            ShowtimeId = "ST002",
            MovieId = "MOV002",
            RoomId = "R002",
            StartTime = new DateTime(2026, 6, 10, 13, 30, 0),
            EndTime = new DateTime(2026, 6, 10, 15, 58, 0), // 148 phút
            Status = "AVAILABLE",
            CreatedAt = new DateTime(2026, 1, 1),
            UpdatedAt = new DateTime(2026, 1, 1)
        },

        new Showtime
        {
            ShowtimeId = "ST003",
            MovieId = "MOV003",
            RoomId = "R003",
            StartTime = new DateTime(2026, 6, 10, 16, 30, 0),
            EndTime = new DateTime(2026, 6, 10, 19, 26, 0), // 176 phút
            Status = "AVAILABLE",
            CreatedAt = new DateTime(2026, 1, 1),
            UpdatedAt = new DateTime(2026, 1, 1)
        },

        new Showtime
        {
            ShowtimeId = "ST004",
            MovieId = "MOV004",
            RoomId = "R001",
            StartTime = new DateTime(2026, 6, 10, 20, 0, 0),
            EndTime = new DateTime(2026, 6, 10, 22, 6, 0), // 126 phút
            Status = "AVAILABLE",
            CreatedAt = new DateTime(2026, 1, 1),
            UpdatedAt = new DateTime(2026, 1, 1)
        },

        new Showtime
        {
            ShowtimeId = "ST005",
            MovieId = "MOV009",
            RoomId = "R002",
            StartTime = new DateTime(2026, 6, 11, 10, 0, 0),
            EndTime = new DateTime(2026, 6, 11, 13, 12, 0), // 192 phút
            Status = "AVAILABLE",
            CreatedAt = new DateTime(2026, 1, 1),
            UpdatedAt = new DateTime(2026, 1, 1)
        },

        new Showtime
        {
            ShowtimeId = "ST006",
            MovieId = "MOV010",
            RoomId = "R003",
            StartTime = new DateTime(2026, 6, 11, 14, 0, 0),
            EndTime = new DateTime(2026, 6, 11, 16, 11, 0), // 131 phút
            Status = "AVAILABLE",
            CreatedAt = new DateTime(2026, 1, 1),
            UpdatedAt = new DateTime(2026, 1, 1)
        }

    );
            modelBuilder.Entity<TicketType>().HasData(

    new TicketType
    {
        TicketTypeId = "TT001",
        Name = "Standard",
        Status = "ACTIVE"
    },

    new TicketType
    {
        TicketTypeId = "TT002",
        Name = "VIP",
        Status = "ACTIVE"
    },

    new TicketType
    {
        TicketTypeId = "TT003",
        Name = "Couple",
        Status = "ACTIVE"
    }

);
            modelBuilder.Entity<ShowtimeTicketType>().HasData(

    new ShowtimeTicketType
    {
        ShowtimeTicketTypeId = "STT001",
        ShowtimeId = "ST001",
        TicketTypeId = "TT001",
        Price = 80000
    },

    new ShowtimeTicketType
    {
        ShowtimeTicketTypeId = "STT002",
        ShowtimeId = "ST001",
        TicketTypeId = "TT002",
        Price = 120000
    },

    new ShowtimeTicketType
    {
        ShowtimeTicketTypeId = "STT003",
        ShowtimeId = "ST002",
        TicketTypeId = "TT001",
        Price = 85000
    },

    new ShowtimeTicketType
    {
        ShowtimeTicketTypeId = "STT004",
        ShowtimeId = "ST002",
        TicketTypeId = "TT002",
        Price = 125000
    },

    new ShowtimeTicketType
    {
        ShowtimeTicketTypeId = "STT005",
        ShowtimeId = "ST003",
        TicketTypeId = "TT001",
        Price = 90000
    },

    new ShowtimeTicketType
    {
        ShowtimeTicketTypeId = "STT006",
        ShowtimeId = "ST003",
        TicketTypeId = "TT002",
        Price = 130000
    }

);
            modelBuilder.Entity<FoodCombo>().HasData(

    new FoodCombo
    {
        FoodComboId = "FC001",
        Name = "Popcorn + Coke",
        Description = "1 Large Popcorn + 1 Coke",
        Status = "ACTIVE",
        Price = 75000,
        ImageUrl = "https://example.com/images/combo_popcorn_coke.jpg",
        CreatedDate = new DateTime(2024, 1, 1),
        UpdatedDate = new DateTime(2024, 1, 1)
    },

    new FoodCombo
    {
        FoodComboId = "FC002",
        Name = "Couple Combo",
        Description = "1 Large Popcorn + 2 Drinks",
        Status = "ACTIVE",
        Price = 120000,
        ImageUrl = "https://example.com/images/combo_couple.jpg",
        CreatedDate = new DateTime(2024, 1, 1),
        UpdatedDate = new DateTime(2024, 1, 1)
    },

    new FoodCombo
    {
        FoodComboId = "FC003",
        Name = "Family Combo",
        Description = "2 Large Popcorn + 4 Drinks",
        Status = "ACTIVE",
        Price = 200000,
        ImageUrl = "https://example.com/images/combo_family.jpg",
        CreatedDate = new DateTime(2024, 1, 1),
        UpdatedDate = new DateTime(2024, 1, 1)
    },

    new FoodCombo
    {
        FoodComboId = "FC004",
        Name = "Nachos Combo",
        Description = "Nachos + 1 Coke",
        Status = "ACTIVE",
        Price = 85000,
        ImageUrl = "https://example.com/images/combo_nachos.jpg",
        CreatedDate = new DateTime(2024, 1, 1),
        UpdatedDate = new DateTime(2024, 1, 1)
    }

);
            modelBuilder.Entity<Seat>().HasData(

    new Seat { SeatId = "SE001", SeatName = "A1", SeatType = "NORMAL", Status = "AVAILABLE", RoomId = "R001", ShowtimeId = "ST001" },
    new Seat { SeatId = "SE002", SeatName = "A2", SeatType = "NORMAL", Status = "AVAILABLE", RoomId = "R001", ShowtimeId = "ST001" },
    new Seat { SeatId = "SE003", SeatName = "A3", SeatType = "VIP", Status = "AVAILABLE", RoomId = "R001", ShowtimeId = "ST001" },
    new Seat { SeatId = "SE004", SeatName = "A4", SeatType = "VIP", Status = "AVAILABLE", RoomId = "R001", ShowtimeId = "ST001" },

    new Seat { SeatId = "SE005", SeatName = "B1", SeatType = "NORMAL", Status = "AVAILABLE", RoomId = "R002", ShowtimeId = "ST002" },
    new Seat { SeatId = "SE006", SeatName = "B2", SeatType = "NORMAL", Status = "AVAILABLE", RoomId = "R002", ShowtimeId = "ST002" },
    new Seat { SeatId = "SE007", SeatName = "B3", SeatType = "VIP", Status = "AVAILABLE", RoomId = "R002", ShowtimeId = "ST002" },
    new Seat { SeatId = "SE008", SeatName = "B4", SeatType = "VIP", Status = "AVAILABLE", RoomId = "R002", ShowtimeId = "ST002" },

    new Seat { SeatId = "SE009", SeatName = "C1", SeatType = "NORMAL", Status = "AVAILABLE", RoomId = "R003", ShowtimeId = "ST003" },
    new Seat { SeatId = "SE010", SeatName = "C2", SeatType = "NORMAL", Status = "AVAILABLE", RoomId = "R003", ShowtimeId = "ST003" },
    new Seat { SeatId = "SE011", SeatName = "C3", SeatType = "VIP", Status = "AVAILABLE", RoomId = "R003", ShowtimeId = "ST003" },
    new Seat { SeatId = "SE012", SeatName = "C4", SeatType = "VIP", Status = "AVAILABLE", RoomId = "R003", ShowtimeId = "ST003" }

);
            modelBuilder.Entity<SeatLock>().HasData(

    new SeatLock
    {
        SeatLockId = "SL001",
        SeatId = "SE001",
        ShowtimeId = "ST001",
        UserId = "USR001",
        LockedAt = new DateTime(2026, 6, 10, 9, 50, 0),
        ExpiredAt = new DateTime(2026, 6, 10, 9, 55, 0)
    },

    new SeatLock
    {
        SeatLockId = "SL002",
        SeatId = "SE006",
        ShowtimeId = "ST002",
        UserId = "USR001",
        LockedAt = new DateTime(2026, 6, 10, 13, 20, 0),
        ExpiredAt = new DateTime(2026, 6, 10, 13, 25, 0)
    }

);
            modelBuilder.Entity<Voucher>().HasData(

        new Voucher
        {
            VoucherId = "VC001",
            Code = "WELCOME10",
            Title = "Welcome Discount",
            Description = "10% discount for new users",
            Value = 10,
            Status = "ACTIVE",
            CreatedDate = new DateTime(2024, 1, 1),
            ExpiredDate = new DateTime(2027, 1, 1)
        },

        new Voucher
        {
            VoucherId = "VC002",
            Code = "MOVIE50K",
            Title = "50K Off",
            Description = "Get 50,000 VND discount on booking",
            Value = 50000,
            Status = "ACTIVE",
            CreatedDate = new DateTime(2024, 1, 1),
            ExpiredDate = new DateTime(2027, 1, 1)
        },

        new Voucher
        {
            VoucherId = "VC003",
            Code = "WEEKEND20",
            Title = "Weekend Discount",
            Description = "20% off for weekend bookings",
            Value = 20,
            Status = "ACTIVE",
            CreatedDate = new DateTime(2024, 1, 1),
            ExpiredDate = new DateTime(2027, 1, 1)
        },

        new Voucher
        {
            VoucherId = "VC004",
            Code = "STUDENT15",
            Title = "Student Offer",
            Description = "15% discount for students",
            Value = 15,
            Status = "ACTIVE",
            CreatedDate = new DateTime(2024, 1, 1),
            ExpiredDate = new DateTime(2027, 1, 1)
        },

        new Voucher
        {
            VoucherId = "VC005",
            Code = "COMBO30",
            Title = "Combo Discount",
            Description = "30% off when buying food combo",
            Value = 30,
            Status = "ACTIVE",
            CreatedDate = new DateTime(2024, 1, 1),
            ExpiredDate = new DateTime(2027, 1, 1)
        }

    );
            modelBuilder.Entity<Booking>().HasData(

    new Booking
    {
        BookingId = "BK001",
        UserId = "USR001",
        ShowtimeId = "ST001",
        TotalAmount = 15.5,
        Status = "PAID",
        CreatedAt = new DateTime(2026, 6, 10, 9, 30, 0)
    },

    new Booking
    {
        BookingId = "BK002",
        UserId = "USR002",
        ShowtimeId = "ST002",
        TotalAmount = 20,
        Status = "PAID",
        CreatedAt = new DateTime(2026, 6, 10, 12, 0, 0)
    }

    );

            modelBuilder.Entity<BookingSeat>().HasData(

            new BookingSeat
            {
                BookingSeatId = "BKS001",
                BookingId = "BK001",
                SeatId = "SE001",
                ShowtimeTicketTypeId = "STT001",
                Price = 7.5,
                QrCode = "QR001",
                Status = "BOOKED",
                CheckinTime = new DateTime(2026, 6, 10, 10, 0, 0)
            },

            new BookingSeat
            {
                BookingSeatId = "BKS002",
                BookingId = "BK001",
                SeatId = "SE002",
                ShowtimeTicketTypeId = "STT001",
                Price = 8,
                QrCode = "QR002",
                Status = "BOOKED",
                CheckinTime = new DateTime(2026, 6, 10, 10, 0, 0)
            },

            new BookingSeat
            {
                BookingSeatId = "BKS003",
                BookingId = "BK002",
                SeatId = "SE003",
                ShowtimeTicketTypeId = "STT002",
                Price = 10,
                QrCode = "QR003",
                Status = "BOOKED",
                CheckinTime = new DateTime(2026, 6, 10, 13, 0, 0)
            }

            );

            modelBuilder.Entity<BookingFoodCombo>().HasData(

            new BookingFoodCombo
            {
                BookingFoodComboId = "BFC001",
                BookingId = "BK001",
                FoodComboId = "FC001",
                Quantity = 1
            },

            new BookingFoodCombo
            {
                BookingFoodComboId = "BFC002",
                BookingId = "BK002",
                FoodComboId = "FC002",
                Quantity = 2
            }

            );

            modelBuilder.Entity<BookingVoucher>().HasData(

            new BookingVoucher
            {
                BookingId = "BK001",
                VoucherId = "VC001"
            },

            new BookingVoucher
            {
                BookingId = "BK002",
                VoucherId = "VC002"
            }

            );
            modelBuilder.Entity<PaymentMethod>().HasData(
    new PaymentMethod
    {
        PaymentMethodId = "PM001",
        Name = "Credit Card",
        ImageUrl = "https://example.com/creditcard.png",
        Status = "ACTIVE",
        CreatedDate = DateTime.Now,
        UpdatedDate = DateTime.Now
    },
    new PaymentMethod
    {
        PaymentMethodId = "PM002",
        Name = "Momo",
        ImageUrl = "https://example.com/momo.png",
        Status = "ACTIVE",
        CreatedDate = DateTime.Now,
        UpdatedDate = DateTime.Now
    },
    new PaymentMethod
    {
        PaymentMethodId = "PM003",
        Name = "ZaloPay",
        ImageUrl = "https://example.com/zalopay.png",
        Status = "ACTIVE",
        CreatedDate = DateTime.Now,
        UpdatedDate = DateTime.Now
    }
);
            modelBuilder.Entity<Payment>().HasData(
    new Payment
    {
        PaymentId = "PAY001",
        BookingId = "BK001",
        PaymentMethodId = "PM001",
        Amount = 120000,
        Status = "PAID",
        CreatedDate = DateTime.Now
    },
    new Payment
    {
        PaymentId = "PAY002",
        BookingId = "BK002",
        PaymentMethodId = "PM002",
        Amount = 150000,
        Status = "PAID",
        CreatedDate = DateTime.Now
    }
);
        }

    }
}
