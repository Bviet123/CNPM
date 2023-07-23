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
    public partial class frm_TTkhachhang : Form
    {
        SqlConnection Connection;
        SqlCommand Command;
        String str = @"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frm_TTkhachhang()
        {
            InitializeComponent();
        }
        private void Ketnoi()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * From KHACH";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            data_TTkhach.DataSource = table;
        }
        private void frm_TTkhachhang_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            Ketnoi();
        }

        private void data_TTkhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dateTime = DateTime.Parse(date_NGAYSINH.Text);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_TTkhach.Rows[e.RowIndex];
                txt_MAKH.Text = row.Cells[0].Value.ToString();
                txt_TENKH.Text = row.Cells[1].Value.ToString();
                txt_CMND.Text = row.Cells[2].Value.ToString();
                txt_tuoi.Text = row.Cells[3].Value.ToString();
                txt_DIACHI.Text = row.Cells[4].Value.ToString();
                txt_SDT.Text = row.Cells[5].Value.ToString();
                date_NGAYSINH.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "insert into KHACH values('" + txt_MAKH.Text + "' , N'" + txt_TENKH.Text + "' ,  "+ txt_CMND.Text +"  ,  "+ txt_tuoi.Text +"  , N'"+txt_DIACHI.Text+"' , "+txt_SDT.Text+" , '"+date_NGAYSINH.Text+"')";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Update KHACH set TENKH = N'" + txt_TENKH.Text + "' , CMND = " + txt_CMND.Text + "  , TUOI = " + txt_tuoi.Text + "  , DIACHI = N'" + txt_DIACHI.Text + "' , SĐT = " + txt_SDT.Text + " , NGAYSINH = '" + date_NGAYSINH.Text + "'  where MAKH = '" + txt_MAKH.Text + "'";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Command = Connection.CreateCommand();
                Command.CommandText = "delete from KHACH where MAKH = '" + txt_MAKH.Text + "' ";
                Command.ExecuteNonQuery();
                Ketnoi();
            }
        }

        private void frm_TTkhachhang_FormClosing(object sender, FormClosingEventArgs e)
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
