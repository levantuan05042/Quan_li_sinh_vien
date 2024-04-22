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
    public partial class tk_sv : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string searchField;
        public tk_sv()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True");
            connection.Open();
            loaddata();
            comboBox1.SelectedItem = "Mã sinh viên";
        }
        void loaddata()
        {
            command = new SqlCommand("SELECT * FROM SinhVien", connection);
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_sinhvien.DataSource = table;
        }
            private void tk_sv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet25.SinhVien' table. You can move, or remove it, as needed.
            //this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet25.SinhVien);
            txt_tk.Focus();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tk_TextChanged(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void dieukien()
        {        
            if (comboBox1.SelectedItem.ToString() == "Mã sinh viên")
            {
                searchField = "ma_sinhvien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Tên sinh viên")
            {
                searchField = "ten_sinhvien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Giới tính")
            {
                searchField = "gioitinh_sinhvien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Ngày sinh")
            {
                searchField = "ngaysinh_sinhvien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Số điện thoại")
            {
                searchField = "sdt_sinhvien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Địa chỉ")
            {
                searchField = "diachi_sinhvien";
            }
            else if (comboBox1.SelectedItem.ToString() == "Mã chính sách")
            {
                searchField = "ma_chinhsach";
            }
            else if (comboBox1.SelectedItem.ToString() == "Mã lớp")
            {
                searchField = "ma_lop";
            }
            else
            {
                return;
            }
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txt_tk.Text;
            if (string.IsNullOrEmpty(txt_tk.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm kiếm!", "Thông báo");
                txt_tk.Focus();
                return;
            }
            dieukien();
            command = new SqlCommand($"SELECT * FROM SinhVien WHERE {searchField} = @searchValue", connection);
            command.Parameters.AddWithValue("@searchValue", searchValue);
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp");
                txt_tk.Text = "";
            }
            else
            {
                bang_sinhvien.DataSource = table;
            }
        }
        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            dieukien();
            string searchValue = txt_tk.Text;
            command = new SqlCommand($"SELECT * FROM SinhVien WHERE {searchField} LIKE @searchValue", connection);
            command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_sinhvien.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
            txt_tk.Text = "";
            txt_tk.Focus();
        }
    }
}
