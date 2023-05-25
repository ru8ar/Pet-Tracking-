using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public String conString = "Data Source=DESKTOP-J51Q8M5;Initial Catalog=VetProject1;Integrated Security=True";

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J51Q8M5;Initial Catalog=VetProject1;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form33 gecis = new Form33(); 
            // gecis.Show();
            //   this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  Form33 gecis = new Form33();
            //  gecis.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Form33 gecis = new Form33();
            // gecis.Show();
            // this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = "";
            String surname = "";
            
            String Phone = "";
            if (comboBox1.Text == "") foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Vet where Vet.Name like '" + comboBox1.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                name = read["Name"].ToString();
                surname = read[2].ToString();
                
                Phone = read[4].ToString();

            }
            baglanti.Close();
            comboBox1.Text = name;
            vet1.Text = surname;
            
            vet2.Text = Phone;
        }
    }
}
