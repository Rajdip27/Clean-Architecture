using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Email", "FirstName", "LastName", "Password", "Phone", "Status", "UpdateBy", "UpdateDate", "UserName" },
                values: new object[] { 1, "1", new DateTimeOffset(new DateTime(2023, 6, 25, 1, 52, 41, 817, DateTimeKind.Unspecified).AddTicks(3439), new TimeSpan(0, 6, 0, 0, 0)), "Srajdip920@gmail.com", "Rajdip", "Raj", "456789", "123315", 1, null, null, "SantanuRaj" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
