using System;
using System.Windows.Forms;
namespace Bai_tap_lon
{
    public partial class ThoiGianCho : Form
    {
        int i, n;
        public ThoiGianCho()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            this.lbThongBao.Text = "Vui lòng chờ  " + i.ToString() + " giây để đăng nhập lại";
            if (i < 0)
            {
                this.timer1.Enabled = false;
                this.Close();
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void lbThongBao_Click(object sender, EventArgs e)
        {
        }
        private void ThoiGianCho_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            i = 15;
            n = i;
        }
    }
}
