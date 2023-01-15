using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreWeb7.Migrations
{
    /// <inheritdoc />
    public partial class CourseSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Python ML");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Python");
        }
    }
}
