using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tramcan2.models;

namespace tramcan2.form
{
    public partial class fReport: Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void fReport_Load(object sender, EventArgs e)
        {

            CanDbcontext dbcontext = new CanDbcontext();
            List<Baocao> listbaocao = dbcontext.baocaos.ToList();
            foreach(Baocao s in listbaocao.ToList())
            {
                Baocao tmp = new Baocao();
                tmp.KhachHang = s.KhachHang;    
                tmp.KhoHang = s.KhoHang;
                tmp.ThoiGianCanL1 = s.ThoiGianCanL1;
                tmp.ThoiGianCanL2 = s.ThoiGianCanL2;
                tmp.KieuCan = s.KieuCan;
                tmp.BienSoDauXe = s.BienSoDauXe;
                tmp.BienSoDuoiXe = s.BienSoDuoiXe;
                tmp.ChatLuongHH = s.ChatLuongHH;
                tmp.DonGia = s.DonGia;
                tmp.GhiChu = s.GhiChu;
                tmp.Id = s.Id;
                tmp.KhoiLuongHang = s.KhoiLuongHang;
                tmp.KhoiLuongL1 = s.KhoiLuongL1;
                tmp.KhoiLuongL2 = s.KhoiLuongL2;
                tmp.LoaiHang = s.LoaiHang;
                tmp.NguonGoc = s.NguonGoc;
                tmp.TenLaixe = s.TenLaixe;
                tmp.ThanhTien = s.ThanhTien;
                tmp.ThoiGianCanL1 = s.ThoiGianCanL1;
                tmp.ThoiGianCanL2 = s.ThoiGianCanL2;
                listbaocao.Add(tmp);
            }
            reportViewer1.LocalReport.ReportPath = "Report.rdlc";
            var source = new ReportDataSource("BaoCaoDataset", listbaocao);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
