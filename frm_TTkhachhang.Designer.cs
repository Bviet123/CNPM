namespace QLKS
{
    partial class frm_TTkhachhang
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
            this.data_TTkhach = new System.Windows.Forms.DataGridView();
            this.txt_MAKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TENKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DIACHI = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.date_NGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTkhach)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTkhach
            // 
            this.data_TTkhach.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.data_TTkhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTkhach.Location = new System.Drawing.Point(29, -1);
            this.data_TTkhach.Name = "data_TTkhach";
            this.data_TTkhach.Size = new System.Drawing.Size(642, 243);
            this.data_TTkhach.TabIndex = 0;
            this.data_TTkhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTkhach_CellContentClick);
            // 
            // txt_MAKH
            // 
            this.txt_MAKH.Location = new System.Drawing.Point(149, 285);
            this.txt_MAKH.Name = "txt_MAKH";
            this.txt_MAKH.Size = new System.Drawing.Size(139, 20);
            this.txt_MAKH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khách hàng :";
            // 
            // txt_TENKH
            // 
            this.txt_TENKH.Location = new System.Drawing.Point(149, 311);
            this.txt_TENKH.Name = "txt_TENKH";
            this.txt_TENKH.Size = new System.Drawing.Size(139, 20);
            this.txt_TENKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng :";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(149, 337);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(139, 20);
            this.txt_CMND.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tuổi :";
            // 
            // txt_DIACHI
            // 
            this.txt_DIACHI.Location = new System.Drawing.Point(462, 285);
            this.txt_DIACHI.Name = "txt_DIACHI";
            this.txt_DIACHI.Size = new System.Drawing.Size(186, 20);
            this.txt_DIACHI.TabIndex = 4;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(462, 311);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(186, 20);
            this.txt_SDT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số điện thoại :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày Sinh :";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(162, 429);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(280, 429);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(400, 429);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // date_NGAYSINH
            // 
            this.date_NGAYSINH.CustomFormat = "dd-MM-yyyy";
            this.date_NGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NGAYSINH.Location = new System.Drawing.Point(462, 337);
            this.date_NGAYSINH.Name = "date_NGAYSINH";
            this.date_NGAYSINH.Size = new System.Drawing.Size(186, 20);
            this.date_NGAYSINH.TabIndex = 6;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Location = new System.Drawing.Point(149, 366);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.Size = new System.Drawing.Size(139, 20);
            this.txt_tuoi.TabIndex = 3;
            // 
            // frm_TTkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 470);
            this.Controls.Add(this.txt_tuoi);
            this.Controls.Add(this.date_NGAYSINH);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TENKH);
            this.Controls.Add(this.txt_DIACHI);
            this.Controls.Add(this.txt_MAKH);
            this.Controls.Add(this.data_TTkhach);
            this.Name = "frm_TTkhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TTkhachhang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TTkhachhang_FormClosing);
            this.Load += new System.EventHandler(this.frm_TTkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTkhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTkhach;
        private System.Windows.Forms.TextBox txt_MAKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TENKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DIACHI;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DateTimePicker date_NGAYSINH;
        private System.Windows.Forms.TextBox txt_tuoi;
    }
}