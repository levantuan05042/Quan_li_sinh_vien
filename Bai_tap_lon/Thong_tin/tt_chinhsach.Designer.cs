namespace Bai_tap_lon
{
    partial class tt_chinhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tt_chinhsach));
            this.label1 = new System.Windows.Forms.Label();
            this.qL_SinhVienDataSet8 = new Bai_tap_lon.QL_SinhVienDataSet8();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet8TableAdapters.KhoaTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bang_chinhsach = new System.Windows.Forms.DataGridView();
            this.machinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chedochinhsachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinhSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet13 = new Bai_tap_lon.QL_SinhVienDataSet13();
            this.chinhSachTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet13TableAdapters.ChinhSachTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_machinhsach = new System.Windows.Forms.TextBox();
            this.txt_chedo = new System.Windows.Forms.TextBox();
            this.txt_tenchinhsach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang_chinhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet13)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(730, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thông tin chính sách";
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
            this.groupBox2.Controls.Add(this.bang_chinhsach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1427, 583);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chính sách";
            // 
            // bang_chinhsach
            // 
            this.bang_chinhsach.AutoGenerateColumns = false;
            this.bang_chinhsach.BackgroundColor = System.Drawing.Color.White;
            this.bang_chinhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_chinhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machinhsachDataGridViewTextBoxColumn,
            this.tenchinhsachDataGridViewTextBoxColumn,
            this.chedochinhsachDataGridViewTextBoxColumn});
            this.bang_chinhsach.DataSource = this.chinhSachBindingSource;
            this.bang_chinhsach.Location = new System.Drawing.Point(6, 27);
            this.bang_chinhsach.Name = "bang_chinhsach";
            this.bang_chinhsach.RowHeadersWidth = 51;
            this.bang_chinhsach.RowTemplate.Height = 24;
            this.bang_chinhsach.Size = new System.Drawing.Size(1415, 550);
            this.bang_chinhsach.TabIndex = 11;
            this.bang_chinhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_chinhsach_CellContentClick);
            // 
            // machinhsachDataGridViewTextBoxColumn
            // 
            this.machinhsachDataGridViewTextBoxColumn.DataPropertyName = "ma_chinhsach";
            this.machinhsachDataGridViewTextBoxColumn.HeaderText = "Mã chính sách";
            this.machinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machinhsachDataGridViewTextBoxColumn.Name = "machinhsachDataGridViewTextBoxColumn";
            this.machinhsachDataGridViewTextBoxColumn.Width = 200;
            // 
            // tenchinhsachDataGridViewTextBoxColumn
            // 
            this.tenchinhsachDataGridViewTextBoxColumn.DataPropertyName = "ten_chinhsach";
            this.tenchinhsachDataGridViewTextBoxColumn.HeaderText = "Tên chính sách";
            this.tenchinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenchinhsachDataGridViewTextBoxColumn.Name = "tenchinhsachDataGridViewTextBoxColumn";
            this.tenchinhsachDataGridViewTextBoxColumn.Width = 200;
            // 
            // chedochinhsachDataGridViewTextBoxColumn
            // 
            this.chedochinhsachDataGridViewTextBoxColumn.DataPropertyName = "chedo_chinhsach";
            this.chedochinhsachDataGridViewTextBoxColumn.HeaderText = "Chế độ";
            this.chedochinhsachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chedochinhsachDataGridViewTextBoxColumn.Name = "chedochinhsachDataGridViewTextBoxColumn";
            this.chedochinhsachDataGridViewTextBoxColumn.Width = 200;
            // 
            // chinhSachBindingSource
            // 
            this.chinhSachBindingSource.DataMember = "ChinhSach";
            this.chinhSachBindingSource.DataSource = this.qL_SinhVienDataSet13;
            // 
            // qL_SinhVienDataSet13
            // 
            this.qL_SinhVienDataSet13.DataSetName = "QL_SinhVienDataSet13";
            this.qL_SinhVienDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chinhSachTableAdapter
            // 
            this.chinhSachTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.Controls.Add(this.txt_machinhsach);
            this.groupBox1.Controls.Add(this.txt_chedo);
            this.groupBox1.Controls.Add(this.txt_tenchinhsach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1445, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 583);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chính sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 42);
            this.button3.TabIndex = 34;
            this.button3.Text = "Báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 42);
            this.button2.TabIndex = 33;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 355);
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
            this.label3.Location = new System.Drawing.Point(6, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Chế độ chính sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên chính sách: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã chính sách: ";
            // 
            // txt_machinhsach
            // 
            this.txt_machinhsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_machinhsach.Location = new System.Drawing.Point(6, 147);
            this.txt_machinhsach.Name = "txt_machinhsach";
            this.txt_machinhsach.Size = new System.Drawing.Size(337, 30);
            this.txt_machinhsach.TabIndex = 28;
            // 
            // txt_chedo
            // 
            this.txt_chedo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chedo.Location = new System.Drawing.Point(6, 309);
            this.txt_chedo.Name = "txt_chedo";
            this.txt_chedo.Size = new System.Drawing.Size(337, 30);
            this.txt_chedo.TabIndex = 27;
            // 
            // txt_tenchinhsach
            // 
            this.txt_tenchinhsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenchinhsach.Location = new System.Drawing.Point(6, 228);
            this.txt_tenchinhsach.Name = "txt_tenchinhsach";
            this.txt_tenchinhsach.Size = new System.Drawing.Size(337, 30);
            this.txt_tenchinhsach.TabIndex = 26;
            // 
            // tt_chinhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 705);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tt_chinhsach";
            this.Text = "Thông tin chính sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tt_chinhsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang_chinhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet13)).EndInit();
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
        private System.Windows.Forms.DataGridView bang_chinhsach;
        private QL_SinhVienDataSet13 qL_SinhVienDataSet13;
        private System.Windows.Forms.BindingSource chinhSachBindingSource;
        private QL_SinhVienDataSet13TableAdapters.ChinhSachTableAdapter chinhSachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chedochinhsachDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_machinhsach;
        private System.Windows.Forms.TextBox txt_chedo;
        private System.Windows.Forms.TextBox txt_tenchinhsach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}