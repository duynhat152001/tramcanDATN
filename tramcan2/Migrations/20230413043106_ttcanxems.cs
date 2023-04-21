using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class ttcanxems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "IdNhomUser",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "TTCanXe");

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "TTCanXe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KhacHang",
                table: "TTCanXe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KhoHang",
                table: "TTCanXe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoaiHang",
                table: "TTCanXe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguonGoc",
                table: "TTCanXe",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "KhacHang",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "KhoHang",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "LoaiHang",
                table: "TTCanXe");

            migrationBuilder.DropColumn(
                name: "NguonGoc",
                table: "TTCanXe");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TTCanXe",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdNhomUser",
                table: "TTCanXe",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "TTCanXe",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "TTCanXe",
                type: "text",
                nullable: true);
        }
    }
}
