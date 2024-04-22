namespace Bai_tap_lon
{
    partial class tk_giaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tk_giaovien));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_gv = new System.Windows.Forms.DataGridView();
            this.magiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhgiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhgiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtgiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachigiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet18 = new Bai_tap_lon.QL_SinhVienDataSet18();
            this.giaoVienTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet18TableAdapters.GiaoVienTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet18)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 35);
            this.label3.TabIndex = 29;
            this.label3.Text = "TÌM KIẾM THÔNG TIN GIÁO VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_gv);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1780, 435);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giáo viên";
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
            this.bang_gv.Location = new System.Drawing.Point(11, 28);
            this.bang_gv.Name = "bang_gv";
            this.bang_gv.RowHeadersWidth = 51;
            this.bang_gv.RowTemplate.Height = 24;
            this.bang_gv.Size = new System.Drawing.Size(1763, 401);
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
            this.diachigiaovienDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.qL_SinhVienDataSet18;
            // 
            // qL_SinhVienDataSet18
            // 
            this.qL_SinhVienDataSet18.DataSetName = "QL_SinhVienDataSet18";
            this.qL_SinhVienDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.Location = new System.Drawing.Point(392, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 159);
            this.groupBox1.TabIndex = 31;
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
            this.button1.TabIndex = 32;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã giáo viên",
            "Tên giáo viên",
            "Giới tính",
            "Ngày sinh",
            "Số điện thoại",
            "Địa chỉ"});
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
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click_1);
            // 
            // txt_tk
            // 
            this.txt_tk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(306, 68);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(436, 28);
            this.txt_tk.TabIndex = 34;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged_1);
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
            // tk_giaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tk_giaovien";
            this.Text = "Tìm kiếm giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tk_giaovien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet18)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bang_gv;
        private QL_SinhVienDataSet18 qL_SinhVienDataSet18;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private QL_SinhVienDataSet18TableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhgiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhgiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtgiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachigiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}