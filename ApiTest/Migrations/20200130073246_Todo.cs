using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiTest.Migrations
{
    public partial class Todo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    activity = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true,defaultValue:"Progress"),
                    CreatedAt = table.Column<DateTime>(nullable: true,defaultValue:DateTime.Now),
                    PublishedAt = table.Column<DateTime>(nullable: true,defaultValue:DateTime.Now)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
