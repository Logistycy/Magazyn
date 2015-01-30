using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Magazyn
{
    public partial class Wykres_Produkty : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Michał\Desktop\Magazyn\Magazyn\Baza_magazynu.mdf;Integrated Security=True");

        public Wykres_Produkty()
        {
            InitializeComponent();
        }

        private void Wykres_Produkty_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Produkty ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            chart1.DataSource = dt;


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

    

       
      

       
    }
}
