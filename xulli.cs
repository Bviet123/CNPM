using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class frm_XULI : Form
    {
        SqlConnection Connection;
        SqlCommand Command;
        String str = @"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frm_XULI()
        {
            InitializeComponent();
        }
        private void Ketnoi()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * From PHONG";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            data_2.DataSource = table;
        }
        private void QL_Phong_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            Ketnoi();
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void data_2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data_2.Rows[e.RowIndex];
                txt_MAPHONG.Text = row.Cells[0].Value.ToString();
                txt_TENPHONG.Text = row.Cells[1].Value.ToString();
                txt_LOAIPHONG.Text = row.Cells[2].Value.ToString();
                txt_TIENNGHI.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Command = Connection.CreateCommand();
                Command.CommandText = "insert into PHONG values('" + txt_MAPHONG.Text + "' , '" + txt_TENPHONG.Text + "' , N'" + txt_LOAIPHONG.Text + "' , N'" + txt_TIENNGHI.Text + "')";
                Command.ExecuteNonQuery();
                Ketnoi();
            }
            catch(Exception ex)
            {
                MessageBox.Show("dữ liệu không được trùng !");
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "delete from PHONG where MAPHONG = '"+txt_MAPHONG.Text+"' ";
            Command.ExecuteNonQuery();
            Ketnoi();
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "update PHONG set TENPHONG = N'" + txt_TENPHONG.Text + "' , LOAIPHONG = N'" + txt_LOAIPHONG.Text + "' , TIENNGHI = N'" + txt_TIENNGHI.Text + "' where MAPHONG = '" + txt_MAPHONG.Text + "' ";
            Command.ExecuteNonQuery();
            Ketnoi();
        }
    }
}
