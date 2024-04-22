namespace Bai_tap_lon
{
    partial class tt_sinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tt_sinhvien));
            this.label1 = new System.Windows.Forms.Label();
            this.qL_SinhVienDataSet8 = new Bai_tap_lon.QL_SinhVienDataSet8();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet8TableAdapters.KhoaTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_sv = new System.Windows.Forms.DataGridView();
            this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhsinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhsinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtsinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachisinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet11 = new Bai_tap_lon.QL_SinhVienDataSet11();
            this.sinhVienTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet11TableAdapters.SinhVienTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_macs = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ns = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.txt_gt = new System.Windows.Forms.TextBox();
            this.txt_tensv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_sv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(741, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // qL_SinhVienDataSet8
            // 
            this.qL_SinhVienDataSet8.DataSetName = "QL_SinhVienDataSet8";
            this.qL_SinhVienDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qL_SinhVienDataSet8;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_sv);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1440, 583);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sinh viên";
            // 
            // bang_sv
            // 
            this.bang_sv.AutoGenerateColumns = false;
            this.bang_sv.BackgroundColor = System.Drawing.Color.White;
            this.bang_sv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_sv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvienDataGridViewTextBoxColumn,
            this.tensinhvienDataGridViewTextBoxColumn,
            this.gioitinhsinhvienDataGridViewTextBoxColumn,
            this.ngaysinhsinhvienDataGridViewTextBoxColumn,
            this.sdtsinhvienDataGridViewTextBoxColumn,
            this.diachisinhvienDataGridViewTextBoxColumn,
            this.machinhsachDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn});
            this.bang_sv.DataSource = this.sinhVienBindingSource;
            this.bang_sv.Location = new System.Drawing.Point(8, 33);
            this.bang_sv.Name = "bang_sv";
            this.bang_sv.RowHeadersWidth = 51;
            this.bang_sv.RowTemplate.Height = 24;
            this.bang_sv.Size = new System.Drawing.Size(1426, 531);
            this.bang_sv.TabIndex = 11;
            this.bang_sv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_sv_CellContentClick);
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
            this.sinhVienBindingSource.DataSource = this.qL_SinhVienDataSet11;
            // 
            // qL_SinhVienDataSet11
            // 
            this.qL_SinhVienDataSet11.DataSetName = "QL_SinhVienDataSet11";
            this.qL_SinhVienDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_macs);
            this.groupBox1.Controls.Add(this.txt_dc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ns);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_masv);
            this.groupBox1.Controls.Add(this.txt_gt);
            this.groupBox1.Controls.Add(this.txt_tensv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1450, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 583);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "Mã lớp:";
            // 
            // txt_malop
            // 
            this.txt_malop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_malop.Location = new System.Drawing.Point(6, 472);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(337, 30);
            this.txt_malop.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Mã chính sách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "Địa chỉ: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "Số điện thoại: ";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(6, 295);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(337, 30);
            this.txt_sdt.TabIndex = 39;
            // 
            // txt_macs
            // 
            this.txt_macs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_macs.Location = new System.Drawing.Point(6, 413);
            this.txt_macs.Name = "txt_macs";
            this.txt_macs.Size = new System.Drawing.Size(337, 30);
            this.txt_macs.TabIndex = 38;
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.Location = new System.Drawing.Point(6, 354);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(337, 30);
            this.txt_dc.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ngày sinh:";
            // 
            // txt_ns
            // 
            this.txt_ns.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ns.Location = new System.Drawing.Point(6, 236);
            this.txt_ns.Name = "txt_ns";
            this.txt_ns.Size = new System.Drawing.Size(337, 30);
            this.txt_ns.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 535);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 42);
            this.button3.TabIndex = 34;
            this.button3.Text = "Báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 42);
            this.button2.TabIndex = 33;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên sinh viên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã sinh viên: ";
            // 
            // txt_masv
            // 
            this.txt_masv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masv.Location = new System.Drawing.Point(6, 59);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(337, 30);
            this.txt_masv.TabIndex = 28;
            // 
            // txt_gt
            // 
            this.txt_gt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gt.Location = new System.Drawing.Point(6, 177);
            this.txt_gt.Name = "txt_gt";
            this.txt_gt.Size = new System.Drawing.Size(337, 30);
            this.txt_gt.TabIndex = 27;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensv.Location = new System.Drawing.Point(6, 118);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(337, 30);
            this.txt_tensv.TabIndex = 26;
            // 
            // tt_sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tt_sinhvien";
            this.Text = "Thông tin sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tt_sinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_sv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QL_SinhVienDataSet8 qL_SinhVienDataSet8;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QL_SinhVienDataSet8TableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bang_sv;
        private QL_SinhVienDataSet11 qL_SinhVienDataSet11;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QL_SinhVienDataSet11TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhsinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhsinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtsinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachisinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ns;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.TextBox txt_gt;
        private System.Windows.Forms.TextBox txt_tensv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_macs;
        private System.Windows.Forms.TextBox txt_dc;
    }
}