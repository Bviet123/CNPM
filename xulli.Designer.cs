namespace QLKS
{
    partial class frm_XULI
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
            this.data_2 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MAPHONG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TENPHONG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LOAIPHONG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TIENNGHI = new System.Windows.Forms.TextBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Fix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_2)).BeginInit();
            this.SuspendLayout();
            // 
            // data_2
            // 
            this.data_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_2.Location = new System.Drawing.Point(90, 172);
            this.data_2.Name = "data_2";
            this.data_2.Size = new System.Drawing.Size(470, 200);
            this.data_2.TabIndex = 0;
            this.data_2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_2_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(409, 38);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Phòng :";
            // 
            // txt_MAPHONG
            // 
            this.txt_MAPHONG.Location = new System.Drawing.Point(103, 40);
            this.txt_MAPHONG.Name = "txt_MAPHONG";
            this.txt_MAPHONG.Size = new System.Drawing.Size(166, 20);
            this.txt_MAPHONG.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Phòng :";
            // 
            // txt_TENPHONG
            // 
            this.txt_TENPHONG.Location = new System.Drawing.Point(103, 66);
            this.txt_TENPHONG.Name = "txt_TENPHONG";
            this.txt_TENPHONG.Size = new System.Drawing.Size(166, 20);
            this.txt_TENPHONG.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Phòng :";
            // 
            // txt_LOAIPHONG
            // 
            this.txt_LOAIPHONG.Location = new System.Drawing.Point(103, 92);
            this.txt_LOAIPHONG.Name = "txt_LOAIPHONG";
            this.txt_LOAIPHONG.Size = new System.Drawing.Size(166, 20);
            this.txt_LOAIPHONG.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tiện Nghi :";
            // 
            // txt_TIENNGHI
            // 
            this.txt_TIENNGHI.Location = new System.Drawing.Point(103, 118);
            this.txt_TIENNGHI.Name = "txt_TIENNGHI";
            this.txt_TIENNGHI.Size = new System.Drawing.Size(166, 20);
            this.txt_TIENNGHI.TabIndex = 3;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(409, 69);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 1;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Fix
            // 
            this.btn_Fix.Location = new System.Drawing.Point(409, 98);
            this.btn_Fix.Name = "btn_Fix";
            this.btn_Fix.Size = new System.Drawing.Size(75, 23);
            this.btn_Fix.TabIndex = 1;
            this.btn_Fix.Text = "Sửa";
            this.btn_Fix.UseVisualStyleBackColor = true;
            this.btn_Fix.Click += new System.EventHandler(this.btn_Fix_Click);
            // 
            // frm_XULI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 373);
            this.Controls.Add(this.txt_TIENNGHI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_LOAIPHONG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TENPHONG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MAPHONG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Fix);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.data_2);
            this.Name = "frm_XULI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lí";
            this.Load += new System.EventHandler(this.QL_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MAPHONG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TENPHONG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LOAIPHONG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TIENNGHI;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Fix;
    }
}