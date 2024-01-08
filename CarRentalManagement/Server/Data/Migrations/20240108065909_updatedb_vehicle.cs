using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedb_vehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Colours_ColourId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "LicensePlate",
                table: "Vehicles",
                newName: "LicensePlateNumber");

            migrationBuilder.AlterColumn<int>(
                name: "ColourId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Colours_ColourId",
                table: "Vehicles",
                column: "ColourId",
                principalTable: "Colours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Colours_ColourId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "LicensePlateNumber",
                table: "Vehicles",
                newName: "LicensePlate");

            migrationBuilder.AlterColumn<int>(
                name: "ColourId",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34f72490-2c50-41da-9d2b-d73711b6bfff", "AQAAAAIAAYagAAAAELKL+nQOU4prhQeVajwW5OgelT84TTjUh9wjbrhlPpyDOQEGtKjgD2lX4g/Ty6eQwQ==", "ad167d94-45da-49e1-a90e-86bd2c78db33" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9826), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9831), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Colours_ColourId",
                table: "Vehicles",
                column: "ColourId",
                principalTable: "Colours",
                principalColumn: "Id");
        }
    }
}
