using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class pauluser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "6193cee3-84d1-4a5d-807a-e7f33c87168b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9573aa6c-2d3e-4c01-9df9-5bd335fec06c", "AQAAAAEAACcQAAAAEOGzh1ix1TnTon/JGaglRMeY5jCi3L6RaJG/W4+Sb6wpAyzTwyAfxj7VmxETMdksew==", "8a46c17b-7649-4651-9285-d40bd2c3d826" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "2cb6386f-8228-4398-acf5-793fe43f3858");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02f664f3-ffc0-4ba0-b469-7a363feabd76", "AQAAAAEAACcQAAAAEPjQlj8pTJtjK9FpruSMBQz+nlnBVTcPAujJ76vWzDpmuvO16dk5S9BIAGGeOJURBA==", "5d1aafde-76af-49db-82d4-b460cead1d21" });
        }
    }
}
