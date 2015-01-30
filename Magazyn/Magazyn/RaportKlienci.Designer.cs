namespace Magazyn
{
    partial class RaportKlienci
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
            this.KlienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KlienciTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.KlienciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KlienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_magazynuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // KlienciBindingSource
            // 
            this.KlienciBindingSource.DataMember = "Klienci";
            this.KlienciBindingSource.DataSource = this.Baza_magazynuDataSet;
            // 
            // Baza_magazynuDataSet
            // 
            this.Baza_magazynuDataSet.DataSetName = "Baza_magazynuDataSet";
            this.Baza_magazynuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KlienciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Magazyn.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(653, 321);
            this.reportViewer1.TabIndex = 0;
            // 
            // KlienciTableAdapter
            // 
            this.KlienciTableAdapter.ClearBeforeFill = true;
            // 
            // RaportKlienci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 319);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportKlienci";
            this.Text = "RaportKlient";
            this.Load += new System.EventHandler(this.RaportKlienci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KlienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_magazynuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KlienciBindingSource;
        private Baza_magazynuDataSet Baza_magazynuDataSet;
        private Baza_magazynuDataSetTableAdapters.KlienciTableAdapter KlienciTableAdapter;
    }
}