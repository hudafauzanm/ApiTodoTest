using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiTest.Migrations
{
    public partial class update_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishedAt",
                table: "Todo",
                newName: "publishedat");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Todo",
                newName: "createdat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publishedat",
                table: "Todo",
                newName: "PublishedAt");

            migrationBuilder.RenameColumn(
                name: "createdat",
                table: "Todo",
                newName: "CreatedAt");
        }
    }
}
