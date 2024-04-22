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
    public partial class GiaoVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        bool isValid = true;
        public GiaoVien()
        {
            InitializeComponent();
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet17.GiaoVien' table. You can move, or remove it, as needed.
            //this.giaoVienTableAdapter.Fill(this.qL_SinhVienDataSet17.GiaoVien);
            txt_magv.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            bang_gv.ReadOnly = true;
            rad_nam.Checked= true;
        }
        void loaddata()
        {           
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM GiaoVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_gv.DataSource = table;
        }
        void reset()
        {
            txt_magv.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_magv.ReadOnly =false;
            btn_them.Enabled = true;
            txt_magv.Text = "";
            txt_tengv.Text = "";
            txt_dcgv.Text = "";
            txt_sdtgv.Text = "";
            rad_nam.Checked = true;
            date_nsgv.Text = "";
            date_nsgv.Value = new DateTime(1999, 1, 1);
        }
        void nhap()
        {

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string checkQuery = "SELECT COUNT(*) FROM GiaoVien WHERE ma_giaovien = @ma_giaovien";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@ma_giaovien", txt_magv.Text);

                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Mã giáo viên đã tồn tại!", "Thông báo");
                    txt_magv.Focus();
                    isValid = false;
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_magv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã giáo viên!", "Thông báo");
                txt_magv.Focus();
                isValid = false;
                return;
            }
            if (txt_magv.Text.Length > 10)
            {
                MessageBox.Show("Mã giáo viên ít hơn 10 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(txt_tengv.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên giáo viên!", "Thông báo");
                txt_tengv.Focus();
                isValid = false;
                return;
            }
            if (txt_tengv.Text.Length > 50)
            {
                MessageBox.Show("Tên giáo viên ít hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(date_nsgv.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh giáo viên!", "Thông báo");
                date_nsgv.Focus();
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txt_sdtgv.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại giáo viên!", "Thông báo");
                txt_sdtgv.Focus();
                isValid = false;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_sdtgv.Text, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!", "Thông báo");
                txt_sdtgv.Focus();
                return;
            }
            if ((txt_sdtgv.Text.StartsWith("0") && txt_sdtgv.Text.Length == 10) || (txt_sdtgv.Text.StartsWith("84") && txt_sdtgv.Text.Length == 11))
            { 
            }
            else
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo");
                isValid = false;
                return;
            }

            if (string.IsNullOrEmpty(txt_dcgv.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ giáo viên!", "Thông báo");
                txt_dcgv.Focus();
                isValid = false;
                return;
            }
            if (txt_dcgv.Text.Length > 50)
            {
                MessageBox.Show("Địa chỉ giáo viên ít hơn 50 kí tự", "Thông báo");
                return;
            }
            if (isValid)
            {
                string gioitinh = rad_nam.Checked ? "Nam" : "Nữ";
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO GiaoVien VALUES('" + txt_magv.Text + "', N'" + txt_tengv.Text + "',N'"+gioitinh+ "', N'" + date_nsgv.Text+ "', N'" + txt_sdtgv.Text + "', N'" + txt_dcgv.Text +"')";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show(" Thêm thành công", "Thông báo");
                reset();
            }
        }
        private void bang_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                txt_magv.ReadOnly = true;
                btn_them.Enabled = false;
                DataGridViewRow row = bang_gv.Rows[e.RowIndex];
                txt_magv.Text = row.Cells[0].Value.ToString();
                txt_tengv.Text = row.Cells[1].Value.ToString();
                string gioitinh = row.Cells[2].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rad_nam.Checked = true;
                }
                else if (gioitinh == "Nữ")
                {
                    rad_nu.Checked = true;
                }
                date_nsgv.Text = row.Cells[3].Value.ToString();
                txt_sdtgv.Text= row.Cells[4].Value.ToString();
                txt_dcgv.Text= row.Cells[5].Value.ToString();
            }
        }
        private void btn_clean_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_tengv.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên giáo viên!", "Thông báo");
                txt_tengv.Focus();
                isValid = false;
                return;
            }
            if (txt_tengv.Text.Length > 50)
            {
                MessageBox.Show("Tên giáo viên ít hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(date_nsgv.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh giáo viên!", "Thông báo");
                date_nsgv.Focus();
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txt_sdtgv.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại giáo viên!", "Thông báo");
                txt_sdtgv.Focus();
                isValid = false;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_sdtgv.Text, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!");
                txt_sdtgv.Focus();
                return;
            }
            if ((txt_sdtgv.Text.StartsWith("0") && txt_sdtgv.Text.Length == 10) || (txt_sdtgv.Text.StartsWith("84") && txt_sdtgv.Text.Length == 11))
            {
            }
            else
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo");
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txt_dcgv.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ giáo viên!", "Thông báo");
                txt_dcgv.Focus();
                isValid = false;
                return;
            }
            if (txt_dcgv.Text.Length > 50)
            {
                MessageBox.Show("Địa chỉ giáo viên ít hơn 50 kí tự", "Thông báo");
                return;
            }
            if (isValid)
            {
                string gioitinh = rad_nam.Checked ? "Nam" : "Nữ";
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không...?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE GiaoVien set ten_giaovien = N'" + txt_tengv.Text + "' ,gioitinh_giaovien = N'" + gioitinh + "' ,ngaysinh_giaovien = N'" + date_nsgv.Text + "' ,sdt_giaovien = N'" + txt_sdtgv.Text + "' ,diachi_giaovien = N'" + txt_dcgv.Text + "' where ma_giaovien ='" + txt_magv.Text + "'";
                command.ExecuteNonQuery();               
                    loaddata();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    reset();
                }
            }
        }
        private void cb_gtgv_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_magv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã cần xóa!", "Thông báo");
                txt_magv.Focus();
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM GiaoVien where ma_giaovien ='" + txt_magv.Text + "'";
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
                    MessageBox.Show("Đề nghị bạn xóa MÃ GIÁO VIÊN trong QUẢN LÝ MÔN HỌC trước khi xóa trong QUẢN LÝ GIÁO VIÊN", "Thông báo");
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            tk_giaovien tkgv = new tk_giaovien();
            this.Hide();
            tkgv.ShowDialog();
            this.Show();
        }
        private void txt_sdtgv_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
