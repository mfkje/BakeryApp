using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "d7a98d38-6048-4e2b-bbba-3b2f839f9f59");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d3bd539-3983-4800-8ff5-570f592ba803", "AQAAAAEAACcQAAAAEMpekiZ+Widqhf4/betPR2Jf4+VxyVEbdyp3xNpNx0oLP/2uf/Oksq2yB3BTGQprLA==", "decd022c-bdde-4916-9bdf-1e7744dfbd86" });
        }
    }
}
