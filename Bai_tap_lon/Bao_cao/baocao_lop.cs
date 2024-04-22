using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_lon.Bao_cao
{
    public partial class baocao_lop : Form
    {
        public baocao_lop()
        {
            InitializeComponent();
        }

        private void baocao_lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet4.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qL_SinhVienDataSet4.Lop);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
