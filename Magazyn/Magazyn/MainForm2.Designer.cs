namespace Magazyn
{
    partial class MainForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Wyszukiwarka produktu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 21);
            this.button2.TabIndex = 19;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 369);
            this.dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 21);
            this.button1.TabIndex = 17;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
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
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 21;
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
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click_1);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click_1);
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
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(512, 530);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainForm2";
            this.Text = "Tryb Przeglądania";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wykresyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
        private Baza_magazynuDataSet baza_magazynuDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private Baza_magazynuDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem raportyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;
    }
}