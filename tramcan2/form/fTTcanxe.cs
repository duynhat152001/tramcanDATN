using NinjaNye.SearchExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using tramcan2.Migrations;
using tramcan2.models;
using NinjaNye.SearchExtensions;

namespace tramcan2.form
{
    public partial class fTTcanxe : Form
    {
        bool kt_ngay = false;
        bool canL1 = true;
        int solancanL1 = 0;
        int solancanL2 = 0;
        public fTTcanxe()
        {
            InitializeComponent();
            loadata();

        }
        CanDbcontext db = new CanDbcontext();
        private void fTTcanxe_Load(object sender, EventArgs e)
        {
            var result = from c in db.tTCanXes select c;  
            dataGridView1.DataSource = result.ToList();

            btn_can1.BackColor = Color.Orange;

        }
        void loadata()
        {
            var result = from c in db.tTCanXes select c;
            dataGridView1.DataSource = result.ToList();
    
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_khachhang.DataBindings.Clear();
            textBox_khachhang.DataBindings.Add(new Binding("Text", comboBox2.DataSource, "TenKhachHang"));
        }

      
        private void comboBox_loaihang_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_loaihang.DataBindings.Clear();
            textBox_loaihang.DataBindings.Add(new Binding("Text", comboBox_loaihang.DataSource, "TenLoaiHang"));
            textBox_donGia.DataBindings.Clear();
            textBox_donGia.DataBindings.Add(new Binding("Text", comboBox_loaihang.DataSource, "DonGia"));
        }

