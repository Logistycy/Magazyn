namespace Magazyn
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.klienciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdycja = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.klienciZamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazamagazynuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter();
            this.produktyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.KlienciTableAdapter();
            this.klienciZamowieniaTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.KlienciZamowieniaTableAdapter();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowieniaTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.ZamowieniaTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnZamowienie = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klienciZamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazamagazynuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacjaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.wykresyToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.autorzyToolStripMenuItem,
            this.raportyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacjaToolStripMenuItem
            // 
            this.aplikacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.aplikacjaToolStripMenuItem.Name = "aplikacjaToolStripMenuItem";
            this.aplikacjaToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.aplikacjaToolStripMenuItem.Text = "Plik";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // wykresyToolStripMenuItem
            // 
            this.wykresyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produktyToolStripMenuItem});
            this.wykresyToolStripMenuItem.Name = "wykresyToolStripMenuItem";
            this.wykresyToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wykresyToolStripMenuItem.Text = "Wykresy";
            // 
            // produktyToolStripMenuItem
            // 
            this.produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            this.produktyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produktyToolStripMenuItem.Text = "Produkty";
            this.produktyToolStripMenuItem.Click += new System.EventHandler(this.produktyToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // autorzyToolStripMenuItem
            // 
            this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
            this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autorzyToolStripMenuItem.Text = "Autorzy";
            this.autorzyToolStripMenuItem.Click += new System.EventHandler(this.autorzyToolStripMenuItem_Click);
            // 
            // raportyToolStripMenuItem
            // 
            this.raportyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produktyToolStripMenuItem1,
            this.klienciToolStripMenuItem});
            this.raportyToolStripMenuItem.Name = "raportyToolStripMenuItem";
            this.raportyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.raportyToolStripMenuItem.Text = "Raporty";
            // 
            // produktyToolStripMenuItem1
            // 
            this.produktyToolStripMenuItem1.Name = "produktyToolStripMenuItem1";
            this.produktyToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.produktyToolStripMenuItem1.Text = "Produkty";
            this.produktyToolStripMenuItem1.Click += new System.EventHandler(this.produktyToolStripMenuItem1_Click);
            // 
            // klienciToolStripMenuItem
            // 
            this.klienciToolStripMenuItem.Name = "klienciToolStripMenuItem";
            this.klienciToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.klienciToolStripMenuItem.Text = "Klienci";
            this.klienciToolStripMenuItem.Click += new System.EventHandler(this.klienciToolStripMenuItem_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(29, 80);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdycja
            // 
            this.btnEdycja.Location = new System.Drawing.Point(29, 109);
            this.btnEdycja.Name = "btnEdycja";
            this.btnEdycja.Size = new System.Drawing.Size(75, 23);
            this.btnEdycja.TabIndex = 4;
            this.btnEdycja.Text = "Edycja";
            this.btnEdycja.UseVisualStyleBackColor = true;
            this.btnEdycja.Click += new System.EventHandler(this.btnEdycja_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(29, 138);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // klienciZamowieniaBindingSource
            // 
            this.klienciZamowieniaBindingSource.DataMember = "KlienciZamowienia";
            this.klienciZamowieniaBindingSource.DataSource = this.bazamagazynuDataSetBindingSource;
            // 
            // bazamagazynuDataSetBindingSource
            // 
            this.bazamagazynuDataSetBindingSource.DataSource = this.baza_magazynuDataSet;
            this.bazamagazynuDataSetBindingSource.Position = 0;
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
            // produktyBindingSource1
            // 
            this.produktyBindingSource1.DataMember = "Produkty";
            this.produktyBindingSource1.DataSource = this.bazamagazynuDataSetBindingSource;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.bazamagazynuDataSetBindingSource;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // klienciZamowieniaTableAdapter
            // 
            this.klienciZamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataMember = "Zamowienia";
            this.zamowieniaBindingSource.DataSource = this.bazamagazynuDataSetBindingSource;
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 21);
            this.button2.TabIndex = 11;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Wyszukiwarka produktu";
            // 
            // btnZamowienie
            // 
            this.btnZamowienie.Location = new System.Drawing.Point(29, 223);
            this.btnZamowienie.Name = "btnZamowienie";
            this.btnZamowienie.Size = new System.Drawing.Size(75, 23);
            this.btnZamowienie.TabIndex = 13;
            this.btnZamowienie.Text = "Zamówienie";
            this.btnZamowienie.UseVisualStyleBackColor = true;
            this.btnZamowienie.Click += new System.EventHandler(this.btnZamowienie_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 83);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(386, 342);
            this.dataGridView1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(543, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnZamowienie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdycja);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Magazyn-Szef";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klienciZamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazamagazynuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aplikacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private Baza_magazynuDataSet baza_magazynuDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdycja;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bazamagazynuDataSetBindingSource;
        private System.Windows.Forms.BindingSource produktyBindingSource1;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private Baza_magazynuDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.BindingSource klienciZamowieniaBindingSource;
        private Baza_magazynuDataSetTableAdapters.KlienciZamowieniaTableAdapter klienciZamowieniaTableAdapter;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private Baza_magazynuDataSetTableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem wykresyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
        private System.Windows.Forms.Button btnZamowienie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem raportyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;

    }
}