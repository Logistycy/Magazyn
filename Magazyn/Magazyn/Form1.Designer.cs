namespace Magazyn
{
    partial class Form1
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
            this.haslouzytkownikatxt = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.haslotxt = new System.Windows.Forms.Label();
            this.wyjdzZAplikacji = new System.Windows.Forms.Button();
            this.przegladaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // haslouzytkownikatxt
            // 
            this.haslouzytkownikatxt.Location = new System.Drawing.Point(216, 53);
            this.haslouzytkownikatxt.Name = "haslouzytkownikatxt";
            this.haslouzytkownikatxt.Size = new System.Drawing.Size(135, 20);
            this.haslouzytkownikatxt.TabIndex = 1;
            this.haslouzytkownikatxt.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(120, 133);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(99, 60);
            this.login.TabIndex = 2;
            this.login.Text = "Zaloguj";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // haslotxt
            // 
            this.haslotxt.AutoSize = true;
            this.haslotxt.Location = new System.Drawing.Point(165, 56);
            this.haslotxt.Name = "haslotxt";
            this.haslotxt.Size = new System.Drawing.Size(36, 13);
            this.haslotxt.TabIndex = 4;
            this.haslotxt.Text = "Hasło";
            // 
            // wyjdzZAplikacji
            // 
            this.wyjdzZAplikacji.Location = new System.Drawing.Point(336, 133);
            this.wyjdzZAplikacji.Name = "wyjdzZAplikacji";
            this.wyjdzZAplikacji.Size = new System.Drawing.Size(99, 60);
            this.wyjdzZAplikacji.TabIndex = 5;
            this.wyjdzZAplikacji.Text = "Zakończ";
            this.wyjdzZAplikacji.UseVisualStyleBackColor = true;
            this.wyjdzZAplikacji.Click += new System.EventHandler(this.wyjdzZAplikacji_Click);
            // 
            // przegladaj
            // 
            this.przegladaj.Location = new System.Drawing.Point(225, 133);
            this.przegladaj.Name = "przegladaj";
            this.przegladaj.Size = new System.Drawing.Size(105, 60);
            this.przegladaj.TabIndex = 6;
            this.przegladaj.Text = "Przeglądaj";
            this.przegladaj.UseVisualStyleBackColor = true;
            this.przegladaj.Click += new System.EventHandler(this.przegladaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 313);
            this.Controls.Add(this.przegladaj);
            this.Controls.Add(this.wyjdzZAplikacji);
            this.Controls.Add(this.haslotxt);
            this.Controls.Add(this.login);
            this.Controls.Add(this.haslouzytkownikatxt);
            this.Name = "Form1";
            this.Text = "Okno Logowania";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox haslouzytkownikatxt;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label haslotxt;
        private System.Windows.Forms.Button wyjdzZAplikacji;
        private System.Windows.Forms.Button przegladaj;
    }
}

