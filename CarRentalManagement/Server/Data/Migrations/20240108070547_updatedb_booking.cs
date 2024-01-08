using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedb_booking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a74646aa-0a22-4702-a57b-8290752bf034", "AQAAAAIAAYagAAAAELasBDumcMzAkWGRB14TmhASk9vmkJfGc/+j3w+7QVWO74auk2WFjv4DJHTgeR9L8Q==", "97dd166d-8ebc-4a2b-859f-9ed21c8fc644" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3054), new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3070), new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3671), new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3673), new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3675), new DateTime(2024, 1, 8, 15, 5, 47, 471, DateTimeKind.Local).AddTicks(3676) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35597767-0f73-43dc-b4f2-7b4f754cc56a", "AQAAAAIAAYagAAAAEIPzC+GbreMiQuNJIaIwnF/vFWn0SAmlhE0JUGnSYVABJnXSOLxHlNEhqxDeQ0vcKw==", "570c9226-ea1b-4cc7-8aa9-836c22ee429e" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(6768), new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(6787), new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7421), new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7423), new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7426), new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7428), new DateTime(2024, 1, 8, 14, 59, 9, 722, DateTimeKind.Local).AddTicks(7428) });
        }
    }
}
