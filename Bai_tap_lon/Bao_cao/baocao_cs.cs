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
    public partial class baocao_cs : Form
    {
        public baocao_cs()
        {
            InitializeComponent();
        }

        private void baocao_cs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_SinhVienDataSet.ChinhSach' table. You can move, or remove it, as needed.
            this.chinhSachTableAdapter.Fill(this.qL_SinhVienDataSet.ChinhSach);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
