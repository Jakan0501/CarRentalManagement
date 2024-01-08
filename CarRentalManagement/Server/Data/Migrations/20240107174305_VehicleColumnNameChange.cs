using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class VehicleColumnNameChange : Migration
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
                values: new object[] { "e2a0215c-a016-45f2-81c5-a8f442058210", "AQAAAAIAAYagAAAAEIJoviW+69PW1W3/jPj9bfFBUYyFjqqeOYvwIvCFrVvz0ovD5wwbPfBYpQbB3LReOQ==", "e31b9a39-61d7-457f-a4b4-f5aeaf7960ab" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 43, 4, 644, DateTimeKind.Local).AddTicks(8135), new DateTime(2024, 1, 7, 23, 43, 4, 644, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 43, 4, 644, DateTimeKind.Local).AddTicks(8167), new DateTime(2024, 1, 7, 23, 43, 4, 644, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 43, 4, 644, DateTimeKind.Local).AddTicks(9954), new DateTime(2024, 1, 7, 23, 43, 4, 644, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 43, 4, 644, DateTimeKind.Local).AddTicks(9965), new DateTime(2024, 1, 7, 23, 43, 4, 644, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 43, 4, 645, DateTimeKind.Local).AddTicks(937), new DateTime(2024, 1, 7, 23, 43, 4, 645, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 43, 4, 645, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 1, 7, 23, 43, 4, 645, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 43, 4, 645, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 1, 7, 23, 43, 4, 645, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 43, 4, 645, DateTimeKind.Local).AddTicks(960), new DateTime(2024, 1, 7, 23, 43, 4, 645, DateTimeKind.Local).AddTicks(961) });

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
