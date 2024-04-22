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
    public partial class tt_giaovien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tt_giaovien()
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
            command.CommandText = "SELECT * FROM GiaoVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_giaovien.DataSource = table;
        }

        private void tt_giaovien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet9.GiaoVien' table. You can move, or remove it, as needed.
            //this.giaoVienTableAdapter.Fill(this.qL_SinhVienDataSet9.GiaoVien);
            txt_magv.ReadOnly = true;
            txt_tengv.ReadOnly = true;
            txt_gt.ReadOnly = true;
            txt_ns.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            txt_dc.ReadOnly = true;
            bang_giaovien.ReadOnly= true;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bang_giaovien.Rows[e.RowIndex];
                txt_magv.Text = Convert.ToString(row.Cells[0].Value);
                txt_tengv.Text = Convert.ToString(row.Cells[1].Value);
                txt_gt.Text = Convert.ToString(row.Cells[2].Value);
                DateTime dateValue = Convert.ToDateTime(row.Cells[3].Value);
                txt_ns.Text = dateValue.ToString("MM/dd/yyyy");
                txt_sdt.Text = Convert.ToString(row.Cells[4].Value);
                txt_dc.Text = Convert.ToString(row.Cells[5].Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tk_giaovien tksv = new tk_giaovien();
            this.Hide();
            tksv.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baocao_gv bcsv = new baocao_gv();
            this.Hide();
            bcsv.ShowDialog();
            this.Show();
        }
    }
}
