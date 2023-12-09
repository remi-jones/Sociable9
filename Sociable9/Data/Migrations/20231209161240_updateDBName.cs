using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sociable9.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateDBName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 12, 39, 565, DateTimeKind.Local).AddTicks(1842));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2023, 12, 3, 9, 54, 31, 622, DateTimeKind.Local).AddTicks(1184));
        }
    }
}
