namespace Magazyn
{
    partial class Zamowienie_2
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
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label nIPLabel;
            System.Windows.Forms.Label rEGONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zamowienie_2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.baza_magazynuDataSet = new Magazyn.Baza_magazynuDataSet();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new Magazyn.Baza_magazynuDataSetTableAdapters.KlienciTableAdapter();
            this.tableAdapterManager = new Magazyn.Baza_magazynuDataSetTableAdapters.TableAdapterManager();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.nIPTextBox = new System.Windows.Forms.TextBox();
            this.rEGONTextBox = new System.Windows.Forms.TextBox();
            this.btndalej = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            nazwaLabel = new System.Windows.Forms.Label();
            nIPLabel = new System.Windows.Forms.Label();
            rEGONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(186, 117);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(43, 13);
            nazwaLabel.TabIndex = 4;
            nazwaLabel.Text = "Nazwa:";
            // 
            // nIPLabel
            // 
            nIPLabel.AutoSize = true;
            nIPLabel.Location = new System.Drawing.Point(186, 143);
            nIPLabel.Name = "nIPLabel";
            nIPLabel.Size = new System.Drawing.Size(28, 13);
            nIPLabel.TabIndex = 6;
            nIPLabel.Text = "NIP:";
            // 
            // rEGONLabel
            // 
            rEGONLabel.AutoSize = true;
            rEGONLabel.Location = new System.Drawing.Point(186, 169);
            rEGONLabel.Name = "rEGONLabel";
            rEGONLabel.Size = new System.Drawing.Size(49, 13);
            rEGONLabel.TabIndex = 8;
            rEGONLabel.Text = "REGON:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // baza_magazynuDataSet
            // 
            this.baza_magazynuDataSet.DataSetName = "Baza_magazynuDataSet";
            this.baza_magazynuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.baza_magazynuDataSet;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlienciTableAdapter = this.klienciTableAdapter;
            this.tableAdapterManager.KlienciZamowieniaTableAdapter = null;
            this.tableAdapterManager.ProduktyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Magazyn.Baza_magazynuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zamowienia_ProduktyTableAdapter = null;
            this.tableAdapterManager.ZamowieniaTableAdapter = null;
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(246, 114);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaTextBox.TabIndex = 5;
            // 
            // nIPTextBox
            // 
            this.nIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "NIP", true));
            this.nIPTextBox.Location = new System.Drawing.Point(246, 140);
            this.nIPTextBox.MaxLength = 9;
            this.nIPTextBox.Name = "nIPTextBox";
            this.nIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.nIPTextBox.TabIndex = 7;
            // 
            // rEGONTextBox
            // 
            this.rEGONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "REGON", true));
            this.rEGONTextBox.Location = new System.Drawing.Point(246, 166);
            this.rEGONTextBox.MaxLength = 9;
            this.rEGONTextBox.Name = "rEGONTextBox";
            this.rEGONTextBox.Size = new System.Drawing.Size(100, 20);
            this.rEGONTextBox.TabIndex = 9;
            // 
            // btndalej
            // 
            this.btndalej.Location = new System.Drawing.Point(151, 222);
            this.btndalej.Name = "btndalej";
            this.btndalej.Size = new System.Drawing.Size(89, 29);
            this.btndalej.TabIndex = 10;
            this.btndalej.Text = "Dalej";
            this.btndalej.UseVisualStyleBackColor = true;
            this.btndalej.Click += new System.EventHandler(this.btndalej_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cofnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zamowienie_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndalej);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(nIPLabel);
            this.Controls.Add(this.nIPTextBox);
            this.Controls.Add(rEGONLabel);
            this.Controls.Add(this.rEGONTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Zamowienie_2";
            this.Text = "Zamowienie_2";
            this.Load += new System.EventHandler(this.Zamowienie_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_magazynuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Baza_magazynuDataSet baza_magazynuDataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private Baza_magazynuDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private Baza_magazynuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox nIPTextBox;
        private System.Windows.Forms.TextBox rEGONTextBox;
        private System.Windows.Forms.Button btndalej;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}