using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e93551e-3b4a-41b6-b4ab-05a45f74b19a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bee0bfa-95b2-44d9-a73e-49672a937e3f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ce8fc77-e842-4f8d-bcba-802502e9072e", "abfcb9b9-fe3c-4db8-bee9-a28750183602", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e4932f3-7293-4cd1-9b8f-7fa81216cf83", "69085558-df55-4648-99a5-06fffc0ed7eb", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ce8fc77-e842-4f8d-bcba-802502e9072e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e4932f3-7293-4cd1-9b8f-7fa81216cf83");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e93551e-3b4a-41b6-b4ab-05a45f74b19a", "231ae805-7dd5-41ed-a601-b3c64455912c", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bee0bfa-95b2-44d9-a73e-49672a937e3f", "bc131cfa-b80e-4d26-bf4f-9a1f185af6f7", "Customer", "CUSTOMER" });
        }
    }
}
