using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Movie_Ticket_Booking_Backend.Data;
using Movie_Ticket_Booking_Backend.Repositories.Implementations.Movies;
using Movie_Ticket_Booking_Backend.Repositories.Implementations.Notificaions;
using Movie_Ticket_Booking_Backend.Repositories.Implementations.Payments;
using Movie_Ticket_Booking_Backend.Repositories.Implementations.Search;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces.Movies;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces.Notifications;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces.Payments;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces.Search;
using Movie_Ticket_Booking_Backend.Services.Implementations;
using Movie_Ticket_Booking_Backend.Services.Implementations.Movie;
using Movie_Ticket_Booking_Backend.Services.Implementations.Notifications;
using Movie_Ticket_Booking_Backend.Services.Implementations.Payments;
using Movie_Ticket_Booking_Backend.Services.Implementations.Search;
using Movie_Ticket_Booking_Backend.Services.Interfaces.Movies;
using Movie_Ticket_Booking_Backend.Services.Interfaces.Notifications;
using Movie_Ticket_Booking_Backend.Services.Interfaces.Payments;
using Movie_Ticket_Booking_Backend.Services.Interfaces.Search;
using System.Text;

namespace Movie_Ticket_Booking_Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // DB
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Services
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<JwtService>();

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            ///watchlist
            builder.Services.AddScoped<IWatchListRepository, WatchListRepository>();
            builder.Services.AddScoped<IWatchListService, WatchListService>();

            ///search
            builder.Services.AddScoped<ISearchRepository, SearchRepository>();
            builder.Services.AddScoped<ISearchService, SearchService>();

            //notifications
            builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
            builder.Services.AddScoped<INotificationService, NotificationService>();

            ///payment_method
            builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            builder.Services.AddScoped<IPaymentMethodService, PaymentMethodService>();
            // CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    policy => policy
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            // JWT
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidAudience = builder.Configuration["Jwt:Audience"],

                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])
                    )
                };
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            // Enable CORS
            app.UseCors("AllowAll");

            // JWT middleware
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}