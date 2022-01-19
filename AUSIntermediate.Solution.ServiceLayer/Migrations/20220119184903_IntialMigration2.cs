using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AUSIntermediate.Solution.ServiceLayer.Migrations
{
    public partial class IntialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 19, 20, 49, 2, 794, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 19, 20, 49, 2, 795, DateTimeKind.Local).AddTicks(8598));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 19, 20, 47, 35, 28, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 19, 20, 47, 35, 29, DateTimeKind.Local).AddTicks(4874));
        }
    }
}
