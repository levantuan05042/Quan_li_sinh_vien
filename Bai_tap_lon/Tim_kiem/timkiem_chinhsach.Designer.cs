namespace Bai_tap_lon
{
    partial class timkiem_chinhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timkiem_chinhsach));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_chinhsach = new System.Windows.Forms.DataGridView();
            this.machinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chedochinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinhSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet1 = new Bai_tap_lon.QL_SinhVienDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chinhSachTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet1TableAdapters.ChinhSachTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_cd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_ten = new System.Windows.Forms.RadioButton();
            this.rad_ma = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_chinhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_chinhsach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1035, 417);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chính sách";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bang_chinhsach
            // 
            this.bang_chinhsach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bang_chinhsach.AutoGenerateColumns = false;
            this.bang_chinhsach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bang_chinhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_chinhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machinhsachDataGridViewTextBoxColumn,
            this.tenchinhsachDataGridViewTextBoxColumn,
            this.chedochinhsachDataGridViewTextBoxColumn});
            this.bang_chinhsach.DataSource = this.chinhSachBindingSource;
            this.bang_chinhsach.Location = new System.Drawing.Point(6, 34);
            this.bang_chinhsach.Name = "bang_chinhsach";
            this.bang_chinhsach.RowHeadersWidth = 51;
            this.bang_chinhsach.RowTemplate.Height = 24;
            this.bang_chinhsach.Size = new System.Drawing.Size(1023, 377);
            this.bang_chinhsach.TabIndex = 1;
            this.bang_chinhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_chinhsach_CellContentClick);
            // 
            // machinhsachDataGridViewTextBoxColumn
            // 
            this.machinhsachDataGridViewTextBoxColumn.DataPropertyName = "ma_chinhsach";
            this.machinhsachDataGridViewTextBoxColumn.HeaderText = "Mã chính sách";
            this.machinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machinhsachDataGridViewTextBoxColumn.Name = "machinhsachDataGridViewTextBoxColumn";
            this.machinhsachDataGridViewTextBoxColumn.Width = 160;
            // 
            // tenchinhsachDataGridViewTextBoxColumn
            // 
            this.tenchinhsachDataGridViewTextBoxColumn.DataPropertyName = "ten_chinhsach";
            this.tenchinhsachDataGridViewTextBoxColumn.HeaderText = "Tên chính sách";
            this.tenchinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenchinhsachDataGridViewTextBoxColumn.Name = "tenchinhsachDataGridViewTextBoxColumn";
            this.tenchinhsachDataGridViewTextBoxColumn.Width = 160;
            // 
            // chedochinhsachDataGridViewTextBoxColumn
            // 
            this.chedochinhsachDataGridViewTextBoxColumn.DataPropertyName = "chedo_chinhsach";
            this.chedochinhsachDataGridViewTextBoxColumn.HeaderText = "Chế độ";
            this.chedochinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chedochinhsachDataGridViewTextBoxColumn.Name = "chedochinhsachDataGridViewTextBoxColumn";
            this.chedochinhsachDataGridViewTextBoxColumn.Width = 125;
            // 
            // chinhSachBindingSource
            // 
            this.chinhSachBindingSource.DataMember = "ChinhSach";
            this.chinhSachBindingSource.DataSource = this.qL_SinhVienDataSet1;
            this.chinhSachBindingSource.CurrentChanged += new System.EventHandler(this.chinhSachBindingSource_CurrentChanged);
            // 
            // qL_SinhVienDataSet1
            // 
            this.qL_SinhVienDataSet1.DataSetName = "QL_SinhVienDataSet1";
            this.qL_SinhVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "TÌM KIẾM THÔNG TIN CHíNH SÁCH";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(639, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(335, 200);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(131, 34);
            this.btn_timkiem.TabIndex = 12;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_tk
            // 
            this.txt_tk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(335, 160);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(436, 28);
            this.txt_tk.TabIndex = 11;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nội dung tìm kiếm: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chinhSachTableAdapter
            // 
            this.chinhSachTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rad_cd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rad_ten);
            this.groupBox1.Controls.Add(this.rad_ma);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 67);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // rad_cd
            // 
            this.rad_cd.AutoSize = true;
            this.rad_cd.Location = new System.Drawing.Point(826, 23);
            this.rad_cd.Name = "rad_cd";
            this.rad_cd.Size = new System.Drawing.Size(86, 24);
            this.rad_cd.TabIndex = 4;
            this.rad_cd.TabStop = true;
            this.rad_cd.Text = "Chế độ";
            this.rad_cd.UseVisualStyleBackColor = true;
            this.rad_cd.CheckedChanged += new System.EventHandler(this.rad_cd_CheckedChanged_1);
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
            this.rad_ten.Location = new System.Drawing.Point(639, 23);
            this.rad_ten.Name = "rad_ten";
            this.rad_ten.Size = new System.Drawing.Size(146, 24);
            this.rad_ten.TabIndex = 1;
            this.rad_ten.TabStop = true;
            this.rad_ten.Text = "Tên chính sách";
            this.rad_ten.UseVisualStyleBackColor = true;
            this.rad_ten.CheckedChanged += new System.EventHandler(this.rad_ten_CheckedChanged_1);
            // 
            // rad_ma
            // 
            this.rad_ma.AutoSize = true;
            this.rad_ma.Location = new System.Drawing.Point(455, 23);
            this.rad_ma.Name = "rad_ma";
            this.rad_ma.Size = new System.Drawing.Size(143, 24);
            this.rad_ma.TabIndex = 0;
            this.rad_ma.TabStop = true;
            this.rad_ma.Text = "Mã chính sách";
            this.rad_ma.UseVisualStyleBackColor = true;
            this.rad_ma.CheckedChanged += new System.EventHandler(this.rad_ma_CheckedChanged_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(487, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timkiem_chinhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "timkiem_chinhsach";
            this.Text = "Tìm kiếm chính sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.timkiem_chinhsach_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_chinhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bang_chinhsach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label2;
        private QL_SinhVienDataSet1 qL_SinhVienDataSet1;
        private System.Windows.Forms.BindingSource chinhSachBindingSource;
        private QL_SinhVienDataSet1TableAdapters.ChinhSachTableAdapter chinhSachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chedochinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_cd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_ten;
        private System.Windows.Forms.RadioButton rad_ma;
        private System.Windows.Forms.Button button1;
    }
}