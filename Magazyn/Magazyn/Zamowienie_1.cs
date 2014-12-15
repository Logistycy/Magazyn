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
    public partial class Zamowienie_1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lenovo\Desktop\Magazyn\Magazyn\Baza_magazynu.mdf;Integrated Security=True");


        public Zamowienie_1()
        {
            InitializeComponent();
        }

        
        

        private void Zamowienie_1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_magazynuDataSet.Produkty' table. You can move, or remove it, as needed.
            this.produktyTableAdapter.Fill(this.baza_magazynuDataSet.Produkty);

          

            

            // TODO: This line of code loads data into the 'baza_magazynuDataSet.Zamowienia_Produkty' table. You can move, or remove it, as needed.
            //this.zamowienia_ProduktyTableAdapter.Fill(this.baza_magazynuDataSet.Zamowienia_Produkty);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

     
        private void btnZamow_Click_1(object sender, EventArgs e)
        {
            

            int iloscZBazy;
            int iloscZwpisania;
            int anInteger3;
            iloscZBazy = Convert.ToInt32(ilośćTextBox.Text);
            iloscZBazy = int.Parse(ilośćTextBox.Text);

            iloscZwpisania = Convert.ToInt32(textboxwpisana.Text);
            iloscZwpisania = int.Parse(textboxwpisana.Text);

            if (iloscZBazy >= iloscZwpisania)
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
                    cmd.CommandText = "INSERT INTO Zamowienia_Produkty (Id_Produkt,Nazwa,Ilość) values(" + id_ProduktTextBox.Text + ", '" + nazwaTextBox.Text + "'," + textboxwpisana.Text + ")";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dodano pozycje", "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    anInteger3 = iloscZBazy - iloscZwpisania;
                   ilośćTextBox.Text =  anInteger3.ToString();

                   cmd.CommandText = "UPDATE Produkty SET Ilość ='" + ilośćTextBox.Text + "'  WHERE Id_Produkt = " + id_ProduktTextBox.Text + " ;";

                 


                    this.textboxwpisana.Text = "0";
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from Zamowienia_Produkty  ";
                    cmd2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;



                }
                catch
                {
                    MessageBox.Show("Produkt znajduje sie juz w  koszyku");
                }





            }
            else
            {
                MessageBox.Show("Brak takiej ilości produktu w magazynie");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                Zamowienie_2 Z2 = new Zamowienie_2();

                Z2.Show();
                this.Close();
          
            
        }

        private void ilośćTextBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void produktyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

       


       

      

    }
}
