using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tramcan2.models;

namespace tramcan2.form
{
    public partial class fLoaiHang : Form
    {
        public fLoaiHang()
        {
            InitializeComponent();
        }
        CanDbcontext db = new CanDbcontext();

        private void HangHoa_Load(object sender, EventArgs e)
        {

            var result = from c in db.loaiHangs select new {Id=c.Id, Ma = c.Ma, Ten = c.TenLoaiHang, DonGia = c.DonGia, TyLeQuyDoi = c.TyLeQuyDoi };  // c1: lấy ra cái mong muốn, theo thứ tự  //c2 db.Product.tostring(); lấy hết
                                                                                                                                              // var result = from c in db.Products //where c.Id < 10  select c;
            dataGridView1.DataSource = result.ToList();

        }
        void Loaddata()
        {

            var result = from c in db.loaiHangs select  new {Id = c.Id, Ma = c.Ma, Ten = c.TenLoaiHang, DonGia = c.DonGia, TyLeQuyDoi = c.TyLeQuyDoi};  // c1: lấy ra cái mong muốn, theo thứ tự  //c2 db.Product.tostring(); lấy hết
                                                            // var result = from c in db.Products //where c.Id < 10  select c;
            dataGridView1.DataSource = result.ToList();

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string Name_t = textBox_tenLH.Text;

                string Ma = textBox_maLH.Text;

                string DonGia_t = textBox_donGia.Text;
                double DonGia = double.Parse(DonGia_t);
                string TyLeQuyDoi_t = textBox_tyLeQuyDoi.Text;
                int TyLeQuyDoi = int.Parse(TyLeQuyDoi_t);




                LoaiHang LH = new LoaiHang() { TenLoaiHang = Name_t, Ma = Ma, DonGia = DonGia, TyLeQuyDoi = TyLeQuyDoi };

                if (LH != null)
                {
                    db.loaiHangs.Add(LH);
                    db.SaveChanges();
                    Loaddata();

                }
                else
                {
                    MessageBox.Show("Lỗi: " + "không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + "không thêm vào được" +ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_maLH.DataBindings.Clear();
            textBox_maLH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Ma"));
            textBox_tenLH.DataBindings.Clear();
            textBox_tenLH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Ten"));
            textBox_donGia.DataBindings.Clear();
            textBox_donGia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGia"));
            textBox_tyLeQuyDoi.DataBindings.Clear();
            textBox_tyLeQuyDoi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TyLeQuyDoi"));
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLH_t = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int MaLH = int.Parse(MaLH_t);

                LoaiHang LH = db.loaiHangs.Find(MaLH);
                if (LH != null)
                {
                    db.loaiHangs.Remove(LH);
                    db.SaveChanges();
                    Loaddata();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + "không xóa được\n"+ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLH_t = dataGridView1.SelectedRows[0].Cells[0].OwningRow.Cells["Id"].Value.ToString();
                int MaLH = int.Parse(MaLH_t);

                LoaiHang LH = db.loaiHangs.Find(MaLH);
                LH.Ma = textBox_maLH.Text;
                LH.TenLoaiHang = textBox_tenLH.Text;
                LH.DonGia = double.Parse(textBox_donGia.Text);
                LH.TyLeQuyDoi = double.Parse(textBox_tyLeQuyDoi.Text);

                if (LH != null)
                {
                    db.SaveChanges();
                    Loaddata();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + "không xóa được"+ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
