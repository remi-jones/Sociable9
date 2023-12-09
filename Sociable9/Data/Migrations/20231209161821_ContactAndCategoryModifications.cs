using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sociable9.Data.Migrations
{
    /// <inheritdoc />
    public partial class ContactAndCategoryModifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Contact",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 18, 19, 954, DateTimeKind.Local).AddTicks(1632));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
