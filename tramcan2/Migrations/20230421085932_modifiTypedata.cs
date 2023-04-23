using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class modifiTypedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "KhoiLuongL2",
                table: "TTCanXe",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<float>(
                name: "KhoiLuongL1",
                table: "TTCanXe",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<float>(
                name: "KhoiLuongHang",
                table: "TTCanXe",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "KhoiLuongL2",
                table: "TTCanXe",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "KhoiLuongL1",
                table: "TTCanXe",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "KhoiLuongHang",
                table: "TTCanXe",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
