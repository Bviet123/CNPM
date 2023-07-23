namespace QLKS
{
    partial class frm_NhanvienTT
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
            this.data_TTNV = new System.Windows.Forms.DataGridView();
            this.txt_MANV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TENNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MACV = new System.Windows.Forms.TextBox();
            this.txt_DIACHI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.Combo_GIOITINH = new System.Windows.Forms.ComboBox();
            this.date_NGAYSINH = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTNV)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTNV
            // 
            this.data_TTNV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.data_TTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTNV.Location = new System.Drawing.Point(0, 1);
            this.data_TTNV.Name = "data_TTNV";
            this.data_TTNV.Size = new System.Drawing.Size(587, 161);
            this.data_TTNV.TabIndex = 0;
            this.data_TTNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTNV_CellContentClick);
            // 
            // txt_MANV
            // 
            this.txt_MANV.Location = new System.Drawing.Point(105, 198);
            this.txt_MANV.Name = "txt_MANV";
            this.txt_MANV.Size = new System.Drawing.Size(147, 20);
            this.txt_MANV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_TENNV
            // 
            this.txt_TENNV.Location = new System.Drawing.Point(105, 224);
            this.txt_TENNV.Name = "txt_TENNV";
            this.txt_TENNV.Size = new System.Drawing.Size(147, 20);
            this.txt_TENNV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính :";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(105, 302);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(147, 20);
            this.txt_CMND.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "CMND :";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(396, 201);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(139, 20);
            this.txt_SDT.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số điện thoại :";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_MACV
            // 
            this.txt_MACV.Location = new System.Drawing.Point(396, 227);
            this.txt_MACV.Name = "txt_MACV";
            this.txt_MACV.Size = new System.Drawing.Size(139, 20);
            this.txt_MACV.TabIndex = 7;
            // 
            // txt_DIACHI
            // 
            this.txt_DIACHI.Location = new System.Drawing.Point(396, 250);
            this.txt_DIACHI.Name = "txt_DIACHI";
            this.txt_DIACHI.Size = new System.Drawing.Size(139, 20);
            this.txt_DIACHI.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã chức vụ :";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Địa chỉ :";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(131, 340);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(247, 340);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(364, 340);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // Combo_GIOITINH
            // 
            this.Combo_GIOITINH.FormattingEnabled = true;
            this.Combo_GIOITINH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.Combo_GIOITINH.Location = new System.Drawing.Point(105, 249);
            this.Combo_GIOITINH.Name = "Combo_GIOITINH";
            this.Combo_GIOITINH.Size = new System.Drawing.Size(147, 21);
            this.Combo_GIOITINH.TabIndex = 3;
            // 
            // date_NGAYSINH
            // 
            this.date_NGAYSINH.CustomFormat = "dd/mm/yyyy";
            this.date_NGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NGAYSINH.Location = new System.Drawing.Point(106, 276);
            this.date_NGAYSINH.Name = "date_NGAYSINH";
            this.date_NGAYSINH.Size = new System.Drawing.Size(146, 20);
            this.date_NGAYSINH.TabIndex = 4;
            // 
            // frm_NhanvienTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 384);
            this.Controls.Add(this.date_NGAYSINH);
            this.Controls.Add(this.Combo_GIOITINH);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.txt_DIACHI);
            this.Controls.Add(this.txt_TENNV);
            this.Controls.Add(this.txt_MACV);
            this.Controls.Add(this.txt_MANV);
            this.Controls.Add(this.data_TTNV);
            this.Name = "frm_NhanvienTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_NhanvienTT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_NhanvienTT_FormClosing);
            this.Load += new System.EventHandler(this.frm_NhanvienTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTNV;
        private System.Windows.Forms.TextBox txt_MANV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TENNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MACV;
        private System.Windows.Forms.TextBox txt_DIACHI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ComboBox Combo_GIOITINH;
        private System.Windows.Forms.DateTimePicker date_NGAYSINH;
    }
}