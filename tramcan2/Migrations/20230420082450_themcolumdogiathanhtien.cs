using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class themcolumdogiathanhtien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "DonGia",
                table: "TTCanXe",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ThanhTien",
                table: "TTCanXe",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DonGia",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "ThanhTien",
                table: "TTCanXe");
        }
    }
}
