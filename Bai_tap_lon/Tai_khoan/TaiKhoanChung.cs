using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_lon.Quan_li
{
    public partial class TaiKhoanChung : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public TaiKhoanChung()
        {
            InitializeComponent();
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }
       
        void md5()
        {
            foreach (DataRow row in table.Rows)
            {
                string original = row[2].ToString();
                string hashed = CalculateMD5Hash(original);
                row[2] = hashed;
                /*string original1 = row[0].ToString();
                string hashed1 = CalculateMD5Hash(original1);
                row[0] = hashed1;*/
            }
        }
        void loaddata()
        {
            using (command = new SqlCommand("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username", connection))
            {
                command.Parameters.AddWithValue("@username", dangnhap.LoggedInUser);
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                md5();
                bang_taikhoan.DataSource = table;
            }
        }


        private void TaiKhoanChung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet28.TaiKhoan' table. You can move, or remove it, as needed.
            //this.taiKhoanTableAdapter.Fill(this.qL_SinhVienDataSet28.TaiKhoan);
            txt_name.Focus();
            bang_taikhoan.ReadOnly = true;
            gr.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        public string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        private void bang_taikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_clean.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                gr.Enabled = true;
                btn_them.Enabled = false;
                txt_us.ReadOnly = true;
                txt_pass.ReadOnly = true;
                DataGridViewRow row = bang_taikhoan.Rows[e.RowIndex];
                txt_name.Text = row.Cells[0].Value.ToString();
                txt_phone.Text = row.Cells[1].Value.ToString();
                txt_us.Text = row.Cells[2].Value.ToString();
                txt_pass.Text = row.Cells[3].Value.ToString();

                string mode = row.Cells[4].Value.ToString();
                if (mode == "User")
                {
                    rad_us.Checked = true;
                }
                else if (mode == "Admin")
                {
                    rad_ad.Checked = true;
                }
                else if (mode == "Trưởng Khoa")
                {
                    rad_tk.Checked = true;
                }
                else if (mode == "Giáo Viên")
                {
                    rad_gv.Checked = true;
                }
                bool state = Convert.ToBoolean(row.Cells[5].Value);
                if (state)
                {
                    rad_t.Checked = true;
                }
                else
                {
                    rad_f.Checked = true;
                }
            }
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {
        }
        void reset()
        {
            txt_name.Focus();
            gr.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            rad_ad.Checked = false;
            rad_us.Checked = false;
            rad_gv.Checked = false;
            rad_tk.Checked = false;
            rad_t.Checked = false;
            rad_f.Checked = false;
            radtk_ad.Checked = false;
            radtk_us.Checked = false;
            radtk_gv.Checked = false;
            radtk_tk.Checked = false;
            radtk_t.Checked = false;
            f.Checked = false;
            txt_name.Text = "";
            txt_pass.Text = "";
            txt_phone.Text = "";
            txt_us.Text = "";
            btn_them.Enabled = true;
            txt_us.ReadOnly = false;
            txt_pass.ReadOnly = false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_us.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông báo");
                txt_us.Focus();
                isValid = false;
                return;
            }
            if (txt_us.Text.Length > 50)
            {
                MessageBox.Show("Tên đăng nhập nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [TaiKhoan] WHERE username = @username", connection))
            {
                checkCommand.Parameters.AddWithValue("@username", txt_us.Text);
                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo");
                    txt_us.Focus();
                    isValid = false;
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo");
                txt_pass.Focus();
                isValid = false;
                return;
            }
            if (txt_pass.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu nhỏ hơn 50 kí tự", "Thông báo");
                isValid = false;
                return;
            }
            if (txt_pass.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu có ít nhất 6 kí tự", "Thông báo");
                isValid = false;
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
                MessageBox.Show("Tên đăng nhập nhỏ hơn 50 kí tự", "Thông báo");
                isValid = false;
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
                isValid = false;
                return;
            }
            using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [TaiKhoan] WHERE CAST(phone_number AS NVARCHAR(MAX)) = N'" + txt_phone.Text + "'", connection))
            {
                checkCommand.Parameters.AddWithValue("@phone_number", txt_phone.Text);
                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Thông báo");
                    txt_phone.Focus();
                    isValid = false;
                    return;
                }
            }

            if (!rad_us.Checked && !rad_ad.Checked && !rad_tk.Checked && !rad_gv.Checked)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
                return;
            }
            if (isValid)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO TaiKhoan (username, fullname, password, phone_number, mode, state) VALUES (@username, @fullname, @password, @phone_number, @mode, 1)", connection))
                {
                    command.Parameters.AddWithValue("@username", txt_us.Text);
                    command.Parameters.AddWithValue("@password", txt_pass.Text); // Sửa lại tên tham số từ "@mk_admin" thành "@password"
                    command.Parameters.AddWithValue("@fullname", txt_name.Text);
                    command.Parameters.AddWithValue("@phone_number", txt_phone.Text);
                    string mode = "";
                    if (rad_us.Checked)
                    {
                        mode = "User";
                    }
                    else if (rad_ad.Checked)
                    {
                        mode = "Admin";
                    }
                    else if (rad_tk.Checked)
                    {
                        mode = "Trưởng Khoa";
                    }
                    else if (rad_gv.Checked)
                    {
                        mode = "Giáo Viên";
                    }
                    command.Parameters.AddWithValue("@mode", mode);

                    command.ExecuteNonQuery();
                }
                loaddata();
                MessageBox.Show("Thêm thành công");
                reset();
            }
        }
        private void btn_clean_Click(object sender, EventArgs e)
        {
            loaddata();
            reset();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string usernameToDelete = txt_us.Text.Trim(); // Get the username to delete

                if (string.IsNullOrEmpty(usernameToDelete))
                {
                    MessageBox.Show("Bạn chưa nhập mã cần xóa!", "Thông báo");
                    txt_us.Focus();
                    return;
                }
                using (SqlCommand command = new SqlCommand("DELETE FROM [TaiKhoan] WHERE username = @username", connection))
                {
                    command.Parameters.AddWithValue("@username", usernameToDelete);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Không có tên đăng nhập cần xóa...!!!", "Thông báo");
                        return;
                    }
                }

                loaddata();
                reset();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rad_ad_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rad_us_CheckedChanged(object sender, EventArgs e)
        {            
        }
        private void rad_gv_CheckedChanged(object sender, EventArgs e)
        {           
        }
        private void rad_tk_CheckedChanged(object sender, EventArgs e)
        {          
        }
        private void rad_t_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rad_f_CheckedChanged(object sender, EventArgs e)
        {            
        }
        private void ExecuteSQL(string query)
        {
            using (command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", dangnhap.LoggedInUser);
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                md5();
                bang_taikhoan.DataSource = table;
            }
        }
        void reset2()
        {
            txt_name.Text = "";
            txt_pass.Text = "";
            txt_phone.Text = "";
            txt_us.Text = "";
            rad_ad.Checked = false;
            rad_us.Checked = false;
            rad_gv.Checked = false;
            rad_tk.Checked = false;
            rad_t.Checked = false;
            rad_f.Checked = false;
            btn_them.Enabled= true;
            btn_xoa.Enabled= false;
            btn_sua.Enabled= false;
            loaddata();
        }
        private void radtk_ad_CheckedChanged(object sender, EventArgs e)
        {
            reset2();
            if (radtk_ad.Checked && rad_t.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'Admin' AND state = 1");
            }
            else if (radtk_ad.Checked && rad_f.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'Admin' AND state = 0");
            }
            else if (radtk_ad.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'Admin'");
            }
        }

        private void radtk_us_CheckedChanged(object sender, EventArgs e)
        {
            reset2();
            if (radtk_us.Checked && rad_t.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE mode = N'User' AND state = 1");
            }
            else if (radtk_us.Checked && rad_f.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE mode = N'User' AND state = 0");
            }
            else if (radtk_us.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE mode = N'User'");
            }
            
        }

        private void radtk_gv_CheckedChanged(object sender, EventArgs e)
        {
            reset2();
            if (radtk_gv.Checked && rad_t.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE mode = N'Giáo Viên' AND state = 1");
            }
            else if (radtk_gv.Checked && rad_f.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE mode = N'Giáo Viên' AND state = 0");
            }
            else if (radtk_gv.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE mode = N'Giáo Viên'");
            }
        }

        private void radtk_tk_CheckedChanged(object sender, EventArgs e)
        {
            reset2();
            if (radtk_tk.Checked && rad_t.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE mode = N'Trưởng Khoa' AND state = 1");
            }
            else if (radtk_tk.Checked && rad_f.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE mode = N'Trưởng Khoa' AND state = 0");
            }
            else if (radtk_tk.Checked)
            {
                ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE mode = N'Trưởng Khoa'");
            }
        }

        private void radtk_t_CheckedChanged(object sender, EventArgs e)
        {
            reset2();
            if (radtk_t.Checked)
            {
                if (radtk_ad.Checked)
                {
                    ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'Admin' AND state = 1");
                }
                else if (radtk_us.Checked)
                {
                    ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'User' AND state = 1");
                }
                else if (radtk_gv.Checked)
                {
                    ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'Giáo Viên' AND state = 1");
                }
                else if (radtk_tk.Checked)
                {
                    ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'Trưởng Khoa' AND state = 1");
                }
            }
        }

        private void f_CheckedChanged(object sender, EventArgs e)
        {
            reset2();
            if (f.Checked)
            {
                if (radtk_ad.Checked)
                {
                    ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'Admin' AND state = 0");
                }
                else if (radtk_us.Checked)
                {
                    ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'User' AND state = 0");
                }
                else if (radtk_gv.Checked)
                {
                    ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'Giáo Viên' AND state = 0");
                }
                else if (radtk_tk.Checked)
                {
                    ExecuteSQL("SELECT * FROM [TaiKhoan] WHERE username != 'admin' AND username != @username AND mode = N'Trưởng Khoa' AND state = 0");
                }
            }
        }


        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đầy đủ!", "Thông báo");
                txt_name.Focus();
                isValid = false;
                return;
            }
            if (txt_name.Text.Length > 50)
            {
                MessageBox.Show("Tên đăng nhập nhỏ hơn 50 kí tự", "Thông báo");
                isValid = false;
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
                isValid = false;
                return;
            }
            if (isValid)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không...?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE TaiKhoan SET fullname = @fullname, phone_number = @phone_number, mode = @mode, state = @state WHERE username = @username";
                command.Parameters.AddWithValue("@fullname", txt_name.Text);
                command.Parameters.AddWithValue("@phone_number", txt_phone.Text);
                command.Parameters.AddWithValue("@username", txt_us.Text);

                string mode = "";
                if (rad_us.Checked)
                {
                    mode = "User";
                }
                else if (rad_ad.Checked)
                {
                    mode = "Admin";
                }
                else if (rad_tk.Checked)
                {
                    mode = "Trưởng Khoa";
                }
                else if (rad_gv.Checked)
                {
                    mode = "Giáo Viên";
                }
                command.Parameters.AddWithValue("@mode", mode);

                int state = rad_t.Checked ? 1 : 0;
                command.Parameters.AddWithValue("@state", state);

                command.ExecuteNonQuery();               
                    loaddata();
                    MessageBox.Show("Sửa thành công");
                    reset();
                }
            }
        }
    }
}
