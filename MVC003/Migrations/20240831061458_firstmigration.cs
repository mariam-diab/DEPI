using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_003.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "clients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
