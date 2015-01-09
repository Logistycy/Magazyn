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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lenovo\Desktop\Magazyn\Magazyn\Baza_magazynu.mdf;Integrated Security=True");
       
    
        public DodajDoBazy()
        {

          
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        
        {
/*
            string a;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select Max(Id_Produkt) from Produkty ;";
             a = cmd2.ExecuteScalar().ToString();

*/
         
            try
            {  if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Produkty (Id_Produkt,Nazwa,Ilość) SELECT MAX(Id_Produkt)+1 , '" + txtNazwa.Text + "'," + txtIlosc.Text + " FROM Produkty";

                cmd.ExecuteNonQuery();
              
                MessageBox.Show("Dodano pozycje", "Messeg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNazwa.Text = "";
                txtIlosc.Text = "";

            }
            catch 
            {
                MessageBox.Show("Nr ID produktu jest już zajęty");
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
