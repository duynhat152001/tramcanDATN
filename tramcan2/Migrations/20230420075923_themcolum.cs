using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class themcolum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "TTCanXe");

            migrationBuilder.AddColumn<double>(
                name: "KhoiLuongHang",
                table: "TTCanXe",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ThoiGianCanL1",
                table: "TTCanXe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThoiGianCanL2",
                table: "TTCanXe",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhoiLuongHang",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "ThoiGianCanL1",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "ThoiGianCanL2",
                table: "TTCanXe");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "TTCanXe",
                type: "text",
                nullable: true);
        }
    }
}
