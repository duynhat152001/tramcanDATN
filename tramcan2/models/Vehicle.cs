using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tramcan2.models
{
    [Table("Vehicle")]
    internal class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BienSoDauXe { get; set; }
        [Required]
        public string BienSoCuoiXe { get; set; }
        [Required]
        public float TrongTai { get; set; }
        public string TenChuXe { get; set; }
        public int SoDienThoai { get; set; }
        public int CMND { get; set; }
        public int MaTheXe { get; set; }
        public string GhiChuXe { get; set; }
        
    }
}
