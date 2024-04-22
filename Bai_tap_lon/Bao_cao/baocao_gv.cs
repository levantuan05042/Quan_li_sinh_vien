using Microsoft.Reporting.WinForms;
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
    public partial class baocao_gv : Form
    {
        public baocao_gv()
        {
            InitializeComponent();
        }

        private void baocao_gv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet17.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.qL_SinhVienDataSet17.GiaoVien);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet17.GiaoVien' table. You can move, or remove it, as needed.
            //this.giaoVienTableAdapter.Fill(this.qL_SinhVienDataSet17.GiaoVien);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet22.SinhVien' table. You can move, or remove it, as needed.
            //this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet22.SinhVien);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet17.GiaoVien' table. You can move, or remove it, as needed.
            //this.giaoVienTableAdapter.Fill(this.qL_SinhVienDataSet17.GiaoVien);
            this.reportViewer1.RefreshReport();
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
