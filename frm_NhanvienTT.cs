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
    public partial class frm_NhanvienTT : Form
    {

        SqlConnection Connection;
        SqlCommand Command;
        String str = @"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frm_NhanvienTT()
        {
            InitializeComponent();
        }
        
        private void Ketnoi()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * From NHANVIEN";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            data_TTNV.DataSource = table;
        }
        private void frm_NhanvienTT_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            Ketnoi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void data_TTNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dateTime = DateTime.Parse(date_NGAYSINH.Text);

            if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.data_TTNV.Rows[e.RowIndex];
                    txt_MANV.Text = row.Cells[0].Value.ToString();
                    txt_TENNV.Text = row.Cells[1].Value.ToString();
                    Combo_GIOITINH.Text = row.Cells[2].Value.ToString();
                    date_NGAYSINH.Text = row.Cells[3].Value.ToString();
                    txt_CMND.Text = row.Cells[4].Value.ToString();
                    txt_SDT.Text = row.Cells[5].Value.ToString();
                    txt_MACV.Text = row.Cells[6].Value.ToString();
                    
                    txt_DIACHI.Text = row.Cells[7].Value.ToString();
                }
            
          
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            
                Command = Connection.CreateCommand();
                Command.CommandText = "insert into NHANVIEN values( '" + txt_MANV.Text + "' , N'" + txt_TENNV.Text + "' , N'" + Combo_GIOITINH.Text + "' , '" + date_NGAYSINH.Text + "' , '" + txt_CMND.Text + "' , '" + txt_SDT.Text + "' , '" + txt_MACV.Text + "' , N'" + txt_DIACHI.Text + "')";
                Command.ExecuteNonQuery();
                Ketnoi();
           
        }

        private void btn_find_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Update NHANVIEN set TENNV = N'" + txt_TENNV.Text + "' , GIOITINH = N'" + Combo_GIOITINH.Text + "' ,NGAYSINH = N'" + date_NGAYSINH.Text + "' ,CMND = '" + txt_CMND.Text + "' , SĐT = " + txt_SDT.Text + " , MACHUCVU = '" + txt_MACV.Text + "' , DIACHI = N'" + txt_DIACHI.Text + "' where MANV ='" + txt_MANV.Text + "'";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Command = Connection.CreateCommand();
                Command.CommandText = "delete from NHANVIEN where MANV = '" + txt_MANV.Text + "' ";
                Command.ExecuteNonQuery();
                Ketnoi();
            }
        }

        private void frm_NhanvienTT_FormClosing(object sender, FormClosingEventArgs e)
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
