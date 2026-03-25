using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserVoucherTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM001",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 25, 19, 14, 31, 711, DateTimeKind.Local).AddTicks(1915), new DateTime(2026, 3, 25, 19, 14, 31, 711, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM002",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 25, 19, 14, 31, 711, DateTimeKind.Local).AddTicks(1932), new DateTime(2026, 3, 25, 19, 14, 31, 711, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM003",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 25, 19, 14, 31, 711, DateTimeKind.Local).AddTicks(1935), new DateTime(2026, 3, 25, 19, 14, 31, 711, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.InsertData(
                table: "UserVouchers",
                columns: new[] { "UserId", "VoucherId", "Status", "UsedAt", "UserVoucherId" },
                values: new object[,]
                {
                    { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC001", "AVAILABLE", null, "UV001" },
                    { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC002", "AVAILABLE", null, "UV002" },
                    { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC003", "AVAILABLE", null, "UV003" },
                    { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC004", "AVAILABLE", null, "UV004" },
                    { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC005", "AVAILABLE", null, "UV005" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserVouchers",
                keyColumns: new[] { "UserId", "VoucherId" },
                keyValues: new object[] { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC001" });

            migrationBuilder.DeleteData(
                table: "UserVouchers",
                keyColumns: new[] { "UserId", "VoucherId" },
                keyValues: new object[] { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC002" });

            migrationBuilder.DeleteData(
                table: "UserVouchers",
                keyColumns: new[] { "UserId", "VoucherId" },
                keyValues: new object[] { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC003" });

            migrationBuilder.DeleteData(
                table: "UserVouchers",
                keyColumns: new[] { "UserId", "VoucherId" },
                keyValues: new object[] { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC004" });

            migrationBuilder.DeleteData(
                table: "UserVouchers",
                keyColumns: new[] { "UserId", "VoucherId" },
                keyValues: new object[] { "a08ab0bf-e5d3-41aa-81bf-e6df209b2bab", "VC005" });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM001",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 25, 19, 8, 44, 217, DateTimeKind.Local).AddTicks(3372), new DateTime(2026, 3, 25, 19, 8, 44, 217, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM002",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 25, 19, 8, 44, 217, DateTimeKind.Local).AddTicks(3383), new DateTime(2026, 3, 25, 19, 8, 44, 217, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM003",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 25, 19, 8, 44, 217, DateTimeKind.Local).AddTicks(3386), new DateTime(2026, 3, 25, 19, 8, 44, 217, DateTimeKind.Local).AddTicks(3386) });
        }
    }
}
