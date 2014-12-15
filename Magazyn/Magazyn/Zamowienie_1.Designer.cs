namespace Magazyn
{
    partial class Zamowienie_1
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
            System.Windows.Forms.Label id_ProduktLabel;
            System.Windows.Forms.Label ilośćLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zamowienie_1));
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.produktyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ProduktTextBox = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnZamow = new System.Windows.Forms.Button();
            this.produktyTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter();
            this.tableAdapterManager = new Magazyn.Baza_magazynuDataSetTableAdapters.TableAdapterManager();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idProduktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniaProduktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.zamowienia_ProduktyTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.Zamowienia_ProduktyTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ilośćTextBox = new System.Windows.Forms.TextBox();
            this.textboxwpisana = new System.Windows.Forms.TextBox();
            id_ProduktLabel = new System.Windows.Forms.Label();
            ilośćLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaProduktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ProduktLabel
            // 
            id_ProduktLabel.AutoSize = true;
            id_ProduktLabel.BackColor = System.Drawing.Color.Transparent;
            id_ProduktLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            id_ProduktLabel.Location = new System.Drawing.Point(46, 113);
            id_ProduktLabel.Name = "id_ProduktLabel";
            id_ProduktLabel.Size = new System.Drawing.Size(59, 13);
            id_ProduktLabel.TabIndex = 2;
            id_ProduktLabel.Text = "Id Produkt:";
            // 
            // ilośćLabel
            // 
            ilośćLabel.AutoSize = true;
            ilośćLabel.BackColor = System.Drawing.Color.Transparent;
            ilośćLabel.Location = new System.Drawing.Point(46, 165);
            ilośćLabel.Name = "ilośćLabel";
            ilośćLabel.Size = new System.Drawing.Size(32, 13);
            ilośćLabel.TabIndex = 6;
            ilośćLabel.Text = "Ilość:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.BackColor = System.Drawing.Color.Transparent;
            nazwaLabel.Location = new System.Drawing.Point(46, 139);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(43, 13);
            nazwaLabel.TabIndex = 4;
            nazwaLabel.Text = "Nazwa:";
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
            // produktyDataGridView
            // 
            this.produktyDataGridView.AutoGenerateColumns = false;
            this.produktyDataGridView.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.produktyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produktyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.produktyDataGridView.DataSource = this.produktyBindingSource;
            this.produktyDataGridView.Location = new System.Drawing.Point(245, 69);
            this.produktyDataGridView.Name = "produktyDataGridView";
            this.produktyDataGridView.Size = new System.Drawing.Size(315, 256);
            this.produktyDataGridView.TabIndex = 1;
            this.produktyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produktyDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Produkt";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Produkt";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nazwa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ilość";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ilość";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // id_ProduktTextBox
            // 
            this.id_ProduktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktyBindingSource, "Id_Produkt", true));
            this.id_ProduktTextBox.Enabled = false;
            this.id_ProduktTextBox.Location = new System.Drawing.Point(111, 110);
            this.id_ProduktTextBox.Name = "id_ProduktTextBox";
            this.id_ProduktTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_ProduktTextBox.TabIndex = 3;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnexit.Location = new System.Drawing.Point(144, 213);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 44);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Anuluj";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnZamow
            // 
            this.btnZamow.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnZamow.Location = new System.Drawing.Point(22, 213);
            this.btnZamow.Name = "btnZamow";
            this.btnZamow.Size = new System.Drawing.Size(99, 44);
            this.btnZamow.TabIndex = 9;
            this.btnZamow.Text = "Dodaj do koszyka";
            this.btnZamow.UseVisualStyleBackColor = false;
            this.btnZamow.Click += new System.EventHandler(this.btnZamow_Click_1);
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlienciTableAdapter = null;
            this.tableAdapterManager.KlienciZamowieniaTableAdapter = null;
            this.tableAdapterManager.ProduktyTableAdapter = this.produktyTableAdapter;
            this.tableAdapterManager.UpdateOrder = Magazyn.Baza_magazynuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zamowienia_ProduktyTableAdapter = null;
            this.tableAdapterManager.ZamowieniaTableAdapter = null;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduktDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.zamowieniaProduktyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(46, 352);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(345, 108);
            this.dataGridView2.TabIndex = 11;
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
            // zamowieniaProduktyBindingSource
            // 
            this.zamowieniaProduktyBindingSource.DataMember = "Zamowienia_Produkty";
            this.zamowieniaProduktyBindingSource.DataSource = this.baza_magazynuDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(241, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dalej";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktyBindingSource, "Nazwa", true));
            this.nazwaTextBox.Enabled = false;
            this.nazwaTextBox.Location = new System.Drawing.Point(111, 136);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaTextBox.TabIndex = 5;
            // 
            // zamowienia_ProduktyTableAdapter
            // 
            this.zamowienia_ProduktyTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 48);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ilośćTextBox
            // 
            this.ilośćTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktyBindingSource, "Ilość", true));
            this.ilośćTextBox.Enabled = false;
            this.ilośćTextBox.Location = new System.Drawing.Point(111, 162);
            this.ilośćTextBox.Name = "ilośćTextBox";
            this.ilośćTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ilośćTextBox.Size = new System.Drawing.Size(100, 20);
            this.ilośćTextBox.TabIndex = 7;
            this.ilośćTextBox.TextChanged += new System.EventHandler(this.ilośćTextBox_TextChanged);
            // 
            // textboxwpisana
            // 
            this.textboxwpisana.Location = new System.Drawing.Point(111, 189);
            this.textboxwpisana.Name = "textboxwpisana";
            this.textboxwpisana.Size = new System.Drawing.Size(100, 20);
            this.textboxwpisana.TabIndex = 15;
            // 
            // Zamowienie_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(567, 520);
            this.Controls.Add(this.textboxwpisana);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnZamow);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(id_ProduktLabel);
            this.Controls.Add(this.id_ProduktTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(ilośćLabel);
            this.Controls.Add(this.ilośćTextBox);
            this.Controls.Add(this.produktyDataGridView);
            this.Name = "Zamowienie_1";
            this.Text = "Zamowienie_1";
            this.Load += new System.EventHandler(this.Zamowienie_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaProduktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza_magazynuDataSet baza_magazynuDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private Baza_magazynuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView produktyDataGridView;
        private System.Windows.Forms.TextBox id_ProduktTextBox;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnZamow;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.BindingSource zamowieniaProduktyBindingSource;
        private Baza_magazynuDataSetTableAdapters.Zamowienia_ProduktyTableAdapter zamowienia_ProduktyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ilośćTextBox;
        private System.Windows.Forms.TextBox textboxwpisana;
    }
}