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
    public partial class ql_giaovien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=DESKTOP-NG5IFP7\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        bool isValid = true;
        public ql_giaovien()
        {
            InitializeComponent();
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }
        void loaddata()
        {
            using (command = new SqlCommand("SELECT * FROM [GV]", connection))
            {
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                bang_gv.DataSource = table;
            }
        }
        void reset()
        {
            btn_them.Enabled = true;
            txt_tendangnhap.ReadOnly = false;
            txt_tendangnhap.Text = "";
            txt_matkhau.Text = "";
        }

        private void ql_giaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet23.GV' table. You can move, or remove it, as needed.
            this.gVTableAdapter.Fill(this.qL_SinhVienDataSet23.GV);
            txt_tendangnhap.Focus();

        }

        private void bang_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_tendangnhap.ReadOnly = true;
                btn_them.Enabled = false;
                DataGridViewRow row = bang_gv.Rows[e.RowIndex];
                txt_tendangnhap.Text = row.Cells[0].Value.ToString();
                txt_matkhau.Text = row.Cells[1].Value.ToString();
            }
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
            using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [GV] WHERE tk_gv = @tk_gv", connection))
            {
                checkCommand.Parameters.AddWithValue("@tk_gv", txt_tendangnhap.Text);
                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Tên giáo viên đã tồn tại!");
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
                using (SqlCommand command = new SqlCommand("INSERT INTO [GV] VALUES(@tk_gv, @mk_gv)", connection))
                {
                    command.Parameters.AddWithValue("@tk_gv", txt_tendangnhap.Text);
                    command.Parameters.AddWithValue("@mk_gv", txt_matkhau.Text);
                    command.ExecuteNonQuery();
                }
                loaddata();
                MessageBox.Show("Thêm thành công");
                reset();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
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
                MessageBox.Show("Mật khẩu có ít nhất 6 kí tự", "Thông báo");
                return;
            }
            if (isValid)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE [GV] set mk_gv = @mk_gv where tk_gv = @tk_gv";
                command.Parameters.AddWithValue("@mk_gv", txt_matkhau.Text);
                command.Parameters.AddWithValue("@tk_gv", txt_tendangnhap.Text);
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
            command.CommandText = "DELETE FROM [GV] where tk_gv ='" + txt_tendangnhap.Text + "'";
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
            this.Close();
        }
    }
}
