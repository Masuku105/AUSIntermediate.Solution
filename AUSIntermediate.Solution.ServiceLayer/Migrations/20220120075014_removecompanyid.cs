using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AUSIntermediate.Solution.ServiceLayer.Migrations
{
    public partial class removecompanyid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "ComplexName", "Country", "IsResidentialAddress", "PostalCode", "Province", "Suburb", "UnitNUmber", "UserId" },
                values: new object[,]
                {
                    { 3, "Midrand",  "Business Complex", "South Africa", true, "01100", "Gauteng", "Midrand", "45627", 1 },
                    { 4, "Durban",  "Curry Road", "South Africa", false, "01100", "Kwazulu Natal", "Newlands", "X1234", 1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 4);

           

            

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
    }
}
