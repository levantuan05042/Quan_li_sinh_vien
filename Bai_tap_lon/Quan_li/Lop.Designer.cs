namespace Bai_tap_lon
{
    partial class Lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lop));
            this.khoaTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet2TableAdapters.KhoaTableAdapter();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet2 = new Bai_tap_lon.QL_SinhVienDataSet2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_lop = new System.Windows.Forms.DataGridView();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet4 = new Bai_tap_lon.QL_SinhVienDataSet4();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.cb_makhoa = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.qL_SinhVienDataSet3 = new Bai_tap_lon.QL_SinhVienDataSet3();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet3TableAdapters.LopTableAdapter();
            this.lopTableAdapter1 = new Bai_tap_lon.QL_SinhVienDataSet4TableAdapters.LopTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qL_SinhVienDataSet2;
            // 
            // qL_SinhVienDataSet2
            // 
            this.qL_SinhVienDataSet2.DataSetName = "QL_SinhVienDataSet2";
            this.qL_SinhVienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_lop);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1808, 402);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin lớp";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bang_lop
            // 
            this.bang_lop.AutoGenerateColumns = false;
            this.bang_lop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bang_lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malopDataGridViewTextBoxColumn,
            this.tenlopDataGridViewTextBoxColumn,
            this.makhoaDataGridViewTextBoxColumn});
            this.bang_lop.DataSource = this.lopBindingSource1;
            this.bang_lop.Location = new System.Drawing.Point(8, 27);
            this.bang_lop.Name = "bang_lop";
            this.bang_lop.RowHeadersWidth = 51;
            this.bang_lop.RowTemplate.Height = 24;
            this.bang_lop.Size = new System.Drawing.Size(1794, 365);
            this.bang_lop.TabIndex = 0;
            this.bang_lop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_lop_CellContentClick);
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "ma_lop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.malopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            this.malopDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenlopDataGridViewTextBoxColumn
            // 
            this.tenlopDataGridViewTextBoxColumn.DataPropertyName = "ten_lop";
            this.tenlopDataGridViewTextBoxColumn.HeaderText = "Tên lớp";
            this.tenlopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenlopDataGridViewTextBoxColumn.Name = "tenlopDataGridViewTextBoxColumn";
            this.tenlopDataGridViewTextBoxColumn.Width = 125;
            // 
            // makhoaDataGridViewTextBoxColumn
            // 
            this.makhoaDataGridViewTextBoxColumn.DataPropertyName = "ma_khoa";
            this.makhoaDataGridViewTextBoxColumn.HeaderText = "Mã khoa";
            this.makhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makhoaDataGridViewTextBoxColumn.Name = "makhoaDataGridViewTextBoxColumn";
            this.makhoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // lopBindingSource1
            // 
            this.lopBindingSource1.DataMember = "Lop";
            this.lopBindingSource1.DataSource = this.qL_SinhVienDataSet4;
            // 
            // qL_SinhVienDataSet4
            // 
            this.qL_SinhVienDataSet4.DataSetName = "QL_SinhVienDataSet4";
            this.qL_SinhVienDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.cb_makhoa);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.txt_tenlop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(429, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 165);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin lớp";
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Location = new System.Drawing.Point(681, 70);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(107, 36);
            this.btn_clean.TabIndex = 27;
            this.btn_clean.Text = "Làm mới";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // cb_makhoa
            // 
            this.cb_makhoa.FormattingEnabled = true;
            this.cb_makhoa.Location = new System.Drawing.Point(272, 119);
            this.cb_makhoa.Name = "cb_makhoa";
            this.cb_makhoa.Size = new System.Drawing.Size(279, 28);
            this.cb_makhoa.TabIndex = 26;
            this.cb_makhoa.SelectedIndexChanged += new System.EventHandler(this.cb_makhoa_SelectedIndexChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(681, 111);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(107, 36);
            this.btn_thoat.TabIndex = 24;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(681, 27);
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
            this.btn_sua.Location = new System.Drawing.Point(568, 70);
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
            this.btn_xoa.Location = new System.Drawing.Point(568, 113);
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
            this.btn_them.Location = new System.Drawing.Point(568, 27);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 36);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên lớp: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã lớp:";
            // 
            // txt_malop
            // 
            this.txt_malop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_malop.Location = new System.Drawing.Point(272, 27);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(279, 30);
            this.txt_malop.TabIndex = 16;
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenlop.Location = new System.Drawing.Point(272, 73);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(279, 30);
            this.txt_tenlop.TabIndex = 14;
            // 
            // qL_SinhVienDataSet3
            // 
            this.qL_SinhVienDataSet3.DataSetName = "QL_SinhVienDataSet3";
            this.qL_SinhVienDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qL_SinhVienDataSet3;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // lopTableAdapter1
            // 
            this.lopTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(754, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "QUẢN LÝ LỚP";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 666);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lop";
            this.Text = "Quản lý lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QL_SinhVienDataSet2TableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QL_SinhVienDataSet2 qL_SinhVienDataSet2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.TextBox txt_tenlop;
        private QL_SinhVienDataSet3 qL_SinhVienDataSet3;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QL_SinhVienDataSet3TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridView bang_lop;
        private QL_SinhVienDataSet4 qL_SinhVienDataSet4;
        private System.Windows.Forms.BindingSource lopBindingSource1;
        private QL_SinhVienDataSet4TableAdapters.LopTableAdapter lopTableAdapter1;
        private System.Windows.Forms.ComboBox cb_makhoa;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clean;
    }
}