using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace YemekSepeti
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 yeni = new Form4();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 eski = new Form1();
            eski.Show();
            this.Hide();           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 eski = new Form5();
            eski.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 eski = new Form6();
            eski.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Gitmek istediğiniz katagori için üstüne basmanız gerekmekte");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            yuvarlakButton3.FlatStyle = FlatStyle.Flat;
            yuvarlakButton3.BackColor = Color.Red;
            yuvarlakButton3.FlatAppearance.BorderSize = 0;
            yuvarlakButton3.Region = GetEllipseRegion(yuvarlakButton3.ClientRectangle);
            yuvarlakButton2.FlatStyle = FlatStyle.Flat;
            yuvarlakButton2.BackColor = Color.Red;
            yuvarlakButton2.FlatAppearance.BorderSize = 0;
            yuvarlakButton2.Region = GetEllipseRegion1(yuvarlakButton2.ClientRectangle);
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private Region GetEllipseRegion(RectangleF rect)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            return new Region(path);
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
            btn.FlatAppearance.BorderSize = 0;
        }
        private Region GetEllipseRegion1(RectangleF rect)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            return new Region(path);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Paint_1(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
            btn.FlatAppearance.BorderSize = 0;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
