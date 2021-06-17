using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRandomizer.Migrations
{
    public partial class AddGroupScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupScore",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupScore",
                table: "Groups");
        }
    }
}
