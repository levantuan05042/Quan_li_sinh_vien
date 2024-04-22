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
    public partial class Lop : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Lop()
        {
            InitializeComponent();
            cb_makhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }
        private void Lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet4.Lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter1.Fill(this.qL_SinhVienDataSet4.Lop);
            txt_malop.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            bang_lop.ReadOnly = true;
        }
        void loaddata()
        {
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Lop";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_lop.DataSource = table;
            command.CommandText = "SELECT ma_khoa FROM Khoa";
            SqlDataReader reader = command.ExecuteReader();
            cb_makhoa.Items.Clear();
            while (reader.Read())
            {
                cb_makhoa.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }
        void reset()
        {
            txt_malop.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_malop.ReadOnly = false;
            btn_them.Enabled = true;
            txt_malop.Text = "";
            txt_tenlop.Text = "";
            cb_makhoa.SelectedItem = null; ;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void cb_makhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_malop.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp!", "Thông báo");
                txt_malop.Focus();
                isValid = false;
                return;
            }
            if (txt_malop.Text.Length > 10)
            {
                MessageBox.Show("Mã lớp nhỏ hơn 10 kí tự", "Thông báo");
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM Lop WHERE ma_lop = @ma_lop";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@ma_lop", txt_malop.Text);
                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Mã lớp đã tồn tại!", "Thông báo");
                    txt_malop.Focus();
                    isValid = false;
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_tenlop.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp!", "Thông báo");
                txt_tenlop.Focus();
                isValid = false;
                return;
            }
            if (txt_tenlop.Text.Length > 50)
            {
                MessageBox.Show("Tên lớp nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(cb_makhoa.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã khoa !","Thông báo");
                cb_makhoa.Focus();
                isValid = false;
                return;
            }
            if (isValid)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Lop VALUES('" + txt_malop.Text + "', N'" + txt_tenlop.Text + "', N'" + cb_makhoa.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show(" Thêm thành công", "Thông báo");
                reset();
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_tenlop.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp!", "Thông báo");
                txt_tenlop.Focus();
                isValid = false;
                return;
            }
            if (txt_tenlop.Text.Length > 50)
            {
                MessageBox.Show("Tên lớp nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(cb_makhoa.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã khoa !", "Thông báo");
                cb_makhoa.Focus();
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
                command.CommandText = "UPDATE lop set ten_lop = N'" + txt_tenlop.Text + "', ma_khoa = N'" + cb_makhoa.Text + "' where ma_lop ='" + txt_malop.Text + "'";
                command.ExecuteNonQuery();                
                    loaddata();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    reset();
                }
            }
        }
        private void bang_lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                txt_malop.ReadOnly = true;
                btn_them.Enabled = false;
                DataGridViewRow row = bang_lop.Rows[e.RowIndex];
                txt_malop.Text = row.Cells[0].Value.ToString();
                txt_tenlop.Text = row.Cells[1].Value.ToString();
                cb_makhoa.Text = row.Cells[2].Value.ToString();
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_malop.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã cần xóa!", "Thông báo");
                    txt_malop.Focus();
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Lop where ma_lop ='" + txt_malop.Text + "'";
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
                        MessageBox.Show("Đề nghị xóa MÃ LỚP trong QUẢN LÝ SINH VIÊN trước khi xóa trong QUẢN LÝ LỚP", "Thông báo");
                    }
                }

            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        private void btn_clean_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            tk_lop tkl = new tk_lop();
            this.Hide();
            tkl.ShowDialog();
            this.Show();
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
