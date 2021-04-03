using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitingApp.Migrations
{
    public partial class UpdateRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b59919e1-b407-43d7-8869-0a69c0e36764");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebe2342f-78b9-4c1f-b48b-a40d2dd886f6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1326ae98-d4e2-46b1-8a2d-9641be825ddd", "15d70f81-c50d-4004-a64f-c10cf4ac03db", "Applicant", "APPLICANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59b319bd-d4c3-4e04-9ce6-71fb5ebf24d8", "bacc3c9d-22d5-44af-87e5-fb3cbe4cf298", "Recruiter", "RECRUITER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1326ae98-d4e2-46b1-8a2d-9641be825ddd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59b319bd-d4c3-4e04-9ce6-71fb5ebf24d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b59919e1-b407-43d7-8869-0a69c0e36764", "efa4d999-d863-4adb-bebe-a350874c5bc0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebe2342f-78b9-4c1f-b48b-a40d2dd886f6", "1505b265-d471-4d74-8361-e84db2d582c6", "Admin", "ADMIN" });
        }
    }
}
