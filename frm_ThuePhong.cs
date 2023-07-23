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
    public partial class frm_ThuePhong : Form
    {
        SqlConnection Connection;
        SqlCommand Command;
        String str = @"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frm_ThuePhong()
        {
            InitializeComponent();
        }
        private void Ketnoi()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * From DANGKYPHONG";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            data_ThueP.DataSource = table;
        }
        private void frm_ThuePhong_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            Ketnoi();
        }

        private void data_ThueP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_ThueP.Rows[e.RowIndex];
                txt_MaTP.Text = row.Cells[0].Value.ToString();
                txt_MaP.Text = row.Cells[1].Value.ToString();
                txt_MaKH.Text = row.Cells[2].Value.ToString();
                txt_GiaPhong.Text = row.Cells[3].Value.ToString();
                dateThueP.Text = row.Cells[4].Value.ToString();
                date_TraP.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "insert into DANGKYPHONG values('" + txt_MaTP.Text + "' , '" + txt_MaP.Text + "' , '" + txt_MaKH.Text + "' , '" + txt_GiaPhong.Text + "' ,  N'" + dateThueP.Text + "'  ,  N'" + date_TraP.Text + "')";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Update DANGKYPHONG set MAPHONG = '" + txt_MaP.Text + "', MAKH = '" + txt_MaKH.Text + "', GIAPHONG = '" + txt_GiaPhong.Text + "', NGAYDANGKY = '" + dateThueP.Text + "', NGAYTRAPHONG = '"+ date_TraP +"' where MATHUEPHONG = '" + txt_MaTP.Text + "'";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Command = Connection.CreateCommand();
                Command.CommandText = "delete from DANGKYPHONG where MATHUEPHONG = '" + txt_MaTP.Text + "' ";
                Command.ExecuteNonQuery();
                Ketnoi();
            }
        }

        private void frm_ThuePhong_FormClosing(object sender, FormClosingEventArgs e)
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
