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
    public partial class tk_monhoc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tk_monhoc()
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
            command.CommandText = "SELECT * FROM MonHoc";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_monhoc.DataSource = table;
        }
        private void tk_monhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet21.MonHoc' table. You can move, or remove it, as needed.
            //this.monHocTableAdapter.Fill(this.qL_SinhVienDataSet21.MonHoc);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet20.SinhVien' table. You can move, or remove it, as needed.
            //this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet20.SinhVien);
            txt_tk.Focus();
            rad_ma.Checked = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            command = new SqlCommand();
            command.Connection = connection;
            if (rad_ma.Checked)
            {
                command.CommandText = "SELECT * FROM MonHoc WHERE ma_monhoc like N'%" + txt_tk.Text + "%'";
            }
            else if (rad_ten.Checked)
            {
                command.CommandText = "SELECT * FROM MonHoc WHERE ten_monhoc like N'%" + txt_tk.Text + "%'";
            }
            else if (rad_st.Checked)
            {
                command.CommandText = "SELECT * FROM MonHoc WHERE sotiet_monhoc like N'%" + txt_tk.Text + "%'";
            }
            else if (rad_magv.Checked)
            {
                command.CommandText = "SELECT * FROM MonHoc WHERE ma_giaovien like N'%" + txt_tk.Text + "%'";
            }
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    bang_monhoc.DataSource = table;
                }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
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
                command.CommandText = "SELECT * FROM MonHoc WHERE ma_monhoc = @searchValue";
            }
            else if (rad_ten.Checked)
            {
                command.CommandText = "SELECT * FROM MonHoc WHERE ten_monhoc = @searchValue";
            }
            else if (rad_st.Checked)
            {
                int sotiet;
                bool isNumeric = int.TryParse(txt_tk.Text, out sotiet);
                if (!isNumeric)
                {
                    MessageBox.Show("Vui lòng chỉ nhập số cho số tiết!", "Thông báo");
                    loaddata();
                    txt_tk.Text = "";
                    txt_tk.Focus();
                    return;
                }
                command.CommandText = "SELECT * FROM MonHoc WHERE sotiet_monhoc = @searchValue";
            }
            else if (rad_magv.Checked)
            {
                command.CommandText = "SELECT * FROM MonHoc WHERE ma_giaovien = @searchValue";
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
                    bang_monhoc.DataSource = table;
                }
            
        }

        private void rad_ma_CheckedChanged(object sender, EventArgs e)
        {
            txt_tk_TextChanged(sender, e);
        }

        private void rad_ten_CheckedChanged(object sender, EventArgs e)
        {
            txt_tk_TextChanged(sender, e);
        }

        private void rad_st_CheckedChanged(object sender, EventArgs e)
        {
            txt_tk_TextChanged(sender, e);
        }

        private void rad_magv_CheckedChanged(object sender, EventArgs e)
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
