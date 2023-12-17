using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class I3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "students");
        }
    }
}
