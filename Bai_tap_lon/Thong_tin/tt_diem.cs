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
    public partial class tt_diem : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public tt_diem()
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
            command.CommandText = "SELECT * FROM Diem";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            bang_diem.DataSource = table;
        }
        private void tt_diem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet14.Diem' table. You can move, or remove it, as needed.
            //this.diemTableAdapter.Fill(this.qL_SinhVienDataSet14.Diem);
            txt_id.ReadOnly = true;
            txt_masv.ReadOnly = true;
            txt_mamh.ReadOnly = true;
            txt_diem.ReadOnly = true;
            bang_diem.ReadOnly = true;
        }

        private void bang_diem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {               
                DataGridViewRow row = bang_diem.Rows[e.RowIndex];
                txt_id.Text = Convert.ToString(row.Cells[0].Value);
                txt_masv.Text = Convert.ToString(row.Cells[1].Value);
                txt_mamh.Text = Convert.ToString(row.Cells[2].Value);
                txt_diem.Text = Convert.ToString(row.Cells[3].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baocao_diem bcd = new baocao_diem();
            this.Hide();
            bcd.ShowDialog();
            this.Show();
        }
    }
}
