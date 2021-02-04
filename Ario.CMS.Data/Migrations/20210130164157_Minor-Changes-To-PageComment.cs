using Microsoft.EntityFrameworkCore.Migrations;

namespace Ario.CMS.Data.Migrations
{
    public partial class MinorChangesToPageComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "PageComments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "PageComments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
