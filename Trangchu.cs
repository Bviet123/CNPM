using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLKS
{
    public partial class Trangchu : Form
    {

        SqlConnection Connection;
        SqlCommand Command;
        String str = @"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Trangchu()
        {
            InitializeComponent();
            
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();         
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DatP datP = new frm_DatP();
            datP.Show();
        }

        private void xửLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_xuli xuli = new frm_xuli();
            xuli.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TTkhachhang TTkhachhang = new frm_TTkhachhang();
            TTkhachhang.Show();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanvienTT NhanVien = new frm_NhanvienTT();
            NhanVien.Show();
        }

        private void đăngKíThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DangkiTV dangkiTV = new frm_DangkiTV();
            dangkiTV.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thaoTácTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_taikhoan taikhoan = new frm_taikhoan();
            taikhoan.Show();
        }

        
        private void btn_DN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void Trangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", " ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void NhanVienMenuItem1_Click(object sender, EventArgs e)
        {
            frm_NhanvienTT NhanVien = new frm_NhanvienTT();
            NhanVien.Show();
        }

        private void ThuePhongtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ThuePhong ThuePhong = new frm_ThuePhong();
            ThuePhong.Show();
        }
    }
}
