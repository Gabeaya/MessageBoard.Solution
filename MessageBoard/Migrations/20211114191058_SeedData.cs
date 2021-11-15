using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Age", "Date", "MessageDescription", "UserName" },
                values: new object[,]
                {
                    { 1, 17, "11-14-2021", "hey pablo ", "Matilda" },
                    { 2, 21, "06-31-1908", "oooooh you nasty", "Rexie" },
                    { 3, 35, "09-26-1998", "who are you sisi", "Matilda" },
                    { 4, 15, "02-10-1996", "My butt itches", "Pip" },
                    { 5, 22, "11-15-1999", "ya that sisi is one looker", "Bartholomew" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5);
        }
    }
}
