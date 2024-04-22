using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_lon
{
    public partial class tk_giaovien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string searchField;
        public tk_giaovien()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True");
            connection.Open();
            loaddata();
            comboBox1.SelectedItem = "Mã giáo viên";
        }

        private void tk_giaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet18.GiaoVien' table. You can move, or remove it, as needed.
            //this.giaoVienTableAdapter.Fill(this.qL_SinhVienDataSet18.GiaoVien);
            txt_tk.Focus();
        }
        void loaddata()
        {
            command = new SqlCommand("SELECT * FROM GiaoVien", connection);
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_gv.DataSource = table;
        }
        void dieukien()
        {
            if (comboBox1.SelectedItem.ToString() == "Mã giáo viên")
            {
                searchField = "ma_giaovien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Tên giáo viên")
            {
                searchField = "ten_giaovien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Giới tính")
            {
                searchField = "gioitinh_giaovien";
            }
            else if(comboBox1.SelectedItem.ToString() == "Ngày sinh")
            {
                searchField = "ngaysinh_giaovien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Số điện thoại")
            {
                searchField = "sdt_giaovien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Địa chỉ")
            {
                searchField = "diachi_giaovien";
            }          
            else
            {
                return;
            }
        }
        private void txt_tk_TextChanged(object sender, EventArgs e)
        {          
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {            
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void txt_tk_TextChanged_1(object sender, EventArgs e)
        {
            dieukien();
            string searchValue = txt_tk.Text;
            command = new SqlCommand($"SELECT * FROM GiaoVien WHERE {searchField} LIKE @searchValue", connection);
            command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_gv.DataSource = table;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_timkiem_Click_1(object sender, EventArgs e)
        {
                string searchValue = txt_tk.Text;
                if (string.IsNullOrEmpty(txt_tk.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin cần tìm kiếm!", "Thông báo");
                    txt_tk.Focus();
                    return;
                }
                dieukien();
                command = new SqlCommand($"SELECT * FROM GiaoVien WHERE {searchField} = @searchValue", connection);
                command.Parameters.AddWithValue("@searchValue", searchValue);
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp","Thông báo");
                    txt_tk.Text = "";
                }
                else
                {
                    bang_gv.DataSource = table;
                }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tk_TextChanged_1(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
            txt_tk.Focus();
            txt_tk.Text = "";
        }

        private void bang_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
