using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tramcan2.form;
using tramcan2.models;
using System.Runtime.Remoting.Contexts;

namespace tramcan2
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        CanDbcontext db = new CanDbcontext();
        private void Form1_Load(object sender, EventArgs e)
        {
            CanDbcontext db = new CanDbcontext();
            //db.Database.EnsureCreated();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = textbox_tendangnhap.Text;
            string password = textBox_matkhau.Text;
           
                string texb_login = textbox_tendangnhap.Text.Trim();
            // User user = db.users.Find(username);
            //User userr = db.users.Find(1);
            User username_t = (from p in db.users where p.Login == username select p).FirstOrDefault();
            User password_t = (from p in db.users where p.Password == password select p).FirstOrDefault();

            if (username_t!=null &&password_t != null )
            {
                   fMain fMain = new fMain();
                   this.Hide();
                   fMain.ShowDialog();
                   this.Show();
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng! " + "Vui long nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
        {                  
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
