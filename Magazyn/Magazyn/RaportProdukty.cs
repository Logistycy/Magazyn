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
    public partial class RaportProdukty : Form
    {
        public RaportProdukty()
        {
            InitializeComponent();
        }

        private void RaportProdukty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Baza_magazynuDataSet.Produkty' table. You can move, or remove it, as needed.
            this.ProduktyTableAdapter.Fill(this.Baza_magazynuDataSet.Produkty);

            this.reportViewer1.RefreshReport();
        }
    }
}
