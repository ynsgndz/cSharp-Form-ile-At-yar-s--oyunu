using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            at1solUzaklık = pictureBox1.Left;
            at2solUzaklık = pictureBox2.Left;
            at3solUzaklık = pictureBox3.Left;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int at1solUzaklık, at2solUzaklık, at3solUzaklık;

        private void timer1_Tick(object sender, EventArgs e)
        {

            int derece = Convert.ToInt32(label8.Text);
            derece++;
            label8.Text = derece.ToString();

            int at1Genislik = pictureBox1.Width;
            int at2Genislik = pictureBox2.Width;
            int at3Genislik = pictureBox3.Width;

            int bitisUzaklığı = label6.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5,15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5,15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5,15);

            if (at1Genislik+pictureBox1.Left>=bitisUzaklığı)
            {
                timer1.Enabled = false;
                label7.Visible = true;
                label7.Text = "1 numaralı at yarışı kazandı";
            }
            if (at2Genislik+pictureBox2.Left>=bitisUzaklığı)
            {
                timer1.Enabled = false;
                label7.Visible = true;
                label7.Text = "2 numaralı at yarışı kazandı";
            }
            if (at3Genislik + pictureBox3.Left >= bitisUzaklığı)
            {
                timer1.Enabled = false;
                label7.Visible = true;
                label7.Text = "3 numaralı at yarışı kazandı";
            }
            if (pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>pictureBox3.Left+1)
            {
                label5.Text = "1 numaralı at  öne geçti";    
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 1)
            {
                label5.Text = "2 numaralı at  öne geçti";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 1)
            {
                label5.Text = "3 numaralı at öne geçti";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label5.Text = " ";
            label8.Text =Convert.ToString(0);
        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
