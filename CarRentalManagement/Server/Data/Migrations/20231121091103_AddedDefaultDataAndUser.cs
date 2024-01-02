using System;
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
            migrationBuilder.RenameColumn(
                name: "CraetedBy",
                table: "Vehicles",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CraetedBy",
                table: "Models",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CraetedBy",
                table: "Makes",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CraetedBy",
                table: "Customers",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CraetedBy",
                table: "Colours",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CraetedBy",
                table: "Bookings",
                newName: "CreatedBy");

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "82765c8a-3c09-41f5-85a4-6c2cd5e14447", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJUSUpVR+s1UUbSZcxPrsXJba70Gmv1G6nmmGEcInj68PqZ5Q3tcC+AA1aktiI/47Q==", null, false, "abf25e30-b0bd-4e2d-b2a4-9a7c6a41499c", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9042), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9046), new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9047), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9526), new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9528), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9530), new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9531), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9825), new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9827), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9829), new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9830), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9832), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9834), new DateTime(2023, 11, 21, 17, 11, 3, 166, DateTimeKind.Local).AddTicks(9835), "Rav4", "System" }
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

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Vehicles",
                newName: "CraetedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Models",
                newName: "CraetedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Makes",
                newName: "CraetedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Customers",
                newName: "CraetedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Colours",
                newName: "CraetedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Bookings",
                newName: "CraetedBy");
        }
    }
}
