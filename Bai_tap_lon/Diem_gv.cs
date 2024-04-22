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
using System.IO;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace Bai_tap_lon
{
    public partial class Diem_gv : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Diem_gv()
        {
            InitializeComponent();
            cb_masv.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_mamh.DropDownStyle = ComboBoxStyle.DropDownList;
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();

            // Đọc trạng thái của các nút từ tệp và thiết lập lại trạng thái của chúng
            if (System.IO.File.Exists(@"buttonState.txt"))
            {
                string buttonState = System.IO.File.ReadAllText(@"buttonState.txt");
                bool isEnabled = Boolean.Parse(buttonState);
                btn_them.Enabled = isEnabled;
                btn_xoa.Enabled = isEnabled;
                btn_sua.Enabled = isEnabled;
                txt_diem.Enabled = isEnabled;
                txt_id.Enabled = isEnabled;
                cb_mamh.Enabled = isEnabled;
                cb_masv.Enabled = isEnabled;
                bang_diem.Enabled = isEnabled;
                btn_chuyendiem.Visible = isEnabled;
            }
        }
        void loaddata()
        {
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Diem";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_diem.DataSource = table;
            command.CommandText = "SELECT ma_sinhvien FROM SinhVien";
            SqlDataReader reader1 = command.ExecuteReader();
            cb_masv.Items.Clear();
            while (reader1.Read())
            {
                cb_masv.Items.Add(reader1.GetString(0));
            }
            reader1.Close();
            command.CommandText = "SELECT ma_monhoc FROM MonHoc";
            SqlDataReader reader2 = command.ExecuteReader();
            cb_mamh.Items.Clear();
            while (reader2.Read())
            {
                cb_mamh.Items.Add(reader2.GetString(0));
            }
            reader2.Close();
        }

        private void Diem_gv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet27.Diem' table. You can move, or remove it, as needed.
            this.diemTableAdapter1.Fill(this.qL_SinhVienDataSet27.Diem);
            txt_id.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            bang_diem.ReadOnly = true;
            if (dangnhap.userRole == "Admin")
            {
                btn_mo.Visible = true;
            }
            else if (dangnhap.userRole == "GiaoVien")
            {
                btn_mo.Visible = false;
            }

        }

        private void bang_diem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                txt_id.ReadOnly = true;
                btn_them.Enabled = false;
                DataGridViewRow row = bang_diem.Rows[e.RowIndex];
                txt_id.Text = Convert.ToString(row.Cells[0].Value);
                cb_masv.Text = Convert.ToString(row.Cells[1].Value);
                cb_mamh.Text = Convert.ToString(row.Cells[2].Value);
                txt_diem.Text = Convert.ToString(row.Cells[3].Value);
            }
        }

        private void btn_cd_Click(object sender, EventArgs e)
        {
            {
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
                txt_diem.Enabled = true;
                txt_id.Enabled = true;
                cb_masv.Enabled = true;
                cb_mamh.Enabled = true;
                bang_diem.Enabled = true;
                btn_chuyendiem.Visible = true;
                System.IO.File.WriteAllText(@"buttonState.txt", "true");
            }                         
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void reset()
        {
            txt_id.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_them.Enabled = true;
            txt_id.ReadOnly = false;
            txt_id.Text = "";
            txt_diem.Text = "";
            cb_mamh.SelectedItem = null; ;
            cb_masv.SelectedItem = null; ;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã ID!", "Thông báo");
                txt_id.Focus();
                return;
            }
            if (txt_id.Text.Length > 10)
            {
                MessageBox.Show("Mã ID nhỏ hơn 10 kí tự", "Thông báo");
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM Diem WHERE id = @id";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@id", txt_id.Text);
                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Mã ID đã tồn tại!");
                    txt_id.Focus();
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_diem.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm!", "Thông báo");
                txt_diem.Focus();
                return;
            }
            float diem;
            bool isFloat = float.TryParse(txt_diem.Text, out diem);
            if (!isFloat)
            {
                MessageBox.Show("Điểm phải là một số!", "Thông báo");
                txt_diem.Focus();
                return;
            }

            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Thông báo");
                txt_diem.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cb_masv.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã sinh viên!", "Thông báo");
                cb_masv.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cb_mamh.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã môn học!", "Thông báo");
                cb_mamh.Focus();
                return;
            }
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO Diem(id, diem, ma_sinhvien, ma_monhoc) VALUES(@id, @diem, @ma_sinhvien, @ma_monhoc)";
            command.Parameters.AddWithValue("@id", txt_id.Text);
            command.Parameters.AddWithValue("@diem", txt_diem.Text);
            command.Parameters.AddWithValue("@ma_sinhvien", cb_masv.Text);
            command.Parameters.AddWithValue("@ma_monhoc", cb_mamh.Text);
            command.ExecuteNonQuery();
            reset();
            loaddata();
            MessageBox.Show("Thêm thành công", "Thông báo");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_diem.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm!", "Thông báo");
                txt_diem.Focus();
                return;
            }
            float diem;
            bool isFloat = float.TryParse(txt_diem.Text, out diem);
            if (!isFloat)
            {
                MessageBox.Show("Điểm phải là một số!", "Thông báo");
                txt_diem.Focus();
                return;
            }

            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Thông báo");
                txt_diem.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cb_masv.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã sinh viên!", "Thông báo");
                cb_masv.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cb_mamh.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã môn học!", "Thông báo");
                cb_mamh.Focus();
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE Diem SET diem = @diem, ma_sinhvien = @ma_sinhvien, ma_monhoc = @ma_monhoc WHERE id = @id";
                command.Parameters.AddWithValue("@id", txt_id.Text);
                command.Parameters.AddWithValue("@diem", txt_diem.Text);
                command.Parameters.AddWithValue("@ma_sinhvien", cb_masv.Text);
                command.Parameters.AddWithValue("@ma_monhoc", cb_mamh.Text);
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Sửa thành công");
                reset();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã cần xóa!", "Thông báo");
                txt_id.Focus();
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Diem where id ='" + txt_id.Text + "'";
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
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_mo_Click(object sender, EventArgs e)
        {
            {
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
                txt_diem.Enabled = false;
                txt_id.Enabled = false;
                cb_masv.Enabled = false;
                cb_mamh.Enabled = false;
                bang_diem.Enabled = false;
                btn_chuyendiem.Visible = false;
                System.IO.File.WriteAllText(@"buttonState.txt", "false");
            }
            {
                //
               
            }
            
        }
    }
}
