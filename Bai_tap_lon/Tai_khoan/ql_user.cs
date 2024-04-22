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
    public partial class ql_user : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=DESKTOP-NG5IFP7\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        bool isValid = true;
        public ql_user()
        {
            InitializeComponent();
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }
        private void ql_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet7.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.qL_SinhVienDataSet7.User);
            txt_tendangnhap.Focus();
        }
        void loaddata()
        {
            using (command = new SqlCommand("SELECT * FROM [User]", connection))
            {
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                bang_user.DataSource = table;
            }
        }
        void reset()
        {
            txt_tendangnhap.ReadOnly = false;
            btn_them.Enabled = true;
            txt_tendangnhap.Text = "";
            txt_matkhau.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
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
            using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE tk_user = @tk_user", connection))
            {
                checkCommand.Parameters.AddWithValue("@tk_user", txt_tendangnhap.Text);
                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Tên User đã tồn tại!");
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
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự", "Thông báo");
                return;
            }
            if (isValid)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO [User] VALUES(@tk_user, @mk_user)", connection))
                {
                    command.Parameters.AddWithValue("@tk_user", txt_tendangnhap.Text);
                    command.Parameters.AddWithValue("@mk_user", txt_matkhau.Text);
                    command.ExecuteNonQuery();
                }
                loaddata();
                MessageBox.Show("Thêm thành công");
                reset();
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            {
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
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự", "Thông báo");
                    return;
                }
                if (isValid)
                {
                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE [User] set mk_user = @mk_user where tk_user = @tk_user";
                    command.Parameters.AddWithValue("@mk_user", txt_matkhau.Text);
                    command.Parameters.AddWithValue("@tk_user", txt_tendangnhap.Text);
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
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_tendangnhap.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã cần xóa!");
                    txt_tendangnhap.Focus();
                    return;
                }
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM [User] where tk_user ='" + txt_tendangnhap.Text + "'";
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Không có mã cần xóa...!!!","Thông báo");
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    loaddata();
                    reset();
                    MessageBox.Show("Xóa thành công","Thông báo");
                }
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
        private void bang_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0)
            {
                txt_tendangnhap.ReadOnly = true;
                btn_them.Enabled = false;
                txt_tendangnhap.ReadOnly = true;
                DataGridViewRow row = bang_user.Rows[e.RowIndex];
                txt_tendangnhap.Text = row.Cells[0].Value.ToString();
                txt_matkhau.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}