namespace Bai_tap_lon
{
    partial class monhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monhoc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bang_monhoc = new System.Windows.Forms.DataGridView();
            this.mamonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotietmonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet19 = new Bai_tap_lon.QL_SinhVienDataSet19();
            this.monHocTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet19TableAdapters.MonHocTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sotiet = new System.Windows.Forms.TextBox();
            this.cb_magv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mamh = new System.Windows.Forms.TextBox();
            this.txt_tenmh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_monhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet19)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.bang_monhoc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1787, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bang_monhoc
            // 
            this.bang_monhoc.AutoGenerateColumns = false;
            this.bang_monhoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bang_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_monhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhocDataGridViewTextBoxColumn,
            this.tenmonhocDataGridViewTextBoxColumn,
            this.sotietmonhocDataGridViewTextBoxColumn,
            this.magiaovienDataGridViewTextBoxColumn});
            this.bang_monhoc.DataSource = this.monHocBindingSource;
            this.bang_monhoc.Location = new System.Drawing.Point(7, 33);
            this.bang_monhoc.Name = "bang_monhoc";
            this.bang_monhoc.RowHeadersWidth = 51;
            this.bang_monhoc.RowTemplate.Height = 24;
            this.bang_monhoc.Size = new System.Drawing.Size(1774, 341);
            this.bang_monhoc.TabIndex = 0;
            this.bang_monhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mamonhocDataGridViewTextBoxColumn
            // 
            this.mamonhocDataGridViewTextBoxColumn.DataPropertyName = "ma_monhoc";
            this.mamonhocDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.mamonhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mamonhocDataGridViewTextBoxColumn.Name = "mamonhocDataGridViewTextBoxColumn";
            this.mamonhocDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenmonhocDataGridViewTextBoxColumn
            // 
            this.tenmonhocDataGridViewTextBoxColumn.DataPropertyName = "ten_monhoc";
            this.tenmonhocDataGridViewTextBoxColumn.HeaderText = "Tên môn học";
            this.tenmonhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenmonhocDataGridViewTextBoxColumn.Name = "tenmonhocDataGridViewTextBoxColumn";
            this.tenmonhocDataGridViewTextBoxColumn.Width = 150;
            // 
            // sotietmonhocDataGridViewTextBoxColumn
            // 
            this.sotietmonhocDataGridViewTextBoxColumn.DataPropertyName = "sotiet_monhoc";
            this.sotietmonhocDataGridViewTextBoxColumn.HeaderText = "Số tiết";
            this.sotietmonhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sotietmonhocDataGridViewTextBoxColumn.Name = "sotietmonhocDataGridViewTextBoxColumn";
            this.sotietmonhocDataGridViewTextBoxColumn.Width = 125;
            // 
            // magiaovienDataGridViewTextBoxColumn
            // 
            this.magiaovienDataGridViewTextBoxColumn.DataPropertyName = "ma_giaovien";
            this.magiaovienDataGridViewTextBoxColumn.HeaderText = "Mã giáo viên";
            this.magiaovienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.magiaovienDataGridViewTextBoxColumn.Name = "magiaovienDataGridViewTextBoxColumn";
            this.magiaovienDataGridViewTextBoxColumn.Width = 150;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qL_SinhVienDataSet19;
            // 
            // qL_SinhVienDataSet19
            // 
            this.qL_SinhVienDataSet19.DataSetName = "QL_SinhVienDataSet19";
            this.qL_SinhVienDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(721, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_sotiet);
            this.groupBox2.Controls.Add(this.cb_magv);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_clean);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_mamh);
            this.groupBox2.Controls.Add(this.txt_tenmh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(377, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1072, 230);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin môn học";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số tiết: ";
            // 
            // txt_sotiet
            // 
            this.txt_sotiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotiet.Location = new System.Drawing.Point(347, 119);
            this.txt_sotiet.Name = "txt_sotiet";
            this.txt_sotiet.Size = new System.Drawing.Size(279, 30);
            this.txt_sotiet.TabIndex = 30;
            // 
            // cb_magv
            // 
            this.cb_magv.FormattingEnabled = true;
            this.cb_magv.Location = new System.Drawing.Point(347, 165);
            this.cb_magv.Name = "cb_magv";
            this.cb_magv.Size = new System.Drawing.Size(279, 28);
            this.cb_magv.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã giáo viên:";
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Location = new System.Drawing.Point(762, 86);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(107, 36);
            this.btn_clean.TabIndex = 27;
            this.btn_clean.Text = "Làm mới";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(762, 127);
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
            this.btn_timkiem.Location = new System.Drawing.Point(762, 43);
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
            this.btn_sua.Location = new System.Drawing.Point(649, 86);
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
            this.btn_xoa.Location = new System.Drawing.Point(649, 129);
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
            this.btn_them.Location = new System.Drawing.Point(649, 43);
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
            this.label2.Location = new System.Drawing.Point(198, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên môn học: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã môn học:";
            // 
            // txt_mamh
            // 
            this.txt_mamh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mamh.Location = new System.Drawing.Point(347, 27);
            this.txt_mamh.Name = "txt_mamh";
            this.txt_mamh.Size = new System.Drawing.Size(279, 30);
            this.txt_mamh.TabIndex = 16;
            // 
            // txt_tenmh
            // 
            this.txt_tenmh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenmh.Location = new System.Drawing.Point(347, 73);
            this.txt_tenmh.Name = "txt_tenmh";
            this.txt_tenmh.Size = new System.Drawing.Size(279, 30);
            this.txt_tenmh.TabIndex = 14;
            // 
            // monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 690);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "monhoc";
            this.Text = "Quản lý môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.monhoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_monhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet19)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bang_monhoc;
        private QL_SinhVienDataSet19 qL_SinhVienDataSet19;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QL_SinhVienDataSet19TableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sotiet;
        private System.Windows.Forms.ComboBox cb_magv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mamh;
        private System.Windows.Forms.TextBox txt_tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotietmonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovienDataGridViewTextBoxColumn;
    }
}