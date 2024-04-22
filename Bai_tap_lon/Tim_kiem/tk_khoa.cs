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
    public partial class tk_khoa : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tk_khoa()
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
        private void tk_khoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet15.Khoa' table. You can move, or remove it, as needed.
            //this.khoaTableAdapter.Fill(this.qL_SinhVienDataSet15.Khoa);
            txt_tk.Focus();
            rad_ma.Checked = true;
        }
        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            command = new SqlCommand();
            command.Connection = connection;
            if (rad_ma.Checked)
            {
                command.CommandText = "SELECT * FROM Khoa WHERE ma_khoa like N'%" + txt_tk.Text + "%'";
            }
            else if (rad_ten.Checked)
            {
                command.CommandText = "SELECT * FROM Khoa WHERE ten_khoa like N'%" + txt_tk.Text + "%'";
            }
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                bang_khoa.DataSource = table;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txt_tk.Text))
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!", "Thông báo");
                    return;
                }
                command = new SqlCommand();
                command.Connection = connection;
                if (rad_ma.Checked)
                {
                    command.CommandText = "SELECT * FROM Khoa WHERE ma_khoa = @searchValue";
                }
                else if (rad_ten.Checked)
                {
                    command.CommandText = "SELECT * FROM Khoa WHERE ten_khoa = @searchValue";
                }
                command.Parameters.AddWithValue("@searchValue", txt_tk.Text);
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tk.Text = string.Empty;
                }
                else
                {
                    bang_khoa.DataSource = table;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        private void rad_ten_CheckedChanged(object sender, EventArgs e)
        {
            txt_tk_TextChanged(sender, e);
        }
        private void rad_ma_CheckedChanged(object sender, EventArgs e)
        {
            txt_tk_TextChanged(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
            txt_tk.Text = "";
                txt_tk.Focus();
        }
    }
}
