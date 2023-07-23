namespace QLKS
{
    partial class frm_xuli
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Emty = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_2)).BeginInit();
            this.SuspendLayout();
            // 
            // data_2
            // 
            this.data_2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.data_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_2.Location = new System.Drawing.Point(12, 12);
            this.data_2.Name = "data_2";
            this.data_2.Size = new System.Drawing.Size(614, 232);
            this.data_2.TabIndex = 0;
            this.data_2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_2_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(443, 286);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 45);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Phòng đã thuê";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Emty
            // 
            this.btn_Emty.Location = new System.Drawing.Point(287, 287);
            this.btn_Emty.Name = "btn_Emty";
            this.btn_Emty.Size = new System.Drawing.Size(91, 44);
            this.btn_Emty.TabIndex = 1;
            this.btn_Emty.Text = "Phòng trống";
            this.btn_Emty.UseVisualStyleBackColor = true;
            this.btn_Emty.Click += new System.EventHandler(this.btn_Emty_Click);
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(120, 287);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(98, 45);
            this.btn_All.TabIndex = 0;
            this.btn_All.Text = "Tất cả Phòng";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // frm_xuli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 359);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.btn_Emty);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.data_2);
            this.Name = "frm_xuli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_xuli_FormClosing);
            this.Load += new System.EventHandler(this.frm_xuli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Emty;
        private System.Windows.Forms.Button btn_All;
    }
}