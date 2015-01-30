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
    public partial class RaportKlienci : Form
    {
        public RaportKlienci()
        {
            InitializeComponent();
        }

        private void RaportKlienci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Baza_magazynuDataSet.Klienci' table. You can move, or remove it, as needed.
            this.KlienciTableAdapter.Fill(this.Baza_magazynuDataSet.Klienci);

            this.reportViewer1.RefreshReport();
        }
    }
}
