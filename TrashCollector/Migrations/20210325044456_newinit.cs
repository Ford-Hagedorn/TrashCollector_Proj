using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class newinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ce8fc77-e842-4f8d-bcba-802502e9072e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e4932f3-7293-4cd1-9b8f-7fa81216cf83");

            migrationBuilder.DropColumn(
                name: "Calendar",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "AddBalance",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GetCustomer",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GetDayOfTheWeek",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e97ab7b-bc2f-4f6e-b7bb-cd121ba0979b", "7feb84d2-4f7d-460b-b924-3c7d98aea815", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b78f9f0f-835e-4b4a-bcfc-2b12dc62e6a7", "7a63a113-d3b1-40e6-845b-494ede907855", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e97ab7b-bc2f-4f6e-b7bb-cd121ba0979b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b78f9f0f-835e-4b4a-bcfc-2b12dc62e6a7");

            migrationBuilder.DropColumn(
                name: "AddBalance",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "GetCustomer",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "GetDayOfTheWeek",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Customer");

            migrationBuilder.AddColumn<DateTime>(
                name: "Calendar",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ce8fc77-e842-4f8d-bcba-802502e9072e", "abfcb9b9-fe3c-4db8-bee9-a28750183602", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e4932f3-7293-4cd1-9b8f-7fa81216cf83", "69085558-df55-4648-99a5-06fffc0ed7eb", "Customer", "CUSTOMER" });
        }
    }
}
