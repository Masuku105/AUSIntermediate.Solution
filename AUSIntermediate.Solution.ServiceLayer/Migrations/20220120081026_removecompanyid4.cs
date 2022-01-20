using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AUSIntermediate.Solution.ServiceLayer.Migrations
{
    public partial class removecompanyid4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 20, 10, 10, 25, 618, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2022, 1, 20, 10, 10, 25, 619, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CompanyId",
                table: "Addresses",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Companies_CompanyId",
                table: "Addresses",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Companies_CompanyId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CompanyId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Addresses");

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
    }
}
