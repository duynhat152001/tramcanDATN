using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class ttcanxems3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ma",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TTCanXe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "TTCanXe",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TTCanXe",
                type: "text",
                nullable: true);
        }
    }
}
