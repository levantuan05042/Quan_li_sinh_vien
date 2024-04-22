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
    public partial class monhoc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public monhoc()
        {
            InitializeComponent();
            cb_magv.DropDownStyle = ComboBoxStyle.DropDownList;
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void monhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet19.MonHoc' table. You can move, or remove it, as needed.
            //this.monHocTableAdapter.Fill(this.qL_SinhVienDataSet19.MonHoc);
            txt_mamh.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            bang_monhoc.ReadOnly = true;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                txt_mamh.ReadOnly = true;
                btn_them.Enabled = false;
                DataGridViewRow row = bang_monhoc.Rows[e.RowIndex];
                txt_mamh.Text = row.Cells[0].Value.ToString();
                txt_tenmh.Text = row.Cells[1].Value.ToString();
                txt_sotiet.Text = row.Cells[2].Value.ToString();
                cb_magv.Text = row.Cells[3].Value.ToString();
            }
        }
        void loaddata()
        {
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM MonHoc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_monhoc.DataSource = table;
            command.CommandText = "SELECT ma_giaovien FROM GiaoVien";
            SqlDataReader reader = command.ExecuteReader();
            cb_magv.Items.Clear();
            while (reader.Read())
            {
                cb_magv.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }
        void reset()
        {
            txt_mamh.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_mamh.ReadOnly = false;
            btn_them.Enabled = true;
            txt_mamh.Text = "";
            txt_tenmh.Text = "";
            txt_sotiet.Text = "";
            cb_magv.SelectedItem = null;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_mamh.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã môn học!", "Thông báo");
                txt_mamh.Focus();
                isValid = false;
                return;
            }
            if (txt_mamh.Text.Length > 10)
            {
                MessageBox.Show("Mã môn học nhỏ hơn 10 kí tự", "Thông báo");
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM MonHoc WHERE ma_monhoc = @ma_monhoc";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@ma_monhoc", txt_mamh.Text);

                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Mã môn học đã tồn tại!", "Thông báo");
                    txt_mamh.Focus();
                    isValid = false;
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_tenmh.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên môn học!", "Thông báo");
                txt_tenmh.Focus();
                isValid = false;
                return;
            }
            if (txt_tenmh.Text.Length > 50)
            {
                MessageBox.Show("Tên môn học nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(txt_sotiet.Text))
            {
                MessageBox.Show("Bạn chưa nhập số tiết!", "Thông báo");
                txt_sotiet.Focus();
                isValid = false;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_sotiet.Text, @"^\d+$"))
            {
                MessageBox.Show("Số tiết chỉ được nhập số!", "Thông báo");
                txt_sotiet.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cb_magv.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã giáo viên!", "Thông báo");
                cb_magv.Focus();
                isValid = false;
                return;
            }
            if (isValid)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO MonHoc VALUES('" + txt_mamh.Text + "', N'" + txt_tenmh.Text + "',N'"+txt_sotiet.Text+"',N'"+cb_magv.Text+"')";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show(" Thêm thành công", "Thông báo");
                reset();
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_tenmh.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên môn học!", "Thông báo");
                txt_tenmh.Focus();
                isValid = false;
                return;
            }
            if (txt_tenmh.Text.Length > 50)
            {
                MessageBox.Show("Tên môn học nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(txt_sotiet.Text))
            {
                MessageBox.Show("Bạn chưa nhập số tiết!");
                txt_sotiet.Focus();
                isValid = false;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_sotiet.Text, @"^\d+$"))
            {
                MessageBox.Show("Số tiết chỉ được nhập số!", "Thông báo");
                txt_sotiet.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cb_magv.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã giáo viên!", "Thông báo");
                cb_magv.Focus();
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
                command.CommandText = "UPDATE MonHoc set ten_monhoc = N'" + txt_tenmh.Text + "' ,sotiet_monhoc = N'" + txt_sotiet.Text + "' ,ma_giaovien = N'" + cb_magv.Text + "' where ma_monhoc ='" + txt_mamh.Text + "'";
                command.ExecuteNonQuery();                
                    loaddata();
                    MessageBox.Show(" Sửa thành công", "Thông báo");
                    reset();
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mamh.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã cần xóa!", "Thông báo");
                txt_mamh.Focus();
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM MonHoc where ma_monhoc ='" + txt_mamh.Text + "'";
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Không có mã cần xóa...!!!", "Thông báo");
                        return;
                    }
                    loaddata();
                    reset();
                    MessageBox.Show("Xóa thành công", "Thông báo");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đề nghị bạn xóa MÃ MÔN HỌC trong QUẢN LÝ ĐIỂM trước khi xóa trong QUẢN LÝ MÔN HỌC", "Thông báo");
                }

            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            tk_monhoc tkmh = new tk_monhoc();
            this.Hide();
            tkmh.ShowDialog();
            this.Show();
        }
        private void btn_clean_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
    }   
}
