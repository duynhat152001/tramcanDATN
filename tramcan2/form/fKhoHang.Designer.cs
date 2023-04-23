namespace tramcan2.form
{
    partial class fKhoHang
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_makh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_diachikh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tenkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Ghichu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "MaKH";
            // 
            // textBox_makh
            // 
            this.textBox_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_makh.Location = new System.Drawing.Point(70, 4);
            this.textBox_makh.Multiline = true;
            this.textBox_makh.Name = "textBox_makh";
            this.textBox_makh.Size = new System.Drawing.Size(132, 25);
            this.textBox_makh.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa Chỉ KH";
            // 
            // textBox_diachikh
            // 
            this.textBox_diachikh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diachikh.Location = new System.Drawing.Point(316, 2);
            this.textBox_diachikh.Multiline = true;
            this.textBox_diachikh.Name = "textBox_diachikh";
            this.textBox_diachikh.Size = new System.Drawing.Size(132, 25);
            this.textBox_diachikh.TabIndex = 6;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 212);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(802, 236);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH: mm     dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(660, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(250, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "DANH SÁCH KHO HÀNG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Location = new System.Drawing.Point(9, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 174);
            this.panel2.TabIndex = 21;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên KH";
            // 
            // textBox_tenkh
            // 
            this.textBox_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenkh.Location = new System.Drawing.Point(70, 59);
            this.textBox_tenkh.Multiline = true;
            this.textBox_tenkh.Name = "textBox_tenkh";
            this.textBox_tenkh.Size = new System.Drawing.Size(132, 25);
            this.textBox_tenkh.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi Chú";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_makh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_diachikh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_tenkh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Ghichu);
            this.panel1.Location = new System.Drawing.Point(188, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 98);
            this.panel1.TabIndex = 18;
            // 
            // textBox_Ghichu
            // 
            this.textBox_Ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ghichu.Location = new System.Drawing.Point(310, 56);
            this.textBox_Ghichu.Multiline = true;
            this.textBox_Ghichu.Name = "textBox_Ghichu";
            this.textBox_Ghichu.Size = new System.Drawing.Size(138, 25);
            this.textBox_Ghichu.TabIndex = 0;
            // 
            // fKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fKhoHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_makh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_diachikh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tenkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Ghichu;
    }
}