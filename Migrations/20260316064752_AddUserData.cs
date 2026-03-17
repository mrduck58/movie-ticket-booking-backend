using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert Roles
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
            { "1", "Admin" },
            { "2", "User" },
            { "3", "Staff" }
                }
            );

            // Insert Users
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[]
                {
            "UserId","Phone","Email","PasswordHash","FullName",
            "AvatarUrl","Status","CreatedAt","UpdatedAt","RoleId"
                },
                values: new object[,]
                {
            {
                "USER_ADMIN",
                "0900000001",
                "admin@gmail.com",
                "123456",
                "System Admin",
                "https://ui-avatars.com/api/?name=Admin",
                "ACTIVE",
                DateTime.Now,
                DateTime.Now,
                "1"
            },
            {
                "USER_NORMAL",
                "0900000002",
                "user@gmail.com",
                "123456",
                "Normal User",
                "https://ui-avatars.com/api/?name=User",
                "ACTIVE",
                DateTime.Now,
                DateTime.Now,
                "2"
            },
            {
                "USER_STAFF",
                "0900000003",
                "staff@gmail.com",
                "123456",
                "Cinema Staff",
                "https://ui-avatars.com/api/?name=Staff",
                "ACTIVE",
                DateTime.Now,
                DateTime.Now,
                "3"
            }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Delete Users
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USER_ADMIN"
            );

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USER_NORMAL"
            );

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: "USER_STAFF"
            );

            // Delete Roles
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: "ROLE_ADMIN"
            );

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: "ROLE_USER"
            );

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: "ROLE_STAFF"
            );
        }
    }
}
