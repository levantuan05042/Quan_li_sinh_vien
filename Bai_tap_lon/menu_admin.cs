using Bai_tap_lon.Quan_li;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Bai_tap_lon
{
    public partial class menu_admin : Form
    {

        public menu_admin()
        {
            InitializeComponent();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            dangnhap dn = new dangnhap();
            this.Hide();
            dn.ShowDialog();
            this.Show();
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                doimk_admin formDoiMatKhau = new doimk_admin();
                formDoiMatKhau.SetTaiKhoan(dangnhap.currentUser);
                this.Hide();
                formDoiMatKhau.ShowDialog();
                this.Show();
            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
        private void quảnLýTàiKhoảnAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoanChung qlad = new TaiKhoanChung();
            this.Hide();
            qlad.ShowDialog();
            this.Show();
        }
        private void quảnLýTàiKhoảnSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ql_user qlus = new ql_user();
            this.Hide();
            qlus.ShowDialog();
            this.Show();
        }
        private void quanLýTàiKhoảnTrưởngKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khoiphuc_mknd qltk = new khoiphuc_mknd();
            this.Hide();
            qltk.ShowDialog();
            this.Show();
        }
        private void chínhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiem_chinhsach tk_cs = new timkiem_chinhsach();
            this.Hide();
            tk_cs.ShowDialog();
            this.Show();
        }
        private void khoaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            khoa k = new khoa();
            this.Hide();
            k.ShowDialog();
            this.Show();
        }
        private void lớpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Lop l= new Lop();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }
        private void chínhSáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            chinhsach cs = new chinhsach();
            this.Hide();
            cs.ShowDialog();
            this.Show();
        }
        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_khoa ttk = new tt_khoa();
            this.Hide();
            ttk.ShowDialog();
            this.Show();
        }
        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_giaovien ttgv = new tt_giaovien();
            this.Hide();
            ttgv.ShowDialog();
            this.Show();
        }
        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_lop ttl = new tt_lop();
            this.Hide();
            ttl.ShowDialog();
            this.Show();
        }
        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tt_sinhvien ttk = new tt_sinhvien();
            this.Hide();
            ttk.ShowDialog();
            this.Show();
        }
        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tt;
            tt = "Phần mền : QUẢN LÝ SINH VIÊN \n";
            tt += "\n";
            tt += "Version: 1.1\n";
            tt += "\n";
            tt += "Học phần thực tập:\n";
            tt += "Lập trình hướng cơ sở dữ liệu\n";
            tt += "\n\n";
            tt += "Copy right @ năm 2023\n";
            tt += "Disigner by: Lê Văn Tuấn\n";
            tt += "Email: letuan@gmail.com\n\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                String tt;
                tt = "Phần mền : QUẢN LÝ SINH VIÊN \n";
                tt += "\n";
                tt += "Version: 1.1\n";
                tt += "\n";
                tt += "Học phần thực tập:\n";
                tt += "Lập trình hướng cơ sở dữ liệu\n";
                tt += "\n\n";
                tt += "Copy right @ năm 2023\n";
                tt += "Disigner by: Lê Văn Tuấn\n";
                tt += "Email: letuan@gmail.com\n\n";
                MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cậpNhậtPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất !", "Thông báo");

        }

        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tk_khoa tkk = new tk_khoa();
            this.Hide();
            tkk.ShowDialog();
            this.Show();
        }
        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tk_giaovien tkgv = new tk_giaovien();
            this.Hide();
            tkgv.ShowDialog();
            this.Show();
        }
        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\mspaint.exe");
        }
        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\cmd.exe");
        }
        private void notpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\notepad.exe");
        }
        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }
        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\"C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.EXE\"");
        }
        private void khóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripthongtin.Visible = false;
            toolStripkhoa.Visible = false;
            toolStrimo.Visible = true;
            mởToolStripMenuItem.Visible = true;
            menucon_dangnhap.Visible = true;
            menucon_qltkad.Visible = false;
            menucon_dx.Visible = false;
            menucon_khoa.Visible = false;
            menuchinh_thongtin.Visible = false;
            menuchinh_timkiem.Visible = false;
            menuchinh_quanly.Visible = false;
            menuchinh_hienthi.Visible = false;
            menuchinh_tienich.Visible = false;
            cậpNhậtPhầnMềmToolStripMenuItem.Visible = false;
            menuchinh_diem.Visible = false;
            menucon_qltktk.Visible = false;
            menucon_dx.Visible = false;
            toolStripword.Visible = false;
            toolStripmaytinh.Visible = false;
            toolStripnote.Visible = false;
            toolStripcmd.Visible = false;
            toolStrippaint.Visible = false;
            menucon_dmk.Visible = false;
            thongtin.Visible = false;
            hienthi.Visible = false;
        }
        private void quảnLýTàiKhoảnGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ql_giaovien ttmh = new ql_giaovien();
            this.Hide();
            ttmh.ShowDialog();
            this.Show();
        }
        public void UpdateLabel()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
            string username = dangnhap.LoggedInUser;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT fullname FROM TaiKhoan WHERE username = @username", connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hienthi.Text = "Xin chào, " + reader["fullname"].ToString();
                        }
                    }
                }
            }
        }

        private void menu_admin_Load(object sender, EventArgs e)
        {
            toolStrimo.Visible= false;
            mởToolStripMenuItem.Visible= false;
            UpdateLabel();
            toolStripStatusLabel1.Text = "Hà Nội, ngày " + DateTime.Now.ToString("dd/MM/yyyy") +
                " - Bây giờ là " + DateTime.Now.ToString("hh: mm: ss tt");
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();

            if (dangnhap.userRole == "User")
            {
                menuchinh_quanly.Visible = false;
                menuchinh_diem.Visible = false;
                menucon_dangnhap.Visible = false;
                menucon_qltkad.Visible = false;
                menucon_qltktk.Visible = false;

            }          
            if (dangnhap.userRole == "TruongKhoa")
            {
                menuchinh_diem.Visible = false;
                menucon_dangnhap.Visible = false;
                menucon_qltkad.Visible = false;
                menucon_qltktk.Visible = false;

            }
            if (dangnhap.userRole == "GiaoVien")
            {
                menuchinh_quanly.Visible = false;
                menucon_dangnhap.Visible = false;
                menucon_qltkad.Visible = false;
                menucon_qltktk.Visible = false;
            }

        }
        private void menucon_mh_Click(object sender, EventArgs e)
        {
            tt_monhoc ttmh = new tt_monhoc();
            this.Hide();
            ttmh.ShowDialog();
            this.Show();
        }
        private void menucon_cs_Click(object sender, EventArgs e)
        {
            tt_chinhsach ttcs = new tt_chinhsach();
            this.Hide();
            ttcs.ShowDialog();
            this.Show();
        }
        private void menucon_diem_Click(object sender, EventArgs e)
        {
            tt_diem ttd = new tt_diem();
            this.Hide();
            ttd.ShowDialog();
            this.Show();
        }
        private string currentLanguage = "Tiếng Việt";
        private void tiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                currentLanguage = "English";
                UpdateLanguage();
            }
        }
            private void UpdateLanguage()
            {
                if (currentLanguage == "English")
                {
                    nemuchinh_hethong.Text = "System";
                    menuchinh_thongtin.Text = "Information";
                    menuchinh_timkiem.Text = "Search";
                    menuchinh_diem.Text = "Scores";
                    menuchinh_quanly.Text = "Management";
                    menuchinh_hienthi.Text = "Display";
                    menuchinh_tienich.Text = "Utilities";
                    menucon_khoa.Text = "Lock";
                    menucon_khoaa.Text = "Department";
                    menucon_gv.Text = "Teacher";
                    menucon_lop.Text = "Class";
                    menucon_sv.Text = "Student";
                    menucon_mh.Text = "Subject";
                    menucon_cs.Text = "Policy";
                    menucon_diem.Text = "Scores";
                    menucon_tkk.Text = "Department";
                    menucon_tkgv.Text = "Teacher";
                    menucon_tkl.Text = "Class";
                    menucon_tksv.Text = "Student";
                    menucon_monhoc.Text = "Subject";
                    menucon_chinhsach.Text = "Policy";
                    menuchinh_hotro.Text = "View Mode";
                    cậpNhậtPhầnMềmToolStripMenuItem.Text = "Update Software";
                    menucon_qlk.Text = "Department";
                    menucon_qlgv.Text = "Teacher";
                    menucon_qll.Text = "Class";
                    menucon_qlsv.Text = "Student";
                    menucon_qlmh.Text = "Subject";
                    menucon_qlcs.Text = "Policy";
                    menucon_qld.Text = "Scores";
                    tiếngViệtToolStripMenuItem.Text = "Vietnamese";
                    trongSuốtToolStripMenuItem.Text = "Transparency";
                    menucon_htnn.Text = "Language";
                    menuchinh_hotro.Text = "Support";
                    menucon_qltkad.Text = "Account management";
                    menucon_dx.Text = "Logout";
                    menucon_qltktk.Text = "Recover account";
                    liênHệToolStripMenuItem.Text = "Contact";
                    thôngTinToolStripMenuItem1.Text = "Information";
                    paintToolStripMenuItem.Text = "Paint";
                    cmdToolStripMenuItem.Text = "Command Prompt";
                    notpadToolStripMenuItem.Text = "Notepad";
                    máyTínhToolStripMenuItem.Text = "Calculator";
                    microsoftWordToolStripMenuItem.Text = "Microsoft Word";
                    menucon_dangnhap.Text = "Log In";
                    toolStripMenuItem2.Text = "Opacity 100%";
                    toolStripMenuItem3.Text = "Opacity 50%";
                    mặĐịnhToolStripMenuItem.Text = "Default Opacity";
                    menuchinh_thoat.Text = "Exit";
                    menucon_dmk.Text = "Change Password";
                    tiếngAnhToolStripMenuItem.Text = "English";            }           
        }

        private void tiếngViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentLanguage = "Tiếng Việt";
            UpdateLanguage();
        }
    
        private void menuchinh_timkiem_Click(object sender, EventArgs e)
        {
        }
        private void menucon_tkl_Click(object sender, EventArgs e)
        {
            tk_lop tkl = new tk_lop();
            this.Hide();
            tkl.ShowDialog();
            this.Show();
        }
        private void menucon_qlgv_Click(object sender, EventArgs e)
        {
            GiaoVien qlgv = new GiaoVien();
            this.Hide();
            qlgv.ShowDialog();
            this.Show();
        }
        private void menucon_qlmh_Click(object sender, EventArgs e)
        {
            monhoc qlmh = new monhoc();
            this.Hide();
            qlmh.ShowDialog();
            this.Show();
        }
        private void menucon_monhoc_Click(object sender, EventArgs e)
        {
            tk_monhoc tkmh = new tk_monhoc();
            this.Hide();
            tkmh.ShowDialog();
            this.Show();
        }
        private void menucon_qlsv_Click(object sender, EventArgs e)
        {
            sinhvien qlsv = new sinhvien();
            this.Hide();
            qlsv.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void tiếngViệtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                nemuchinh_hethong.Text = "Hệ thống";
                menuchinh_thongtin.Text = "Thông tin";
                menuchinh_timkiem.Text = "Tìm kiếm";
                menuchinh_diem.Text = "Điểm";
                menuchinh_quanly.Text = "Quản lý";
                menuchinh_hienthi.Text = "Hiển thị";
                menuchinh_tienich.Text = "Tiện ích";
                menucon_khoa.Text = "Khóa";
                menucon_khoaa.Text = "Khoa";
                menucon_gv.Text = "Giáo viên";
                menucon_lop.Text = "Lớp";
                menucon_sv.Text = "Sinh viên";
                menucon_mh.Text = "Môn học";
                menucon_cs.Text = "Chính sách";
                menucon_diem.Text = "Điểm";
                menucon_tkk.Text = "Khoa";
                menucon_tkgv.Text = "Giáo viên";
                menucon_tkl.Text = "Lớp";
                menucon_tksv.Text = "Sinh viên";
                menucon_monhoc.Text = "Môn học";
                menucon_chinhsach.Text = "Chính sách";
                menuchinh_hotro.Text = "Chế Độ Xem";
                cậpNhậtPhầnMềmToolStripMenuItem.Text = "Cập Nhật Phần Mềm";
                menucon_qlk.Text = "Khoa";
                menucon_qlgv.Text = "Giáo viên";
                menucon_qll.Text = "Lớp";
                menucon_qlsv.Text = "Sinh viên";
                menucon_qlmh.Text = "Môn học";
                menucon_qlcs.Text = "Chính sách";
                menucon_qld.Text = "Điểm";
                tiếngViệtToolStripMenuItem.Text = "Tiếng Việt";
                trongSuốtToolStripMenuItem.Text = "Trong suốt";
                menucon_htnn.Text = "Ngôn ngữ";
                menuchinh_hotro.Text = "Hỗ trợ";
                menucon_qltkad.Text = "Quản lý tài khoản";
                menucon_dx.Text = "Đăng xuất";
                menucon_qltktk.Text = "Khôi phục tài khoản";
                liênHệToolStripMenuItem.Text = "Liên hệ";
                thôngTinToolStripMenuItem1.Text = "Thông tin";
                paintToolStripMenuItem.Text = "Paint";
                cmdToolStripMenuItem.Text = "Command Prompt";
                notpadToolStripMenuItem.Text = "Notepad";
                máyTínhToolStripMenuItem.Text = "Máy tính";
                microsoftWordToolStripMenuItem.Text = "Microsoft word";
                menucon_dangnhap.Text = "Đăng nhập";
                toolStripMenuItem2.Text = "Độ mờ 100%";
                toolStripMenuItem3.Text = "Độ mờ 50%";
                mặĐịnhToolStripMenuItem.Text = "Độ mờ mặc định";
                menuchinh_thoat.Text = "Thoát";
                menucon_dmk.Text = "Đổi mật khẩu";
                tiếngAnhToolStripMenuItem.Text = "Tiếng Anh";
        }      
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hà Nội, ngày " + DateTime.Now.ToString("dd/MM/yyyy") +
               " - Bây giờ là " + DateTime.Now.ToString("hh: mm: ss tt");
        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
        }
        private void mặĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
        private void menucon_tksv_Click(object sender, EventArgs e)
        {
            tk_sv tksv = new tk_sv();
            this.Hide();
            tksv.ShowDialog();
            this.Show();
        }
        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinnguoidung tt = new thongtinnguoidung();
            tt.SetTaiKhoan(dangnhap.currentUser);
            this.Hide();
            tt.ShowDialog();
            this.Show();
        }
        private void menucon_qld_Click(object sender, EventArgs e)
        {
            diem d = new diem();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }
        private void menuchinh_diem_Click(object sender, EventArgs e)
        {
            Diem_gv dgv = new Diem_gv();
            this.Hide();
            dgv.ShowDialog();
            this.Show();
        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoanChung dgv = new TaiKhoanChung();
            this.Hide();
            dgv.ShowDialog();
            this.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thongtinnguoidung tt = new thongtinnguoidung();
            tt.SetTaiKhoan(dangnhap.currentUser);
            this.Hide();
            tt.ShowDialog();
            this.Show();
        }
        private void nemuchinh_hethong_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripthongtin.Visible = false;
            menucon_dmk.Visible = false;
            thongtin.Visible = false;
            hienthi.Visible = false;
            menucon_dangnhap.Visible = true;
            menucon_qltkad.Visible = false;
            menucon_dx.Visible = false;
            menucon_khoa.Visible = false;
            menuchinh_thongtin.Visible = false;
            menuchinh_timkiem.Visible = false;
            menuchinh_quanly.Visible = false;
            menuchinh_hienthi.Visible = false;
            menuchinh_tienich.Visible = false;
            cậpNhậtPhầnMềmToolStripMenuItem.Visible = false;
            menuchinh_diem.Visible = false;
            menucon_qltktk.Visible = false;
            menucon_dx.Visible = false;
            toolStripkhoa.Visible = false;
            toolStrimo.Visible = true;
            mởToolStripMenuItem.Visible = true;
            toolStripword.Visible = false;
            toolStripmaytinh.Visible = false;
            toolStripnote.Visible = false;
            toolStripcmd.Visible = false;
            toolStrippaint.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            thongtinnguoidung tt = new thongtinnguoidung();
            tt.SetTaiKhoan(dangnhap.currentUser);
            this.Hide();
            tt.ShowDialog();
            this.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không...?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\"C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.EXE\"");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\notepad.exe");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\cmd.exe");
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\mspaint.exe");
        }

        private void mởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            mo t = new mo();
            t.SetTaiKhoan(dangnhap.currentUser);
            this.Hide();
            t.ShowDialog();
            this.Show();
            /*toolStripthongtin.Visible = true;
            menucon_dmk.Visible = true;
            thongtin.Visible = true;
            hienthi.Visible = true;
            menucon_dangnhap.Visible = true;
            menucon_qltkad.Visible = true;
            menucon_dx.Visible = true;
            menucon_khoa.Visible = true;
            menuchinh_thongtin.Visible = true;
            menuchinh_timkiem.Visible = true;
            menuchinh_quanly.Visible = true;
            menuchinh_hienthi.Visible = true;
            menuchinh_tienich.Visible = true;
            cậpNhậtPhầnMềmToolStripMenuItem.Visible = true;
            menuchinh_diem.Visible = true;
            menucon_qltktk.Visible = true;
            menucon_dx.Visible = true;
            toolStripkhoa.Visible = true;
            mởToolStripMenuItem.Visible = false;
            toolStrimo.Visible = false;
            toolStripword.Visible = true;
            toolStripmaytinh.Visible = true;
            toolStripnote.Visible = true;
            toolStripcmd.Visible = true;
            toolStrippaint.Visible = true;*/
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            /* toolStripthongtin.Visible = true;
             menucon_dmk.Visible = true;
             thongtin.Visible = true;
             hienthi.Visible = true;
             menucon_dangnhap.Visible = true;
             menucon_qltkad.Visible = true;
             menucon_dx.Visible = true;
             menucon_khoa.Visible = true;
             menuchinh_thongtin.Visible = true;
             menuchinh_timkiem.Visible = true;
             menuchinh_quanly.Visible = true;
             menuchinh_hienthi.Visible = true;
             menuchinh_tienich.Visible = true;
             cậpNhậtPhầnMềmToolStripMenuItem.Visible = true;
             menuchinh_diem.Visible = true;
             menucon_qltktk.Visible = true;
             menucon_dx.Visible = true;
             toolStripkhoa.Visible = true;
             toolStrimo.Visible = false;
             mởToolStripMenuItem.Visible = false;
             toolStripword.Visible = true;
             toolStripmaytinh.Visible = true;
             toolStripnote.Visible = true;
             toolStripcmd.Visible = true;
             toolStrippaint.Visible = true;*/
            this.Close();
            mo t = new mo();
            t.SetTaiKhoan(dangnhap.currentUser);
            this.Hide();
            t.ShowDialog();
            this.Show();
        }
    }
}
