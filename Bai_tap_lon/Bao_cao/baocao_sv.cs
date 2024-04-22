using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_lon
{
    public partial class baocao_sv : Form
    {
        public baocao_sv()
        {
            InitializeComponent();
        }

        private void baocao_sv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet22.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qL_SinhVienDataSet22.SinhVien);
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.ChinhSach' table. You can move, or remove it, as needed.
            //this.chinhSachTableAdapter.Fill(this.qL_SinhVienDataSet.ChinhSach);
            
            this.reportViewer1.RefreshReport();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
