using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AUSIntermediate.Solution.ServiceLayer.Migrations
{
    public partial class removecompanyid3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 20, 10, 2, 47, 562, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 20, 10, 2, 47, 563, DateTimeKind.Local).AddTicks(9293));

          

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
