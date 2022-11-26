using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pressao.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigração : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    PressaoId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PressaoSistolica = table.Column<int>(type: "INTEGER", nullable: false),
                    PressaoDiastalica = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.PressaoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyProperty");
        }
    }
}
