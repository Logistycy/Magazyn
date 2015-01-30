namespace Magazyn
{
    partial class RaportProdukty
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
            this.ProduktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProduktyTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProduktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_magazynuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProduktyBindingSource
            // 
            this.ProduktyBindingSource.DataMember = "Produkty";
            this.ProduktyBindingSource.DataSource = this.Baza_magazynuDataSet;
            // 
            // Baza_magazynuDataSet
            // 
            this.Baza_magazynuDataSet.DataSetName = "Baza_magazynuDataSet";
            this.Baza_magazynuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProduktyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Magazyn.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProduktyTableAdapter
            // 
            this.ProduktyTableAdapter.ClearBeforeFill = true;
            // 
            // RaportProdukty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 349);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportProdukty";
            this.Text = "RaportProdukty";
            this.Load += new System.EventHandler(this.RaportProdukty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProduktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_magazynuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProduktyBindingSource;
        private Baza_magazynuDataSet Baza_magazynuDataSet;
        private Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter ProduktyTableAdapter;
    }
}