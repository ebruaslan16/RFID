using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO.Ports;
using System.IO;

namespace RFID_Oyun
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menüyeDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  // form2 göster diyoruz
            this.Hide();
        }

        private void nasılOynanırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ekranda çıkacak olan kombini\n" +
                "etiketli kartlarla sırayla\n" +
                "eşleştirerek, kombini onaylayın.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sapka= Directory.GetFiles(@"D:\resim\", "*.jpg");
            string[] gomlek = Directory.GetFiles(@"D:\resim\", "*.jpg");
            string[] pantolon = Directory.GetFiles(@"D:\resim\", "*.jpg");
            t.Open();

            pictureBox1.Image = Image.FromFile("C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\limonata.jpg");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            string sonuc = t.ReadExisting();
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sonuc = t.ReadExisting();

            if (sonuc == " 82 92 9D 21")
            {

                MessageBox.Show(sonuc);
                MessageBox.Show("doru");
            }
            else
            {
                System.Threading.Thread.Sleep(5000);

                MessageBox.Show("Yanlış yaptın cevap kedi :)");
            }
            t.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}