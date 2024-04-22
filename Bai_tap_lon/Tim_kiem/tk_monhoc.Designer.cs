namespace Bai_tap_lon
{
    partial class tk_monhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tk_monhoc));
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_magv = new System.Windows.Forms.RadioButton();
            this.rad_st = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_ten = new System.Windows.Forms.RadioButton();
            this.rad_ma = new System.Windows.Forms.RadioButton();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_monhoc = new System.Windows.Forms.DataGridView();
            this.mamonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotietmonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet21 = new Bai_tap_lon.QL_SinhVienDataSet21();
            this.qL_SinhVienDataSet20 = new Bai_tap_lon.QL_SinhVienDataSet20();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet20TableAdapters.SinhVienTableAdapter();
            this.monHocTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet21TableAdapters.MonHocTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_monhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 35);
            this.label3.TabIndex = 34;
            this.label3.Text = "TÌM KIẾM THÔNG TIN MÔN HỌC\r\n";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(633, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 33;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(328, 208);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(132, 34);
            this.btn_timkiem.TabIndex = 32;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rad_magv);
            this.groupBox1.Controls.Add(this.rad_st);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rad_ten);
            this.groupBox1.Controls.Add(this.rad_ma);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 95);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // rad_magv
            // 
            this.rad_magv.AutoSize = true;
            this.rad_magv.Location = new System.Drawing.Point(610, 57);
            this.rad_magv.Name = "rad_magv";
            this.rad_magv.Size = new System.Drawing.Size(131, 24);
            this.rad_magv.TabIndex = 5;
            this.rad_magv.TabStop = true;
            this.rad_magv.Text = "Mã giáo viên";
            this.rad_magv.UseVisualStyleBackColor = true;
            this.rad_magv.CheckedChanged += new System.EventHandler(this.rad_magv_CheckedChanged);
            // 
            // rad_st
            // 
            this.rad_st.AutoSize = true;
            this.rad_st.Location = new System.Drawing.Point(457, 57);
            this.rad_st.Name = "rad_st";
            this.rad_st.Size = new System.Drawing.Size(80, 24);
            this.rad_st.TabIndex = 4;
            this.rad_st.TabStop = true;
            this.rad_st.Text = "Số tiết";
            this.rad_st.UseVisualStyleBackColor = true;
            this.rad_st.CheckedChanged += new System.EventHandler(this.rad_st_CheckedChanged);
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
            // rad_ten
            // 
            this.rad_ten.AutoSize = true;
            this.rad_ten.Location = new System.Drawing.Point(610, 27);
            this.rad_ten.Name = "rad_ten";
            this.rad_ten.Size = new System.Drawing.Size(131, 24);
            this.rad_ten.TabIndex = 1;
            this.rad_ten.TabStop = true;
            this.rad_ten.Text = "Tên môn học";
            this.rad_ten.UseVisualStyleBackColor = true;
            this.rad_ten.CheckedChanged += new System.EventHandler(this.rad_ten_CheckedChanged);
            // 
            // rad_ma
            // 
            this.rad_ma.AutoSize = true;
            this.rad_ma.Location = new System.Drawing.Point(457, 27);
            this.rad_ma.Name = "rad_ma";
            this.rad_ma.Size = new System.Drawing.Size(128, 24);
            this.rad_ma.TabIndex = 0;
            this.rad_ma.TabStop = true;
            this.rad_ma.Text = "Mã môn học";
            this.rad_ma.UseVisualStyleBackColor = true;
            this.rad_ma.CheckedChanged += new System.EventHandler(this.rad_ma_CheckedChanged);
            // 
            // txt_tk
            // 
            this.txt_tk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(328, 168);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(436, 28);
            this.txt_tk.TabIndex = 31;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_monhoc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 475);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin môn học";
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
            this.bang_monhoc.Location = new System.Drawing.Point(7, 28);
            this.bang_monhoc.Name = "bang_monhoc";
            this.bang_monhoc.RowHeadersWidth = 51;
            this.bang_monhoc.RowTemplate.Height = 24;
            this.bang_monhoc.Size = new System.Drawing.Size(1012, 441);
            this.bang_monhoc.TabIndex = 0;
            // 
            // mamonhocDataGridViewTextBoxColumn
            // 
            this.mamonhocDataGridViewTextBoxColumn.DataPropertyName = "ma_monhoc";
            this.mamonhocDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.mamonhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mamonhocDataGridViewTextBoxColumn.Name = "mamonhocDataGridViewTextBoxColumn";
            this.mamonhocDataGridViewTextBoxColumn.Width = 155;
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
            this.monHocBindingSource.DataSource = this.qL_SinhVienDataSet21;
            // 
            // qL_SinhVienDataSet21
            // 
            this.qL_SinhVienDataSet21.DataSetName = "QL_SinhVienDataSet21";
            this.qL_SinhVienDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_SinhVienDataSet20
            // 
            this.qL_SinhVienDataSet20.DataSetName = "QL_SinhVienDataSet20";
            this.qL_SinhVienDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qL_SinhVienDataSet20;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(481, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 36;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tk_monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 728);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_tk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tk_monhoc";
            this.Text = "Tìm kiếm môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tk_monhoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_monhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_ten;
        private System.Windows.Forms.RadioButton rad_ma;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bang_monhoc;
        private QL_SinhVienDataSet20 qL_SinhVienDataSet20;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QL_SinhVienDataSet20TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private QL_SinhVienDataSet21 qL_SinhVienDataSet21;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QL_SinhVienDataSet21TableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotietmonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rad_magv;
        private System.Windows.Forms.RadioButton rad_st;
        private System.Windows.Forms.Button button1;
    }
}