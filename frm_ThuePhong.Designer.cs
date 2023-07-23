namespace QLKS
{
    partial class frm_ThuePhong
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
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.data_ThueP = new System.Windows.Forms.DataGridView();
            this.date_TraP = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaPhong = new System.Windows.Forms.TextBox();
            this.GiaP = new System.Windows.Forms.Label();
            this.txt_MaP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateThueP = new System.Windows.Forms.DateTimePicker();
            this.txt_MaTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_ThueP)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(137, 261);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(191, 20);
            this.txt_MaKH.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã Khách Hàng :";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(386, 320);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 49);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(386, 204);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 49);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // data_ThueP
            // 
            this.data_ThueP.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.data_ThueP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ThueP.Location = new System.Drawing.Point(31, 23);
            this.data_ThueP.Name = "data_ThueP";
            this.data_ThueP.Size = new System.Drawing.Size(534, 145);
            this.data_ThueP.TabIndex = 27;
            this.data_ThueP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_ThueP_CellContentClick);
            // 
            // date_TraP
            // 
            this.date_TraP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_TraP.Location = new System.Drawing.Point(137, 352);
            this.date_TraP.Name = "date_TraP";
            this.date_TraP.Size = new System.Drawing.Size(192, 20);
            this.date_TraP.TabIndex = 5;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(386, 259);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 49);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ngày đăng kí :";
            // 
            // txt_GiaPhong
            // 
            this.txt_GiaPhong.Location = new System.Drawing.Point(137, 290);
            this.txt_GiaPhong.Name = "txt_GiaPhong";
            this.txt_GiaPhong.Size = new System.Drawing.Size(192, 20);
            this.txt_GiaPhong.TabIndex = 3;
            // 
            // GiaP
            // 
            this.GiaP.AutoSize = true;
            this.GiaP.Location = new System.Drawing.Point(68, 295);
            this.GiaP.Name = "GiaP";
            this.GiaP.Size = new System.Drawing.Size(63, 13);
            this.GiaP.TabIndex = 15;
            this.GiaP.Text = "Giá Phòng :";
            // 
            // txt_MaP
            // 
            this.txt_MaP.Location = new System.Drawing.Point(136, 228);
            this.txt_MaP.Name = "txt_MaP";
            this.txt_MaP.Size = new System.Drawing.Size(191, 20);
            this.txt_MaP.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày trả phòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã Phòng :";
            // 
            // dateThueP
            // 
            this.dateThueP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateThueP.Location = new System.Drawing.Point(137, 322);
            this.dateThueP.Name = "dateThueP";
            this.dateThueP.Size = new System.Drawing.Size(192, 20);
            this.dateThueP.TabIndex = 4;
            // 
            // txt_MaTP
            // 
            this.txt_MaTP.Location = new System.Drawing.Point(137, 201);
            this.txt_MaTP.Name = "txt_MaTP";
            this.txt_MaTP.Size = new System.Drawing.Size(191, 20);
            this.txt_MaTP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã thuê phòng :";
            // 
            // frm_ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(599, 383);
            this.Controls.Add(this.txt_MaTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateThueP);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.data_ThueP);
            this.Controls.Add(this.date_TraP);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_GiaPhong);
            this.Controls.Add(this.GiaP);
            this.Controls.Add(this.txt_MaP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "frm_ThuePhong";
            this.Text = "frm_ThuePhong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ThuePhong_FormClosing);
            this.Load += new System.EventHandler(this.frm_ThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_ThueP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView data_ThueP;
        private System.Windows.Forms.DateTimePicker date_TraP;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_GiaPhong;
        private System.Windows.Forms.Label GiaP;
        private System.Windows.Forms.TextBox txt_MaP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateThueP;
        private System.Windows.Forms.TextBox txt_MaTP;
        private System.Windows.Forms.Label label1;
    }
}