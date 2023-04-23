using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class modifikhohang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaKhoHang",
                table: "KhoHang",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaKhoHang",
                table: "KhoHang");
        }
    }
}
