using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace CodeFirst.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    roomId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Empty = table.Column<bool>(nullable: false),
                    roomnUMBER = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.roomId);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "studentId", "studentName" },
                values: new object[] { 1, "Reham" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "studentId", "studentName" },
                values: new object[] { 2, "Arwa" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "studentId", "studentName" },
                values: new object[] { 3, "Amal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "studentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "studentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "studentId",
                keyValue: 3);
        }
    }
}
