namespace Bai_tap_lon
{
    partial class baocao_gv
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baocao_gv));
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet17 = new Bai_tap_lon.QL_SinhVienDataSet17();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet22 = new Bai_tap_lon.QL_SinhVienDataSet22();
            this.chinhSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSinhVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_SinhVienDataSet = new Bai_tap_lon.QL_SinhVienDataSet();
            this.chinhSachTableAdapter = new Bai_tap_lon.QL_SinhVienDataSetTableAdapters.ChinhSachTableAdapter();
            this.sinhVienTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet22TableAdapters.SinhVienTableAdapter();
            this.giaoVienTableAdapter = new Bai_tap_lon.QL_SinhVienDataSet17TableAdapters.GiaoVienTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.qL_SinhVienDataSet17;
            // 
            // qL_SinhVienDataSet17
            // 
            this.qL_SinhVienDataSet17.DataSetName = "QL_SinhVienDataSet17";
            this.qL_SinhVienDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qL_SinhVienDataSet22;
            // 
            // qL_SinhVienDataSet22
            // 
            this.qL_SinhVienDataSet22.DataSetName = "QL_SinhVienDataSet22";
            this.qL_SinhVienDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chinhSachBindingSource
            // 
            this.chinhSachBindingSource.DataMember = "ChinhSach";
            this.chinhSachBindingSource.DataSource = this.qLSinhVienDataSetBindingSource;
            // 
            // qLSinhVienDataSetBindingSource
            // 
            this.qLSinhVienDataSetBindingSource.DataSource = this.qL_SinhVienDataSet;
            this.qLSinhVienDataSetBindingSource.Position = 0;
            // 
            // qL_SinhVienDataSet
            // 
            this.qL_SinhVienDataSet.DataSetName = "QL_SinhVienDataSet";
            this.qL_SinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chinhSachTableAdapter
            // 
            this.chinhSachTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.giaoVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bai_tap_lon.Bao_cao.baocao_gv.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("D:\\Desktop\\lap_trinh\\NET 2.0\\Bai_tap\\Bai_tap\\bin\\Debug\\barcode.rdlc", System.UriKind.Absolute);
            this.reportViewer1.Size = new System.Drawing.Size(1419, 779);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1311, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baocao_gv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 850);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "baocao_gv";
            this.Text = "Báo cáo danh sách giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.baocao_gv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QL_SinhVienDataSet22 qL_SinhVienDataSet22;
        private System.Windows.Forms.BindingSource chinhSachBindingSource;
        private System.Windows.Forms.BindingSource qLSinhVienDataSetBindingSource;
        private QL_SinhVienDataSet qL_SinhVienDataSet;
        private QL_SinhVienDataSetTableAdapters.ChinhSachTableAdapter chinhSachTableAdapter;
        private QL_SinhVienDataSet22TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private QL_SinhVienDataSet17 qL_SinhVienDataSet17;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private QL_SinhVienDataSet17TableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
    }
}