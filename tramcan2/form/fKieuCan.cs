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
    public partial class fKieuCan : Form
    {
        public fKieuCan()
        {
            InitializeComponent();
            loadata();
        }

        CanDbcontext db = new CanDbcontext();

        void loadata()
        {
            var result = from c in db.kieuCans select c;
            dataGridView1.DataSource = result.ToList();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string TenKieuCan = textBox_tenkieucan.Text;

            string SoLanCan_t = textBox_solancan.Text;
            int SoLanCan = int.Parse(SoLanCan_t);
            string TenTTDC = textBox_tenttdc.Text;
           
            string DuLieuDC_t = textBox_dulieudieuchinh.Text;
            double? DuLieuDC = double.Parse(DuLieuDC_t);


            KieuCan KC = new KieuCan() { TenKieuCan = TenKieuCan, SoLanCan = SoLanCan, TenThongTinDieuChinh = TenTTDC, DuLieuDieuChinh= DuLieuDC };

            if (KC != null)
            {
                db.kieuCans.Add(KC);
                db.SaveChanges();
                loadata();

            }
            else
            {
                MessageBox.Show("Lỗi: " + "không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
