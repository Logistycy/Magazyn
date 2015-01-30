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
    public partial class Zamowienie_2 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Michał\Desktop\Magazyn\Magazyn\Baza_magazynu.mdf;Integrated Security=True");

        public Zamowienie_2()
        {
            InitializeComponent();
        }


        private void Zamowienie_2_Load(object sender, EventArgs e)
        {

        }

        private void btndalej_Click(object sender, EventArgs e)
        {


            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Klienci (Id_Klienta,Nazwa,NIP,REGON) SELECT MAX(Id_Klienta)+1 , '" + nazwaTextBox.Text + "','" + nIPTextBox.Text + "' , '" + rEGONTextBox.Text + "' FROM Klienci";

                cmd.ExecuteNonQuery();

                if ((String.IsNullOrEmpty(nazwaTextBox.Text)) || (String.IsNullOrEmpty(nIPTextBox.Text)) || (String.IsNullOrEmpty(rEGONTextBox.Text)))
                {
                    MessageBox.Show("Puste pole");
                }
                else
                {
                    MessageBox.Show("Dodano pozycje", "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Zamowienie_3 Z3 = new Zamowienie_3();



                    Z3.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Pole NIP,Regon muszą być liczbą ");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamowienie_1 Z1 = new Zamowienie_1();

            Z1.Show();
            this.Close();
        }


    }
}
