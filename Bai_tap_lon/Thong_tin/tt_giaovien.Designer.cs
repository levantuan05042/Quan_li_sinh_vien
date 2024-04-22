namespace Bai_tap_lon
{
    partial class tt_giaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tt_giaovien));
            this.label1 = new System.Windows.Forms.Label();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet8 = new Bai_tap_lon.QL_SinhVienDataSet8();
            this.khoaTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet8TableAdapters.KhoaTableAdapter();
            this.qL_SinhVienDataSet9 = new Bai_tap_lon.QL_SinhVienDataSet9();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaoVienTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet9TableAdapters.GiaoVienTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bang_giaovien = new System.Windows.Forms.DataGridView();
            this.magiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhgiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhgiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtgiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachigiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ns = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.txt_gt = new System.Windows.Forms.TextBox();
            this.txt_tengv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_giaovien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(760, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin giáo viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qL_SinhVienDataSet8;
            // 
            // qL_SinhVienDataSet8
            // 
            this.qL_SinhVienDataSet8.DataSetName = "QL_SinhVienDataSet8";
            this.qL_SinhVienDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // qL_SinhVienDataSet9
            // 
            this.qL_SinhVienDataSet9.DataSetName = "QL_SinhVienDataSet9";
            this.qL_SinhVienDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.qL_SinhVienDataSet9;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.bang_giaovien);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1436, 583);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thông tin giáo viên";
            // 
            // bang_giaovien
            // 
            this.bang_giaovien.AutoGenerateColumns = false;
            this.bang_giaovien.BackgroundColor = System.Drawing.Color.White;
            this.bang_giaovien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_giaovien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiaovienDataGridViewTextBoxColumn,
            this.tengiaovienDataGridViewTextBoxColumn,
            this.gioitinhgiaovienDataGridViewTextBoxColumn,
            this.ngaysinhgiaovienDataGridViewTextBoxColumn,
            this.sdtgiaovienDataGridViewTextBoxColumn,
            this.diachigiaovienDataGridViewTextBoxColumn});
            this.bang_giaovien.DataSource = this.giaoVienBindingSource;
            this.bang_giaovien.Location = new System.Drawing.Point(6, 27);
            this.bang_giaovien.Name = "bang_giaovien";
            this.bang_giaovien.RowHeadersWidth = 51;
            this.bang_giaovien.RowTemplate.Height = 24;
            this.bang_giaovien.Size = new System.Drawing.Size(1424, 550);
            this.bang_giaovien.TabIndex = 3;
            this.bang_giaovien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_dc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_ns);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_magv);
            this.groupBox2.Controls.Add(this.txt_gt);
            this.groupBox2.Controls.Add(this.txt_tengv);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1446, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 583);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giáo viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Địa chỉ:";
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.Location = new System.Drawing.Point(0, 424);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(337, 30);
            this.txt_dc.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Số điện thoại:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(0, 351);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(337, 30);
            this.txt_sdt.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ngày sinh:";
            // 
            // txt_ns
            // 
            this.txt_ns.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ns.Location = new System.Drawing.Point(0, 278);
            this.txt_ns.Name = "txt_ns";
            this.txt_ns.Size = new System.Drawing.Size(337, 30);
            this.txt_ns.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 42);
            this.button3.TabIndex = 34;
            this.button3.Text = "Báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 42);
            this.button2.TabIndex = 33;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 492);
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
            this.label3.Location = new System.Drawing.Point(0, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên giáo viên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã giáo viên: ";
            // 
            // txt_magv
            // 
            this.txt_magv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_magv.Location = new System.Drawing.Point(0, 59);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(337, 30);
            this.txt_magv.TabIndex = 28;
            // 
            // txt_gt
            // 
            this.txt_gt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gt.Location = new System.Drawing.Point(0, 205);
            this.txt_gt.Name = "txt_gt";
            this.txt_gt.Size = new System.Drawing.Size(337, 30);
            this.txt_gt.TabIndex = 27;
            // 
            // txt_tengv
            // 
            this.txt_tengv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tengv.Location = new System.Drawing.Point(0, 132);
            this.txt_tengv.Name = "txt_tengv";
            this.txt_tengv.Size = new System.Drawing.Size(337, 30);
            this.txt_tengv.TabIndex = 26;
            // 
            // tt_giaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 701);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tt_giaovien";
            this.Text = "Thông tin giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tt_giaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_giaovien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QL_SinhVienDataSet8 qL_SinhVienDataSet8;
        private QL_SinhVienDataSet8TableAdapters.KhoaTableAdapter khoaTableAdapter;
        private QL_SinhVienDataSet9 qL_SinhVienDataSet9;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private QL_SinhVienDataSet9TableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bang_giaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhgiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhgiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtgiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachigiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ns;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.TextBox txt_gt;
        private System.Windows.Forms.TextBox txt_tengv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sdt;
    }
}