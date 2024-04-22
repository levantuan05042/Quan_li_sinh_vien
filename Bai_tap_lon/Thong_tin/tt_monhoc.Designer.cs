namespace Bai_tap_lon
{
    partial class tt_monhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tt_monhoc));
            this.label1 = new System.Windows.Forms.Label();
            this.qL_SinhVienDataSet8 = new Bai_tap_lon.QL_SinhVienDataSet8();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet8TableAdapters.KhoaTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_monhoc = new System.Windows.Forms.DataGridView();
            this.mamonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotietmonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magiaovienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet12 = new Bai_tap_lon.QL_SinhVienDataSet12();
            this.monHocTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet12TableAdapters.MonHocTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_magiaovien = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mamh = new System.Windows.Forms.TextBox();
            this.txt_sotiet = new System.Windows.Forms.TextBox();
            this.txt_tenmh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_monhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet12)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thông tin môn học";
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
            this.groupBox2.Controls.Add(this.bang_monhoc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1435, 583);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin môc học";
            // 
            // bang_monhoc
            // 
            this.bang_monhoc.AutoGenerateColumns = false;
            this.bang_monhoc.BackgroundColor = System.Drawing.Color.White;
            this.bang_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_monhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhocDataGridViewTextBoxColumn,
            this.tenmonhocDataGridViewTextBoxColumn,
            this.sotietmonhocDataGridViewTextBoxColumn,
            this.magiaovienDataGridViewTextBoxColumn});
            this.bang_monhoc.DataSource = this.monHocBindingSource;
            this.bang_monhoc.Location = new System.Drawing.Point(6, 27);
            this.bang_monhoc.Name = "bang_monhoc";
            this.bang_monhoc.RowHeadersWidth = 51;
            this.bang_monhoc.RowTemplate.Height = 24;
            this.bang_monhoc.Size = new System.Drawing.Size(1423, 550);
            this.bang_monhoc.TabIndex = 11;
            this.bang_monhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_monhoc_CellContentClick);
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
            this.monHocBindingSource.DataSource = this.qL_SinhVienDataSet12;
            // 
            // qL_SinhVienDataSet12
            // 
            this.qL_SinhVienDataSet12.DataSetName = "QL_SinhVienDataSet12";
            this.qL_SinhVienDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_magiaovien);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_mamh);
            this.groupBox1.Controls.Add(this.txt_sotiet);
            this.groupBox1.Controls.Add(this.txt_tenmh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1453, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 583);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mã giáo viên:";
            // 
            // txt_magiaovien
            // 
            this.txt_magiaovien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_magiaovien.Location = new System.Drawing.Point(6, 382);
            this.txt_magiaovien.Name = "txt_magiaovien";
            this.txt_magiaovien.Size = new System.Drawing.Size(337, 30);
            this.txt_magiaovien.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 54);
            this.button3.TabIndex = 34;
            this.button3.Text = "Báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 54);
            this.button2.TabIndex = 33;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 54);
            this.button1.TabIndex = 32;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Số tiết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên môn học: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã môn học: ";
            // 
            // txt_mamh
            // 
            this.txt_mamh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mamh.Location = new System.Drawing.Point(6, 147);
            this.txt_mamh.Name = "txt_mamh";
            this.txt_mamh.Size = new System.Drawing.Size(337, 30);
            this.txt_mamh.TabIndex = 28;
            // 
            // txt_sotiet
            // 
            this.txt_sotiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotiet.Location = new System.Drawing.Point(6, 309);
            this.txt_sotiet.Name = "txt_sotiet";
            this.txt_sotiet.Size = new System.Drawing.Size(337, 30);
            this.txt_sotiet.TabIndex = 27;
            // 
            // txt_tenmh
            // 
            this.txt_tenmh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenmh.Location = new System.Drawing.Point(6, 228);
            this.txt_tenmh.Name = "txt_tenmh";
            this.txt_tenmh.Size = new System.Drawing.Size(337, 30);
            this.txt_tenmh.TabIndex = 26;
            // 
            // tt_monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 698);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tt_monhoc";
            this.Text = "Thông tin môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tt_monhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_monhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet12)).EndInit();
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
        private System.Windows.Forms.DataGridView bang_monhoc;
        private QL_SinhVienDataSet12 qL_SinhVienDataSet12;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QL_SinhVienDataSet12TableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotietmonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiaovienDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mamh;
        private System.Windows.Forms.TextBox txt_sotiet;
        private System.Windows.Forms.TextBox txt_tenmh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_magiaovien;
    }
}