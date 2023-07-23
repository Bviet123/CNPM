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
    public partial class frm_xuli : Form
    {
        SqlConnection Connection;
        SqlCommand Command;
        String str = @"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public frm_xuli()
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
        private void KetnoiPT()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * From PHONG where TRANGTHAI = 0";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            data_2.DataSource = table;
        }
        
        private void KetnoiPDT()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * From PHONG where TRANGTHAI = 1";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            data_2.DataSource = table;
        }
        private void KetnoiList()
        {
            
        }
        private void frm_xuli_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            Ketnoi();
            KetnoiList();
        }

        private void data_2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            KetnoiPDT();

        }

        private void btn_Emty_Click(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            KetnoiPT();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            Ketnoi();
        }

       

        private void cbb_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_xuli_FormClosing(object sender, FormClosingEventArgs e)
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
