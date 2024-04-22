using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_lon
{
    public partial class mo : Form
    {
        private string taiKhoan;
        public mo()
        {
            InitializeComponent();
        }

        private void mo_Load(object sender, EventArgs e)
        {
            txt_ten.ReadOnly = true;
            txt_mkhientai.Focus();
        }
        public void SetTaiKhoan(string tk)
        {
            taiKhoan = tk;
            txt_ten.Text = taiKhoan;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string username = txt_ten.Text;
            string password = txt_mkhientai.Text;
            if (string.IsNullOrEmpty(txt_mkhientai.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo");
                txt_mkhientai.Focus();
                isValid = false;
                return;
            }
            if (txt_mkhientai.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu nhỏ hơn 50 kí tự", "Thông báo");
                txt_mkhientai.Focus();
                return;
            }
            if (txt_mkhientai.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu lớn hơn 6 kí tự", "Thông báo");
                txt_mkhientai.Focus();
                return;
            }

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQueryUser = "SELECT * FROM TaiKhoan WHERE username = @username AND password = @password";
                SqlCommand commandUser = new SqlCommand(sqlQueryUser, connection);
                commandUser.Parameters.AddWithValue("@username", username);
                commandUser.Parameters.AddWithValue("@password", password);

                using (SqlDataReader readerUser = commandUser.ExecuteReader())
                {
                    if (readerUser.HasRows)
                    {
                        this.Close();
                        menu_admin dn = new menu_admin();
                        this.Hide();
                        dn.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu sai. Vui lòng nhập lại...!", "Thông báo");
                        txt_mkhientai.Text = "";
                        txt_mkhientai.Focus();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienthi.Checked)
            {
                txt_mkhientai.PasswordChar = '\0';
            }
            else 
            { 
                txt_mkhientai.PasswordChar = '*';
            }
        }
    }
}
