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
    

    public partial class Form2 : Form
    {

        public Form2()
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
        private void menüyeDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  // form2 göster diyoruz
            this.Hide();
        }

        private void nasılOynanırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona basıldığında çıkan\n" +
                "hayvan sesinin hangi hayvana\n" +
                "ait olduğunu etiketli kart ile\n" +
                "okutularak eşleştirilir.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Portlar = SerialPort.GetPortNames();
            Random rast = new Random();
            int sayi = 1;

            SoundPlayer kedi = new SoundPlayer(@"C:\Users\Seyma\Downloads\Meow - Sound Effect.wav");
            //SoundPlayer inek = new SoundPlayer(@"C:\Users\Seyma\Downloads\İnek Sesi Efekti.wav");
            SoundPlayer at = new SoundPlayer(@"C:\Users\Seyma\Downloads\Ses Efektleri (TR) At ses efekti..wav");
            SoundPlayer kopek = new SoundPlayer(@"C:\Users\Seyma\Downloads\Köpek Havlama Ses Efekti.wav");
            //SoundPlayer circirbocek = new SoundPlayer(@"C:\Users\Seyma\Downloads\Cırcır böceği ses efekti.wav");
            SoundPlayer kurbaga = new SoundPlayer(@"C:\Users\Seyma\Downloads\Kurbağa Sesi.wav");
            SoundPlayer horoz = new SoundPlayer(@"C:\Users\Seyma\Downloads\Horoz Ses Efekti - Rooster Sound Effect.wav");
            SoundPlayer fil = new SoundPlayer(@"C:\Users\Seyma\Downloads\Gerçek Fil Sesi.wav");
            SoundPlayer kus = new SoundPlayer(@"C:\Users\Seyma\Downloads\Bird Chirping   Sound Effect.wav");
            SoundPlayer ari = new SoundPlayer(@"C:\Users\Seyma\Downloads\Bee Buzz - Sound Effect (HD).wav");
            SoundPlayer alkis = new SoundPlayer(@"C:\Users\Seyma\Downloads\alkis.wav");
            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Seyma\Downloads\yanlis.wav");

            int rfid = 0;
            for (int i = 0; i > 1; i++)
            {


                if (i == 0)
                {

                    serialPort1.Open();
                    System.Threading.Thread.Sleep(4000);
                    string sonuc = serialPort1.ReadExisting();
                    if (sonuc == " 82 AB E5 21")
                    {
                        yanlis.Play();

                    }
                    else
                    {
                        alkis.Play();
                        break;
                        //MessageBox.Show("Yanlış yaptın cevap kedi :)");
                    }
                    serialPort1.Close();

                }
            }
                
                if (sayi == 1)
                {
                    at.Play();
                    serialPort1.Open();
                    System.Threading.Thread.Sleep(10000);
                    string sonuc = serialPort1.ReadExisting();
                    if (sonuc == " 72 F4 AF 21")
                    {
                        alkis.Play();
                    }
                    else
                    {
                        yanlis.Play();
                        //MessageBox.Show("Yanlış yaptın cevap at :)");
                    }

                    serialPort1.Close();
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Portlar = SerialPort.GetPortNames();
            Random rast = new Random();
            int sayi = 1;
            int sayi2 = 2;

            SoundPlayer kedi = new SoundPlayer(@"C:\Users\Seyma\Downloads\Meow - Sound Effect.wav");
            //SoundPlayer inek = new SoundPlayer(@"C:\Users\Seyma\Downloads\İnek Sesi Efekti.wav");
            SoundPlayer at = new SoundPlayer(@"C:\Users\Seyma\Downloads\Ses Efektleri (TR) At ses efekti..wav");
            SoundPlayer kopek = new SoundPlayer(@"C:\Users\Seyma\Downloads\Köpek Havlama Ses Efekti.wav");
            //SoundPlayer circirbocek = new SoundPlayer(@"C:\Users\Seyma\Downloads\Cırcır böceği ses efekti.wav");
            SoundPlayer kurbaga = new SoundPlayer(@"C:\Users\Seyma\Downloads\Kurbağa Sesi.wav");
            SoundPlayer horoz = new SoundPlayer(@"C:\Users\Seyma\Downloads\Horoz Ses Efekti - Rooster Sound Effect.wav");
            SoundPlayer fil = new SoundPlayer(@"C:\Users\Seyma\Downloads\Gerçek Fil Sesi.wav");
            SoundPlayer kus = new SoundPlayer(@"C:\Users\Seyma\Downloads\Bird Chirping   Sound Effect.wav");
            SoundPlayer ari = new SoundPlayer(@"C:\Users\Seyma\Downloads\Bee Buzz - Sound Effect (HD).wav");
            SoundPlayer alkis = new SoundPlayer(@"C:\Users\Seyma\Downloads\alkis.wav");
            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Seyma\Downloads\yanlis.wav");

            int rfid = 0;
           


               
            

            if (sayi == 1)
            {

                at.Play();

                serialPort2.Open();
                System.Threading.Thread.Sleep(5000);
                alkis.Play();

                string sonuc = serialPort2.ReadExisting();
                if (sonuc == " 72 F4 AF 21")
                {
                }
                else
                {
                    //MessageBox.Show("Yanlış yaptın cevap at :)");
                }

                serialPort2.Close();
            }
            if (sayi2 == 2)
            {
                System.Threading.Thread.Sleep(7000);

                kedi.Play();
                System.Threading.Thread.Sleep(5000);

                yanlis.Play();
                MessageBox.Show("Yanlış yaptın cevap kedi :)");
                serialPort2.Open();
                System.Threading.Thread.Sleep(4000);
                string sonuc = serialPort2.ReadExisting();
                if (sonuc == " 82 AB E5 21")
                {

                }
                else
                {
                    alkis.Play();

                    //MessageBox.Show("Yanlış yaptın cevap kedi :)");
                }
                serialPort2.Close();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
        /*if (sayi == 1)
{
   kedi.Play();
   serialPort1.Open();
   System.Threading.Thread.Sleep(4000);
   string sonuc = serialPort1.ReadExisting();
   if (sonuc == " 82 AB E5 21")
   {
       yanlis.Play();

   }
   else
   {
       alkis.Play();

       //MessageBox.Show("Yanlış yaptın cevap kedi :)");
   }

   serialPort1.Close();

}

else if (sayi == 2)
{
   at.Play();
   serialPort1.Open();
   System.Threading.Thread.Sleep(10000);
   string sonuc = serialPort1.ReadExisting();
   if (sonuc==" 72 F4 AF 21"){
       alkis.Play();
   }
   else
   {
       yanlis.Play();
       //MessageBox.Show("Yanlış yaptın cevap at :)");
   }

   serialPort1.Close();
}
/*else if (sayi == 3)
{
   kopek.Play();
   serialPort1.Open();
   System.Threading.Thread.Sleep(10000);
   string sonuc = serialPort1.ReadExisting();
   if(sonuc==" 82 1A 27 21")
   {
       yanlis.Play();

   }
   else
   {
       alkis.Play();
       //MessageBox.Show("Yanlış yaptın cevap köpek :)");
   }
   serialPort1.Close();
}

else if (sayi == 4)
{
   kurbaga.Play();
   serialPort1.Open();
   System.Threading.Thread.Sleep(10000);

   string sonuc = serialPort1.ReadExisting();
   if(sonuc==" 82 F1 A8 21")
   {
       yanlis.Play();
   }
   else
   {
       alkis.Play();

       //MessageBox.Show("Yanlış Yaptın cevap kurbağa :)");
   }
   serialPort1.Close();
}
else if (sayi == 5)
{
   horoz.Play();
   serialPort1.Open();
   System.Threading.Thread.Sleep(4000);

   string sonuc = serialPort1.ReadExisting();
   if (sonuc == " 72 EC 5C 21")
   {
       alkis.Play();
   }
   else
   {
       yanlis.Play();
       MessageBox.Show("Yanlış Yaptın cevap horoz :)");
   }
   MessageBox.Show(sonuc);
   serialPort1.Close();
}
else if (sayi == 6)
{
   fil.Play();
   serialPort1.Open();
   System.Threading.Thread.Sleep(4000);

   string sonuc = serialPort1.ReadExisting();
   if (sonuc == " 57 E7 20 D9")
   {
       alkis.Play();
   }
   else
   {
       yanlis.Play();
       MessageBox.Show("Yanlış yaptın cevap fil :)");
   }
   MessageBox.Show(sonuc);
   serialPort1.Close();
}
else if (sayi == 7)
{
   kus.Play();
   serialPort1.Open();
   System.Threading.Thread.Sleep(4000);

   string sonuc = serialPort1.ReadExisting();
   if (sonuc == " 82 01 51 21")
   {
       alkis.Play();
   }
   else
   {
       yanlis.Play();
       MessageBox.Show("Yanlış Yaptın cevap kuş :)");
   }
   MessageBox.Show(sonuc);
   serialPort1.Close();
}
else if (sayi == 8)
{
   ari.Play();
   serialPort1.Open();
   System.Threading.Thread.Sleep(4000);

   string sonuc = serialPort1.ReadExisting();
   if (sonuc == " 92 06 FD 21")
   {
       alkis.Play();
   }
   else
   {
       yanlis.Play();
       MessageBox.Show("Yanlış Yaptın cevap arı :)");
   }
   MessageBox.Show(sonuc);
   serialPort1.Close();

}
*/

    }

        //private void button2_Click(object sender, EventArgs e)
        //{
            
        //}
    //}

