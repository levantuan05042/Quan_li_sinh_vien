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
    public partial class tt_monhoc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tt_monhoc()
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
        private void tt_monhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet12.MonHoc' table. You can move, or remove it, as needed.
            //this.monHocTableAdapter.Fill(this.qL_SinhVienDataSet12.MonHoc);
            txt_mamh.ReadOnly = true;
            txt_tenmh.ReadOnly = true;
            txt_sotiet.ReadOnly = true;
            txt_magiaovien.ReadOnly = true;
            bang_monhoc.ReadOnly = true;
        }

        private void bang_monhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bang_monhoc.Rows[e.RowIndex];
                txt_mamh.Text = Convert.ToString(row.Cells[0].Value);
                txt_tenmh.Text = Convert.ToString(row.Cells[1].Value);
                txt_sotiet.Text = Convert.ToString(row.Cells[2].Value);
                txt_magiaovien.Text = Convert.ToString(row.Cells[3].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tk_monhoc tksv = new tk_monhoc();
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
            baocao_monhoc bcmh = new baocao_monhoc();
            this.Hide();
            bcmh.ShowDialog();
            this.Show();
        }
    }
}
