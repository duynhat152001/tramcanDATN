using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tramcan2.form
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTTcanxe fm = new fTTcanxe();
            fm.ShowDialog();
        }

        private void càiĐặtCổngCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCOM fm = new fCOM();
            fm.ShowDialog();
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhachHang fm = new fKhachHang();
            fm.ShowDialog();

        }

        private void tàiKhoảnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUser fm = new fUser();
            fm.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLoaiHang fm = new fLoaiHang();
            fm.Show();
        }

        private void côngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLoaiHang fmLoaiHang = new fLoaiHang();
            fmLoaiHang.Show();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhoHang fmKhoHang = new fKhoHang();
            fmKhoHang.Show();
        }

        private void chấtLượngHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChatLuongHH fmCLHH = new fChatLuongHH();
            fmCLHH.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
