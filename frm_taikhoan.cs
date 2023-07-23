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
    public partial class frm_taikhoan : Form
    {
        SqlConnection Connection;
        SqlCommand Command;
        String str = @"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frm_taikhoan()
        {
            InitializeComponent();
        }
        private void Ketnoi()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * From TAIKHOANDN";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            data_TK.DataSource = table;
        }
        private void frm_taikhoan_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            Ketnoi();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "insert into TAIKHOANDN values( '" + txt_taikhoan.Text + "' , '"+txt_matkhau.Text+"' , '"+cbb_Quyen.Text+"')";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void data_TK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_TK.Rows[e.RowIndex];
                txt_taikhoan.Text = row.Cells[0].Value.ToString();
                txt_matkhau.Text = row.Cells[1].Value.ToString();
                cbb_Quyen.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Update TAIKHOANDN set MATKHAU = '"+txt_matkhau.Text+"' , QUYEN = '"+cbb_Quyen.Text+"' where TAIKHOAN = '" + txt_taikhoan.Text + "'";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Command = Connection.CreateCommand();
                Command.CommandText = "delete from TAIKHOANDN where TAIKHOAN = '" + txt_taikhoan.Text + "' ";
                Command.ExecuteNonQuery();
                Ketnoi();
            }
            
        }

        private void frm_taikhoan_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
