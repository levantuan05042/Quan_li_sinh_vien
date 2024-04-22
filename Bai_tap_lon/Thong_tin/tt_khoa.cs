using Bai_tap_lon.Bao_cao;
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
    public partial class tt_khoa : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tt_khoa()
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
        private void tt_khoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet8.Khoa' table. You can move, or remove it, as needed.
            //this.khoaTableAdapter.Fill(this.qL_SinhVienDataSet8.Khoa);
            txt_makhoa.ReadOnly = true;
            txt_tenkhoa.ReadOnly = true;
            bang_khoa.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
        }
        private void bang_khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bang_khoa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bang_khoa.Rows[e.RowIndex];
                txt_makhoa.Text = Convert.ToString(row.Cells[0].Value);
                txt_tenkhoa.Text = Convert.ToString(row.Cells[1].Value);               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tk_khoa tksv = new tk_khoa();
            this.Hide();
            tksv.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baocao_khoa bck = new baocao_khoa();
            this.Hide();
            bck.ShowDialog();
            this.Show();
        }
    }
}
