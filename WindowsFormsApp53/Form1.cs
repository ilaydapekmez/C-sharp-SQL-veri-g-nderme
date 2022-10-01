using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp53
{
    public partial class Form1 : Form
    {

        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataReader oku;
        public Form1()
        {
            InitializeComponent();

  
            baglanti = new MySqlConnection("connection string");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           
            komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO `happy`(`ograd`, `ogrsoyad`, `dtarih`) VALUES('"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"')";
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Eklendiii :)) ");
        }
    }
}
