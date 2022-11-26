using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pressao.Migrations
{
    /// <inheritdoc />
    public partial class DataMedicao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataMedicao",
                table: "MyProperty",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataMedicao",
                table: "MyProperty");
        }
    }
}
