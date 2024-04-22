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
    public partial class tt_lop : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tt_lop()
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
            command.CommandText = "SELECT * FROM Lop";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_lop.DataSource = table;
        }
        private void tt_lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet10.Lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter.Fill(this.qL_SinhVienDataSet10.Lop);
            txt_malop.ReadOnly = true;
            txt_tenlop.ReadOnly = true;
            txt_makhoa.ReadOnly = true;
            bang_lop.ReadOnly = true;
        }

        private void bang_lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bang_lop.Rows[e.RowIndex];
                txt_malop.Text = Convert.ToString(row.Cells[0].Value);
                txt_tenlop.Text = Convert.ToString(row.Cells[1].Value);
                txt_makhoa.Text = Convert.ToString(row.Cells[2].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tk_lop tksv = new tk_lop();
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
            baocao_lop bcl = new baocao_lop();
            this.Hide();
            bcl.ShowDialog();
            this.Show();
        }
    }
}
