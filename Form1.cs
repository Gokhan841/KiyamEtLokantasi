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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a,b,toplam;


        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            listBox1.Items.Clear();
            label6.Text="";
            MessageBox.Show("Siparişiniz İptal Edildi");
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("Lütfen Porsiyon Miktarını Giriniz");
                
            }
            if (comboBox1.Text=="" || comboBox2.Text=="")
            {
                MessageBox.Show("Lütfen Ana ve Ara Yemekleri Seçiniz");
                
            }
            listBox1.Items.Add(textBox1.Text+" " +"porsiyon"+" " +comboBox1.Text);
            listBox1.Items.Add(textBox2.Text + " " +"porsiyon" + " " +comboBox2.Text);
            
            if (comboBox1.Text=="Kaşarlı Köfte")
            {
                a = 20;
            }
            if (comboBox1.Text == "Izgara Köfte")
            {
                a = 18;
            }
            if (comboBox1.Text == "Karşık Izgara")
            {
                a = 30;
            }
            if (comboBox1.Text == "Çöp Şiş")
            {
                a = 34;
            }
            if (comboBox1.Text == "Bonfile")
            {
                a = 38;
            }
            if (comboBox2.Text == "Pilav")
            {
                b = 6;
            }
            if (comboBox2.Text == "Bulgur")
            {
                b = 5;
            }
            if (comboBox2.Text == "Patates Püresi")
            {
                b = 7;
            }
            if (comboBox2.Text == "Yaprak Sarma")
            {
                b = 9;
            }
            if (comboBox2.Text == "Elma Patates")
            {
                b = 4;
            }
            toplam = a * Convert.ToInt32(textBox1.Text) + b * Convert.ToInt32(textBox2.Text);
            label6.Text = toplam.ToString() + " "+"Türk Lirası";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece Sayısal veri giribilmek için olaylara tıklayıp Keypress kısmına textbox2_KeyPress yazıp çift tıklayıp açılan kısma aşağıdaki kodu yaz.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
