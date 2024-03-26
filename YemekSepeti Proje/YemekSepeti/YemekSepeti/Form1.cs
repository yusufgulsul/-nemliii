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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 0;
        int sayaç = 0;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ÖĞRENCİ\\Desktop\\Yemek_Sepeti-main\\Yemek_Sepeti-main\\YemekSepeti Proje\\Yemek_Sepeti.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            hak++;
            string ad = textBox1.Text;
            string şifre = textBox2.Text;

            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kullanıcılar WHERE KullaniciAdi='" + textBox1.Text + "'AND  Sifre='" + textBox2.Text + "'", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Başarılı giriş yaptınız, Sayfaya yönlendiriliyorsunuz");
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }   
            else if (hak == 3) 
            {
                MessageBox.Show("3 Hatalı giriş yaptınız, Biraz beklemelisiniz");
                timer1.Start();
            }
            else if (hak == 6) 
            {
                MessageBox.Show("6 Hatalı giriş yaptınız, Biraz beklemelisiniz");
                timer1.Start();
            }
            else if (hak == 9)
            {
                MessageBox.Show("9 Hatalı giriş yaptınız, Biraz beklemelisiniz");
                timer1.Start();
            }
            else 
            {
                MessageBox.Show("Bu kullanıcı adı veya şifre sisteme kayıtlı değil");
            }
            baglan.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            sayaç++;
            label1.Text = sayaç.ToString();
            if (hak==3) 
            {
                if (sayaç == 10) 
                {
                    sayaç = 0;
                    button1.Enabled = true;
                    timer1.Stop();
                }     
            }
            else if (hak == 6) 
            {
                if (sayaç == 20) 
                {
                     sayaç = 0;
                     button1.Enabled = true;
                     timer1.Stop();
                }
            }
            else if (hak == 9)
            {
                if (sayaç == 60)
                {
                    sayaç = 0;
                    button1.Enabled = true;
                    timer1.Stop();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 yeni = new Form8();
            yeni.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }
    }
}
