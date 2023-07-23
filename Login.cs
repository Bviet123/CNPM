using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QLKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txtUsename.Text;
            string password = txtPass.Text;

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G9HM7RN\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");

            string query = "SELECT * FROM TAIKHOANDN WHERE TAIKHOAN = @UserName AND MATKHAU = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string quyen = reader["QUYEN"].ToString();

                if (quyen == "admin")
                {
                    Trangchu trangchu = new Trangchu();
                    trangchu.Show();
                    this.Hide();
                    trangchu.lbQuyen.Text = "Admin";
                    trangchu.menuStrip1.Items[1].Enabled = false;
                    trangchu.menuStrip1.Items[2].Enabled = false;
                    trangchu.menuStrip1.Items[3].Enabled = false;


                }
                if (quyen == "LeTan")
                {
                    Trangchu trangchu = new Trangchu();
                    trangchu.Show();
                    this.Hide();
                    trangchu.lbQuyen.Text = "Lễ Tân";
                    trangchu.menuStrip1.Items[0].Enabled = false;
                    trangchu.menuStrip1.Items[3].Enabled = false;
                    trangchu.menuStrip1.Items[4].Enabled = false;
                }
                if (quyen == "QuanLy")
                {
                    Trangchu trangchu = new Trangchu();
                    trangchu.Show();
                    trangchu.lbQuyen.Text = "Quản Lý";
                    this.Hide();
                }
            }
            else
            {
                if (txtUsename.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Hãy kiểm tra lại mật khẩu và tài khoản");
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            connection.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", " ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPass.PasswordChar = '\0';
            }
            else
                txtPass.PasswordChar = '*';
        }
    }
}
