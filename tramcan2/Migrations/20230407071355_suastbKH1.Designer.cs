﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using tramcan2.models;

namespace tramcan2.Migrations
{
    [DbContext(typeof(CanDbcontext))]
    [Migration("20230407071355_suastbKH1")]
    partial class suastbKH1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("tramcan2.models.CaTruc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateTimeFrom")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateTimeTo")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("GhiChu")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CaTruc");
                });

            modelBuilder.Entity("tramcan2.models.ChatLuongHangHoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("text");

                    b.Property<string>("Ma")
                        .HasColumnType("text");

                    b.Property<string>("TenChatLuongHangHoa")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ChatLuongHangHoa");
                });

            modelBuilder.Entity("tramcan2.models.KhachHang", b =>
                {
                    b.Property<int>("MaKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CMNDKH")
                        .HasColumnType("integer");

                    b.Property<string>("DiaChiKH")
                        .HasColumnType("text");

                    b.Property<int>("DtKH")
                        .HasColumnType("integer");

                    b.Property<string>("GhiChu")
                        .HasColumnType("text");

                    b.Property<string>("NgayCapKH")
                        .HasColumnType("text");

                    b.Property<string>("NoiCapKH")
                        .HasColumnType("text");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("text");

                    b.HasKey("MaKH");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("tramcan2.models.KhoHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DiaChiKhoHang")
                        .HasColumnType("text");

                    b.Property<string>("GhiChu")
                        .HasColumnType("text");

                    b.Property<string>("TenKhoHang")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("KhoHang");
                });

            modelBuilder.Entity("tramcan2.models.KieuCan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("DuLieuDieuChinh")
                        .HasColumnType("double precision");

                    b.Property<string>("GhiChu")
                        .HasColumnType("text");

                    b.Property<int>("SoLanCan")
                        .HasColumnType("integer");

                    b.Property<string>("TenKieuCan")
                        .HasColumnType("text");

                    b.Property<string>("TenThongTinChua")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("KieuCan");
                });

            modelBuilder.Entity("tramcan2.models.LoaiHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("DonGia")
                        .HasColumnType("double precision");

                    b.Property<string>("GhiChu")
                        .HasColumnType("text");

                    b.Property<string>("Ma")
                        .HasColumnType("text");

                    b.Property<string>("TenLoaiHang")
                        .HasColumnType("text");

                    b.Property<double>("TyLeQuyDoi")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("LoaiHang");
                });

            modelBuilder.Entity("tramcan2.models.NguonGocHangHoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("text");

                    b.Property<string>("Ma")
                        .HasColumnType("text");

                    b.Property<string>("TenNGHH")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("NguonGocHangHoa");
                });

            modelBuilder.Entity("tramcan2.models.NhomUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("text");

                    b.Property<string>("TenNhom")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("NhomUser");
                });

            modelBuilder.Entity("tramcan2.models.TramCan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("text");

                    b.Property<string>("Ma")
                        .HasColumnType("text");

                    b.Property<string>("TenTramCan")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TramCan");
                });

            modelBuilder.Entity("tramcan2.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Ma")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("tramcan2.models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BienSoCuoiXe")
                        .HasColumnType("text");

                    b.Property<string>("BienSoDauXe")
                        .HasColumnType("text");

                    b.Property<int>("CMNDXe")
                        .HasColumnType("integer");

                    b.Property<int>("DTXe")
                        .HasColumnType("integer");

                    b.Property<string>("GhiChuXe")
                        .HasColumnType("text");

                    b.Property<int>("MaTheXe")
                        .HasColumnType("integer");

                    b.Property<double>("TrongTai")
                        .HasColumnType("double precision");

                    b.Property<string>("XeChiCan1Lan")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
