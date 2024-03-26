using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSepeti
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 eski = new Form1();
            eski.Show();
            this.Hide();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 eski = new Form8();
            eski.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öncelike Giriş yapmalısınız");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öncelike Giriş yapmalısınız");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öncelike Giriş yapmalısınız");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öncelike Giriş yapmalısınız");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öncelike Giriş yapmalısınız");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öncelike Giriş yapmalısınız");
        }
    }
}
