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
    public partial class sinhvien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public sinhvien()
        {
            InitializeComponent();
            cb_macs.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_mal.DropDownStyle = ComboBoxStyle.DropDownList;
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }
        void loaddata()
        {
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM SinhVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_sinhvien.DataSource = table;
            command.CommandText = "SELECT ma_chinhsach FROM ChinhSach";
            SqlDataReader reader1 = command.ExecuteReader();
            cb_macs.Items.Clear();
            while (reader1.Read())
            {
                cb_macs.Items.Add(reader1.GetString(0));
            }
            reader1.Close();
            command.CommandText = "SELECT ma_lop FROM Lop";
            SqlDataReader reader2 = command.ExecuteReader();
            cb_mal.Items.Clear();
            while (reader2.Read())
            {
                cb_mal.Items.Add(reader2.GetString(0));
            }
            reader2.Close();
        }
        private void sinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet22.SinhVien' table. You can move, or remove it, as needed.
            //this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet22.SinhVien);
            txt_masv.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            rad_nam.Checked = true;
            bang_sinhvien.ReadOnly = true;
        }
        void reset()
        {
            txt_masv.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_masv.ReadOnly = false;
            btn_them.Enabled = true;
            txt_masv.Text = "";
            txt_tensv.Text = "";
            datengaysinh.Text = "";
            txt_sodt.Text = "";
            txt_dc.Text = "";
            cb_macs.SelectedItem = null; ;
            cb_mal.SelectedItem = null; ;
            rad_nam.Checked = true;
        }
        private void bang_sinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                txt_masv.ReadOnly = true;
                btn_them.Enabled = false;
                DataGridViewRow row = bang_sinhvien.Rows[e.RowIndex];
                txt_masv.Text = row.Cells[0].Value.ToString();
                txt_tensv.Text = row.Cells[1].Value.ToString();
                string gioitinh = row.Cells[2].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rad_nam.Checked = true;
                }
                else if (gioitinh == "Nữ")
                {
                    rad_nu.Checked = true;
                }
                datengaysinh.Text = row.Cells[3].Value.ToString();
                txt_dc.Text = row.Cells[5].Value.ToString();
                txt_sodt.Text = row.Cells[4].Value.ToString();
                cb_macs.Text = row.Cells[6].Value.ToString();
                cb_mal.Text = row.Cells[7].Value.ToString();
            }
        }
        private void btn_clean_Click(object sender, EventArgs e)
        {           
            reset();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_masv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên!", "Thông báo");
                txt_masv.Focus();
                isValid = false;
                return;
            }
            if (txt_masv.Text.Length > 10)
            {
                MessageBox.Show("Mã sinh viên nhỏ hơn 10 kí tự", "Thông báo");
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM SinhVien WHERE ma_sinhvien = @ma_sinhvien";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@ma_sinhvien", txt_masv.Text);

                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo");
                    txt_masv.Focus();
                    isValid = false;
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_tensv.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên!", "Thông báo");
                txt_tensv.Focus();
                isValid = false;
                return;
            }
            if (txt_tensv.Text.Length > 50)
            {
                MessageBox.Show("Tên sinh viên nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(datengaysinh.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh sinh viên!", "Thông báo");
                datengaysinh.Focus();
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txt_sodt.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại sinh viên!", "Thông báo");
                txt_sodt.Focus();
                isValid = false;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_sodt.Text, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!", "Thông báo");
                txt_sodt.Focus();
                return;
            }
            if ((txt_sodt.Text.StartsWith("0") && txt_sodt.Text.Length == 10) || (txt_sodt.Text.StartsWith("84") && txt_sodt.Text.Length == 11))
            {
            }
            else
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo");
                isValid = false;
                return;
            }

            if (string.IsNullOrEmpty(txt_dc.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ sinh viên!", "Thông báo");
                txt_dc.Focus();
                isValid = false;
                return;
            }
            if (txt_dc.Text.Length > 50)
            {
                MessageBox.Show("Địa chỉ sinh viên nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(cb_macs.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã chính sách!", "Thông báo");
                cb_macs.Focus();
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(cb_mal.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã lớp!", "Thông báo");
                cb_mal.Focus();
                isValid = false;
                return;
            }
            if (isValid)
            {
                string gioitinh = rad_nam.Checked ? "Nam" : "Nữ";
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO SinhVien VALUES('" + txt_masv.Text + "', N'" + txt_tensv.Text + "',N'" + gioitinh + "', N'" + datengaysinh.Text + "', N'" + txt_sodt.Text + "', N'" + txt_dc.Text + "',N'" + cb_macs.Text + "',N'" + cb_mal.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show(" Thêm thành công", "Thông báo");
                reset();
            }

        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_tensv.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên!", "Thông báo");
                txt_tensv.Focus();
                isValid = false;
                return;
            }
            if (txt_tensv.Text.Length > 50)
            {
                MessageBox.Show("Tên sinh viên nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(datengaysinh.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh sinh viên!", "Thông báo");
                datengaysinh.Focus();
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txt_sodt.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại sinh viên!", "Thông báo");
                txt_sodt.Focus();
                isValid = false;
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_sodt.Text, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!", "Thông báo");
                txt_sodt.Focus();
                return;
            }
            if ((txt_sodt.Text.StartsWith("0") && txt_sodt.Text.Length == 10) || (txt_sodt.Text.StartsWith("84") && txt_sodt.Text.Length == 11))
            {
            }
            else
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo");
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txt_dc.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ sinh viên!", "Thông báo");
                txt_dc.Focus();
                isValid = false;
                return;
            }
            if (txt_dc.Text.Length > 50)
            {
                MessageBox.Show("Địa chỉ sinh viên nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(cb_macs.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã chính sách!", "Thông báo");
                cb_macs.Focus();
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(cb_mal.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã lớp!", "Thông báo");
                cb_mal.Focus();
                isValid = false;
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
                command.CommandText = "UPDATE SinhVien set ten_sinhvien = N'" + txt_tensv.Text + "' ,gioitinh_sinhvien = N'" + gioitinh + "' ,ngaysinh_sinhvien = N'" + datengaysinh.Text + "' , sdt_sinhvien=N'"+txt_sodt.Text+"', diachi_sinhvien=N'"+txt_dc.Text+"' , ma_chinhsach = N'" +cb_macs.Text+"' ,ma_lop=N'"+cb_mal.Text+"' where ma_sinhvien ='" + txt_masv.Text + "'";
                command.ExecuteNonQuery();               
                    loaddata();
                    MessageBox.Show(" Sửa thành công", "Thông báo");
                    reset();
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_masv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã cần xóa!", "Thông báo");
                txt_masv.Focus();
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM SinhVien where ma_sinhvien ='" + txt_masv.Text + "'";
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
                    MessageBox.Show("Đề nghị bạn xóa MÃ SINH VIÊN trong QUẢN LÝ ĐIỂM trước khi xóa trong QUẢN LÝ SINH VIÊN", "Thông báo");
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
            tk_sv tksv = new tk_sv();
            this.Hide();
            tksv.ShowDialog();
            this.Show();
        }
        private void datengaysinh_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
