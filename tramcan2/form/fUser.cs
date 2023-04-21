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
    public partial class fUser : Form
    {
        public fUser()
        {
            InitializeComponent();
            Loaddata();
        }
        CanDbcontext db = new CanDbcontext();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fUser_Load(object sender, EventArgs e)
        {

        }

        void Loaddata()
        {
            var result = from c in db.users select c;  // c1: lấy ra cái mong muốn, theo thứ tự  //c2 db.Product.tostring(); lấy hết
                                                            // var result = from c in db.Products //where c.Id < 10  select c;
            dataGridView1.DataSource = result.ToList();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_tenuser.DataBindings.Clear();
            textBox_tenuser.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Name"));
            textBox_tendangnhap.DataBindings.Clear();
            textBox_tendangnhap.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Login"));
            textBox_matkhau.DataBindings.Clear();
            textBox_matkhau.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Password"));
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            string Name_t = textBox_tenuser.Text;
            string Login = textBox_tendangnhap.Text;
            string Password = textBox_matkhau.Text;




            User user = new User() { Name = Name_t, Login=Login, Password=Password };

            if (user != null)
            {
                db.users.Add(user);
                db.SaveChanges();
                Loaddata();

            }
            else
            {
                MessageBox.Show("Lỗi: " + "không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string id_t = dataGridView1.SelectedRows[0].Cells[0].OwningRow.Cells["Id"].Value.ToString();
            int id = int.Parse(id_t);

            User user =db.users.Find(id);
            user.Name = textBox_tenuser.Text;
            user.Login = textBox_tendangnhap.Text;
            user.Password = textBox_matkhau.Text;

            if (user != null)
            {
                db.SaveChanges();
                Loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string id_t = dataGridView1.SelectedRows[0].Cells[0].OwningRow.Cells["Id"].Value.ToString();
            int id = int.Parse(id_t);

            User user = db.users.Find(id);
            if (user != null)
            {
                db.users.Remove(user);
                db.SaveChanges();
                Loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
