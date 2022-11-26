using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pressao.Migrations
{
    /// <inheritdoc />
    public partial class Decimaiseclassificaçãoderisco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PressaoArterialSistolica",
                table: "MyProperty",
                type: "decimal(3,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<decimal>(
                name: "PressaoArterialDiastalica",
                table: "MyProperty",
                type: "decimal(3,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PressaoArterialSistolica",
                table: "MyProperty",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)");

            migrationBuilder.AlterColumn<int>(
                name: "PressaoArterialDiastalica",
                table: "MyProperty",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)");
        }
    }
}
