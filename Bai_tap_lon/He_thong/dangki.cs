using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class dangki : Form
    {
        public dangki()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void dangki_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string username = textBox1.Text;
            string password = textBox2.Text;
            string passwordConfirm = textBox3.Text;
            string fullname = txt_name.Text;
            string phoneNumber = txt_phone.Text;

            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đầy đủ!", "Thông báo");
                txt_name.Focus();
                isValid = false;
                return;
            }
            if (txt_name.Text.Length > 50)
            {
                MessageBox.Show("Tên đầy đủ nhỏ hơn 50 kí tự", "Thông báo");
                txt_name.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_phone.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo");
                txt_phone.Focus();
                isValid = false;
                return;
            }
            if ((txt_phone.Text.StartsWith("0") && txt_phone.Text.Length == 10) || (txt_phone.Text.StartsWith("84") && txt_phone.Text.Length == 11))
            {
            }
            else
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo");
                txt_phone.Focus();
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông báo");
                textBox1.Focus();
                isValid = false;
                return;
            }
            if (textBox1.Text.Length > 50)
            {
                MessageBox.Show("Tên đăng nhập nhỏ hơn 50 kí tự", "Thông báo");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo");
                textBox3.Focus();
                isValid = false;
                return;
            }
            if (textBox3.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu nhỏ hơn 50 kí tự", "Thông báo");
                textBox3.Focus();
                return;
            }
            if (textBox3.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu lớn hơn 6 kí tự", "Thông báo");
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu!", "Thông báo");
                textBox2.Focus();
                isValid = false;
                return;
            }
            if (password != passwordConfirm)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng với mật khẩu!", "Thông báo");
                textBox2.Focus();
                return;
            }
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQueryUser = "SELECT * FROM TaiKhoan WHERE username = @username";
                SqlCommand commandUser = new SqlCommand(sqlQueryUser, connection);
                commandUser.Parameters.AddWithValue("@username", username);

                SqlDataReader readerUser = commandUser.ExecuteReader();
                if (readerUser.HasRows)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo");
                    return;
                }
                readerUser.Close();
                string sqlQueryPhone = "SELECT * FROM TaiKhoan WHERE CAST(phone_number AS NVARCHAR(MAX)) = @phone_number";
                SqlCommand commandPhone = new SqlCommand(sqlQueryPhone, connection);
                commandPhone.Parameters.AddWithValue("@phone_number", txt_phone.Text);

                SqlDataReader readerPhone = commandPhone.ExecuteReader();
                if (readerPhone.HasRows)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng!", "Thông báo");
                    return;
                }
                readerPhone.Close();

                sqlQueryUser = "INSERT INTO TaiKhoan (username, fullname, password, phone_number, mode, state) VALUES (@username, @fullname, @password, @phone_number, N'User', 1)";
                commandUser = new SqlCommand(sqlQueryUser, connection);
                commandUser.Parameters.AddWithValue("@username", username);
                commandUser.Parameters.AddWithValue("@fullname", fullname);
                commandUser.Parameters.AddWithValue("@password", password);
                commandUser.Parameters.AddWithValue("@phone_number", phoneNumber);

                int resultUser = commandUser.ExecuteNonQuery();
                if (resultUser > 0)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo");
                    dangnhap dn = new dangnhap();
                    this.Hide();
                    dn.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thất bại!", "Thông báo");
                }
            }
        }


            private void cb_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienthi.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
