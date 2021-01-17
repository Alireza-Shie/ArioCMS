using Microsoft.EntityFrameworkCore.Migrations;

namespace Ario.CMS.Data.Migrations
{
    public partial class AddPageTitlePageComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "PageComments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "PageComments");
        }
    }
}
