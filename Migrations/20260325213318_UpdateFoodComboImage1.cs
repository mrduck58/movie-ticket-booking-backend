using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_Ticket_Booking_Backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFoodComboImage1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC001",
                column: "ImageUrl",
                value: "https://www.bhdstar.vn/wp-content/uploads/2025/06/SINGLE-COMBO-1-1.jpg");

            migrationBuilder.UpdateData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC002",
                column: "ImageUrl",
                value: "https://www.bhdstar.vn/wp-content/uploads/2025/06/COUPLE-COMBO-1-1.jpg");

            migrationBuilder.UpdateData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC003",
                column: "ImageUrl",
                value: "https://www.bhdstar.vn/wp-content/uploads/2025/05/TRA-3-VI-2-1.jpg");

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM001",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 4, 33, 17, 956, DateTimeKind.Local).AddTicks(5084), new DateTime(2026, 3, 26, 4, 33, 17, 956, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM002",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 4, 33, 17, 956, DateTimeKind.Local).AddTicks(5096), new DateTime(2026, 3, 26, 4, 33, 17, 956, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM003",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 4, 33, 17, 956, DateTimeKind.Local).AddTicks(5097), new DateTime(2026, 3, 26, 4, 33, 17, 956, DateTimeKind.Local).AddTicks(5102) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC001",
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1585238342024-78d387f4a707");

            migrationBuilder.UpdateData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC002",
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1600891964599-f61ba0e24092");

            migrationBuilder.UpdateData(
                table: "FoodCombos",
                keyColumn: "FoodComboId",
                keyValue: "FC003",
                column: "ImageUrl",
                value: "https://images.unsplash.com/photo-1598515214211-89d3c73ae83b");

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM001",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 4, 15, 39, 174, DateTimeKind.Local).AddTicks(2184), new DateTime(2026, 3, 26, 4, 15, 39, 174, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM002",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 4, 15, 39, 174, DateTimeKind.Local).AddTicks(2198), new DateTime(2026, 3, 26, 4, 15, 39, 174, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "PaymentMethodId",
                keyValue: "PM003",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 26, 4, 15, 39, 174, DateTimeKind.Local).AddTicks(2201), new DateTime(2026, 3, 26, 4, 15, 39, 174, DateTimeKind.Local).AddTicks(2201) });
        }
    }
}
