using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class kieucan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenThongTinChua",
                table: "KieuCan");

            migrationBuilder.AddColumn<string>(
                name: "TenThongTinDieuChinh",
                table: "KieuCan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenThongTinDieuChinh",
                table: "KieuCan");

            migrationBuilder.AddColumn<string>(
                name: "TenThongTinChua",
                table: "KieuCan",
                type: "text",
                nullable: true);
        }
    }
}