        private void comboBox_khohang_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_khohang.DataBindings.Clear();
            textBox_khohang.DataBindings.Add(new Binding("Text", comboBox_khohang.DataSource, "TenKhoHang"));
        }

        private void comboBox_nguongoc_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_nguongoc.DataBindings.Clear();
            textBox_nguongoc.DataBindings.Add(new Binding("Text", comboBox_nguongoc.DataSource, "TenNGHH"));
        }

        private void comboBox_chatluong_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_chatluong.DataBindings.Clear();
            textBox_chatluong.DataBindings.Add(new Binding("Text", comboBox_chatluong.DataSource, "TenChatLuongHangHoa"));
        }

       

        
        private void comboBox_biensotruoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox_bienso1.DataBindings.Clear();
            textBox_bienso1.DataBindings.Add(new Binding("Text", comboBox_biensotruoc.DataSource, "BienSoDauXe"));
            textBox_bienso2.DataBindings.Clear();
            textBox_bienso2.DataBindings.Add(new Binding("Text", comboBox_biensotruoc.DataSource, "BienSoCuoiXe"));
            textBox_tenlaixe.DataBindings.Clear();
            textBox_tenlaixe.DataBindings.Add(new Binding("Text", comboBox_biensotruoc.DataSource, "TenChuXe"));
            textBox_CMND.DataBindings.Clear();
            textBox_CMND.DataBindings.Add(new Binding("Text", comboBox_biensotruoc.DataSource, "CMND"));
            textBox_KL1.DataBindings.Clear();
            textBox_KL1.DataBindings.Add(new Binding("Text", comboBox_biensotruoc.DataSource, "TrongTai"));
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            var KH = from c in db.khachHangs select c;
            comboBox2.DataSource = KH.ToList();
            comboBox2.DisplayMember = "TenKhachHang";
        }

        private void comboBox_loaihang_Click(object sender, EventArgs e)
        {

            var LH = from c in db.loaiHangs select c;
            comboBox_loaihang.DataSource = LH.ToList();
            comboBox_loaihang.DisplayMember = "TenLoaiHang";
        }

        private void comboBox_khohang_Click(object sender, EventArgs e)
        {
            var KhoHang = from c in db.khoHangs select c;
            comboBox_khohang.DataSource = KhoHang.ToList();
            comboBox_khohang.DisplayMember = "TenKhoHang";
        }

        private void comboBox_nguongoc_Click(object sender, EventArgs e)
        {
            var NG = from c in db.nguonGocHangHoas select c;
            comboBox_nguongoc.DataSource = NG.ToList();
            comboBox_nguongoc.DisplayMember = "TenNGHH";
        }

        private void comboBox_chatluong_Click(object sender, EventArgs e)
        {
            var CLHH = from c in db.chatLuongHangHoas select c;
            comboBox_chatluong.DataSource = CLHH.ToList();
            comboBox_chatluong.DisplayMember = "TenChatLuongHangHoa";
        }
        

        
        private void comboBox_biensotruoc_Click(object sender, EventArgs e)
        {
            var biensodau = from c in db.vehicles select c;
            comboBox_biensotruoc.DataSource = biensodau.ToList();
            comboBox_biensotruoc.DisplayMember = "id";
        }

        private void button4_Click(object sender, EventArgs e)  //btm them
        {
            try
            {

                TTCanXe TT = new TTCanXe()
                {
                    TenLaixe = textBox_tenlaixe.Text,
                    KhachHang = textBox_khachhang.Text,
                    LoaiHang = textBox_loaihang.Text,
                    NguonGoc = textBox_nguongoc.Text,
                    KhoHang = textBox_khohang.Text,
                    KieuCan = comboBox_kieucan.Text,
                    ChatLuongHH = textBox_chatluong.Text,
                    BienSoDauXe = textBox_bienso1.Text,
                    BienSoDuoiXe = textBox_bienso2.Text,
                    KhoiLuongL1 = float.Parse(textBox_KL1.Text),
                    KhoiLuongL2 = float.Parse(textBox_KL2.Text),
                    ThoiGianCanL1 = DateTime.Now.ToString("dd/MM/yyyy"),
                    
                };


                if (TT != null)
                {
                    if (string.IsNullOrEmpty(comboBox_kieucan.Text) || string.IsNullOrEmpty(textBox_khachhang.Text))
                    {
                        MessageBox.Show("Lỗi: " + "Tên khách hàng và kiểu cân không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(textBox_tenlaixe.Text) || string.IsNullOrEmpty(textBox_bienso1.Text) || string.IsNullOrEmpty(textBox_bienso2.Text))
                    {
                        MessageBox.Show("Lỗi: " + "Tên lái xe và biển số xe được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(textBox_KL1.Text))
                    {
                        MessageBox.Show("Lỗi: " + "Khối lượng cân lần 1 không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if( canL1)
                        {
                            db.tTCanXes.Add(TT);
                            db.SaveChanges();
                            MessageBox.Show("Lời Nhắc: " + "thêm thành công", "Lời nhắc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            solancanL1 +=1 ;
                            lb_solancanL1.Text = solancanL1.ToString();
                            loadata();

                        }
                        else
                        {
                           // string SoPhieu_t = dataGridView1.SelectedRows[0].Cells[0].OwningRow.Cells["MaKH"].Value.ToString();
                            int SoPhieu = int.Parse(textBox_sophieu.Text);

                            TTCanXe ttcan = db.tTCanXes.Find(SoPhieu);

                            ttcan.KhoiLuongL2 = float.Parse(textBox_KL2.Text);
                            ttcan.ThoiGianCanL2 = DateTime.Now.ToString("dd/MM/yyyy"); 
                            ttcan.KhoiLuongHang = float.Parse(textBox_KLHang.Text);
                            ttcan.ThanhTien = float.Parse(textBox_Thanhtien.Text);


                            if (ttcan != null)
                            {
                                db.SaveChanges();
                                MessageBox.Show("Lời Nhắc: " + "thêm số kg lần 2 thành công", "Lời nhắc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                solancanL2 += 1;
                                label_solancanL2.Text = solancanL2.ToString();
                                label_chocanL2.Text = (solancanL1-solancanL2).ToString();
                                loadata();
                                
                            }
                            else
                            {
                                MessageBox.Show("Lỗi: " + "không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Lỗi: " + "không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + "" +  ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_khachhang.DataBindings.Clear();
                textBox_khachhang.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "KhachHang"));
                textBox_khohang.DataBindings.Clear();
                textBox_khohang.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "KhoHang"));
                textBox_chatluong.DataBindings.Clear();
                textBox_chatluong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "ChatLuongHH"));
                textBox_loaihang.DataBindings.Clear();
                textBox_loaihang.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "LoaiHang"));
                textBox_sophieu.DataBindings.Clear();
                textBox_sophieu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Id"));
                textBox_KL1.DataBindings.Clear();
                textBox_KL1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "KhoiLuongL1"));
                textBox_KL2.DataBindings.Clear();
                textBox_KL2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "KhoiLuongL2"));
                comboBox_kieucan.DataBindings.Clear();
                comboBox_kieucan.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "KieuCan"));
                textBox_bienso1.DataBindings.Clear();
                textBox_bienso1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "BienSoDauXe"));
                textBox_bienso2.DataBindings.Clear();
                textBox_bienso2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "BienSoDuoiXe"));
                textBox_tenlaixe.DataBindings.Clear();
                textBox_tenlaixe.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenLaiXe"));
                textBox_nguongoc.DataBindings.Clear();
                textBox_nguongoc.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "NguonGoc"));
                textBox_KLHang.DataBindings.Clear();
                textBox_KLHang.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "KhoiLuongHang"));
                textBox_donGia.DataBindings.Clear();
                textBox_donGia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGia"));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + "Databilding" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void btn_can1_Click(object sender, EventArgs e)
        {
            try
            {
                canL1 = true;
                btn_can1.BackColor = Color.Orange;
                btn_can2.BackColor = Color.LightGray;
            }
            catch(Exception ex )
            {
                MessageBox.Show("Lỗi: " + "" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private  void btn_can2_Click(object sender, EventArgs e)
        {
            try
            {
                canL1 = false;
                btn_can2.BackColor = Color.Orange;
                btn_can1.BackColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + "" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox_ghisocan_TextChanged(object sender, EventArgs e)
        {

                ChonCheDoCan();
 
        }

        public void ChonCheDoCan()
        { 
            try
            {
                if (canL1)
                {
                    textBox_KL1.Text = textBox_ghisocan.Text;
                }
                else
                {
                    textBox_KL2.Text = textBox_ghisocan.Text;
                    
                    float KL_Hang2 = float.Parse(textBox_KL2.Text);
                    float KL_Hang1 = float.Parse(textBox_KL1.Text);

                    if(KL_Hang1>=KL_Hang2)
                    {
                        //MessageBox.Show("Cảnh báo: " + "Khối lượng L2 không nhỏ hơn Khối lượng L1" , "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }     
                    else
                    {
                        textBox_KLHang.Text = (KL_Hang2 - KL_Hang1).ToString();
                    }                        
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + "Chọn Chế Độ Cân Lỗi\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        void TimKiem()
        {
            try
            {
                dataGridView1.DataSource = (from c in db.tTCanXes
                                            where ((string.IsNullOrEmpty(comboBox_tkTenKH.Text) ? true : c.KhachHang.Contains(comboBox_tkTenKH.Text)) && (string.IsNullOrEmpty(comboBox3.Text) ? true : c.KieuCan.Contains(comboBox3.Text)) &&
                                                                     (string.IsNullOrEmpty(textBox_tkBienso.Text) ? true : (c.BienSoDauXe.Contains(textBox_tkBienso.Text)) || c.BienSoDuoiXe.Contains(textBox_tkBienso.Text)) &&
                                                                     (string.IsNullOrEmpty(textBox_tg.Text) ? true : (c.ThoiGianCanL1.Contains(textBox_tg.Text) || (c.ThoiGianCanL2.Contains(textBox_tg.Text)))) &&
                                                                     (string.IsNullOrEmpty(textBox_tkTatCa.Text) ? true : (c.KhoHang.Contains(textBox_tkTatCa.Text) || (c.TenLaixe.Contains(textBox_tkTatCa.Text)) ||
                                                                                                                          (c.ChatLuongHH.Contains(textBox_tkTatCa.Text)) || (c.LoaiHang.Contains(textBox_tkTatCa.Text)) ||
                                                                                                                          (c.NguonGoc.Contains(textBox_tkTatCa.Text)) || (c.KhachHang.Contains(textBox_tkTatCa.Text)) ||
                                                                                                                          (c.BienSoDauXe.Contains(textBox_tkTatCa.Text)) || c.BienSoDuoiXe.Contains(textBox_tkTatCa.Text)) ||
                                                                                                                          (c.ThoiGianCanL1.Contains(textBox_tkTatCa.Text) || (c.ThoiGianCanL2.Contains(textBox_tkTatCa.Text))||
                                                                                                                          (c.KieuCan.Contains(textBox_tkTatCa.Text))||
                                                                                                                          (c.Id.Equals(textBox_tkTatCa.Text)) || (c.DonGia.Equals(textBox_tkTatCa.Text)))))


                                            select c).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + "Tìm Kiếm Lỗi\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            var KH = from c in db.khachHangs select c;
            comboBox_tkTenKH.DataSource = KH.ToList();
            comboBox_tkTenKH.DisplayMember = "TenKhachHang";
        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            loadata();
        }

     

        private void comboBox_kieucan_Click(object sender, EventArgs e)
        {
            var KieuCan = from c in db.kieuCans select c;
            comboBox_kieucan.DataSource = KieuCan.ToList();
            comboBox_kieucan.DisplayMember = "TenKieuCan";
        }

       

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_khachhang.Clear();
                textBox_khohang.Clear();
                textBox_chatluong.Clear();
                textBox_loaihang.Clear();
                textBox_sophieu.Clear();
                textBox_KL1.Text = "0";
                textBox_KL2.Text = "0";
                textBox_bienso2.Clear();
                textBox_tenlaixe.Clear();
                textBox_nguongoc.Clear();
                textBox_bienso1.Clear();
                textBox_KLHang.Text = "0";
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi: " + "không thêm mới được\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

       

        private void textBox_donGia_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox_donGia.Text != null && float.Parse(textBox_donGia.Text) >= 0)
                {
                    var sum = (float.Parse(textBox_KLHang.Text)) * (float.Parse(textBox_donGia.Text));
                    textBox_Thanhtien.Text = sum.ToString();
                }
                else
                {
                    textBox_Thanhtien.Text = "0";
                    textBox_donGia.Text = "0";
                    MessageBox.Show("Cảnh báo: " + "Đơn Giá không được âm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);     
                }    
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi: " + "" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
// test moi nekkk