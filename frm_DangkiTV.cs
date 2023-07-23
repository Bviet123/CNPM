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
    public partial class frm_DangkiTV : Form
    {
        SqlConnection Connection;
        SqlCommand Command;
        String str = @"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frm_DangkiTV()
        {
            InitializeComponent();
        }
        private void Ketnoi()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * From THETV";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            data_DKTV.DataSource = table;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frm_DangkiTV_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            Ketnoi();
        }

        private void data_DKTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_DKTV.Rows[e.RowIndex];
                txt_MATHETV.Text = row.Cells[0].Value.ToString();
                txt_TENKH.Text = row.Cells[1].Value.ToString();
                txt_CMND.Text = row.Cells[2].Value.ToString();
                txt_TUOI.Text = row.Cells[3].Value.ToString();
                txt_SDT.Text = row.Cells[4].Value.ToString();
                date_NGAYSINH.Text = row.Cells[5].Value.ToString();
                txt_DIACHI.Text = row.Cells[6].Value.ToString();
                
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "insert into THETV values( '" + txt_MATHETV.Text + "',N'" + txt_TENKH.Text + "','" + txt_CMND.Text + "' , '" + txt_TUOI.Text + "' , '" + txt_SDT.Text + "' , '" + date_NGAYSINH.Text + "' , N'" + txt_DIACHI.Text + "')";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Command = Connection.CreateCommand();
                Command.CommandText = "delete from THETV where MATHETV = '" + txt_MATHETV.Text + "' ";
                Command.ExecuteNonQuery();
                Ketnoi();
            }
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Update THETV set TENKH = N'" + txt_TENKH.Text + "' ,CMND = N'" + txt_CMND.Text + "' ,TUOI = '" + txt_TUOI.Text + "' , SDT = " + txt_SDT.Text + " , NGAYSINH = '" + date_NGAYSINH.Text + "' , DIACHI = N'" + txt_DIACHI.Text + "' where MATHETV =  '" + txt_MATHETV.Text + "'";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void frm_DangkiTV_FormClosing(object sender, FormClosingEventArgs e)
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
