using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pressao.Migrations
{
    /// <inheritdoc />
    public partial class Risco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassificaoMedida",
                table: "MyProperty",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassificaoMedida",
                table: "MyProperty");
        }
    }
}
