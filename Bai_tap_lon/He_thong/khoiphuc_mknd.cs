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
    public partial class khoiphuc_mknd : Form
    {
        public khoiphuc_mknd()
        {
            InitializeComponent();
        }

        private void btn_kp_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_ten.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông báo");
                txt_ten.Focus();
                isValid = false;
                return;
            }
            if (txt_ten.Text.Length > 50)
            {
                MessageBox.Show("Tên đăng nhập nhỏ hơn 50 kí tự", "Thông báo");
                txt_ten.Focus();
                return;
            }
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
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_sdt.Text, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!", "Thông báo");
                txt_sdt.Focus();
                return;
            }
            if ((txt_sdt.Text.StartsWith("0") && txt_sdt.Text.Length == 10) || (txt_sdt.Text.StartsWith("84") && txt_sdt.Text.Length == 11))
            {
            }
            else
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo");
                isValid = false;
                return;
            }
            string username = txt_ten.Text;
            string fullname = txt_name.Text;
            string phone_number = txt_sdt.Text;
            using (SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan WHERE username = @username AND fullname = @fullname AND CAST(phone_number AS NVARCHAR(MAX)) = @phone_number AND (mode = N'User' OR mode = N'Trưởng Khoa' OR mode = N'Giáo Viên')", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@fullname", fullname);
                    command.Parameters.AddWithValue("@phone_number", phone_number);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Close();
                        using (SqlCommand updateCommand = new SqlCommand("UPDATE TaiKhoan SET password = '111111', state = 1 WHERE username = @username AND fullname = @fullname AND CAST(phone_number AS NVARCHAR(MAX)) = @phone_number AND (mode = N'User' OR mode = N'Trưởng Khoa' OR mode = N'Giáo Viên')", connection))
                        {
                            updateCommand.Parameters.AddWithValue("@username", username);
                            updateCommand.Parameters.AddWithValue("@fullname", fullname);
                            updateCommand.Parameters.AddWithValue("@phone_number", phone_number);

                            updateCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Mật khẩu đã được đặt lại thành 111111.","Thông Báo");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng phù hợp.", "Thông Báo");
                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
