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
    public partial class baocao_diem : Form
    {
        public baocao_diem()
        {
            InitializeComponent();
        }

        private void baocao_diem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet26.Diem' table. You can move, or remove it, as needed.
            this.diemTableAdapter.Fill(this.qL_SinhVienDataSet26.Diem);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
