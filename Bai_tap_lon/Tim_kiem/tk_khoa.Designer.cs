namespace Bai_tap_lon
{
    partial class tk_khoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tk_khoa));
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_ten = new System.Windows.Forms.RadioButton();
            this.rad_ma = new System.Windows.Forms.RadioButton();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_khoa = new System.Windows.Forms.DataGridView();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet15 = new Bai_tap_lon.QL_SinhVienDataSet15();
            this.khoaTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet15TableAdapters.KhoaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "TÌM KIẾM THÔNG TIN KHOA";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(629, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(325, 214);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(131, 34);
            this.btn_timkiem.TabIndex = 17;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rad_ten);
            this.groupBox1.Controls.Add(this.rad_ma);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 67);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm theo: ";
            // 
            // rad_ten
            // 
            this.rad_ten.AutoSize = true;
            this.rad_ten.Location = new System.Drawing.Point(650, 27);
            this.rad_ten.Name = "rad_ten";
            this.rad_ten.Size = new System.Drawing.Size(103, 24);
            this.rad_ten.TabIndex = 1;
            this.rad_ten.TabStop = true;
            this.rad_ten.Text = "Tên khoa";
            this.rad_ten.UseVisualStyleBackColor = true;
            this.rad_ten.CheckedChanged += new System.EventHandler(this.rad_ten_CheckedChanged);
            // 
            // rad_ma
            // 
            this.rad_ma.AutoSize = true;
            this.rad_ma.Location = new System.Drawing.Point(495, 27);
            this.rad_ma.Name = "rad_ma";
            this.rad_ma.Size = new System.Drawing.Size(100, 24);
            this.rad_ma.TabIndex = 0;
            this.rad_ma.TabStop = true;
            this.rad_ma.Text = "Mã khoa";
            this.rad_ma.UseVisualStyleBackColor = true;
            this.rad_ma.CheckedChanged += new System.EventHandler(this.rad_ma_CheckedChanged);
            // 
            // txt_tk
            // 
            this.txt_tk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(325, 174);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(436, 28);
            this.txt_tk.TabIndex = 16;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_khoa);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 390);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khoa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bang_khoa
            // 
            this.bang_khoa.AutoGenerateColumns = false;
            this.bang_khoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bang_khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_khoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoaDataGridViewTextBoxColumn,
            this.tenkhoaDataGridViewTextBoxColumn});
            this.bang_khoa.DataSource = this.khoaBindingSource;
            this.bang_khoa.Location = new System.Drawing.Point(6, 45);
            this.bang_khoa.Name = "bang_khoa";
            this.bang_khoa.RowHeadersWidth = 51;
            this.bang_khoa.RowTemplate.Height = 24;
            this.bang_khoa.Size = new System.Drawing.Size(1005, 339);
            this.bang_khoa.TabIndex = 0;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qL_SinhVienDataSet15;
            // 
            // qL_SinhVienDataSet15
            // 
            this.qL_SinhVienDataSet15.DataSetName = "QL_SinhVienDataSet15";
            this.qL_SinhVienDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(477, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // makhoaDataGridViewTextBoxColumn
            // 
            this.makhoaDataGridViewTextBoxColumn.DataPropertyName = "ma_khoa";
            this.makhoaDataGridViewTextBoxColumn.HeaderText = "Mã khoa";
            this.makhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makhoaDataGridViewTextBoxColumn.Name = "makhoaDataGridViewTextBoxColumn";
            this.makhoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenkhoaDataGridViewTextBoxColumn
            // 
            this.tenkhoaDataGridViewTextBoxColumn.DataPropertyName = "ten_khoa";
            this.tenkhoaDataGridViewTextBoxColumn.HeaderText = "Tên khoa";
            this.tenkhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenkhoaDataGridViewTextBoxColumn.Name = "tenkhoaDataGridViewTextBoxColumn";
            this.tenkhoaDataGridViewTextBoxColumn.Width = 200;
            // 
            // tk_khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_tk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tk_khoa";
            this.Text = "Tìm kiếm khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tk_khoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet15)).EndInit();
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
        private System.Windows.Forms.DataGridView bang_khoa;
        private QL_SinhVienDataSet15 qL_SinhVienDataSet15;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QL_SinhVienDataSet15TableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoaDataGridViewTextBoxColumn;
    }
}