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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void menüyeDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  // form2 göster diyoruz
            this.Hide();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nasılOynanırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parçadan bütüne gitme yöntemi\n" +
                "kullanılır. Çıkan kelimelerin\n" +
                "birleşiminden oluşan bir kelime\n" +
                "düşünülür ve etiketli kart ile\n" +
                "okutulur.");
                }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer alkis = new SoundPlayer(@"C:\Users\Seyma\Downloads\alkis.wav");
            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Seyma\Downloads\yanlis.wav");
            Random random = new Random();
            int sayi = random.Next(0, 11);
            if (sayi == 0)
            {
                serialPort1.Open();

                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\aycicegi.jpg";
                System.Threading.Thread.Sleep(30000);
                string sonuc = serialPort1.ReadExisting();
                MessageBox.Show(sonuc);
                if (sonuc == " 82 40 30 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 1)
            {
                serialPort1.Open();
                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\balon.jpg";
                System.Threading.Thread.Sleep(30000);
                string sonuc = serialPort1.ReadExisting();
                MessageBox.Show(sonuc);
                if (sonuc == " 82 47 09 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 2)
            {
                serialPort1.Open();

                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\baykus.jpg";
                System.Threading.Thread.Sleep(30000);
                string sonuc = serialPort1.ReadExisting();
                MessageBox.Show(sonuc);
                if (sonuc == " 82 96 7E 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 3)
            {
                serialPort1.Open();

                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\besiktas.jpg";
                System.Threading.Thread.Sleep(30000);
                string sonuc = serialPort1.ReadExisting();
                MessageBox.Show(sonuc);
                if (sonuc == " 57 73 23 D9")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 4)
            {
                serialPort1.Open();

                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\biberon.jpg";
                string sonuc = serialPort1.ReadExisting();
                System.Threading.Thread.Sleep(30000);

                MessageBox.Show(sonuc);
                if (sonuc == " 72 95 18 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 5)
            {
                serialPort1.Open();
                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\Fenerbahce.jpg";
                string sonuc = serialPort1.ReadExisting();
                System.Threading.Thread.Sleep(30000);

                MessageBox.Show(sonuc);
                if (sonuc == " 27 7B 02 D8")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 6)
            {
                serialPort1.Open();

                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\karakol.jpg";
                string sonuc = serialPort1.ReadExisting();
                System.Threading.Thread.Sleep(30000);

                MessageBox.Show(sonuc);
                if (sonuc == " 82 56 6B 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 7)
            {
                serialPort1.Open();

                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\kutupayisi.jpg";
                string sonuc = serialPort1.ReadExisting();
                System.Threading.Thread.Sleep(30000);

                MessageBox.Show(sonuc);
                if (sonuc == " 82 40 08 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 8)
            {
                serialPort1.Open();

                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\limonata.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                string sonuc = serialPort1.ReadExisting();
                System.Threading.Thread.Sleep(30000);

                MessageBox.Show(sonuc);
                if (sonuc == " 82 92 9D 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 9)
            {
                serialPort1.Open();

                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\pilot.jpg";
                string sonuc = serialPort1.ReadExisting();
                System.Threading.Thread.Sleep(30000);

                MessageBox.Show(sonuc);
                if (sonuc == " F1 3D 11 22")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }
            if (sayi == 10)
            {
                serialPort1.Open();

                pictureBox1.ImageLocation = "C:\\Users\\Seyma\\Desktop\\Resfebe kod resmi\\portakalsuyu.jpg";

                string sonuc = serialPort1.ReadExisting();
                System.Threading.Thread.Sleep(30000);

                MessageBox.Show(sonuc);
                if (sonuc == " 82 5D 1E 21")
                {
                    alkis.Play();
                }
                else
                {
                    yanlis.Play();
                    MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }

                serialPort1.Close();
            }

        }
    }
}
