namespace Magazyn
{
    partial class Zamowienie_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zamowienie_3));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Zamowienia_ProduktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.KlienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Zamowienia_ProduktyTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.Zamowienia_ProduktyTableAdapter();
            this.KlienciTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.KlienciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Zamowienia_ProduktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_magazynuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KlienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Zamowienia_ProduktyBindingSource
            // 
            this.Zamowienia_ProduktyBindingSource.DataMember = "Zamowienia_Produkty";
            this.Zamowienia_ProduktyBindingSource.DataSource = this.Baza_magazynuDataSet;
            // 
            // Baza_magazynuDataSet
            // 
            this.Baza_magazynuDataSet.DataSetName = "Baza_magazynuDataSet";
            this.Baza_magazynuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KlienciBindingSource
            // 
            this.KlienciBindingSource.DataMember = "Klienci";
            this.KlienciBindingSource.DataSource = this.Baza_magazynuDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 53);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cofnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Zamów";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Zamowienia_ProduktyBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.KlienciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Magazyn.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(590, 336);
            this.reportViewer1.TabIndex = 14;
            // 
            // Zamowienia_ProduktyTableAdapter
            // 
            this.Zamowienia_ProduktyTableAdapter.ClearBeforeFill = true;
            // 
            // KlienciTableAdapter
            // 
            this.KlienciTableAdapter.ClearBeforeFill = true;
            // 
            // Zamowienie_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 462);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Zamowienie_3";
            this.Text = "Zamowienie_3";
            this.Load += new System.EventHandler(this.Zamowienie_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Zamowienia_ProduktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Baza_magazynuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KlienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Zamowienia_ProduktyBindingSource;
        private Baza_magazynuDataSet Baza_magazynuDataSet;
        private Baza_magazynuDataSetTableAdapters.Zamowienia_ProduktyTableAdapter Zamowienia_ProduktyTableAdapter;
        private System.Windows.Forms.BindingSource KlienciBindingSource;
        private Baza_magazynuDataSetTableAdapters.KlienciTableAdapter KlienciTableAdapter;
    }
}