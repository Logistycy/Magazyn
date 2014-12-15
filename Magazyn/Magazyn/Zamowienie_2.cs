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
    public partial class Zamowienie_2 : Form
    {
        public Zamowienie_2()
        {
            InitializeComponent();
        }

    
        private void Zamowienie_2_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Zamowienie_3 Z3 = new Zamowienie_3();

            Z3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamowienie_1 Z1 = new Zamowienie_1();

            Z1.Show();
            this.Close();
        }

       
    }
}
