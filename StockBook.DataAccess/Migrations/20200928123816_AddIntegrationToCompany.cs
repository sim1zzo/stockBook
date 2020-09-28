using Microsoft.EntityFrameworkCore.Migrations;

namespace StockBook.DataAccess.Migrations
{
    public partial class AddIntegrationToCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "Companies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
