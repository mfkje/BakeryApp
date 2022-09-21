using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "af1a2eea-5dbf-4774-b0a4-811483d5d6a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cb1b4a5-448c-414a-b939-a5177f41b892", "AQAAAAEAACcQAAAAEMuCU5tvK2nAFDHOYLGbK2C94Yojp4XMWnJP+EKvW0KficmHWJ1+VeQJb2agoC321Q==", "b1c03c39-1e37-4d41-8bdc-a5039e05c9f9" });

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumns: new[] { "ApplicationUserId", "ProductID" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 1L });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "6e02ed7a-72ca-4cea-8390-33cfc6797d44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a44e4d5-7f83-499d-8570-00743776a5d7", "AQAAAAEAACcQAAAAECS5aGwFiyrsWZDb4SnUVKqBSgW9/S0M7lbZcpArPfTFsvbt4a6BwGV+1ppRsCSLPA==", "2e88d68d-7a5a-48fc-b6b8-c619e8b21c85" });
        }
    }
}
