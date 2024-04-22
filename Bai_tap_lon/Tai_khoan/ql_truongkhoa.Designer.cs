namespace Bai_tap_lon
{
    partial class ql_truongkhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ql_truongkhoa));
            this.adminTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet6TableAdapters.AdminTableAdapter();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.qL_SinhVienDataSet6 = new Bai_tap_lon.QL_SinhVienDataSet6();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bang_tk = new System.Windows.Forms.DataGridView();
            this.tktruongkhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mktruongkhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truongKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet24 = new Bai_tap_lon.QL_SinhVienDataSet24();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.khoaTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet2TableAdapters.KhoaTableAdapter();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet2 = new Bai_tap_lon.QL_SinhVienDataSet2();
            this.btn_clean = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.truongKhoaTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet24TableAdapters.TruongKhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bang_tk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truongKhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet24)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(383, 93);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(279, 30);
            this.txt_matkhau.TabIndex = 14;
            // 
            // qL_SinhVienDataSet6
            // 
            this.qL_SinhVienDataSet6.DataSetName = "QL_SinhVienDataSet6";
            this.qL_SinhVienDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.qL_SinhVienDataSet6;
            // 
            // bang_tk
            // 
            this.bang_tk.AutoGenerateColumns = false;
            this.bang_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_tk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tktruongkhoaDataGridViewTextBoxColumn,
            this.mktruongkhoaDataGridViewTextBoxColumn});
            this.bang_tk.DataSource = this.truongKhoaBindingSource;
            this.bang_tk.Location = new System.Drawing.Point(9, 28);
            this.bang_tk.Name = "bang_tk";
            this.bang_tk.RowHeadersWidth = 51;
            this.bang_tk.RowTemplate.Height = 24;
            this.bang_tk.Size = new System.Drawing.Size(1008, 354);
            this.bang_tk.TabIndex = 0;
            this.bang_tk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_tk_CellContentClick);
            // 
            // tktruongkhoaDataGridViewTextBoxColumn
            // 
            this.tktruongkhoaDataGridViewTextBoxColumn.DataPropertyName = "tk_truongkhoa";
            this.tktruongkhoaDataGridViewTextBoxColumn.HeaderText = "Tài khoản trưởng khoa";
            this.tktruongkhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tktruongkhoaDataGridViewTextBoxColumn.Name = "tktruongkhoaDataGridViewTextBoxColumn";
            this.tktruongkhoaDataGridViewTextBoxColumn.Width = 200;
            // 
            // mktruongkhoaDataGridViewTextBoxColumn
            // 
            this.mktruongkhoaDataGridViewTextBoxColumn.DataPropertyName = "mk_truongkhoa";
            this.mktruongkhoaDataGridViewTextBoxColumn.HeaderText = "Mật khẩu trưởng khoa";
            this.mktruongkhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mktruongkhoaDataGridViewTextBoxColumn.Name = "mktruongkhoaDataGridViewTextBoxColumn";
            this.mktruongkhoaDataGridViewTextBoxColumn.Width = 200;
            // 
            // truongKhoaBindingSource
            // 
            this.truongKhoaBindingSource.DataMember = "TruongKhoa";
            this.truongKhoaBindingSource.DataSource = this.qL_SinhVienDataSet24;
            // 
            // qL_SinhVienDataSet24
            // 
            this.qL_SinhVienDataSet24.DataSetName = "QL_SinhVienDataSet24";
            this.qL_SinhVienDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bang_tk);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(58, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 388);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Trưởng Khóa";
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendangnhap.Location = new System.Drawing.Point(383, 47);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(279, 30);
            this.txt_tendangnhap.TabIndex = 16;
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
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Location = new System.Drawing.Point(799, 47);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(107, 36);
            this.btn_clean.TabIndex = 25;
            this.btn_clean.Text = "Clean";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(799, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 36);
            this.button5.TabIndex = 24;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(686, 70);
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
            this.btn_xoa.Location = new System.Drawing.Point(686, 113);
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
            this.btn_them.Location = new System.Drawing.Point(686, 27);
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
            this.label2.Location = new System.Drawing.Point(174, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mật khẩu: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên đăng nhập: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(526, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quản lý tài khoản Trưởng Khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tendangnhap);
            this.groupBox1.Controls.Add(this.txt_matkhau);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 165);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin Trưởng Khoa";
            // 
            // truongKhoaTableAdapter
            // 
            this.truongKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // ql_truongkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 736);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ql_truongkhoa";
            this.Text = "Quản lý tài khoản Trưởng Khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ql_truongkhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bang_tk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truongKhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet24)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_SinhVienDataSet6TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.TextBox txt_matkhau;
        private QL_SinhVienDataSet6 qL_SinhVienDataSet6;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private System.Windows.Forms.DataGridView bang_tk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private QL_SinhVienDataSet2TableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QL_SinhVienDataSet2 qL_SinhVienDataSet2;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private QL_SinhVienDataSet24 qL_SinhVienDataSet24;
        private System.Windows.Forms.BindingSource truongKhoaBindingSource;
        private QL_SinhVienDataSet24TableAdapters.TruongKhoaTableAdapter truongKhoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tktruongkhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mktruongkhoaDataGridViewTextBoxColumn;
    }
}