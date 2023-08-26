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
    public partial class Form1 : Form
    {
       SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6V24RBI;Initial Catalog=otogaleri;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adtr = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }
        



        void listele()
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from arac", baglanti);
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            adtr.Dispose();
            baglanti.Close();
        }
        //kayıt sil
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from arac where s_no=" + sno.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                ds.Clear();
                listele();
            }
        }
        
           
            
        

        //arac güncelle
        private void button3_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update arac set marka='" + marka.Text + "', model='" + model.Text + "', fiyat='" + fiyat.Text + "', kasa='" + comboBox1.Text + "', renk='" + comboBox2.Text + "', vites='" + comboBox3.Text + "', y_tipi='" + comboBox4.Text + "', m_yili='" + comboBox5.Text + "', durumu='" + comboBox6.Text + "' where s_no=" + sno.Text + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Clear();
            listele();
        }
            
        
    

        
        //acces teki kayıtları data gridewiew e atar
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();




        }
        //kayıt ara
        private void aekle_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            baglanti = new SqlConnection("Data Source=DESKTOP-6V24RBI;Initial Catalog=otogaleri;Integrated Security=True");
            adtr = new SqlDataAdapter("SElect * from arac where s_no like '" + sno.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        
        //kayıt ekle
        private void aekle_Click_1(object sender, EventArgs e)
        {
           
            if (sno.Text != "" && marka.Text != "" && model.Text != "" && fiyat.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && comboBox5.Text != "" && comboBox6.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into arac (s_no,marka,model,fiyat,kasa,renk,vites,y_tipi,m_yili,durumu) Values ('" + sno.Text + "','" + marka.Text + "','" + model.Text + "','" + fiyat.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Tamamlandı!");
                ds.Clear();
                listele();
            }
            else
            {
                MessageBox.Show("Boş alan geçmeyiniz!");
            }
        }
        //data gridwiew den texboxlara atar
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void modelyili_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            sno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox6.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            
        }
    }
}
          
            
        
        
    
            
        
    

            
        
    
    
        
    

    


