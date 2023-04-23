namespace tramcan2.form
{
    partial class fVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_biensoduoixe = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_tenchuxe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_sodienthoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mathe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_biensodauxe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ghichu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_trongtaitho = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_CMND = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH: mm     dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(794, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // textBox_biensoduoixe
            // 
            this.textBox_biensoduoixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_biensoduoixe.Location = new System.Drawing.Point(465, 55);
            this.textBox_biensoduoixe.Multiline = true;
            this.textBox_biensoduoixe.Name = "textBox_biensoduoixe";
            this.textBox_biensoduoixe.Size = new System.Drawing.Size(132, 25);
            this.textBox_biensoduoixe.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(936, 344);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Biển Số Đuôi Xe";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 174);
            this.panel2.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Silver;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Red;
            this.btn_sua.Location = new System.Drawing.Point(12, 95);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(84, 38);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Silver;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_xoa.Location = new System.Drawing.Point(12, 51);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(84, 38);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Silver;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Red;
            this.btn_them.Location = new System.Drawing.Point(12, 8);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(84, 37);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(305, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "DANH SÁCH PHƯƠNG TIỆN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_CMND);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_tenchuxe);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_sodienthoai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_mathe);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_biensodauxe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_ghichu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_trongtaitho);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_biensoduoixe);
            this.panel1.Location = new System.Drawing.Point(160, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 191);
            this.panel1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Chủ Xe";
            // 
            // textBox_tenchuxe
            // 
            this.textBox_tenchuxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenchuxe.Location = new System.Drawing.Point(114, 58);
            this.textBox_tenchuxe.Multiline = true;
            this.textBox_tenchuxe.Name = "textBox_tenchuxe";
            this.textBox_tenchuxe.Size = new System.Drawing.Size(132, 25);
            this.textBox_tenchuxe.TabIndex = 14;
            this.textBox_tenchuxe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số Điện Thoại";
            // 
            // textBox_sodienthoai
            // 
            this.textBox_sodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sodienthoai.Location = new System.Drawing.Point(114, 102);
            this.textBox_sodienthoai.Multiline = true;
            this.textBox_sodienthoai.Name = "textBox_sodienthoai";
            this.textBox_sodienthoai.Size = new System.Drawing.Size(132, 25);
            this.textBox_sodienthoai.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã thẻ";
            // 
            // textBox_mathe
            // 
            this.textBox_mathe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mathe.Location = new System.Drawing.Point(114, 6);
            this.textBox_mathe.Multiline = true;
            this.textBox_mathe.Name = "textBox_mathe";
            this.textBox_mathe.Size = new System.Drawing.Size(132, 25);
            this.textBox_mathe.TabIndex = 10;
            this.textBox_mathe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Biển Số Đầu Xe";
            // 
            // textBox_biensodauxe
            // 
            this.textBox_biensodauxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_biensodauxe.Location = new System.Drawing.Point(465, 7);
            this.textBox_biensodauxe.Multiline = true;
            this.textBox_biensodauxe.Name = "textBox_biensodauxe";
            this.textBox_biensodauxe.Size = new System.Drawing.Size(132, 25);
            this.textBox_biensodauxe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ghi chú";
            // 
            // textBox_ghichu
            // 
            this.textBox_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ghichu.Location = new System.Drawing.Point(465, 151);
            this.textBox_ghichu.Multiline = true;
            this.textBox_ghichu.Name = "textBox_ghichu";
            this.textBox_ghichu.Size = new System.Drawing.Size(132, 25);
            this.textBox_ghichu.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trọng Tải Xe Thô (KG)";
            // 
            // textBox_trongtaitho
            // 
            this.textBox_trongtaitho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_trongtaitho.Location = new System.Drawing.Point(465, 105);
            this.textBox_trongtaitho.Multiline = true;
            this.textBox_trongtaitho.Name = "textBox_trongtaitho";
            this.textBox_trongtaitho.Size = new System.Drawing.Size(132, 25);
            this.textBox_trongtaitho.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "CMND";
            // 
            // textBox_CMND
            // 
            this.textBox_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CMND.Location = new System.Drawing.Point(114, 152);
            this.textBox_CMND.Multiline = true;
            this.textBox_CMND.Name = "textBox_CMND";
            this.textBox_CMND.Size = new System.Drawing.Size(132, 25);
            this.textBox_CMND.TabIndex = 16;
            // 
            // fVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 606);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "fVehicle";
            this.Text = "fVehicle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_biensoduoixe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_biensodauxe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ghichu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_trongtaitho;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mathe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_tenchuxe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_sodienthoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_CMND;
    }
}