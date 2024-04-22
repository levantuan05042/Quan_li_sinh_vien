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
    public partial class timkiem_chinhsach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public timkiem_chinhsach()
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
                command.CommandText = "SELECT * FROM ChinhSach WHERE ma_chinhsach = @searchValue";
            }
            else if (rad_ten.Checked)
            {
                command.CommandText = "SELECT * FROM ChinhSach WHERE ten_chinhsach = @searchValue";
            }
            else if (rad_cd.Checked)
            {
                command.CommandText = "SELECT * FROM ChinhSach WHERE chedo_chinhsach = @searchValue";
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
                bang_chinhsach.DataSource = table;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_tk_TextChanged_1(object sender, EventArgs e)
        {
            command = new SqlCommand();
            command.Connection = connection;
            if (rad_ma.Checked)
            {
                command.CommandText = "SELECT * FROM ChinhSach WHERE ma_chinhsach like N'%" + txt_tk.Text + "%'";
            }
            else if (rad_ten.Checked)
            {
                command.CommandText = "SELECT * FROM ChinhSach WHERE ten_chinhsach like N'%" + txt_tk.Text + "%'";
            }
            else if (rad_cd.Checked)
            {
                command.CommandText = "SELECT * FROM ChinhSach WHERE chedo_chinhsach like N'%" + txt_tk.Text + "%'";
            }
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                bang_chinhsach.DataSource = table;
            }
        }
        private void timkiem_chinhsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet1.ChinhSach' table. You can move, or remove it, as needed.
            //this.chinhSachTableAdapter.Fill(this.qL_SinhVienDataSet1.ChinhSach);
            txt_tk.Focus();
            rad_ma.Checked = true;
        }       
        private void rad_ten_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rad_ma_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void bang_chinhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void chinhSachBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void rad_cd_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void rad_ten_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_tk_TextChanged_1(sender, e);
        }
        private void rad_cd_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_tk_TextChanged_1(sender, e);
        }
        private void rad_ma_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_tk_TextChanged_1(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
            txt_tk.Text = "";
            txt_tk.Focus();
        }
    }
}
