using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            
            string haslo = this.haslouzytkownikatxt.Text;

            if (sprawdzDaneLogowania(haslo))
            {

                MessageBox.Show("Zalogowano");

                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
               

            }
            else
                MessageBox.Show("Niepoprawne dane logowania");

        }

        public bool sprawdzDaneLogowania ( string haslo)
        {

            if (haslo == "admin")
            {
                return true;
            }

            else
                return false;
        }

        private void wyjdzZAplikacji_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void przegladaj_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Tryb Przeglądania");

            this.Hide();
            MainForm2 mf2 = new MainForm2();
            mf2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

       
    }
}
