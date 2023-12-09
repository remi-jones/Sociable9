using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sociable9.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedDataAndChangeDBName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2023, 12, 9, 12, 37, 10, 841, DateTimeKind.Local).AddTicks(3851));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
