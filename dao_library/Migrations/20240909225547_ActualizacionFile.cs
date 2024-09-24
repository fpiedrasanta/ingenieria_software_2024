using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daolibrary.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path2",
                table: "File",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path2",
                table: "File");
        }
    }
}
