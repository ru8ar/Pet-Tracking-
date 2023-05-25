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



namespace PetProject
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        public String conString = "Data Source=DESKTOP-J51Q8M5;Initial Catalog=VetProject1;Integrated Security=True";

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J51Q8M5;Initial Catalog=VetProject1;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vetProject1DataSet.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.vetProject1DataSet.Clinic);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString); 
            con.Open(); 


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Form2 gecis = new Form2(); 
            //  gecis.Show();
            // this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Form2 gecis = new Form2();
            // gecis.Show();
            //  this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Form2 gecis = new Form2();
            // gecis.Show();

        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Application.Exit(); 
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void klinik1_TextChanged(object sender, EventArgs e)
        {
            String name="";
            String Street="";
            String No  ="" ;
            String Phone = "";
            if (klinik1.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Clinic where Clinic.Name like '" + klinik1.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                name = read["Name"].ToString();
                Street = read[2].ToString();
                No = read[3].ToString();
                Phone = read[4].ToString();

            }
            baglanti.Close();
            klinik1.Text = name;
            klinik2.Text = Street;
            klinik3.Text = No;
            klinik4.Text = Phone;
        }
    }
}
