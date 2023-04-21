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
    public partial class fKhoHang : Form
    {
        public fKhoHang()
        {
            InitializeComponent();
            Loaddata();
        }

        CanDbcontext db = new CanDbcontext();
        void Loaddata()
        {

            var result = from c in db.khoHangs select c;
            dataGridView1.DataSource = result.ToList();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            
            string Name_t = textBox_tenkh.Text;      
            string DiaChiKH_t = textBox_diachikh.Text;
            string Ghichu = textBox_Ghichu.Text;



            KhoHang KH = new KhoHang() { TenKhoHang = Name_t, DiaChiKhoHang = DiaChiKH_t, GhiChu = Ghichu  };

            if (KH != null)
            {
                db.khoHangs.Add(KH);
                db.SaveChanges();
                Loaddata();

            }
            else
            {
                MessageBox.Show("Lỗi: " + "không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            textBox_makh.DataBindings.Clear();
            textBox_makh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Id"));
           
            textBox_tenkh.DataBindings.Clear();
            textBox_tenkh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenKhoHang"));
           
            textBox_diachikh.DataBindings.Clear();
            textBox_diachikh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DiaChiKhoHang"));
            textBox_Ghichu.DataBindings.Clear();
            textBox_Ghichu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GhiChu"));

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string MaKH_t = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int MaKH = int.Parse(MaKH_t);

            KhoHang KH = db.khoHangs.Find(MaKH);
            if (KH != null)
            {
                db.khoHangs.Remove(KH);
                db.SaveChanges();
                Loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string MaKH_t = dataGridView1.SelectedRows[0].Cells[0].OwningRow.Cells["Id"].Value.ToString();
            int MaKH = int.Parse(MaKH_t);

            KhoHang KH = db.khoHangs.Find(MaKH);
            KH.TenKhoHang = textBox_tenkh.Text;
            KH.DiaChiKhoHang = textBox_diachikh.Text;
            KH.GhiChu = textBox_Ghichu.Text;

            if (KH != null)
            {
                db.SaveChanges();
                Loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
