using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class ttcanxems2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhacHang",
                table: "TTCanXe");

            migrationBuilder.AddColumn<string>(
                name: "KhachHang",
                table: "TTCanXe",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhachHang",
                table: "TTCanXe");

            migrationBuilder.AddColumn<string>(
                name: "KhacHang",
                table: "TTCanXe",
                type: "text",
                nullable: true);
        }
    }
}
