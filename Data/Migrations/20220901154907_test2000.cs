using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class test2000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "518c6373-3f22-48ee-bd25-5c67851d5f29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf872d45-d08f-467f-8c34-ce5cdf659d2d", "AQAAAAEAACcQAAAAEAWDzYjq6mvKjg+viCCzJjUzn7xZzcaWfeUT9KgaFxLGqWmHtOjZyKLFaLAhVtQhag==", "b7181228-1e7a-4100-bbfa-7f1fd9725cba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "d30967fa-0d11-4fcf-b4e4-7483d00bf9e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2b2d613-a6cc-498e-9cd7-0ad177b0e9db", "AQAAAAEAACcQAAAAEME0+VvlwVul/YNJQG6blMsCuiw6iIg2vxnHrsMPRGQRSZRqdpTOSlvR86Va7jg1eA==", "71b56403-741f-410e-82e9-66a6a16ed29e" });
        }
    }
}
