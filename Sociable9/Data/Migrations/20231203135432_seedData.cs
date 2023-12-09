using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sociable9.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Family" },
                    { 2, "Friend" },
                    { 3, "Work" },
                    { 4, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ContactID", "Address", "CategoryID", "CreationDate", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Province", "Town", "Username" },
                values: new object[,]
                {
                    { 1, "1234 Street", 1, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1091), "john.doe@example.com", "John", "Doe", "123-456-7890", "12345", "Province", "Townsville", "11contacts" },
                    { 2, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1151), "jane.smith@example.com", "Jane", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 3, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1155), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 4, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1158), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 5, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1161), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 6, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1164), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 7, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1167), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 8, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1171), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 9, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1174), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 10, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1178), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 11, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1181), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "11contacts" },
                    { 12, "5678 Avenue", 2, new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1184), "jenny.smith@example.com", "Jenny", "Smith", "098-765-4321", "54321", "Province", "Citytown", "1contact" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2);
        }
    }
}
