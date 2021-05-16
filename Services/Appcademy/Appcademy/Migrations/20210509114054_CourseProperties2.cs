using Microsoft.EntityFrameworkCore.Migrations;

namespace Appcademy.Migrations
{
    public partial class CourseProperties2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Courses");
        }
    }
}
