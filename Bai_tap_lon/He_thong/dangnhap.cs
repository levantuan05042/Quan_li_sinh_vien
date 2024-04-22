using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_tap_lon
{
    public partial class dangnhap : Form
    {
        public static string LoggedInUser { get; set; }
        public static string currentUser = "";
        public static string currentPassword = "";
        private DateTime lockoutTime;
        private int dangnhapsai = 0;
        public void KetNoiCSDL()
        {
        }
        public dangnhap()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 15000; // 15 giây
            timer1.Tick += timer1_Tick;;
        }      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void dangnhap_Load(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_ok.Enabled = true;
            timer1.Stop();
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        public static string userRole = "";
        private void btn_ok_Click(object sender, EventArgs e)
        {
            LoggedInUser = textBox1.Text;
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "" && password == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập và mật khẩu", "Thông báo");
                textBox1.Focus();
                return;
            }
            else if (username == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo");
                textBox1.Focus();
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo");
                textBox2.Focus();
                return;
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo");
                textBox2.Focus();
                return;
            }
            else if (password.Length > 50)
            {
                MessageBox.Show("Mật khẩu phải nhỏ hơn 50 ký tự!", "Thông báo");
                textBox2.Focus();
                return;
            }
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_SinhVien;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQueryUser = "SELECT * FROM TaiKhoan WHERE username = @username AND password = @password";

                SqlCommand commandUser = new SqlCommand(sqlQueryUser, connection);

                commandUser.Parameters.AddWithValue("@username", username);
                commandUser.Parameters.AddWithValue("@password", password);
                using (SqlDataReader readerUser = commandUser.ExecuteReader())
                {
                    if (dangnhapsai >= 5)
                    {
                        if (DateTime.Now < lockoutTime)
                        {
                            MessageBox.Show("Bạn đã đăng nhập sai quá 5 lần. Vui lòng thử lại sau 15 giây.", "Thông báo");
                            btn_ok.Enabled = false;
                            timer1.Start();
                            ThoiGianCho tg = new ThoiGianCho();
                            tg.Show();
                            return;
                        }
                        else
                        {
                            dangnhapsai = 0;
                        }
                    }
                    if (readerUser.HasRows)
                    {
                        while (readerUser.Read())
                        {
                            string mode = readerUser["mode"].ToString();
                            bool state = Convert.ToBoolean(readerUser["state"]);
                            LoggedInUser = username;
                            if (!state)
                            {
                                MessageBox.Show("Tài khoản của bạn đã bị khóa. Vui lòng liên hệ với quản trị viên để mở khóa.", "Thông báo");
                                return;
                            }
                            if (dangnhapsai >= 5)
                            {
                                if (DateTime.Now < lockoutTime)
                                {
                                    MessageBox.Show("Bạn đã đăng nhập sai quá 5 lần. Vui lòng thử lại sau 15 giây.", "Thông báo");
                                    btn_ok.Enabled = false;
                                    timer1.Start();
                                    ThoiGianCho tg = new ThoiGianCho();
                                    tg.Show();
                                    return;
                                }
                                else
                                {
                                    dangnhapsai = 0;
                                }
                            }
                            switch (mode)
                            {
                                case "Admin":
                                    userRole = "Admin";
                                    currentUser = username;
                                    //currentPassword = password;
                                    break;
                                case "User":
                                    userRole = "User";
                                    currentUser = username;
                                    //currentPassword = password;
                                    break;
                                case "Trưởng Khoa":
                                    userRole = "TruongKhoa";
                                    currentUser = username;
                                    //currentPassword = password;
                                    break;
                                case "Giáo Viên":
                                    userRole = "GiaoVien";
                                    currentUser = username;
                                    //currentPassword = password;
                                    break;
                            }
                            textBox2.Text = "";
                            switch (userRole)
                            {
                                case "Admin":
                                    menu_admin ad = new menu_admin();
                                    this.Hide();
                                    ad.ShowDialog();
                                    this.Show();
                                    break;
                                case "User":
                                    menu_admin ad2 = new menu_admin();
                                    this.Hide();
                                    ad2.ShowDialog();
                                    this.Show();
                                    break;
                                case "TruongKhoa":
                                    menu_admin ad3 = new menu_admin();
                                    this.Hide();
                                    ad3.ShowDialog();
                                    this.Show();
                                    break;
                                case "GiaoVien":
                                    menu_admin ad4 = new menu_admin();
                                    this.Hide();
                                    ad4.ShowDialog();
                                    this.Show();
                                    break;
                            }

                            return;
                        }
                    }
                    {
                        //bing chat
                        dangnhapsai++;
                        if (dangnhapsai >= 5)
                        {
                            lockoutTime = DateTime.Now.AddSeconds(15);
                        }
                        MessageBox.Show("- Tên đăng nhập hoặc mật khẩu không đúng...!!!\n" +
                            "- Bạn đã đang nhập sai " + dangnhapsai + " lần...!!!\n\n" +
                            "- Lưu ý: Nếu bạn đăng nhập sai quá 5 lần thì sẽ không đăng nhập được trong 15 giây", "Thông báo");
                    }
                }
            }
        }
        private void cb_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienthi.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
