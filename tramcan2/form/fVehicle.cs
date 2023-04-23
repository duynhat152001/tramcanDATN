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
    public partial class fVehicle : Form
    {
        public fVehicle()
        {
            InitializeComponent();
            Loaddata();
        }
        CanDbcontext db = new CanDbcontext();
        void Loaddata()
        {

            var result = from c in db.vehicles select new { MaTheXe = c.Id, BienSoDauXe = c.BienSoDauXe, BienSoCuoiXe = c.BienSoCuoiXe,TrongTaiTho = c.TrongTai,TenChuXe=c.TenChuXe,
                                                            CMND=c.CMND,SoDienThoai=c.SoDienThoai,GhiChu = c.GhiChuXe };  
            dataGridView1.DataSource = result.ToList();

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {

               Vehicle VH = new Vehicle() {GhiChuXe=textBox_ghichu.Text , BienSoDauXe = textBox_biensodauxe.Text , BienSoCuoiXe = textBox_biensoduoixe.Text,TenChuXe=textBox_tenchuxe.Text,
                                            SoDienThoai=int.Parse(textBox_sodienthoai.Text),CMND=int.Parse(textBox_CMND.Text) };

                if (VH!=null)
                {
                    db.vehicles.Add(VH);
                    db.SaveChanges();
                    Loaddata();

                }
                else
                {
                    MessageBox.Show("Lỗi: " + "không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + "không thêm vào được" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaVH_t = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int MaVH = int.Parse(MaVH_t);

                Vehicle VH = db.vehicles.Find(MaVH);
                if (VH != null)
                {
                    db.vehicles.Remove(VH);
                    db.SaveChanges();
                    Loaddata();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + "không xóa được\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string MaVH_t = dataGridView1.SelectedRows[0].Cells[0].OwningRow.Cells["MaTheXe"].Value.ToString();
                int MaVH = int.Parse(MaVH_t);

                Vehicle VH = db.vehicles.Find(MaVH);
                VH.BienSoDauXe = textBox_biensodauxe.Text;
                VH.BienSoCuoiXe = textBox_biensoduoixe.Text;
                VH.GhiChuXe = textBox_ghichu.Text;
                VH.TrongTai = float.Parse(textBox_trongtaitho.Text);
                VH.TenChuXe = textBox_tenchuxe.Text;
                VH.SoDienThoai = int.Parse(textBox_sodienthoai.Text);
                VH.CMND = int.Parse(textBox_CMND.Text);

                if (VH!= null)
                {
                    db.SaveChanges();
                    Loaddata();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + "không xóa được" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_mathe.DataBindings.Clear();
                textBox_mathe.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaTheXe"));
                textBox_biensodauxe.DataBindings.Clear();
                textBox_biensodauxe.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "BienSoDauXe"));
                textBox_biensoduoixe.DataBindings.Clear();
                textBox_biensoduoixe.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "BienSoCuoiXe"));
                textBox_trongtaitho.DataBindings.Clear();
                textBox_trongtaitho.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TrongTaiTho"));
                textBox_tenchuxe.DataBindings.Clear();
                textBox_tenchuxe.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenChuXe"));
                textBox_sodienthoai.DataBindings.Clear();
                textBox_sodienthoai.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoDienThoai"));
                textBox_CMND.DataBindings.Clear();
                textBox_CMND.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "CMND"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + "" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

     
        
    }
}
