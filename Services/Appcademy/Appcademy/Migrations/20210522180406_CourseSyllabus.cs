using Microsoft.EntityFrameworkCore.Migrations;

namespace Appcademy.Migrations
{
    public partial class CourseSyllabus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Syllabus",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Syllabus",
                table: "Courses");
        }
    }
}
