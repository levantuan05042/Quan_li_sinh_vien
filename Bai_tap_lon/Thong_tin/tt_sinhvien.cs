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
    public partial class tt_sinhvien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tt_sinhvien()
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
            command.CommandText = "SELECT * FROM SinhVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_sv.DataSource = table;
        }
            private void tt_sinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet11.SinhVien' table. You can move, or remove it, as needed.
            //this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet11.SinhVien);
            txt_masv.ReadOnly = true;
            txt_tensv.ReadOnly = true;
            txt_malop.ReadOnly = true;
            txt_macs.ReadOnly = true;
            txt_gt.ReadOnly = true;
            txt_dc.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            txt_ns.ReadOnly = true;
            bang_sv.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tk_sv tksv = new tk_sv();
            this.Hide();
            tksv.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bang_sv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = bang_sv.Rows[e.RowIndex];
                txt_masv.Text = Convert.ToString(row.Cells[0].Value);
                txt_tensv.Text = Convert.ToString(row.Cells[1].Value);
                txt_gt.Text = Convert.ToString(row.Cells[2].Value);
                DateTime dateValue = Convert.ToDateTime(row.Cells[3].Value);
                txt_ns.Text = dateValue.ToString("MM/dd/yyyy");
                txt_sdt.Text = Convert.ToString(row.Cells[4].Value);
                txt_dc.Text = Convert.ToString(row.Cells[5].Value);
                txt_macs.Text = Convert.ToString(row.Cells[6].Value);
                txt_malop.Text = Convert.ToString(row.Cells[7].Value);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            baocao_sv bcsv = new baocao_sv();
            this.Hide();
            bcsv.ShowDialog();
            this.Show();
        }
    }
}
