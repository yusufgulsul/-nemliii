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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ÖĞRENCİ\\Desktop\\Yemek_Sepeti-main\\Yemek_Sepeti-main\\YemekSepeti Proje\\Yemek_Sepeti.mdb");
        private void label1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kullanıcılar SET Sifre='" + textBox2.Text + "'WHERE Email='" + textBox1.Text + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Şifre Başarıyla Değiştirilidi");
        }
    }
}
