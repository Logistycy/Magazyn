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
    public partial class Zamowienie_3 : Form
    {
        public Zamowienie_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamowienie_2 Z2 = new Zamowienie_2();

            Z2.Show();
            this.Close();
        }

        private void Zamowienie_3_Load(object sender, EventArgs e)
        {

        }
    }
}
