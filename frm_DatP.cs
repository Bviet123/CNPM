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
    public partial class frm_DatP : Form
    {
        SqlConnection Connection;
        SqlCommand Command;
        String str = @"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frm_DatP()
        {
            InitializeComponent();
        }
        private void Ketnoi()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * From DATPHONG";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            data_DatP.DataSource = table;
        }
        private void frm_DatP_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            Ketnoi();
        }

        private void img_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", " ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frm_DatP_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "insert into DATPHONG values('" + txt_MaDatP.Text + "' , '" + txt_MaP.Text + "' , '" + txt_MaNV.Text + "' ,  N'" + txt_TenKH.Text + "'  ,  '" + txt_SDT.Text + "'  , '" + date_DatP.Text + "')";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void data_DatP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dateTime = DateTime.Parse(date_DatP.Text);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_DatP.Rows[e.RowIndex];
                txt_MaDatP.Text = row.Cells[0].Value.ToString();
                txt_MaP.Text = row.Cells[1].Value.ToString();
                txt_MaNV.Text = row.Cells[2].Value.ToString();
                txt_TenKH.Text = row.Cells[3].Value.ToString();
                txt_SDT.Text = row.Cells[4].Value.ToString();
                date_DatP.Text = row.Cells[5].Value.ToString();

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Update DATPHONG set MADATPHONG ='"+ txt_MaDatP.Text +"', MAPHONG = '"+ txt_MaP.Text +"', MANV = '" + txt_MaNV.Text + "', TENKH = '" + txt_TenKH.Text + "', NGAYHEN = '" + date_DatP.Text + "' where MADATPHONG = '" + txt_MaDatP.Text + "'"; 
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Command = Connection.CreateCommand();
                Command.CommandText = "delete from DATPHONG where MADATPHONG = '" + txt_MaDatP.Text + "' ";
                Command.ExecuteNonQuery();
                Ketnoi();
            }
        }
    }
}
