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
    public partial class fNguonGocHangHoa : Form
    {
        public fNguonGocHangHoa()
        {
            InitializeComponent();
            loadata();
        }
        CanDbcontext db = new CanDbcontext();

        void loadata()
        {

            var result = from c in db.nguonGocHangHoas select c;
            dataGridView1.DataSource = result.ToList();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string Name_t = textBox_tenLH.Text;

            string Ma = textBox_maLH.Text;
            string GhiChu = textBox_GhiChu.Text;



            NguonGocHangHoa NGHH = new NguonGocHangHoa() {Ma = Ma , TenNGHH = Name_t, GhiChu=GhiChu};

            if (NGHH != null)
            {
                db.nguonGocHangHoas.Add(NGHH);
                db.SaveChanges();
                loadata();

            }
            else
            {
                MessageBox.Show("Lỗi: " + "không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string Ma_t = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int Ma = int.Parse(Ma_t);

            NguonGocHangHoa KH = db.nguonGocHangHoas.Find(Ma);
            if (KH != null)
            {
                db.nguonGocHangHoas.Remove(KH);
                db.SaveChanges();
                loadata();
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

            NguonGocHangHoa NGHH = db.nguonGocHangHoas.Find(MaKH);
            NGHH.TenNGHH = textBox_tenLH.Text;
            NGHH.GhiChu = textBox_GhiChu.Text;
            

            if (NGHH != null)
            {
                db.SaveChanges();
                loadata();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadata();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_maLH.DataBindings.Clear();
            textBox_maLH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Ma"));
            textBox_tenLH.DataBindings.Clear();
            textBox_tenLH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenNGHH"));
            textBox_GhiChu.DataBindings.Clear();
            textBox_GhiChu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GhiChu"));
        }

        private void textBox_tenLH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_maLH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_GhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
