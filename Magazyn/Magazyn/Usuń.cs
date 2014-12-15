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
    public partial class Usuń : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lenovo\Desktop\Magazyn\Magazyn\Baza_magazynu.mdf;Integrated Security=True");

        public Usuń()
        {
            InitializeComponent();
        }

      

        private void Usuń_Load(object sender, EventArgs e)
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

        private void btnUsun_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from Produkty where Id_Produkt='" + this.txtId.Text + "' ;";
                  //  cmd.ExecuteNonQuery();
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows == 1)
                    {
                        MessageBox.Show("Usunieto produkt!");
                    }
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("Błąd: Nie ma takiego id !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

          
         
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
           
        }

        private void button1_Click(object sender, System.EventArgs e)
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

    }
}
