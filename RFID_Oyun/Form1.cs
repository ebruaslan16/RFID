using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_Oyun
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hayvanların Sesleri")
            {
                Form2 form2 = new Form2();
                form2.Show();  // form2 göster diyoruz
                this.Hide();

            }
            else if (comboBox1.Text == "RESFEBE Oyunu")
            {
                Form3 form3 = new Form3();
                form3.Show();  // form3 göster diyoruz
                this.Hide();
            }
            else if (comboBox1.Text == "Kıyafet Eşleştirme")
            {
                Form4 form4 = new Form4();
                form4.Show();  // form4 göster diyoruz
                this.Hide();
            }
            else if (comboBox1.Text == "Şekil ve Renk Eşleştirme")
            {
                Form5 form5 = new Form5();
                form5.Show();  // form5 göster diyoruz
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
            }
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu oyun Şeyma Başgöze ve Ebru Aslan tarafından yazılmıştır.");
        }

        private void yardımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Önce kategori seçiniz. Daha sonra\n " +
                "oyun kategorisi için açılan pencerede\n'Yardım'" +
                " butonuna tıklayarak oyunun talimatlarını\ninceleyiniz.");
        }
    }
}

