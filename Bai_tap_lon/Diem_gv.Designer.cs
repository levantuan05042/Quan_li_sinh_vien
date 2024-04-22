namespace Bai_tap_lon
{
    partial class Diem_gv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diem_gv));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.machinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_mamh = new System.Windows.Forms.ComboBox();
            this.cb_masv = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_chuyendiem = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_mo = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.chedochinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet26TableAdapters.DiemTableAdapter();
            this.qL_SinhVienDataSet26 = new Bai_tap_lon.QL_SinhVienDataSet26();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bang_diem = new System.Windows.Forms.DataGridView();
            this.diemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet27 = new Bai_tap_lon.QL_SinhVienDataSet27();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.diemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diemTableAdapter1 = new Bai_tap_lon.QL_SinhVienDataSet27TableAdapters.DiemTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bang_diem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet27)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(777, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "ĐIỂM SINH VIÊN";
            // 
            // machinhsachDataGridViewTextBoxColumn
            // 
            this.machinhsachDataGridViewTextBoxColumn.DataPropertyName = "ma_chinhsach";
            this.machinhsachDataGridViewTextBoxColumn.HeaderText = "Mã chính sách";
            this.machinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machinhsachDataGridViewTextBoxColumn.Name = "machinhsachDataGridViewTextBoxColumn";
            this.machinhsachDataGridViewTextBoxColumn.Width = 160;
            // 
            // txt_diem
            // 
            this.txt_diem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diem.Location = new System.Drawing.Point(287, 147);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(451, 30);
            this.txt_diem.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Điểm:";
            // 
            // cb_mamh
            // 
            this.cb_mamh.FormattingEnabled = true;
            this.cb_mamh.Location = new System.Drawing.Point(287, 109);
            this.cb_mamh.Name = "cb_mamh";
            this.cb_mamh.Size = new System.Drawing.Size(451, 28);
            this.cb_mamh.TabIndex = 27;
            // 
            // cb_masv
            // 
            this.cb_masv.FormattingEnabled = true;
            this.cb_masv.Location = new System.Drawing.Point(287, 66);
            this.cb_masv.Name = "cb_masv";
            this.cb_masv.Size = new System.Drawing.Size(451, 28);
            this.cb_masv.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txt_diem);
            this.groupBox1.Controls.Add(this.btn_chuyendiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_mamh);
            this.groupBox1.Controls.Add(this.cb_masv);
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btn_mo);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(369, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1101, 201);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin điểm";
            // 
            // btn_chuyendiem
            // 
            this.btn_chuyendiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyendiem.Location = new System.Drawing.Point(894, 38);
            this.btn_chuyendiem.Name = "btn_chuyendiem";
            this.btn_chuyendiem.Size = new System.Drawing.Size(179, 36);
            this.btn_chuyendiem.TabIndex = 31;
            this.btn_chuyendiem.Text = "Chuyển điểm";
            this.btn_chuyendiem.UseVisualStyleBackColor = true;
            this.btn_chuyendiem.Click += new System.EventHandler(this.btn_mo_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Location = new System.Drawing.Point(894, 81);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(179, 36);
            this.btn_clean.TabIndex = 25;
            this.btn_clean.Text = "Làm mới";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(894, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 36);
            this.button5.TabIndex = 24;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_mo
            // 
            this.btn_mo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mo.Location = new System.Drawing.Point(894, 38);
            this.btn_mo.Name = "btn_mo";
            this.btn_mo.Size = new System.Drawing.Size(179, 36);
            this.btn_mo.TabIndex = 23;
            this.btn_mo.Text = "Mở";
            this.btn_mo.UseVisualStyleBackColor = true;
            this.btn_mo.Click += new System.EventHandler(this.btn_cd_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(772, 81);
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
            this.btn_xoa.Location = new System.Drawing.Point(772, 124);
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
            this.btn_them.Location = new System.Drawing.Point(772, 38);
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
            this.label3.Location = new System.Drawing.Point(131, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã sinh viên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID: ";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(287, 21);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(451, 30);
            this.txt_id.TabIndex = 16;
            // 
            // chedochinhsachDataGridViewTextBoxColumn
            // 
            this.chedochinhsachDataGridViewTextBoxColumn.DataPropertyName = "chedo_chinhsach";
            this.chedochinhsachDataGridViewTextBoxColumn.HeaderText = "Chế độ";
            this.chedochinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chedochinhsachDataGridViewTextBoxColumn.Name = "chedochinhsachDataGridViewTextBoxColumn";
            this.chedochinhsachDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemTableAdapter
            // 
            this.diemTableAdapter.ClearBeforeFill = true;
            // 
            // qL_SinhVienDataSet26
            // 
            this.qL_SinhVienDataSet26.DataSetName = "QL_SinhVienDataSet26";
            this.qL_SinhVienDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "Diem";
            this.diemBindingSource.DataSource = this.qL_SinhVienDataSet26;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.Width = 125;
            // 
            // mamonhocDataGridViewTextBoxColumn
            // 
            this.mamonhocDataGridViewTextBoxColumn.DataPropertyName = "ma_monhoc";
            this.mamonhocDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.mamonhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mamonhocDataGridViewTextBoxColumn.Name = "mamonhocDataGridViewTextBoxColumn";
            this.mamonhocDataGridViewTextBoxColumn.Width = 125;
            // 
            // masinhvienDataGridViewTextBoxColumn
            // 
            this.masinhvienDataGridViewTextBoxColumn.DataPropertyName = "ma_sinhvien";
            this.masinhvienDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.masinhvienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masinhvienDataGridViewTextBoxColumn.Name = "masinhvienDataGridViewTextBoxColumn";
            this.masinhvienDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // bang_diem
            // 
            this.bang_diem.AutoGenerateColumns = false;
            this.bang_diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_diem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.masinhvienDataGridViewTextBoxColumn,
            this.mamonhocDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn});
            this.bang_diem.DataSource = this.diemBindingSource2;
            this.bang_diem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bang_diem.Location = new System.Drawing.Point(3, 27);
            this.bang_diem.Name = "bang_diem";
            this.bang_diem.RowHeadersWidth = 51;
            this.bang_diem.RowTemplate.Height = 24;
            this.bang_diem.Size = new System.Drawing.Size(1783, 448);
            this.bang_diem.TabIndex = 2;
            this.bang_diem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_diem_CellContentClick);
            // 
            // diemBindingSource2
            // 
            this.diemBindingSource2.DataMember = "Diem";
            this.diemBindingSource2.DataSource = this.qL_SinhVienDataSet27;
            // 
            // qL_SinhVienDataSet27
            // 
            this.qL_SinhVienDataSet27.DataSetName = "QL_SinhVienDataSet27";
            this.qL_SinhVienDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_diem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1789, 478);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin điểm";
            // 
            // diemBindingSource1
            // 
            this.diemBindingSource1.DataMember = "Diem";
            this.diemBindingSource1.DataSource = this.qL_SinhVienDataSet26;
            // 
            // diemTableAdapter1
            // 
            this.diemTableAdapter1.ClearBeforeFill = true;
            // 
            // Diem_gv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 760);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Diem_gv";
            this.Text = "Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Diem_gv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bang_diem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet27)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_mamh;
        private System.Windows.Forms.ComboBox cb_masv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn chedochinhsachDataGridViewTextBoxColumn;
        private QL_SinhVienDataSet26TableAdapters.DiemTableAdapter diemTableAdapter;
        private QL_SinhVienDataSet26 qL_SinhVienDataSet26;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView bang_diem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource diemBindingSource1;
        private QL_SinhVienDataSet27 qL_SinhVienDataSet27;
        private System.Windows.Forms.BindingSource diemBindingSource2;
        private QL_SinhVienDataSet27TableAdapters.DiemTableAdapter diemTableAdapter1;
        private System.Windows.Forms.Button btn_mo;
        private System.Windows.Forms.Button btn_chuyendiem;
    }
}