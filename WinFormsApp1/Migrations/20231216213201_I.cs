using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class I : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    student_id = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    weight = table.Column<int>(type: "INTEGER", nullable: false),
                    gpa = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => new { x.student_id, x.name });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "subjects");
        }
    }
}
