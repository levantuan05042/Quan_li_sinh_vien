using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bai_tap_lon.Quan_li;

namespace Bai_tap_lon
{
    public partial class thongtinnguoidung : Form
    {
        private string taiKhoan;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        public thongtinnguoidung()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True");
            connection.Open();
        }

        public void SetTaiKhoan(string tk)
        {
            taiKhoan = tk;
            txt_ten.Text = taiKhoan;
            FetchUserDetails(taiKhoan);
        }

        public void FetchUserDetails(string username)
        {
            string query = "SELECT password, fullname, phone_number FROM TaiKhoan WHERE username = @username";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txt_mkmoi.Text = reader.GetString(0); // password
                        txt_name.Text = reader.GetString(1); // fullname
                        txt_sdt.Text = reader.GetString(2); // number_sdt
                    }
                }
            }
        }

        private void thongtinnguoidung_Load(object sender, EventArgs e)
        {
            txt_mkmoi.ReadOnly= true;
            txt_ten.ReadOnly= true;
            txt_name.ReadOnly= true;
            txt_sdt.ReadOnly= true;
            btn_capnhat.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_name.ReadOnly = false;
            txt_sdt.ReadOnly= false;
            btn_capnhat.Visible = true;
            btn_sua.Visible = false;

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Thông báo");
                txt_name.Focus();
                isValid = false;
                return;
            }
            if (txt_name.Text.Length > 50)
            {
                MessageBox.Show("Tên nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(txt_sdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo");
                txt_sdt.Focus();
                isValid = false;
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
            if (isValid)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE [TaiKhoan] SET fullname = @fullname, phone_number = @phone WHERE username = @username";
                command.Parameters.AddWithValue("@fullname", txt_name.Text);
                command.Parameters.AddWithValue("@phone", txt_sdt.Text);
                command.Parameters.AddWithValue("@username", taiKhoan);
                command.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật không...?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    txt_name.ReadOnly = true;
                    txt_sdt.ReadOnly = true;
                    btn_capnhat.Visible = false;
                    btn_sua.Visible = true;
                    menu_admin dgv = new menu_admin();
                    this.Hide();
                    dgv.ShowDialog();
                    this.Show();
                }                     
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
