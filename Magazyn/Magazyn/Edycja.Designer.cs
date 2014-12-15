namespace Magazyn
{
    partial class Edycja
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
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label ilośćLabel;
            this.baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter();
            this.tableAdapterManager = new Magazyn.Baza_magazynuDataSetTableAdapters.TableAdapterManager();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProduktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id_ProduktTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.ilośćTextBox = new System.Windows.Forms.TextBox();
            id_ProduktLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            ilośćLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ProduktLabel
            // 
            id_ProduktLabel.AutoSize = true;
            id_ProduktLabel.Location = new System.Drawing.Point(34, 49);
            id_ProduktLabel.Name = "id_ProduktLabel";
            id_ProduktLabel.Size = new System.Drawing.Size(59, 13);
            id_ProduktLabel.TabIndex = 2;
            id_ProduktLabel.Text = "Id Produkt:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(34, 139);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(43, 13);
            nazwaLabel.TabIndex = 4;
            nazwaLabel.Text = "Nazwa:";
            // 
            // ilośćLabel
            // 
            ilośćLabel.AutoSize = true;
            ilośćLabel.Location = new System.Drawing.Point(34, 165);
            ilośćLabel.Name = "ilośćLabel";
            ilośćLabel.Size = new System.Drawing.Size(32, 13);
            ilośćLabel.TabIndex = 6;
            ilośćLabel.Text = "Ilość:";
            // 
            // baza_magazynuDataSet
            // 
            this.baza_magazynuDataSet.DataSetName = "Baza_magazynuDataSet";
            this.baza_magazynuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.baza_magazynuDataSet;
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 223);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 40);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(233, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 229);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_ProduktTextBox
            // 
            this.id_ProduktTextBox.Location = new System.Drawing.Point(99, 49);
            this.id_ProduktTextBox.Name = "id_ProduktTextBox";
            this.id_ProduktTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_ProduktTextBox.TabIndex = 12;
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.Location = new System.Drawing.Point(99, 132);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaTextBox.TabIndex = 13;
            // 
            // ilośćTextBox
            // 
            this.ilośćTextBox.Location = new System.Drawing.Point(99, 158);
            this.ilośćTextBox.Name = "ilośćTextBox";
            this.ilośćTextBox.Size = new System.Drawing.Size(100, 20);
            this.ilośćTextBox.TabIndex = 14;
            // 
            // Edycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 328);
            this.Controls.Add(this.ilośćTextBox);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(this.id_ProduktTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(id_ProduktLabel);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(ilośćLabel);
            this.Name = "Edycja";
            this.Text = "Edycja";
            this.Load += new System.EventHandler(this.Edycja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Baza_magazynuDataSet baza_magazynuDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private Baza_magazynuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox id_ProduktTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox ilośćTextBox;
    }
}