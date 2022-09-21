using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class userID_tableA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "ad221e9a-c61f-4f02-8950-77f90daed3b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b510c6e2-7d69-4f24-b0b3-88e55bdb3599", "AQAAAAEAACcQAAAAEBCShTGfOeoBjYeStBar6Uwgy9787UJALNYKg8JxxTv+FlevW8eDxHXylMrnrxkmXQ==", "c90d5301-28e0-41a6-b1bc-1ef1a86eb1cb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "5eea6feb-3e87-4d9e-86d0-7116e01ecf3b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6eccddfc-274a-4d44-97f2-e9646acbfee2", "AQAAAAEAACcQAAAAEHrpi1o0mJ69/CehqFaiTeG+4aZ1ABZUPD49UNF2/5u4nbYFZfJLpA+fciQmNlrE1w==", "0817695e-561a-435b-b667-641c3ab891cb" });
        }
    }
}
