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
    public partial class ql_admin : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=DESKTOP-NG5IFP7\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public ql_admin()
        {
            InitializeComponent();
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }
        private void ql_admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet6.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.qL_SinhVienDataSet6.Admin);
            txt_tendangnhap.Focus();

        }
        private void bang_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_them.Enabled = false;
                txt_tendangnhap.ReadOnly = true;
                DataGridViewRow row = bang_admin.Rows[e.RowIndex];
                txt_tendangnhap.Text = row.Cells[0].Value.ToString();
                txt_matkhau.Text = row.Cells[1].Value.ToString();
            }
        }
        void loaddata()
        {
            using (command = new SqlCommand("SELECT * FROM [Admin]", connection))
            {
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                bang_admin.DataSource = table;
            }
        }
        void reset()
        {
            btn_them.Enabled = true;
            txt_tendangnhap.ReadOnly = false;
            txt_tendangnhap.Text = "";
            txt_matkhau.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_tendangnhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
                txt_tendangnhap.Focus();
                isValid = false;
                return;
            }
            if (txt_tendangnhap.Text.Length > 50)
            {
                MessageBox.Show("Tên đăng nhập nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Admin] WHERE tk_admin = @tk_admin", connection))
            {
                checkCommand.Parameters.AddWithValue("@tk_admin", txt_tendangnhap.Text);
                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Tên Admin đã tồn tại!");
                    txt_tendangnhap.Focus();
                    isValid = false;
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_matkhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");
                txt_matkhau.Focus();
                isValid = false;
                return;
            }
            if (txt_matkhau.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (txt_matkhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu có ít nhất 6 kí tự", "Thông báo");
                return;
            }
            if (isValid)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO [Admin] VALUES(@tk_admin, @mk_admin)", connection))
                {
                    command.Parameters.AddWithValue("@tk_admin", txt_tendangnhap.Text);
                    command.Parameters.AddWithValue("@mk_admin", txt_matkhau.Text);
                    command.ExecuteNonQuery();
                }
                loaddata();
                MessageBox.Show("Thêm thành công");
                reset();
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_matkhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");
                txt_matkhau.Focus();
                isValid = false;
                return;
            }
            if (txt_matkhau.Text.Length > 50)
            {
                MessageBox.Show("Mật khẩu nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (txt_matkhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu có ít nhất 6 kí tự", "Thông báo");
                return;
            }
            if (isValid)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE [Admin] set mk_admin = @mk_admin where tk_admin = @tk_admin";
                command.Parameters.AddWithValue("@mk_admin", txt_matkhau.Text);
                command.Parameters.AddWithValue("@tk_admin", txt_tendangnhap.Text);
                command.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không...?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    loaddata();
                    MessageBox.Show("Sửa thành công");
                    reset();
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tendangnhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã cần xóa!");
                txt_tendangnhap.Focus();
                return;
            }
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM [Admin] where tk_admin ='" + txt_tendangnhap.Text + "'";
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 0)
            {
                MessageBox.Show("Không có mã cần xóa...!!!", "Thông báo");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                loaddata();
                reset();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }
        private void btn_clean_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
    }
}
