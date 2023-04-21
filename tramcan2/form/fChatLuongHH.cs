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
    public partial class fChatLuongHH : Form
    {
        public fChatLuongHH()
        {
            InitializeComponent();
            loaddata();
        }
        CanDbcontext db = new CanDbcontext();

        void loaddata()
        {
            var result = from c in db.chatLuongHangHoas select c;
            dataGridView1.DataSource = result.ToList();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string Name_t = textBox_ten.Text;

            string Ma = textBox_ma.Text;
            string GhiChu = textBox_GhiChu.Text;



            ChatLuongHangHoa CLHH = new ChatLuongHangHoa() { Ma = Ma, TenChatLuongHangHoa = Name_t, GhiChu = GhiChu };

            if (CLHH != null)
            {
                db.chatLuongHangHoas.Add(CLHH);
                db.SaveChanges();
                loaddata();

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

            ChatLuongHangHoa CLHH = db.chatLuongHangHoas.Find(Ma);
            if (CLHH != null)
            {
                db.chatLuongHangHoas.Remove(CLHH);
                db.SaveChanges();
                loaddata() ;
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string Ma_t = dataGridView1.SelectedRows[0].Cells[0].OwningRow.Cells["Id"].Value.ToString();
            int Ma= int.Parse(Ma_t);

            ChatLuongHangHoa NGHH = db.chatLuongHangHoas.Find(Ma);
            NGHH.TenChatLuongHangHoa = textBox_ten.Text;
            NGHH.GhiChu = textBox_GhiChu.Text;


            if (NGHH != null)
            {
                db.SaveChanges();
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_ma.DataBindings.Clear();
            textBox_ma.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Ma"));
            textBox_ten.DataBindings.Clear();
            textBox_ten.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenChatLuongHangHoa"));
            textBox_GhiChu.DataBindings.Clear();
            textBox_GhiChu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GhiChu"));
        }
    }
}
