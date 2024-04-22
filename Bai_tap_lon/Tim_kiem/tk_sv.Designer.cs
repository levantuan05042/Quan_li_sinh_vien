namespace Bai_tap_lon
{
    partial class tk_sv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tk_sv));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_sinhvien = new System.Windows.Forms.DataGridView();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet25 = new Bai_tap_lon.QL_SinhVienDataSet25();
            this.sinhVienTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet25TableAdapters.SinhVienTableAdapter();
            this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhsinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhsinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtsinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachisinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_sinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet25)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 35);
            this.label3.TabIndex = 34;
            this.label3.Text = "TÌM KIẾM THÔNG TIN SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.txt_tk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(333, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 159);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(458, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 38;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã sinh viên",
            "Tên sinh viên",
            "Giới tính",
            "Ngày sinh",
            "Số điện thoại",
            "Mã chính sách",
            "Mã lớp"});
            this.comboBox1.Location = new System.Drawing.Point(441, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 28);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(610, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 36;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(306, 108);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(131, 34);
            this.btn_timkiem.TabIndex = 35;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_tk
            // 
            this.txt_tk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(306, 68);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(436, 28);
            this.txt_tk.TabIndex = 34;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm theo: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_sinhvien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(58, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1587, 487);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Sinh Viên";
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
            this.bang_sinhvien.Location = new System.Drawing.Point(7, 28);
            this.bang_sinhvien.Name = "bang_sinhvien";
            this.bang_sinhvien.RowHeadersWidth = 51;
            this.bang_sinhvien.RowTemplate.Height = 24;
            this.bang_sinhvien.Size = new System.Drawing.Size(1580, 453);
            this.bang_sinhvien.TabIndex = 0;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qL_SinhVienDataSet25;
            // 
            // qL_SinhVienDataSet25
            // 
            this.qL_SinhVienDataSet25.DataSetName = "QL_SinhVienDataSet25";
            this.qL_SinhVienDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // masinhvienDataGridViewTextBoxColumn
            // 
            this.masinhvienDataGridViewTextBoxColumn.DataPropertyName = "ma_sinhvien";
            this.masinhvienDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.masinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masinhvienDataGridViewTextBoxColumn.Name = "masinhvienDataGridViewTextBoxColumn";
            this.masinhvienDataGridViewTextBoxColumn.Width = 155;
            // 
            // tensinhvienDataGridViewTextBoxColumn
            // 
            this.tensinhvienDataGridViewTextBoxColumn.DataPropertyName = "ten_sinhvien";
            this.tensinhvienDataGridViewTextBoxColumn.HeaderText = "Tên sinh viên";
            this.tensinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tensinhvienDataGridViewTextBoxColumn.Name = "tensinhvienDataGridViewTextBoxColumn";
            this.tensinhvienDataGridViewTextBoxColumn.Width = 155;
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
            this.sdtsinhvienDataGridViewTextBoxColumn.Width = 155;
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
            this.machinhsachDataGridViewTextBoxColumn.Width = 155;
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "ma_lop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.malopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            this.malopDataGridViewTextBoxColumn.Width = 125;
            // 
            // tk_sv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 748);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tk_sv";
            this.Text = "Tìm kiếm sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tk_sv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_sinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bang_sinhvien;
        private QL_SinhVienDataSet25 qL_SinhVienDataSet25;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QL_SinhVienDataSet25TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhsinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhsinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtsinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachisinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
    }
}