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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_tap_lon
{
    public partial class doimk_admin : Form
    {
        private string taiKhoan;
        public doimk_admin()
        {
            InitializeComponent();
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
            string passwordNew = txt_mkmoi.Text;
            string passwordConfirm = txt_nhaplai.Text;

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

            if (string.IsNullOrEmpty(txt_mkmoi.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới!", "Thông báo");
                txt_mkmoi.Focus();
                isValid = false;
                return;
            }
            if (txt_mkmoi.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu nhỏ hơn 50 kí tự", "Thông báo");
                txt_mkmoi.Focus();
                return;
            }
            if (txt_mkmoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu lớn hơn 6 kí tự", "Thông báo");
                txt_mkmoi.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_nhaplai.Text))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu!", "Thông báo");
                txt_nhaplai.Focus();
                isValid = false;
                return;
            }
            if (passwordNew != passwordConfirm)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng với mật khẩu!", "Thông báo");
                txt_nhaplai.Focus();
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
                        readerUser.Close();
                        sqlQueryUser = "UPDATE TaiKhoan SET password = @passwordNew WHERE username = @username";
                        commandUser = new SqlCommand(sqlQueryUser, connection);
                        commandUser.Parameters.AddWithValue("@username", username);
                        commandUser.Parameters.AddWithValue("@passwordNew", passwordNew);

                        int resultUser = commandUser.ExecuteNonQuery();
                        if (resultUser > 0)
                        {
                            MessageBox.Show("Bạn đã đổi mật khẩu thành công!", "Thông báo");
                            dangnhap dn = new dangnhap();
                            this.Hide();
                            dn.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu hiện tại không đúng!", "Thông báo");
                    }
                }
            }
        }    
        private void cb_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienthi.Checked)
            {
                txt_mkhientai.PasswordChar = '\0';
                txt_mkmoi.PasswordChar = '\0';
                txt_nhaplai.PasswordChar= '\0';
            }
            else
            {
                txt_mkmoi.PasswordChar = '*';
                txt_mkhientai.PasswordChar = '*';
                txt_nhaplai .PasswordChar = '*';
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        private void doimk_admin_Load(object sender, EventArgs e)
        {
            txt_ten.ReadOnly=true;
            txt_mkhientai.Focus();
        }

        private void txt_nhaplai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_mkhientai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_mkmoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
