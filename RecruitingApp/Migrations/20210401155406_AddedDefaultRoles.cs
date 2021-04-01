using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitingApp.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "kalle.kullonen@gmail.com", "Kalle", "Kukkonen" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebe2342f-78b9-4c1f-b48b-a40d2dd886f6", "1505b265-d471-4d74-8361-e84db2d582c6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b59919e1-b407-43d7-8869-0a69c0e36764", "efa4d999-d863-4adb-bebe-a350874c5bc0", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b59919e1-b407-43d7-8869-0a69c0e36764");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebe2342f-78b9-4c1f-b48b-a40d2dd886f6");

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "atte.henkonen@outlook.com", "Atte", "Henkonen" });
        }
    }
}
