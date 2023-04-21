using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class ttcanxems1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChatLuongHH",
                table: "TTCanXe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KieuCan",
                table: "TTCanXe",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChatLuongHH",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "KieuCan",
                table: "TTCanXe");
        }
    }
}
