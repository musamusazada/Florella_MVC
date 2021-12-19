using Microsoft.EntityFrameworkCore.Migrations;

namespace Florella_MVC.Migrations
{
    public partial class LayoutCreated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Layout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slogan = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    facebook_url = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    twitter_url = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layout", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Layout");
        }
    }
}
