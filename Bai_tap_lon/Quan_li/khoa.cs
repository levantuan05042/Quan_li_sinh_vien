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
    public partial class khoa : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public khoa()
        {
            InitializeComponent();
            connection = new SqlConnection(sql);
            connection.Open();
            loaddata();
        }
        void loaddata()
        {
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Khoa";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_khoa.DataSource = table;
        }
        private void khoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet2.Khoa' table. You can move, or remove it, as needed.
            //this.khoaTableAdapter.Fill(this.qL_SinhVienDataSet2.Khoa);
            txt_makhoa.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            bang_khoa.ReadOnly = true;
        }
        void reset()
        {
            txt_makhoa.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_makhoa.ReadOnly = false;
            btn_them.Enabled = true;
            txt_makhoa.Text = "";
            txt_tenkhoa.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txt_makhoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khoa!", "Thông báo");
                txt_makhoa.Focus();
                isValid = false;
                return;
            }
            if (txt_makhoa.Text.Length > 10)
            {
                MessageBox.Show("Mã khoa nhỏ hơn 10 kí tự", "Thông báo");
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM Khoa WHERE ma_khoa = @ma_khoa";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@ma_khoa", txt_makhoa.Text);

                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Mã khoa đã tồn tại!", "Thông báo");
                    txt_makhoa.Focus();
                    isValid = false;
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_tenkhoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khoa!", "Thông báo");
                txt_tenkhoa.Focus();
                isValid = false;
                return;
            }
            if (txt_tenkhoa.Text.Length > 50)
            {
                MessageBox.Show("Tên khoa nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (isValid)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Khoa VALUES('" + txt_makhoa.Text + "', N'" + txt_tenkhoa.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show(" Thêm thành công", "Thông báo");
                reset();
            }
        }
        private void bang_khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                txt_makhoa.ReadOnly = true;
                btn_them.Enabled = false;
                DataGridViewRow row = bang_khoa.Rows[e.RowIndex];
                txt_makhoa.Text = row.Cells[0].Value.ToString();
                txt_tenkhoa.Text = row.Cells[1].Value.ToString();
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_tenkhoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khoa!", "Thông báo");
                txt_tenkhoa.Focus();
                isValid = false;
                return;
            }
            if (txt_tenkhoa.Text.Length > 50)
            {
                MessageBox.Show("Tên khoa nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (isValid)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không...?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE khoa set ten_khoa = N'" + txt_tenkhoa.Text + "' where ma_khoa ='" + txt_makhoa.Text + "'";
                command.ExecuteNonQuery();                
                    loaddata();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    reset();
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_makhoa.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã cần xóa!", "Thông báo");
                    txt_makhoa.Focus();
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Khoa where ma_khoa ='" + txt_makhoa.Text + "'";
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
                        MessageBox.Show("Đề nghị bạn xóa MÃ KHOA trong QUẢN LÝ LỚP trước khi xóa trong QUẢN LÝ KHOA", "Thông báo");
                    }
                }
            }
        }
        private void btn_clean_Click(object sender, EventArgs e)
        { 
        }
        private void button5_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        private void btn_clean_Click_1(object sender, EventArgs e)
        {
            reset();
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            tk_khoa tkk = new tk_khoa();
            this.Hide();
            tkk.ShowDialog();
            this.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void txt_makhoa_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_tenkhoa_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void khoaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
