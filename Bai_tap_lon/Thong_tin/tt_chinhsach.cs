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
    public partial class tt_chinhsach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tt_chinhsach()
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

        private void tt_chinhsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet13.ChinhSach' table. You can move, or remove it, as needed.
            //this.chinhSachTableAdapter.Fill(this.qL_SinhVienDataSet13.ChinhSach);
            txt_machinhsach.ReadOnly = true;
            txt_tenchinhsach.ReadOnly = true;
            txt_chedo.ReadOnly = true;
            bang_chinhsach.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timkiem_chinhsach tk = new timkiem_chinhsach();
            this.Hide();
            tk.ShowDialog();
            this.Show();
        }
        private void bang_chinhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bang_chinhsach.Rows[e.RowIndex];
                txt_machinhsach.Text = Convert.ToString(row.Cells[0].Value);
                txt_tenchinhsach.Text = Convert.ToString(row.Cells[1].Value);
                txt_chedo.Text = Convert.ToString(row.Cells[2].Value);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            baocao_cs bcsv = new baocao_cs();
            this.Hide();
            bcsv.ShowDialog();
            this.Show();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
