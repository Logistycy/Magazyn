namespace Magazyn
{
    partial class DodajDoBazy
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
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.produktyTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtIdd = new System.Windows.Forms.Label();
            this.Nazwa = new System.Windows.Forms.Label();
            this.Ilosc = new System.Windows.Forms.Label();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idProduktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(82, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(82, 50);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(100, 20);
            this.txtNazwa.TabIndex = 1;
            // 
            // txtIdd
            // 
            this.txtIdd.AutoSize = true;
            this.txtIdd.Location = new System.Drawing.Point(34, 27);
            this.txtIdd.Name = "txtIdd";
            this.txtIdd.Size = new System.Drawing.Size(16, 13);
            this.txtIdd.TabIndex = 2;
            this.txtIdd.Text = "Id";
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSize = true;
            this.Nazwa.Location = new System.Drawing.Point(31, 56);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(40, 13);
            this.Nazwa.TabIndex = 3;
            this.Nazwa.Text = "Nazwa";
            // 
            // Ilosc
            // 
            this.Ilosc.AutoSize = true;
            this.Ilosc.Location = new System.Drawing.Point(34, 82);
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.Size = new System.Drawing.Size(29, 13);
            this.Ilosc.TabIndex = 4;
            this.Ilosc.Text = "Ilość";
            // 
            // txtIlosc
            // 
            this.txtIlosc.Location = new System.Drawing.Point(82, 82);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(100, 20);
            this.txtIlosc.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 129);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(77, 31);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduktDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(270, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 181);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idProduktDataGridViewTextBoxColumn
            // 
            this.idProduktDataGridViewTextBoxColumn.DataPropertyName = "Id_Produkt";
            this.idProduktDataGridViewTextBoxColumn.HeaderText = "Id_Produkt";
            this.idProduktDataGridViewTextBoxColumn.Name = "idProduktDataGridViewTextBoxColumn";
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // ilośćDataGridViewTextBoxColumn
            // 
            this.ilośćDataGridViewTextBoxColumn.DataPropertyName = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.Name = "ilośćDataGridViewTextBoxColumn";
            // 
            // DodajDoBazy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 265);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.Ilosc);
            this.Controls.Add(this.Nazwa);
            this.Controls.Add(this.txtIdd);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.txtId);
            this.Name = "DodajDoBazy";
            this.Text = "DodajDoBazy";
            this.Load += new System.EventHandler(this.DodajDoBazy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza_magazynuDataSet baza_magazynuDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label txtIdd;
        private System.Windows.Forms.Label Nazwa;
        private System.Windows.Forms.Label Ilosc;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
    }
}