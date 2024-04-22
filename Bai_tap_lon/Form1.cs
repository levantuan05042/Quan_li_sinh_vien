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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();          
        }
        private void lb_tentruong_Click(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (lb_tentruong.Left <= this.Width)
            {
                lb_tentruong.Left += 10;
            }
            else
                lb_tentruong.Left = -lb_tentruong.Width;*/

            if (lb_tentruong.Left >= -lb_tentruong.Width)
            {
                lb_tentruong.Left -= 13;
            }
            else
                lb_tentruong.Left = this.Width;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Phần mềm: QUẢN LÍ SINH VIÊN";
            tt += "\n";
            tt += "VERSION: 1.1\n";
            tt += "Học phần thực tập:\n\n";
            tt += "Lập trình cơ sở dữ liệu \n";
            tt += "\n\n";
            tt += "Copy righet @ năm 2020\n";
            tt += "Desgner by: Tuấn\n";
            tt += "Email:letuan@gmail.com\n\n";
            MessageBox.Show((tt), "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Phần mềm: QUẢN LÍ SINH VIÊN";
            tt += "\n";
            tt += "VERSION: 1.1\n";
            tt += "Học phần thực tập:\n\n";
            tt += "Lập trình cơ sở dữ liệu \n";
            tt += "\n\n";
            tt += "Copy righet @ năm 2020\n";
            tt += "Desgner by: Tuấn\n";
            tt += "Email:letuan@gmail.com\n\n";
            MessageBox.Show((tt), "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dangnhap dn=new dangnhap();
            this.Hide();
            dn.ShowDialog();
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dangki dk=new dangki();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
