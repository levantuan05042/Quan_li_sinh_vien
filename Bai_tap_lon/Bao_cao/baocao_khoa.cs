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
    public partial class baocao_khoa : Form
    {
        public baocao_khoa()
        {
            InitializeComponent();
        }

        private void baocao_khoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet2.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qL_SinhVienDataSet2.Khoa);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
