namespace Bai_tap_lon
{
    partial class GiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoVien));
            this.bang = new System.Windows.Forms.GroupBox();
            this.bang_gv = new System.Windows.Forms.DataGridView();
            this.magiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhgiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhgiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtgiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachigiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet17 = new Bai_tap_lon.QL_SinhVienDataSet17();
            this.giaoVienTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet17TableAdapters.GiaoVienTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.date_nsgv = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sdtgv = new System.Windows.Forms.TextBox();
            this.txt_dcgv = new System.Windows.Forms.TextBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.txt_tengv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet17)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bang
            // 
            this.bang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bang.Controls.Add(this.bang_gv);
            this.bang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bang.Location = new System.Drawing.Point(12, 390);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(1784, 289);
            this.bang.TabIndex = 0;
            this.bang.TabStop = false;
            this.bang.Text = "Bảng giáo viên";
            // 
            // bang_gv
            // 
            this.bang_gv.AutoGenerateColumns = false;
            this.bang_gv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bang_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiaovienDataGridViewTextBoxColumn,
            this.tengiaovienDataGridViewTextBoxColumn,
            this.gioitinhgiaovienDataGridViewTextBoxColumn,
            this.ngaysinhgiaovienDataGridViewTextBoxColumn,
            this.sdtgiaovienDataGridViewTextBoxColumn,
            this.diachigiaovienDataGridViewTextBoxColumn});
            this.bang_gv.DataSource = this.giaoVienBindingSource;
            this.bang_gv.Location = new System.Drawing.Point(7, 22);
            this.bang_gv.Name = "bang_gv";
            this.bang_gv.RowHeadersWidth = 51;
            this.bang_gv.RowTemplate.Height = 24;
            this.bang_gv.Size = new System.Drawing.Size(1771, 261);
            this.bang_gv.TabIndex = 0;
            this.bang_gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_gv_CellContentClick);
            // 
            // magiaovienDataGridViewTextBoxColumn
            // 
            this.magiaovienDataGridViewTextBoxColumn.DataPropertyName = "ma_giaovien";
            this.magiaovienDataGridViewTextBoxColumn.HeaderText = "Mã giáo viên";
            this.magiaovienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.magiaovienDataGridViewTextBoxColumn.Name = "magiaovienDataGridViewTextBoxColumn";
            this.magiaovienDataGridViewTextBoxColumn.Width = 150;
            // 
            // tengiaovienDataGridViewTextBoxColumn
            // 
            this.tengiaovienDataGridViewTextBoxColumn.DataPropertyName = "ten_giaovien";
            this.tengiaovienDataGridViewTextBoxColumn.HeaderText = "Tên giáo viên";
            this.tengiaovienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tengiaovienDataGridViewTextBoxColumn.Name = "tengiaovienDataGridViewTextBoxColumn";
            this.tengiaovienDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioitinhgiaovienDataGridViewTextBoxColumn
            // 
            this.gioitinhgiaovienDataGridViewTextBoxColumn.DataPropertyName = "gioitinh_giaovien";
            this.gioitinhgiaovienDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioitinhgiaovienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioitinhgiaovienDataGridViewTextBoxColumn.Name = "gioitinhgiaovienDataGridViewTextBoxColumn";
            this.gioitinhgiaovienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaysinhgiaovienDataGridViewTextBoxColumn
            // 
            this.ngaysinhgiaovienDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh_giaovien";
            this.ngaysinhgiaovienDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhgiaovienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaysinhgiaovienDataGridViewTextBoxColumn.Name = "ngaysinhgiaovienDataGridViewTextBoxColumn";
            this.ngaysinhgiaovienDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdtgiaovienDataGridViewTextBoxColumn
            // 
            this.sdtgiaovienDataGridViewTextBoxColumn.DataPropertyName = "sdt_giaovien";
            this.sdtgiaovienDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sdtgiaovienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdtgiaovienDataGridViewTextBoxColumn.Name = "sdtgiaovienDataGridViewTextBoxColumn";
            this.sdtgiaovienDataGridViewTextBoxColumn.Width = 150;
            // 
            // diachigiaovienDataGridViewTextBoxColumn
            // 
            this.diachigiaovienDataGridViewTextBoxColumn.DataPropertyName = "diachi_giaovien";
            this.diachigiaovienDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diachigiaovienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachigiaovienDataGridViewTextBoxColumn.Name = "diachigiaovienDataGridViewTextBoxColumn";
            this.diachigiaovienDataGridViewTextBoxColumn.Width = 200;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.qL_SinhVienDataSet17;
            // 
            // qL_SinhVienDataSet17
            // 
            this.qL_SinhVienDataSet17.DataSetName = "QL_SinhVienDataSet17";
            this.qL_SinhVienDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.date_nsgv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_sdtgv);
            this.groupBox1.Controls.Add(this.txt_dcgv);
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_magv);
            this.groupBox1.Controls.Add(this.txt_tengv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(385, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 283);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin giáo viên";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.rad_nu);
            this.groupBox3.Controls.Add(this.rad_nam);
            this.groupBox3.Location = new System.Drawing.Point(206, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 43);
            this.groupBox3.TabIndex = 42;
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
            // date_nsgv
            // 
            this.date_nsgv.CustomFormat = "";
            this.date_nsgv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_nsgv.Location = new System.Drawing.Point(718, 43);
            this.date_nsgv.Name = "date_nsgv";
            this.date_nsgv.Size = new System.Drawing.Size(279, 28);
            this.date_nsgv.TabIndex = 35;
            this.date_nsgv.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ngày sinh: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(561, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Số điện thoại: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Giới tính: ";
            // 
            // txt_sdtgv
            // 
            this.txt_sdtgv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtgv.Location = new System.Drawing.Point(718, 92);
            this.txt_sdtgv.Name = "txt_sdtgv";
            this.txt_sdtgv.Size = new System.Drawing.Size(279, 30);
            this.txt_sdtgv.TabIndex = 27;
            this.txt_sdtgv.TextChanged += new System.EventHandler(this.txt_sdtgv_TextChanged);
            // 
            // txt_dcgv
            // 
            this.txt_dcgv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dcgv.Location = new System.Drawing.Point(718, 143);
            this.txt_dcgv.Name = "txt_dcgv";
            this.txt_dcgv.Size = new System.Drawing.Size(279, 30);
            this.txt_dcgv.TabIndex = 26;
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Location = new System.Drawing.Point(724, 220);
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
            this.button5.Location = new System.Drawing.Point(890, 220);
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
            this.btn_timkiem.Location = new System.Drawing.Point(558, 220);
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
            this.btn_sua.Location = new System.Drawing.Point(226, 220);
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
            this.btn_xoa.Location = new System.Drawing.Point(392, 220);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên giáo viên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã giáo viên: ";
            // 
            // txt_magv
            // 
            this.txt_magv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_magv.Location = new System.Drawing.Point(206, 46);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(279, 30);
            this.txt_magv.TabIndex = 16;
            // 
            // txt_tengv
            // 
            this.txt_tengv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tengv.Location = new System.Drawing.Point(206, 97);
            this.txt_tengv.Name = "txt_tengv";
            this.txt_tengv.Size = new System.Drawing.Size(279, 30);
            this.txt_tengv.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(701, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "QUẢN LÝ GIÁO VIÊN";
            // 
            // GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 691);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiaoVien";
            this.Text = "Quản lý giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GiaoVien_Load);
            this.bang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet17)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bang;
        private System.Windows.Forms.DataGridView bang_gv;
        private QL_SinhVienDataSet17 qL_SinhVienDataSet17;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private QL_SinhVienDataSet17TableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.TextBox txt_tengv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sdtgv;
        private System.Windows.Forms.TextBox txt_dcgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_nsgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhgiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhgiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtgiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachigiaovienDataGridViewTextBoxColumn;
    }
}