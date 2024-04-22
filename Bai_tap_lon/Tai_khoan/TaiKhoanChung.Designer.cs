namespace Bai_tap_lon.Quan_li
{
    partial class TaiKhoanChung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoanChung));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.f = new System.Windows.Forms.RadioButton();
            this.radtk_t = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radtk_tk = new System.Windows.Forms.RadioButton();
            this.radtk_gv = new System.Windows.Forms.RadioButton();
            this.radtk_us = new System.Windows.Forms.RadioButton();
            this.radtk_ad = new System.Windows.Forms.RadioButton();
            this.bang_taikhoan = new System.Windows.Forms.DataGridView();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet28 = new Bai_tap_lon.QL_SinhVienDataSet28();
            this.taiKhoanTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet28TableAdapters.TaiKhoanTableAdapter();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_us = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.GroupBox();
            this.rad_f = new System.Windows.Forms.RadioButton();
            this.rad_t = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_tk = new System.Windows.Forms.RadioButton();
            this.rad_gv = new System.Windows.Forms.RadioButton();
            this.rad_us = new System.Windows.Forms.RadioButton();
            this.rad_ad = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_taikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet28)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gr.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.bang_taikhoan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1390, 553);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thông tin tài khoản";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(72, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1269, 166);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hiển thị theo";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.f);
            this.groupBox7.Controls.Add(this.radtk_t);
            this.groupBox7.Location = new System.Drawing.Point(716, 29);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(250, 124);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Trạng thái hoạt động";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(57, 82);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(75, 27);
            this.f.TabIndex = 3;
            this.f.TabStop = true;
            this.f.Text = "False";
            this.f.UseVisualStyleBackColor = true;
            this.f.CheckedChanged += new System.EventHandler(this.f_CheckedChanged);
            // 
            // radtk_t
            // 
            this.radtk_t.AutoSize = true;
            this.radtk_t.Location = new System.Drawing.Point(57, 40);
            this.radtk_t.Name = "radtk_t";
            this.radtk_t.Size = new System.Drawing.Size(71, 27);
            this.radtk_t.TabIndex = 2;
            this.radtk_t.TabStop = true;
            this.radtk_t.Text = "True";
            this.radtk_t.UseVisualStyleBackColor = true;
            this.radtk_t.CheckedChanged += new System.EventHandler(this.radtk_t_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radtk_tk);
            this.groupBox6.Controls.Add(this.radtk_gv);
            this.groupBox6.Controls.Add(this.radtk_us);
            this.groupBox6.Controls.Add(this.radtk_ad);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(298, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(325, 136);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức vụ";
            // 
            // radtk_tk
            // 
            this.radtk_tk.AutoSize = true;
            this.radtk_tk.Location = new System.Drawing.Point(156, 82);
            this.radtk_tk.Name = "radtk_tk";
            this.radtk_tk.Size = new System.Drawing.Size(143, 27);
            this.radtk_tk.TabIndex = 3;
            this.radtk_tk.TabStop = true;
            this.radtk_tk.Text = "Trưởng Khoa";
            this.radtk_tk.UseVisualStyleBackColor = true;
            this.radtk_tk.CheckedChanged += new System.EventHandler(this.radtk_tk_CheckedChanged);
            // 
            // radtk_gv
            // 
            this.radtk_gv.AutoSize = true;
            this.radtk_gv.Location = new System.Drawing.Point(156, 40);
            this.radtk_gv.Name = "radtk_gv";
            this.radtk_gv.Size = new System.Drawing.Size(114, 27);
            this.radtk_gv.TabIndex = 2;
            this.radtk_gv.TabStop = true;
            this.radtk_gv.Text = "Giáo Viên";
            this.radtk_gv.UseVisualStyleBackColor = true;
            this.radtk_gv.CheckedChanged += new System.EventHandler(this.radtk_gv_CheckedChanged);
            // 
            // radtk_us
            // 
            this.radtk_us.AutoSize = true;
            this.radtk_us.Location = new System.Drawing.Point(17, 82);
            this.radtk_us.Name = "radtk_us";
            this.radtk_us.Size = new System.Drawing.Size(71, 27);
            this.radtk_us.TabIndex = 1;
            this.radtk_us.TabStop = true;
            this.radtk_us.Text = "User";
            this.radtk_us.UseVisualStyleBackColor = true;
            this.radtk_us.CheckedChanged += new System.EventHandler(this.radtk_us_CheckedChanged);
            // 
            // radtk_ad
            // 
            this.radtk_ad.AutoSize = true;
            this.radtk_ad.Location = new System.Drawing.Point(17, 40);
            this.radtk_ad.Name = "radtk_ad";
            this.radtk_ad.Size = new System.Drawing.Size(85, 27);
            this.radtk_ad.TabIndex = 0;
            this.radtk_ad.TabStop = true;
            this.radtk_ad.Text = "Admin";
            this.radtk_ad.UseVisualStyleBackColor = true;
            this.radtk_ad.CheckedChanged += new System.EventHandler(this.radtk_ad_CheckedChanged);
            // 
            // bang_taikhoan
            // 
            this.bang_taikhoan.AutoGenerateColumns = false;
            this.bang_taikhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bang_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_taikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.stateDataGridViewCheckBoxColumn});
            this.bang_taikhoan.DataSource = this.taiKhoanBindingSource;
            this.bang_taikhoan.Location = new System.Drawing.Point(0, 201);
            this.bang_taikhoan.Name = "bang_taikhoan";
            this.bang_taikhoan.RowHeadersWidth = 51;
            this.bang_taikhoan.RowTemplate.Height = 24;
            this.bang_taikhoan.Size = new System.Drawing.Size(1390, 352);
            this.bang_taikhoan.TabIndex = 1;
            this.bang_taikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_taikhoan_CellContentClick);
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Tên đầy đủ";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 175;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 175;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "mode";
            this.modeDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            this.modeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewCheckBoxColumn
            // 
            this.stateDataGridViewCheckBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewCheckBoxColumn.HeaderText = "Trạng thái hoạt động";
            this.stateDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewCheckBoxColumn.Name = "stateDataGridViewCheckBoxColumn";
            this.stateDataGridViewCheckBoxColumn.Width = 210;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.qL_SinhVienDataSet28;
            // 
            // qL_SinhVienDataSet28
            // 
            this.qL_SinhVienDataSet28.DataSetName = "QL_SinhVienDataSet28";
            this.qL_SinhVienDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(293, 53);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(473, 30);
            this.txt_name.TabIndex = 0;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(293, 102);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(473, 30);
            this.txt_phone.TabIndex = 1;
            // 
            // txt_us
            // 
            this.txt_us.Location = new System.Drawing.Point(293, 151);
            this.txt_us.Name = "txt_us";
            this.txt_us.Size = new System.Drawing.Size(473, 30);
            this.txt_us.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(293, 200);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(473, 30);
            this.txt_pass.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btn_clean);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gr);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txt_pass);
            this.groupBox2.Controls.Add(this.txt_us);
            this.groupBox2.Controls.Add(this.txt_phone);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1390, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Location = new System.Drawing.Point(1151, 179);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(107, 36);
            this.btn_clean.TabIndex = 30;
            this.btn_clean.Text = "Làm mới";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1151, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 36);
            this.button5.TabIndex = 29;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(1038, 205);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(107, 36);
            this.btn_sua.TabIndex = 28;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(1038, 248);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 36);
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(1038, 162);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 36);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đầy đủ:";
            // 
            // gr
            // 
            this.gr.Controls.Add(this.rad_f);
            this.gr.Controls.Add(this.rad_t);
            this.gr.Location = new System.Drawing.Point(1017, 32);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(250, 124);
            this.gr.TabIndex = 5;
            this.gr.TabStop = false;
            this.gr.Text = "Trạng thái hoạt động";
            this.gr.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rad_f
            // 
            this.rad_f.AutoSize = true;
            this.rad_f.Location = new System.Drawing.Point(57, 82);
            this.rad_f.Name = "rad_f";
            this.rad_f.Size = new System.Drawing.Size(75, 27);
            this.rad_f.TabIndex = 3;
            this.rad_f.TabStop = true;
            this.rad_f.Text = "False";
            this.rad_f.UseVisualStyleBackColor = true;
            this.rad_f.CheckedChanged += new System.EventHandler(this.rad_f_CheckedChanged);
            // 
            // rad_t
            // 
            this.rad_t.AutoSize = true;
            this.rad_t.Location = new System.Drawing.Point(57, 40);
            this.rad_t.Name = "rad_t";
            this.rad_t.Size = new System.Drawing.Size(71, 27);
            this.rad_t.TabIndex = 2;
            this.rad_t.TabStop = true;
            this.rad_t.Text = "True";
            this.rad_t.UseVisualStyleBackColor = true;
            this.rad_t.CheckedChanged += new System.EventHandler(this.rad_t_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_tk);
            this.groupBox3.Controls.Add(this.rad_gv);
            this.groupBox3.Controls.Add(this.rad_us);
            this.groupBox3.Controls.Add(this.rad_ad);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(811, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 210);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức vụ";
            // 
            // rad_tk
            // 
            this.rad_tk.AutoSize = true;
            this.rad_tk.Location = new System.Drawing.Point(17, 166);
            this.rad_tk.Name = "rad_tk";
            this.rad_tk.Size = new System.Drawing.Size(143, 27);
            this.rad_tk.TabIndex = 3;
            this.rad_tk.TabStop = true;
            this.rad_tk.Text = "Trưởng Khoa";
            this.rad_tk.UseVisualStyleBackColor = true;
            this.rad_tk.CheckedChanged += new System.EventHandler(this.rad_tk_CheckedChanged);
            // 
            // rad_gv
            // 
            this.rad_gv.AutoSize = true;
            this.rad_gv.Location = new System.Drawing.Point(17, 124);
            this.rad_gv.Name = "rad_gv";
            this.rad_gv.Size = new System.Drawing.Size(114, 27);
            this.rad_gv.TabIndex = 2;
            this.rad_gv.TabStop = true;
            this.rad_gv.Text = "Giáo Viên";
            this.rad_gv.UseVisualStyleBackColor = true;
            this.rad_gv.CheckedChanged += new System.EventHandler(this.rad_gv_CheckedChanged);
            // 
            // rad_us
            // 
            this.rad_us.AutoSize = true;
            this.rad_us.Location = new System.Drawing.Point(17, 82);
            this.rad_us.Name = "rad_us";
            this.rad_us.Size = new System.Drawing.Size(71, 27);
            this.rad_us.TabIndex = 1;
            this.rad_us.TabStop = true;
            this.rad_us.Text = "User";
            this.rad_us.UseVisualStyleBackColor = true;
            this.rad_us.CheckedChanged += new System.EventHandler(this.rad_us_CheckedChanged);
            // 
            // rad_ad
            // 
            this.rad_ad.AutoSize = true;
            this.rad_ad.Location = new System.Drawing.Point(17, 40);
            this.rad_ad.Name = "rad_ad";
            this.rad_ad.Size = new System.Drawing.Size(85, 27);
            this.rad_ad.TabIndex = 0;
            this.rad_ad.TabStop = true;
            this.rad_ad.Text = "Admin";
            this.rad_ad.UseVisualStyleBackColor = true;
            this.rad_ad.CheckedChanged += new System.EventHandler(this.rad_ad_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 42);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quản lý tài khoản";
            // 
            // TaiKhoanChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 988);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaiKhoanChung";
            this.Text = "Quản lý tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TaiKhoanChung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_taikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet28)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gr.ResumeLayout(false);
            this.gr.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bang_taikhoan;
        private QL_SinhVienDataSet28 qL_SinhVienDataSet28;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private QL_SinhVienDataSet28TableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_us;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_tk;
        private System.Windows.Forms.RadioButton rad_gv;
        private System.Windows.Forms.RadioButton rad_us;
        private System.Windows.Forms.RadioButton rad_ad;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.RadioButton rad_f;
        private System.Windows.Forms.RadioButton rad_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radtk_tk;
        private System.Windows.Forms.RadioButton radtk_us;
        private System.Windows.Forms.RadioButton radtk_ad;
        private System.Windows.Forms.RadioButton radtk_gv;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton f;
        private System.Windows.Forms.RadioButton radtk_t;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stateDataGridViewCheckBoxColumn;
    }
}