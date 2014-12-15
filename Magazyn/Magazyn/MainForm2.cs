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
    public partial class MainForm2 : Form
    {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Michał\Desktop\2222\projekt\Magazyn\Magazyn\Baza_magazynu.mdf;Integrated Security=True");


        public MainForm2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Klienci");
            comboBox1.Items.Add("KlienciZamówienia");
            comboBox1.Items.Add("Produkty");
            comboBox1.Items.Add("Zamówienia");
        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void wylogujToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void zakończToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
        private void produktyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wykres_Produkty WP = new Wykres_Produkty();

            WP.Show();
        }

        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autorzy A = new Autorzy();
            A.Show();
        }

       
               private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Klienci ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from KlienciZamowienia ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            if (comboBox1.SelectedIndex == 2)
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
            if (comboBox1.SelectedIndex == 3)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Zamowienia ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
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
            cmd.CommandText = " select * from Produkty where Nazwa='" + this.textBox1.Text + "' ;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
              if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from Produkty where Nazwa='" + this.textBox1.Text + "' ;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_magazynuDataSet.Produkty' table. You can move, or remove it, as needed.
            this.produktyTableAdapter.Fill(this.baza_magazynuDataSet.Produkty);
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
