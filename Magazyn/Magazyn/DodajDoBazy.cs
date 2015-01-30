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
    public partial class DodajDoBazy : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Michał\Desktop\Magazyn\Magazyn\Baza_magazynu.mdf;Integrated Security=True");


        public DodajDoBazy()
        {


            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {


            try
            {
                if (con.State == ConnectionState.Open)
                {

                    con.Close();

                }


                

                if ((String.IsNullOrEmpty(txtNazwa.Text)) || (String.IsNullOrEmpty(txtIlosc.Text)))
                {
                    MessageBox.Show("Puste pole");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Produkty (Id_Produkt,Nazwa,Ilość) SELECT MAX(Id_Produkt)+1 , '" + txtNazwa.Text + "','" + txtIlosc.Text + "' FROM Produkty";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano pozycje", "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Pole: Ilość musi być liczbą");
            }

        }

        private void DodajDoBazy_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = dt;



        }




        private void button1_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = dt;


        }



        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


    }
}
