namespace Magazyn
{
    partial class Wykres_Produkty
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.produktyTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.produktyBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ilość produktów w magazynie";
            series1.XValueMember = "Nazwa";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueMembers = "Ilość";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(777, 423);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.baza_magazynuDataSet;
            // 
            // baza_magazynuDataSet
            // 
            this.baza_magazynuDataSet.DataSetName = "Baza_magazynuDataSet";
            this.baza_magazynuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // Wykres_Produkty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 423);
            this.Controls.Add(this.chart1);
            this.Name = "Wykres_Produkty";
            this.Text = "Wykres_Produkty";
            this.Load += new System.EventHandler(this.Wykres_Produkty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Baza_magazynuDataSet baza_magazynuDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
    }
}