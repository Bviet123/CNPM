namespace QLKS
{
    partial class frm_DatP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.date_DatP = new System.Windows.Forms.DateTimePicker();
            this.img_Exit = new System.Windows.Forms.PictureBox();
            this.data_DatP = new System.Windows.Forms.DataGridView();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_MaDatP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_DatP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng :";
            // 
            // txt_MaP
            // 
            this.txt_MaP.Location = new System.Drawing.Point(131, 260);
            this.txt_MaP.Name = "txt_MaP";
            this.txt_MaP.Size = new System.Drawing.Size(129, 20);
            this.txt_MaP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Nhân Viên :";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(131, 285);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(129, 20);
            this.txt_MaNV.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại :";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(418, 231);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(129, 20);
            this.txt_SDT.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày hẹn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên Khách hàng :";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(107, 327);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 49);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // date_DatP
            // 
            this.date_DatP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_DatP.Location = new System.Drawing.Point(419, 286);
            this.date_DatP.Name = "date_DatP";
            this.date_DatP.Size = new System.Drawing.Size(129, 20);
            this.date_DatP.TabIndex = 5;
            // 
            // img_Exit
            // 
            this.img_Exit.Image = global::QLKS.Properties.Resources.blue_square_close_x_button_icon_transparent_background_31631915375xqhh0ezcuw;
            this.img_Exit.Location = new System.Drawing.Point(546, 1);
            this.img_Exit.Name = "img_Exit";
            this.img_Exit.Size = new System.Drawing.Size(35, 29);
            this.img_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Exit.TabIndex = 6;
            this.img_Exit.TabStop = false;
            this.img_Exit.Click += new System.EventHandler(this.img_Exit_Click);
            // 
            // data_DatP
            // 
            this.data_DatP.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.data_DatP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DatP.Location = new System.Drawing.Point(25, 64);
            this.data_DatP.Name = "data_DatP";
            this.data_DatP.Size = new System.Drawing.Size(534, 145);
            this.data_DatP.TabIndex = 11;
            this.data_DatP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DatP_CellContentClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(241, 327);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 49);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(381, 327);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 49);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(419, 260);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(129, 20);
            this.txt_TenKH.TabIndex = 4;
            // 
            // txt_MaDatP
            // 
            this.txt_MaDatP.Location = new System.Drawing.Point(131, 231);
            this.txt_MaDatP.Name = "txt_MaDatP";
            this.txt_MaDatP.Size = new System.Drawing.Size(129, 20);
            this.txt_MaDatP.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Đặt Phòng :";
            // 
            // frm_DatP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.txt_MaDatP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.data_DatP);
            this.Controls.Add(this.img_Exit);
            this.Controls.Add(this.date_DatP);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_MaP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DatP";
            this.Text = "frm_DatP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_DatP_FormClosed);
            this.Load += new System.EventHandler(this.frm_DatP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_DatP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DateTimePicker date_DatP;
        private System.Windows.Forms.PictureBox img_Exit;
        private System.Windows.Forms.DataGridView data_DatP;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_MaDatP;
        private System.Windows.Forms.Label label3;
    }
}