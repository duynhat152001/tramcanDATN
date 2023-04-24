using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using tramcan2.Migrations;

namespace tramcan2.models
{
     class CanDbcontext : DbContext
    {
       public DbSet<User> users { get; set; }
       public DbSet<Vehicle> vehicles { get; set; }
       public DbSet<NhomUser> nhomUsers { get; set; }
       public DbSet<KhachHang> khachHangs { get; set; }
       public DbSet<KieuCan> kieuCans { get; set; }
       public DbSet<CaTruc> caTrucs { get; set; }
       public DbSet<LoaiHang> loaiHangs { get; set; }
       public DbSet<KhoHang> khoHangs { get; set; }
       public DbSet<NguonGocHangHoa> nguonGocHangHoas { get; set; }
       public DbSet<ChatLuongHangHoa> chatLuongHangHoas { get; set; }
       public DbSet<TramCan> tramCans { get; set; }
       public DbSet<TTCanXe> tTCanXes { get; set; }
       public DbSet<Baocao> baocaos { get; set; }

        private const string conn = (@"server=localhost;Port=5432;User Id=postgres;Password=minhquy2001;Database=tramcan");

        public CanDbcontext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(conn);
        }
    }
}
