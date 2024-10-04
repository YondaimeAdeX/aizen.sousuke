using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aizensouske
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            if (s1<s2)
            {
                label3.Text = "Sayı 1 Küçüktür";
            }
            else if(s1==s2)
            {
                label3.Text = "Sayılar Eşittir";
            }
            else 
            {
                label3.Text = "Sayı 2 Küçüktür";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label4.Text = "Erkek Seçili";
            }
            else
            {
                label4.Text = "Kadın Seçili";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox4.Text);
            if (s>=0)
            {
                    label5.Text = s + " Sayısı Pozitiftir";
            }
            else
            {
                
                    label5.Text = s + " Negatiftir";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox3.Text);
            if (s%2==0)
            {
                label6.Text = s + " Sayısı Çifttir";
            }
            else
            {
                label6.Text = s + " Sayısı Tektir";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int dyili, yil, yas;
            dyili = Convert.ToInt32(textBox5.Text);
            yil = DateTime.Now.Year;
            yas = yil - dyili;
            if (yas<18)
            {
                label9.Text = yas + " Yaşındasınız Ehliyet için Yaşınız Yetmiyor";
            }
            else
            {
                label9.Text = yas + " Yaşındasınız Ehliyet için Yaşınız Yetiyor";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox6.Text);
            if (s%10==0)
            {
                label11.Text = s + " Sayısı 10'a Tam Bölünür";
            }
            else
            {
                label11.Text = s + " Sayısı 10'a Tam Bölünemez";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 

            if (checkBox2.Checked)
            {
                listBox1.Items.Add("Lamba Açık");
            }
            else
            {
                listBox1.Items.Add("Lamba Kapalı");
            }
            if (checkBox1.Checked)
            {
                listBox1.Items.Add("Kombi Açık");
            }
            else
            {
                listBox1.Items.Add("Kombi Kapalı");
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double s1, s2,sonuc=0;
            s1 = Convert.ToDouble(textBox8.Text);
            s2 = Convert.ToDouble(textBox7.Text);
            if (radioButton3.Checked)
            {
                sonuc = s1 + s2;
            }
            else if (radioButton4.Checked)
            {
                sonuc = s1 * s2;
            }
            else if (radioButton5.Checked)
            {
                sonuc = s1 / s2;
            }
            else
            {
                sonuc = s1 - s2;
            }
            label13.Text = sonuc.ToString();
        }
    }
}
