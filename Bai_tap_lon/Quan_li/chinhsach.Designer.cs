namespace Bai_tap_lon
{
    partial class chinhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chinhsach));
            this.qL_SinhVienDataSet = new Bai_tap_lon.QL_SinhVienDataSet();
            this.machinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_machinhsach = new System.Windows.Forms.TextBox();
            this.txt_chedo = new System.Windows.Forms.TextBox();
            this.txt_tenchinhsach = new System.Windows.Forms.TextBox();
            this.chinhSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chinhSachTableAdapter = new Bai_tap_lon.QL_SinhVienDataSetTableAdapters.ChinhSachTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_chinhsach = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_SinhVienDataSet5 = new Bai_tap_lon.QL_SinhVienDataSet5();
            this.chinhSachTableAdapter1 = new Bai_tap_lon.QL_SinhVienDataSet5TableAdapters.ChinhSachTableAdapter();
            this.chinhSachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chedochinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_chinhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_SinhVienDataSet
            // 
            this.qL_SinhVienDataSet.DataSetName = "QL_SinhVienDataSet";
            this.qL_SinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machinhsachDataGridViewTextBoxColumn
            // 
            this.machinhsachDataGridViewTextBoxColumn.DataPropertyName = "ma_chinhsach";
            this.machinhsachDataGridViewTextBoxColumn.HeaderText = "Mã chính sách";
            this.machinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machinhsachDataGridViewTextBoxColumn.Name = "machinhsachDataGridViewTextBoxColumn";
            this.machinhsachDataGridViewTextBoxColumn.Width = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_machinhsach);
            this.groupBox1.Controls.Add(this.txt_chedo);
            this.groupBox1.Controls.Add(this.txt_tenchinhsach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(363, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1101, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin chính sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Location = new System.Drawing.Point(896, 64);
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
            this.button5.Location = new System.Drawing.Point(896, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 36);
            this.button5.TabIndex = 24;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(896, 21);
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
            this.btn_sua.Location = new System.Drawing.Point(774, 64);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(107, 36);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(774, 107);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 36);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(774, 21);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 36);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chế độ chính sách:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên chính sách: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã chính sách: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_machinhsach
            // 
            this.txt_machinhsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_machinhsach.Location = new System.Drawing.Point(287, 21);
            this.txt_machinhsach.Name = "txt_machinhsach";
            this.txt_machinhsach.Size = new System.Drawing.Size(451, 30);
            this.txt_machinhsach.TabIndex = 16;
            this.txt_machinhsach.TextChanged += new System.EventHandler(this.txt_machinhsach_TextChanged);
            // 
            // txt_chedo
            // 
            this.txt_chedo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chedo.Location = new System.Drawing.Point(287, 113);
            this.txt_chedo.Name = "txt_chedo";
            this.txt_chedo.Size = new System.Drawing.Size(451, 30);
            this.txt_chedo.TabIndex = 15;
            this.txt_chedo.TextChanged += new System.EventHandler(this.txt_chedo_TextChanged);
            // 
            // txt_tenchinhsach
            // 
            this.txt_tenchinhsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenchinhsach.Location = new System.Drawing.Point(287, 67);
            this.txt_tenchinhsach.Name = "txt_tenchinhsach";
            this.txt_tenchinhsach.Size = new System.Drawing.Size(451, 30);
            this.txt_tenchinhsach.TabIndex = 14;
            this.txt_tenchinhsach.TextChanged += new System.EventHandler(this.txt_tenchinhsach_TextChanged);
            // 
            // chinhSachBindingSource
            // 
            this.chinhSachBindingSource.DataMember = "ChinhSach";
            this.chinhSachBindingSource.DataSource = this.qL_SinhVienDataSet;
            this.chinhSachBindingSource.CurrentChanged += new System.EventHandler(this.chinhSachBindingSource_CurrentChanged);
            // 
            // chinhSachTableAdapter
            // 
            this.chinhSachTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(769, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "CHÍNH SÁCH";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_chinhsach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1789, 429);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chính sách";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bang_chinhsach
            // 
            this.bang_chinhsach.AutoGenerateColumns = false;
            this.bang_chinhsach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bang_chinhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_chinhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.tenchinhsachDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2});
            this.bang_chinhsach.DataSource = this.chinhSachBindingSource;
            this.bang_chinhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bang_chinhsach.Location = new System.Drawing.Point(3, 27);
            this.bang_chinhsach.Name = "bang_chinhsach";
            this.bang_chinhsach.RowHeadersWidth = 51;
            this.bang_chinhsach.RowTemplate.Height = 24;
            this.bang_chinhsach.Size = new System.Drawing.Size(1783, 399);
            this.bang_chinhsach.TabIndex = 2;
            this.bang_chinhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_chinhsach_CellContentClick_2);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ma_chinhsach";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã chính sách";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // tenchinhsachDataGridViewTextBoxColumn
            // 
            this.tenchinhsachDataGridViewTextBoxColumn.DataPropertyName = "ten_chinhsach";
            this.tenchinhsachDataGridViewTextBoxColumn.HeaderText = "Tên chính sách";
            this.tenchinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenchinhsachDataGridViewTextBoxColumn.Name = "tenchinhsachDataGridViewTextBoxColumn";
            this.tenchinhsachDataGridViewTextBoxColumn.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "chedo_chinhsach";
            this.dataGridViewTextBoxColumn2.HeaderText = "Chế độ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // qL_SinhVienDataSet5
            // 
            this.qL_SinhVienDataSet5.DataSetName = "QL_SinhVienDataSet5";
            this.qL_SinhVienDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chinhSachTableAdapter1
            // 
            this.chinhSachTableAdapter1.ClearBeforeFill = true;
            // 
            // chinhSachBindingSource1
            // 
            this.chinhSachBindingSource1.DataMember = "ChinhSach";
            this.chinhSachBindingSource1.DataSource = this.qL_SinhVienDataSet5;
            // 
            // chedochinhsachDataGridViewTextBoxColumn
            // 
            this.chedochinhsachDataGridViewTextBoxColumn.DataPropertyName = "chedo_chinhsach";
            this.chedochinhsachDataGridViewTextBoxColumn.HeaderText = "Chế độ";
            this.chedochinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chedochinhsachDataGridViewTextBoxColumn.Name = "chedochinhsachDataGridViewTextBoxColumn";
            this.chedochinhsachDataGridViewTextBoxColumn.Width = 125;
            // 
            // chinhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1813, 727);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chinhsach";
            this.Text = "Quản lý chính sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.chinhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_chinhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_SinhVienDataSet qL_SinhVienDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_machinhsach;
        private System.Windows.Forms.TextBox txt_chedo;
        private System.Windows.Forms.TextBox txt_tenchinhsach;
        private System.Windows.Forms.BindingSource chinhSachBindingSource;
        private QL_SinhVienDataSetTableAdapters.ChinhSachTableAdapter chinhSachTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bang_chinhsach;
        private QL_SinhVienDataSet5 qL_SinhVienDataSet5;
        private QL_SinhVienDataSet5TableAdapters.ChinhSachTableAdapter chinhSachTableAdapter1;
        private System.Windows.Forms.BindingSource chinhSachBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chedochinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}