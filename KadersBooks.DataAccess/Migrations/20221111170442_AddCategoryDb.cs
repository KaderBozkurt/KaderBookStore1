using Microsoft.EntityFrameworkCore.Migrations;

namespace KadersBooks.DataAccess.Migrations
{
    public partial class AddCategoryDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identy", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                }); ;
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
