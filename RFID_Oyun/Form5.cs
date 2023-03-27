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

namespace RFID_Oyun
{
    public partial class Form5 : Form
    {
        public Form5()
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

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nasılOynanırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ekrana çıkan bir cismin şeklini\n" +
                "ve rengini etiketli kartları\n" +
                "okutarak eşleştiriniz.");
        }

        private void menüyeDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  // form1 göster diyoruz
            this.Hide();
        }
        int sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer alkis = new SoundPlayer(@"C:\Users\Seyma\Downloads\alkis.wav");
            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Seyma\Downloads\yanlis.wav");
            Random random = new Random();
            sayi = random.Next(0, 6);
            if (sayi == 0)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Downloads\\agac.jpeg";
                System.Threading.Thread.Sleep(10000);

                string sonuc = serialPort1.ReadExisting();
                if (sonuc == " 72 8D D7 21 B7 09 17 D9")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış Yaptın :(");
                }
                MessageBox.Show(sonuc);
                serialPort1.Close();
            }
            if (sayi == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Downloads\\saturn.jpeg";
                System.Threading.Thread.Sleep(10000);

                string sonuc = serialPort1.ReadExisting();
                if (sonuc == " 82 D8 5F 21 82 99 62 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış Yaptın :(");
                }
                MessageBox.Show(sonuc);
                serialPort1.Close();
            }
            if (sayi == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Downloads\\bal.jpeg";
                System.Threading.Thread.Sleep(10000);

                string sonuc = serialPort1.ReadExisting();
                if (sonuc == " 82 BB 1D 21 82 BE 45 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış Yaptın :(");
                }
                MessageBox.Show(sonuc);
                serialPort1.Close();
            }
            if (sayi == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Downloads\\karpuz.jpeg";
                System.Threading.Thread.Sleep(10000);

                string sonuc = serialPort1.ReadExisting();
                if (sonuc == " F1 37 B8 22 B7 09 17 D9")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış Yaptın :(");
                }
                MessageBox.Show(sonuc);
                serialPort1.Close();
            }
            if (sayi == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Downloads\\donut.jpeg";
                System.Threading.Thread.Sleep(10000);

                string sonuc = serialPort1.ReadExisting();
                if (sonuc == " 82 D8 5F 21 82 92 BE 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış Yaptın :(");
                }
                MessageBox.Show(sonuc);
                serialPort1.Close();
            }
            if (sayi == 0)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Downloads\\kup.jpeg";
                System.Threading.Thread.Sleep(10000);

                string sonuc = serialPort1.ReadExisting();
                if (sonuc == " 72 8D D7 21 82 BE 45 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış Yaptın :(");
                }
                MessageBox.Show(sonuc);
                serialPort1.Close();
            }

        }
    }
}
