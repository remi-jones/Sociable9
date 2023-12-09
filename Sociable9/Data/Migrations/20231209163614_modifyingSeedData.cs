using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sociable9.Data.Migrations
{
    /// <inheritdoc />
    public partial class modifyingSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 36, 13, 104, DateTimeKind.Local).AddTicks(7069));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
