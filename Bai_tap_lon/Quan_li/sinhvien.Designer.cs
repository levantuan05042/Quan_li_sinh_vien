namespace Bai_tap_lon
{
    partial class sinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sinhvien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bang_sinhvien = new System.Windows.Forms.DataGridView();
            this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhsinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhsinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtsinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachisinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet22 = new Bai_tap_lon.QL_SinhVienDataSet22();
            this.sinhVienTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet22TableAdapters.SinhVienTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.lb8 = new System.Windows.Forms.Label();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.lb4 = new System.Windows.Forms.Label();
            this.txt_sodt = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.cb_mal = new System.Windows.Forms.ComboBox();
            this.cb_macs = new System.Windows.Forms.ComboBox();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.txt_tensv = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_sinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet22)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.bang_sinhvien);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1796, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // bang_sinhvien
            // 
            this.bang_sinhvien.AutoGenerateColumns = false;
            this.bang_sinhvien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bang_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_sinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvienDataGridViewTextBoxColumn,
            this.tensinhvienDataGridViewTextBoxColumn,
            this.gioitinhsinhvienDataGridViewTextBoxColumn,
            this.ngaysinhsinhvienDataGridViewTextBoxColumn,
            this.sdtsinhvienDataGridViewTextBoxColumn,
            this.diachisinhvienDataGridViewTextBoxColumn,
            this.machinhsachDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn});
            this.bang_sinhvien.DataSource = this.sinhVienBindingSource;
            this.bang_sinhvien.Location = new System.Drawing.Point(6, 41);
            this.bang_sinhvien.Name = "bang_sinhvien";
            this.bang_sinhvien.RowHeadersWidth = 51;
            this.bang_sinhvien.RowTemplate.Height = 24;
            this.bang_sinhvien.Size = new System.Drawing.Size(1784, 299);
            this.bang_sinhvien.TabIndex = 0;
            this.bang_sinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_sinhvien_CellContentClick);
            // 
            // masinhvienDataGridViewTextBoxColumn
            // 
            this.masinhvienDataGridViewTextBoxColumn.DataPropertyName = "ma_sinhvien";
            this.masinhvienDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.masinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masinhvienDataGridViewTextBoxColumn.Name = "masinhvienDataGridViewTextBoxColumn";
            this.masinhvienDataGridViewTextBoxColumn.Width = 150;
            // 
            // tensinhvienDataGridViewTextBoxColumn
            // 
            this.tensinhvienDataGridViewTextBoxColumn.DataPropertyName = "ten_sinhvien";
            this.tensinhvienDataGridViewTextBoxColumn.HeaderText = "Tên sinh viên";
            this.tensinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tensinhvienDataGridViewTextBoxColumn.Name = "tensinhvienDataGridViewTextBoxColumn";
            this.tensinhvienDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioitinhsinhvienDataGridViewTextBoxColumn
            // 
            this.gioitinhsinhvienDataGridViewTextBoxColumn.DataPropertyName = "gioitinh_sinhvien";
            this.gioitinhsinhvienDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioitinhsinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioitinhsinhvienDataGridViewTextBoxColumn.Name = "gioitinhsinhvienDataGridViewTextBoxColumn";
            this.gioitinhsinhvienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaysinhsinhvienDataGridViewTextBoxColumn
            // 
            this.ngaysinhsinhvienDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh_sinhvien";
            this.ngaysinhsinhvienDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhsinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaysinhsinhvienDataGridViewTextBoxColumn.Name = "ngaysinhsinhvienDataGridViewTextBoxColumn";
            this.ngaysinhsinhvienDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdtsinhvienDataGridViewTextBoxColumn
            // 
            this.sdtsinhvienDataGridViewTextBoxColumn.DataPropertyName = "sdt_sinhvien";
            this.sdtsinhvienDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sdtsinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdtsinhvienDataGridViewTextBoxColumn.Name = "sdtsinhvienDataGridViewTextBoxColumn";
            this.sdtsinhvienDataGridViewTextBoxColumn.Width = 150;
            // 
            // diachisinhvienDataGridViewTextBoxColumn
            // 
            this.diachisinhvienDataGridViewTextBoxColumn.DataPropertyName = "diachi_sinhvien";
            this.diachisinhvienDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachisinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachisinhvienDataGridViewTextBoxColumn.Name = "diachisinhvienDataGridViewTextBoxColumn";
            this.diachisinhvienDataGridViewTextBoxColumn.Width = 125;
            // 
            // machinhsachDataGridViewTextBoxColumn
            // 
            this.machinhsachDataGridViewTextBoxColumn.DataPropertyName = "ma_chinhsach";
            this.machinhsachDataGridViewTextBoxColumn.HeaderText = "Mã chính sách";
            this.machinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machinhsachDataGridViewTextBoxColumn.Name = "machinhsachDataGridViewTextBoxColumn";
            this.machinhsachDataGridViewTextBoxColumn.Width = 150;
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "ma_lop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.malopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            this.malopDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qL_SinhVienDataSet22;
            // 
            // qL_SinhVienDataSet22
            // 
            this.qL_SinhVienDataSet22.DataSetName = "QL_SinhVienDataSet22";
            this.qL_SinhVienDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(716, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(388, 42);
            this.label7.TabIndex = 16;
            this.label7.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lb8);
            this.groupBox2.Controls.Add(this.datengaysinh);
            this.groupBox2.Controls.Add(this.lb4);
            this.groupBox2.Controls.Add(this.txt_sodt);
            this.groupBox2.Controls.Add(this.txt_dc);
            this.groupBox2.Controls.Add(this.cb_mal);
            this.groupBox2.Controls.Add(this.cb_macs);
            this.groupBox2.Controls.Add(this.lb6);
            this.groupBox2.Controls.Add(this.lb5);
            this.groupBox2.Controls.Add(this.lb7);
            this.groupBox2.Controls.Add(this.lb3);
            this.groupBox2.Controls.Add(this.btn_clean);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.lb2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_masv);
            this.groupBox2.Controls.Add(this.txt_tensv);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(379, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1032, 283);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin sinh viên";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.rad_nu);
            this.groupBox3.Controls.Add(this.rad_nam);
            this.groupBox3.Location = new System.Drawing.Point(206, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 43);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // rad_nu
            // 
            this.rad_nu.AutoSize = true;
            this.rad_nu.Location = new System.Drawing.Point(172, 13);
            this.rad_nu.Name = "rad_nu";
            this.rad_nu.Size = new System.Drawing.Size(54, 24);
            this.rad_nu.TabIndex = 1;
            this.rad_nu.TabStop = true;
            this.rad_nu.Text = "Nữ";
            this.rad_nu.UseVisualStyleBackColor = true;
            // 
            // rad_nam
            // 
            this.rad_nam.AutoSize = true;
            this.rad_nam.Location = new System.Drawing.Point(53, 13);
            this.rad_nam.Name = "rad_nam";
            this.rad_nam.Size = new System.Drawing.Size(67, 24);
            this.rad_nam.TabIndex = 0;
            this.rad_nam.TabStop = true;
            this.rad_nam.Text = "Nam";
            this.rad_nam.UseVisualStyleBackColor = true;
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb8.Location = new System.Drawing.Point(535, 182);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(81, 23);
            this.lb8.TabIndex = 40;
            this.lb8.Text = "Mã lớp: ";
            // 
            // datengaysinh
            // 
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(206, 179);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(279, 28);
            this.datengaysinh.TabIndex = 39;
            this.datengaysinh.ValueChanged += new System.EventHandler(this.datengaysinh_ValueChanged);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(56, 180);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(104, 23);
            this.lb4.TabIndex = 38;
            this.lb4.Text = "Ngày sinh: ";
            // 
            // txt_sodt
            // 
            this.txt_sodt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sodt.Location = new System.Drawing.Point(686, 48);
            this.txt_sodt.Name = "txt_sodt";
            this.txt_sodt.Size = new System.Drawing.Size(279, 30);
            this.txt_sodt.TabIndex = 37;
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.Location = new System.Drawing.Point(686, 92);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(279, 30);
            this.txt_dc.TabIndex = 36;
            // 
            // cb_mal
            // 
            this.cb_mal.FormattingEnabled = true;
            this.cb_mal.Location = new System.Drawing.Point(686, 178);
            this.cb_mal.Name = "cb_mal";
            this.cb_mal.Size = new System.Drawing.Size(279, 28);
            this.cb_mal.TabIndex = 35;
            // 
            // cb_macs
            // 
            this.cb_macs.FormattingEnabled = true;
            this.cb_macs.Location = new System.Drawing.Point(686, 136);
            this.cb_macs.Name = "cb_macs";
            this.cb_macs.Size = new System.Drawing.Size(279, 28);
            this.cb_macs.TabIndex = 34;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(535, 94);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(80, 23);
            this.lb6.TabIndex = 33;
            this.lb6.Text = "Địa chỉ: ";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(535, 50);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(130, 23);
            this.lb5.TabIndex = 32;
            this.lb5.Text = "Số điện thoại: ";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.Location = new System.Drawing.Point(535, 138);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(142, 23);
            this.lb7.TabIndex = 31;
            this.lb7.Text = "Mã chính sách: ";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(56, 136);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(97, 23);
            this.lb3.TabIndex = 30;
            this.lb3.Text = "Giới tính: ";
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Location = new System.Drawing.Point(696, 220);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(107, 36);
            this.btn_clean.TabIndex = 25;
            this.btn_clean.Text = "Làm mới";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(855, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 36);
            this.button5.TabIndex = 24;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(537, 220);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(107, 36);
            this.btn_timkiem.TabIndex = 23;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(219, 220);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(107, 36);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(378, 220);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 36);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(60, 220);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 36);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(56, 92);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(131, 23);
            this.lb2.TabIndex = 18;
            this.lb2.Text = "Tên sinh viên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã sinh viên: ";
            // 
            // txt_masv
            // 
            this.txt_masv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masv.Location = new System.Drawing.Point(206, 46);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(279, 30);
            this.txt_masv.TabIndex = 16;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensv.Location = new System.Drawing.Point(206, 91);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(279, 30);
            this.txt_tensv.TabIndex = 14;
            // 
            // sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 717);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sinhvien";
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sinhvien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_sinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet22)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bang_sinhvien;
        private QL_SinhVienDataSet22 qL_SinhVienDataSet22;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QL_SinhVienDataSet22TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txt_sodt;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.ComboBox cb_mal;
        private System.Windows.Forms.ComboBox cb_macs;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.TextBox txt_tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhsinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhsinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtsinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachisinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.RadioButton rad_nu;
    }
}