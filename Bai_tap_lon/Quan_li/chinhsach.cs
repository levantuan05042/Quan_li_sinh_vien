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
    public partial class chinhsach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public chinhsach()
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
            command.CommandText = "SELECT * FROM ChinhSach";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_chinhsach.DataSource = table;
        }

        private void chinhsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.ChinhSach' table. You can move, or remove it, as needed.
            //this.chinhSachTableAdapter.Fill(this.qL_SinhVienDataSet.ChinhSach);
            txt_machinhsach.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            bang_chinhsach.ReadOnly = true;
        }
        void reset()
        {
            txt_machinhsach.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_machinhsach.ReadOnly = false;
            btn_them.Enabled = true;
            txt_machinhsach.Text = "";
            txt_tenchinhsach.Text = "";
            txt_chedo.Text = "";
        }
        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txt_tenchinhsach.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên chính sách!", "Thông báo");
                txt_tenchinhsach.Focus();
                isValid = false;
                return;
            }
            if (txt_tenchinhsach.Text.Length > 50)
            {
                MessageBox.Show("Tên chính sách nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(txt_chedo.Text))
            {
                MessageBox.Show("Bạn chưa nhập chế độ!", "Thông báo");
                txt_chedo.Focus();
                isValid = false;
                return;
            }
            if (txt_chedo.Text.Length > 50)
            {
                MessageBox.Show("Chế độ nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE chinhsach set ten_chinhsach = N'" + txt_tenchinhsach.Text + "', chedo_chinhsach = N'" + txt_chedo.Text + "' where ma_chinhsach ='" + txt_machinhsach.Text + "'";
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Sửa không thành công");
                    return;
                }

                loaddata();
                MessageBox.Show("Sửa thành công");
                reset();
            }
        }
        private void btn_them_Click_1(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txt_machinhsach.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã chính sách!", "Thông báo");
                txt_machinhsach.Focus();
                isValid = false;
                return;
            }
            if (txt_machinhsach.Text.Length > 10)
            {
                MessageBox.Show("Mã chính sách nhỏ hơn 10 kí tự", "Thông báo");
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM ChinhSach WHERE ma_chinhsach = @ma_chinhsach";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@ma_chinhsach", txt_machinhsach.Text);

                int existingCount = (int)checkCommand.ExecuteScalar();
                if (existingCount > 0)
                {
                    MessageBox.Show("Mã chính sách đã tồn tại!", "Thông báo");
                    txt_machinhsach.Focus();
                    isValid = false;
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_tenchinhsach.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên chính sách!", "Thông báo");
                txt_tenchinhsach.Focus();
                isValid = false;
                return;
            }
            if (txt_tenchinhsach.Text.Length > 50)
            {
                MessageBox.Show("Tên chính sách nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(txt_chedo.Text))
            {
                MessageBox.Show("Bạn chưa nhập chế độ!", "Thông báo");
                txt_chedo.Focus();
                isValid = false;
                return;
            }
            if (txt_chedo.Text.Length > 50)
            {
                MessageBox.Show("Chế độ nhỏ hơn 50 kí tự", "Thông báo");
                return;
            }
            if (isValid)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO ChinhSach VALUES('" + txt_machinhsach.Text + "', N'" + txt_tenchinhsach.Text + "', N'" + txt_chedo.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show(" Thêm thành công", "Thông báo");
                reset();
            }
        }
        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_machinhsach.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã cần xóa!", "Thông báo");
                txt_machinhsach.Focus();
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM ChinhSach where ma_chinhsach ='" + txt_machinhsach.Text + "'";
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
                    MessageBox.Show("Đề nghị bạn xóa MÃ CHÍNH SÁCH trong QUẢN LÝ SINH VIÊN trước khi xóa trong QUẢN LÝ CHÍNH SÁCH", "Thông báo");
                }
            }

        }
        private void btn_clean_Click_1(object sender, EventArgs e)
        {          
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            timkiem_chinhsach tk=new timkiem_chinhsach();
            this.Hide();
            tk.ShowDialog();
            this.Show();
        }
        private void bang_chinhsach_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_them.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                txt_machinhsach.ReadOnly = true;
                btn_them.Enabled = false;
                DataGridViewRow row = bang_chinhsach.Rows[e.RowIndex];
                txt_machinhsach.Text = Convert.ToString(row.Cells[0].Value);
                txt_tenchinhsach.Text = Convert.ToString(row.Cells[1].Value);
                txt_chedo.Text = Convert.ToString(row.Cells[2].Value);
            }
        }
        private void btn_clean_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void txt_tenchinhsach_TextChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void txt_machinhsach_TextChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void txt_chedo_TextChanged(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void chinhSachBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }     
    }
}
