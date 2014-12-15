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
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lenovo\Desktop\Magazyn\Magazyn\Baza_magazynu.mdf;Integrated Security=True");


        public MainForm()
        {
    
            InitializeComponent();
            comboBox1.Items.Add("Klienci");
            comboBox1.Items.Add("KlienciZamówienia");
            comboBox1.Items.Add("Produkty");
            comboBox1.Items.Add("Zamówienia");
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MainForm_Load(object sender, EventArgs e)
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajDoBazy DDB = new DodajDoBazy();

            DDB.Show();            
        }

      
        private void btnUsun_Click(object sender, EventArgs e)
        {
            Usuń U = new Usuń();

            U.Show();
           
        }

        private void btnEdycja_Click(object sender, EventArgs e)
        {
            Edycja E = new Edycja();

            E.Show();
           
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

        private void btnZamowienie_Click(object sender, EventArgs e)
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
                cmd.CommandText = "delete from Zamowienia_Produkty";
                //  cmd.ExecuteNonQuery();
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows == 1)
                {

                }
                if (affectedRows == 0)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Zamowienie_1 Z1 = new Zamowienie_1();
           Z1.Show();
        }

       
    }
}
