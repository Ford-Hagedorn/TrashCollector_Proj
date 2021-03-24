using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class nukenew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "398aab4c-d755-4f60-b7b8-b0fa1eedba13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfb8ebcb-c6bd-4238-9892-2a083658bdcb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b16ff46c-9982-43ab-92db-2313bef6c6d2", "858aff1d-fc42-4dac-a395-5dc6544e67e7", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0c73abe-e3d6-4c2a-9335-e2d32537a3dd", "dce23266-2b96-42d3-aff9-9713d558d9f8", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b16ff46c-9982-43ab-92db-2313bef6c6d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0c73abe-e3d6-4c2a-9335-e2d32537a3dd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "398aab4c-d755-4f60-b7b8-b0fa1eedba13", "ce0e76c8-4ce1-4e1f-a09e-df7ac09c052f", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfb8ebcb-c6bd-4238-9892-2a083658bdcb", "13d8725e-5e18-4d23-8098-a25f9378a78a", "Customer", "CUSTOMER" });
        }
    }
}
