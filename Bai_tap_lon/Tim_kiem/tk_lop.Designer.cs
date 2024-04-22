namespace Bai_tap_lon
{
    partial class tk_lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tk_lop));
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_makhoa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_ten = new System.Windows.Forms.RadioButton();
            this.rad_ma = new System.Windows.Forms.RadioButton();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_lop = new System.Windows.Forms.DataGridView();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet16 = new Bai_tap_lon.QL_SinhVienDataSet16();
            this.lopTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet16TableAdapters.LopTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 35);
            this.label3.TabIndex = 24;
            this.label3.Text = "TÌM KIẾM THÔNG TIN LỚP\r\n";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(607, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(303, 220);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(131, 34);
            this.btn_timkiem.TabIndex = 22;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rad_makhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rad_ten);
            this.groupBox1.Controls.Add(this.rad_ma);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 67);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // rad_makhoa
            // 
            this.rad_makhoa.AutoSize = true;
            this.rad_makhoa.Location = new System.Drawing.Point(641, 23);
            this.rad_makhoa.Name = "rad_makhoa";
            this.rad_makhoa.Size = new System.Drawing.Size(100, 24);
            this.rad_makhoa.TabIndex = 4;
            this.rad_makhoa.TabStop = true;
            this.rad_makhoa.Text = "Mã khoa";
            this.rad_makhoa.UseVisualStyleBackColor = true;
            this.rad_makhoa.CheckedChanged += new System.EventHandler(this.rad_makhoa_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // rad_ten
            // 
            this.rad_ten.AutoSize = true;
            this.rad_ten.Location = new System.Drawing.Point(541, 23);
            this.rad_ten.Name = "rad_ten";
            this.rad_ten.Size = new System.Drawing.Size(89, 24);
            this.rad_ten.TabIndex = 1;
            this.rad_ten.TabStop = true;
            this.rad_ten.Text = "Tên lớp";
            this.rad_ten.UseVisualStyleBackColor = true;
            this.rad_ten.CheckedChanged += new System.EventHandler(this.rad_ten_CheckedChanged);
            // 
            // rad_ma
            // 
            this.rad_ma.AutoSize = true;
            this.rad_ma.Location = new System.Drawing.Point(444, 23);
            this.rad_ma.Name = "rad_ma";
            this.rad_ma.Size = new System.Drawing.Size(86, 24);
            this.rad_ma.TabIndex = 0;
            this.rad_ma.TabStop = true;
            this.rad_ma.Text = "Mã lớp";
            this.rad_ma.UseVisualStyleBackColor = true;
            this.rad_ma.CheckedChanged += new System.EventHandler(this.rad_ma_CheckedChanged);
            // 
            // txt_tk
            // 
            this.txt_tk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(303, 172);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(436, 28);
            this.txt_tk.TabIndex = 21;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_lop);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1020, 392);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin lớp";
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
            this.bang_lop.DataSource = this.lopBindingSource;
            this.bang_lop.Location = new System.Drawing.Point(6, 22);
            this.bang_lop.Name = "bang_lop";
            this.bang_lop.RowHeadersWidth = 51;
            this.bang_lop.RowTemplate.Height = 24;
            this.bang_lop.Size = new System.Drawing.Size(1008, 361);
            this.bang_lop.TabIndex = 0;
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
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qL_SinhVienDataSet16;
            // 
            // qL_SinhVienDataSet16
            // 
            this.qL_SinhVienDataSet16.DataSetName = "QL_SinhVienDataSet16";
            this.qL_SinhVienDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(455, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tk_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_tk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tk_lop";
            this.Text = "Tìm kiếm lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tk_lop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet16)).EndInit();
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
        private System.Windows.Forms.DataGridView bang_lop;
        private QL_SinhVienDataSet16 qL_SinhVienDataSet16;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QL_SinhVienDataSet16TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rad_makhoa;
        private System.Windows.Forms.Button button1;
    }
}