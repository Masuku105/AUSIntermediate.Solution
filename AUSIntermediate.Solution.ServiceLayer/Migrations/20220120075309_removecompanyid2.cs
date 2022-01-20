using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AUSIntermediate.Solution.ServiceLayer.Migrations
{
    public partial class removecompanyid2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 20, 9, 53, 8, 500, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 20, 9, 53, 8, 501, DateTimeKind.Local).AddTicks(5910));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 20, 9, 50, 13, 876, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 20, 9, 50, 13, 877, DateTimeKind.Local).AddTicks(155));
        }
    }
}
