using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pressao.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoNomeTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PressaoSistolica",
                table: "MyProperty",
                newName: "PressaoArterialSistolica");

            migrationBuilder.RenameColumn(
                name: "PressaoDiastalica",
                table: "MyProperty",
                newName: "PressaoArterialDiastalica");

            migrationBuilder.RenameColumn(
                name: "PressaoId",
                table: "MyProperty",
                newName: "PressaoArterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PressaoArterialSistolica",
                table: "MyProperty",
                newName: "PressaoSistolica");

            migrationBuilder.RenameColumn(
                name: "PressaoArterialDiastalica",
                table: "MyProperty",
                newName: "PressaoDiastalica");

            migrationBuilder.RenameColumn(
                name: "PressaoArterialId",
                table: "MyProperty",
                newName: "PressaoId");
        }
    }
}
