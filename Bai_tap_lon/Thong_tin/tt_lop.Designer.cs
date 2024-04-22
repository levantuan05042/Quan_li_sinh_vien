namespace Bai_tap_lon
{
    partial class tt_lop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tt_lop));
            this.label1 = new System.Windows.Forms.Label();
            this.qL_SinhVienDataSet8 = new Bai_tap_lon.QL_SinhVienDataSet8();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet8TableAdapters.KhoaTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_lop = new System.Windows.Forms.DataGridView();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet10 = new Bai_tap_lon.QL_SinhVienDataSet10();
            this.lopTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet10TableAdapters.LopTableAdapter();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.txt_makhoa = new System.Windows.Forms.TextBox();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet10)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(788, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thông tin lớp";
            // 
            // qL_SinhVienDataSet8
            // 
            this.qL_SinhVienDataSet8.DataSetName = "QL_SinhVienDataSet8";
            this.qL_SinhVienDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qL_SinhVienDataSet8;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bang_lop);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1444, 583);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin lớp";
            // 
            // bang_lop
            // 
            this.bang_lop.AutoGenerateColumns = false;
            this.bang_lop.BackgroundColor = System.Drawing.Color.White;
            this.bang_lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malopDataGridViewTextBoxColumn,
            this.tenlopDataGridViewTextBoxColumn,
            this.makhoaDataGridViewTextBoxColumn});
            this.bang_lop.DataSource = this.lopBindingSource;
            this.bang_lop.Location = new System.Drawing.Point(8, 33);
            this.bang_lop.Name = "bang_lop";
            this.bang_lop.RowHeadersWidth = 51;
            this.bang_lop.RowTemplate.Height = 24;
            this.bang_lop.Size = new System.Drawing.Size(1430, 544);
            this.bang_lop.TabIndex = 11;
            this.bang_lop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_lop_CellContentClick);
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
            this.lopBindingSource.DataSource = this.qL_SinhVienDataSet10;
            // 
            // qL_SinhVienDataSet10
            // 
            this.qL_SinhVienDataSet10.DataSetName = "QL_SinhVienDataSet10";
            this.qL_SinhVienDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenlop.Location = new System.Drawing.Point(6, 228);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(337, 30);
            this.txt_tenlop.TabIndex = 26;
            // 
            // txt_makhoa
            // 
            this.txt_makhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makhoa.Location = new System.Drawing.Point(6, 309);
            this.txt_makhoa.Name = "txt_makhoa";
            this.txt_makhoa.Size = new System.Drawing.Size(337, 30);
            this.txt_makhoa.TabIndex = 27;
            // 
            // txt_malop
            // 
            this.txt_malop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_malop.Location = new System.Drawing.Point(6, 147);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(337, 30);
            this.txt_malop.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã lớp: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên lớp: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mã khoa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.txt_makhoa);
            this.groupBox1.Controls.Add(this.txt_tenlop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1454, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 583);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 54);
            this.button3.TabIndex = 37;
            this.button3.Text = "Báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 54);
            this.button2.TabIndex = 36;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 54);
            this.button1.TabIndex = 35;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tt_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tt_lop";
            this.Text = "Thông tin lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tt_lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet10)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private QL_SinhVienDataSet8 qL_SinhVienDataSet8;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QL_SinhVienDataSet8TableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bang_lop;
        private QL_SinhVienDataSet10 qL_SinhVienDataSet10;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QL_SinhVienDataSet10TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.TextBox txt_makhoa;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}