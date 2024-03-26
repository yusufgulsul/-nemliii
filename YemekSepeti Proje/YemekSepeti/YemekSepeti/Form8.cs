using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace YemekSepeti
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public void goruntule() 
        {
            baglan.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From Kullanıcılar", baglan);
            DataTable dt = new DataTable();
            adtr.Fill(dt);
            baglan.Close();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ÖĞRENCİ\\Desktop\\Yemek_Sepeti-main\\Yemek_Sepeti-main\\YemekSepeti Proje\\Yemek_Sepeti.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Insert into Kullanıcılar(KullaniciAdi,Sifre,Email,Telefon) Values('" + textBox4.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            goruntule();
            button1.Enabled = true;
            MessageBox.Show("Kayıt Başarılı Giriş yapabilirsiniz");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            this.Hide();
            giris.Show();
        }
    }
}
