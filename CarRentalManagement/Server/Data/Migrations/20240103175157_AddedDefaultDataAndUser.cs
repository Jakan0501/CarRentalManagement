﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "34f72490-2c50-41da-9d2b-d73711b6bfff", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELKL+nQOU4prhQeVajwW5OgelT84TTjUh9wjbrhlPpyDOQEGtKjgD2lX4g/Ty6eQwQ==", null, false, "ad167d94-45da-49e1-a90e-86bd2c78db33", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9091), "Black", "System" },
                    { 2, "System", new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9096), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9582), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9584), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9826), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9827), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9829), "X5", "System" },
                    { 3, "System", new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9831), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9832), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 1, 4, 1, 51, 56, 797, DateTimeKind.Local).AddTicks(9834), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
