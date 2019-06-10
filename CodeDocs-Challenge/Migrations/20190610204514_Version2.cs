using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeDocs_Challenge.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    SourceUrl = table.Column<string>(nullable: true),
                    ImgBlob = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: false),
                    ContentMD = table.Column<string>(nullable: true),
                    ContentHtml = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
