using Microsoft.EntityFrameworkCore.Migrations;

namespace tramcan2.Migrations
{
    public partial class reqiured : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BienSoDauXe",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BienSoCuoiXe",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BienSoDauXe",
                table: "Vehicle",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BienSoCuoiXe",
                table: "Vehicle",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
