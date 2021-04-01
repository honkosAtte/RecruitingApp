using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitingApp.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, ".Net, SQL, Entity Framework", "Ohjelmistosuunnittelija" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Pensselit, ja vesivärit", "Taitelija" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Haetaan rakennusalan ammattilaista", "Rappari" });

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "Id", "Application", "Email", "FirstName", "JobId", "LastName" },
                values: new object[] { 1, "Haen tähän paikkaan, koska haen tähän paikkaan", "atte.henkonen@outlook.com", "Atte", 1, "Henkonen" });

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "Id", "Application", "Email", "FirstName", "JobId", "LastName" },
                values: new object[] { 2, "Haen tähän paikkaan, koska tarvitsen rahaa", "markku.miettinen@outlook.com", "Markku", 2, "Miettinen" });

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "Id", "Application", "Email", "FirstName", "JobId", "LastName" },
                values: new object[] { 3, "Haen tähän paikkaan, koska haluan rapata", "atte.henkonen@outlook.com", "Atte", 3, "Henkonen" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
