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
        }

    }
}
