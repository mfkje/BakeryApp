using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "414ad103-53be-478e-ba30-d346c63bf20b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "262b0992-93fc-4314-9035-514a7c276ab1", "AQAAAAEAACcQAAAAEFoVoW6umP0c7PpnI2D8FBaDN3icr4f30/wmfhR9EQZ+8Rz0LzAUP+ONlip9n1vxmA==", "e20046fb-8c30-4753-824c-58861a56c96c" });
        }
    }
}
