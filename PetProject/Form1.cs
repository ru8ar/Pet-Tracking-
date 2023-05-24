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



        private void Form1_Load(object sender, EventArgs e)
        {

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
            Form2 gecis = new Form2(); 
            gecis.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 gecis = new Form2();
            gecis.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 gecis = new Form2();
            gecis.Show();
            
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit(); 
        }
    }
}
