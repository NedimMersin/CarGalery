using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace galari_programı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6V24RBI;Initial Catalog=otogaleri;Integrated Security=True");
             
        
        public void baglantıac()
        {
            try
            {
                baglanti.Open();
            }
            catch (Exception)
            {

                baglanti.Close();
                baglanti.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
              baglantıac();
           
            SqlCommand cmd = new SqlCommand("SELECT * FROM uye WHERE Kul_adi='" + kulad.Text + "'and Parola='" + sifre.Text + "'", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else if (kulad.Text == "" || sifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı, tekrar deneyin!!");
                kulad.Text = "";
                sifre.Text = "";
            }
        }
    }
}
