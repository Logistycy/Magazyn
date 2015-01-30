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
    public partial class Zamowienie_3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Michał\Desktop\Magazyn\Magazyn\Baza_magazynu.mdf;Integrated Security=True");



        public Zamowienie_3()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Klienci where Id_Klienta = (select max(Id_Klienta) from Klienci)";
                //  cmd.ExecuteNonQuery();
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows == 1)
                {

                }
                if (affectedRows == 0)
                {
                    MessageBox.Show("Błąd !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            Zamowienie_2 Z2 = new Zamowienie_2();

            Z2.Show();
            this.Close();
        }

        private void Zamowienie_3_Load(object sender, EventArgs e)
        {

            this.Zamowienia_ProduktyTableAdapter.Fill(this.Baza_magazynuDataSet.Zamowienia_Produkty);
            this.KlienciTableAdapter.Fill(this.Baza_magazynuDataSet.Klienci);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Zamowienia_Produkty", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ds.Tables[0].TableName = "Zamowienia_Produkty";

            this.Zamowienia_ProduktyBindingSource.DataSource = ds;


            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Klienci", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            ds2.Tables[0].TableName = "Klienci";

            this.KlienciBindingSource.DataSource = ds2;

            this.reportViewer1.RefreshReport();

        }

        private void button2_Click(object sender, EventArgs e)
        {



            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Zamowienia (Id_Zamówienia) SELECT MAX(Id_Zamówienia)+1 FROM ZAMOWIENIA";

            cmd.ExecuteNonQuery();



            string a, b;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = " SELECT MAX(Id_Zamówienia) FROM ZAMOWIENIA";

            cmd2.ExecuteNonQuery();
            a = cmd2.ExecuteScalar().ToString();


            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = " SELECT MAX(Id_Klienta) FROM Klienci";

            cmd3.ExecuteNonQuery();
            b = cmd3.ExecuteScalar().ToString();

            SqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "INSERT INTO KlienciZamowienia (FK_Zamowienia,FK_Klienci) values(" + a + ", " + b + ");";

            cmd4.ExecuteNonQuery();

            MessageBox.Show("Dokonano zamówienia", "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }



    }
}
