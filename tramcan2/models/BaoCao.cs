using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("Report")]
    internal class Baocao
    {
        [Key]
        public int Id { get; set; }
        public string TenLaixe { get; set; }
        public string KhachHang { get; set; }
        public string LoaiHang { get; set; }
        public string KhoHang { get; set; }
        public string NguonGoc { get; set; }
        public string KieuCan { get; set; }
        public string ChatLuongHH { get; set; }
        public string BienSoDauXe { get; set; }
        public string BienSoDuoiXe { get; set; }
        public float KhoiLuongL1 { get; set; }
        public float KhoiLuongL2 { get; set; }
        public float KhoiLuongHang { get; set; }
        public string ThoiGianCanL1 { get; set; }
        public string ThoiGianCanL2 { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public string GhiChu { get; set; }
    }
}
