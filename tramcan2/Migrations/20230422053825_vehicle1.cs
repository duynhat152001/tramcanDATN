using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class vehicle1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachungNhanXe",
                table: "Vehicle");

            migrationBuilder.AddColumn<int>(
                name: "CMND",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CMND",
                table: "Vehicle");

            migrationBuilder.AddColumn<int>(
                name: "MachungNhanXe",
                table: "Vehicle",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
