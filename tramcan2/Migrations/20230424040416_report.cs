using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace tramcan2.Migrations
{
    public partial class report : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaTruc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    DateTimeFrom = table.Column<DateTime>(nullable: false),
                    DateTimeTo = table.Column<DateTime>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaTruc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatLuongHangHoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma = table.Column<string>(nullable: true),
                    TenChatLuongHangHoa = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLuongHangHoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenKhachHang = table.Column<string>(nullable: true),
                    DtKH = table.Column<int>(nullable: false),
                    DiaChiKH = table.Column<string>(nullable: true),
                    CMNDKH = table.Column<int>(nullable: false),
                    NgayCapKH = table.Column<string>(nullable: true),
                    NoiCapKH = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "KhoHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaKhoHang = table.Column<string>(nullable: true),
                    TenKhoHang = table.Column<string>(nullable: true),
                    DiaChiKhoHang = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KieuCan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenKieuCan = table.Column<string>(nullable: true),
                    SoLanCan = table.Column<int>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    TenThongTinDieuChinh = table.Column<string>(nullable: true),
                    DuLieuDieuChinh = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuCan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma = table.Column<string>(nullable: true),
                    TenLoaiHang = table.Column<string>(nullable: true),
                    DonGia = table.Column<double>(nullable: false),
                    TyLeQuyDoi = table.Column<double>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NguonGocHangHoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma = table.Column<string>(nullable: true),
                    TenNGHH = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguonGocHangHoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhomUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenNhom = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenLaixe = table.Column<string>(nullable: true),
                    KhachHang = table.Column<string>(nullable: true),
                    LoaiHang = table.Column<string>(nullable: true),
                    KhoHang = table.Column<string>(nullable: true),
                    NguonGoc = table.Column<string>(nullable: true),
                    KieuCan = table.Column<string>(nullable: true),
                    ChatLuongHH = table.Column<string>(nullable: true),
                    BienSoDauXe = table.Column<string>(nullable: true),
                    BienSoDuoiXe = table.Column<string>(nullable: true),
                    KhoiLuongL1 = table.Column<float>(nullable: false),
                    KhoiLuongL2 = table.Column<float>(nullable: false),
                    KhoiLuongHang = table.Column<float>(nullable: false),
                    ThoiGianCanL1 = table.Column<string>(nullable: true),
                    ThoiGianCanL2 = table.Column<string>(nullable: true),
                    DonGia = table.Column<float>(nullable: false),
                    ThanhTien = table.Column<float>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TramCan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma = table.Column<string>(nullable: true),
                    TenTramCan = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramCan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TTCanXe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenLaixe = table.Column<string>(nullable: true),
                    KhachHang = table.Column<string>(nullable: true),
                    LoaiHang = table.Column<string>(nullable: true),
                    KhoHang = table.Column<string>(nullable: true),
                    NguonGoc = table.Column<string>(nullable: true),
                    KieuCan = table.Column<string>(nullable: true),
                    ChatLuongHH = table.Column<string>(nullable: true),
                    BienSoDauXe = table.Column<string>(nullable: true),
                    BienSoDuoiXe = table.Column<string>(nullable: true),
                    KhoiLuongL1 = table.Column<float>(nullable: false),
                    KhoiLuongL2 = table.Column<float>(nullable: false),
                    KhoiLuongHang = table.Column<float>(nullable: false),
                    ThoiGianCanL1 = table.Column<string>(nullable: true),
                    ThoiGianCanL2 = table.Column<string>(nullable: true),
                    DonGia = table.Column<float>(nullable: false),
                    ThanhTien = table.Column<float>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTCanXe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BienSoDauXe = table.Column<string>(nullable: false),
                    BienSoCuoiXe = table.Column<string>(nullable: false),
                    TrongTai = table.Column<float>(nullable: false),
                    TenChuXe = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<int>(nullable: false),
                    CMND = table.Column<int>(nullable: false),
                    MaTheXe = table.Column<int>(nullable: false),
                    GhiChuXe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaTruc");

            migrationBuilder.DropTable(
                name: "ChatLuongHangHoa");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "KhoHang");

            migrationBuilder.DropTable(
                name: "KieuCan");

            migrationBuilder.DropTable(
                name: "LoaiHang");

            migrationBuilder.DropTable(
                name: "NguonGocHangHoa");

            migrationBuilder.DropTable(
                name: "NhomUser");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "TramCan");

            migrationBuilder.DropTable(
                name: "TTCanXe");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
