using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class vehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CMNDXe",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "DTXe",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "XeChiCan1Lan",
                table: "Vehicle");

            migrationBuilder.AlterColumn<float>(
                name: "TrongTai",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddColumn<int>(
                name: "MachungNhanXe",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoDienThoai",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TenChuXe",
                table: "Vehicle",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachungNhanXe",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "SoDienThoai",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "TenChuXe",
                table: "Vehicle");

            migrationBuilder.AlterColumn<double>(
                name: "TrongTai",
                table: "Vehicle",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<int>(
                name: "CMNDXe",
                table: "Vehicle",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DTXe",
                table: "Vehicle",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "XeChiCan1Lan",
                table: "Vehicle",
                type: "text",
                nullable: true);
        }
    }
}
