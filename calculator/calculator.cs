using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace calculator
{
    public partial class calculator : Form
    {
        public double giriSayi;
        public char operation='0';
        
        public calculator()
        {
            InitializeComponent();
            
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0" && textBox1.Text==null)
            {
                textBox1.Text = "1";
            }
            else
            {
                if (textBox1.Text== "Sayıyı 0'a bölemesiniz.")//yazıya sayı eklememek için yazıyı siliyoruz.
                {
                    textBox1.Text = null;
                    textBox1.Text = "1";
                }
                else
                {
                     textBox1.Text = textBox1.Text + "1";  
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                if (textBox1.Text == "Sayıyı 0'a bölemesiniz.")
                {
                    textBox1.Text = null;
                    textBox1.Text = "2";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                if (textBox1.Text == "Sayıyı 0'a bölemesiniz.")
                {
                    textBox1.Text = null;
                    textBox1.Text = "3";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                if (textBox1.Text == "Sayıyı 0'a bölemesiniz.")
                {
                    textBox1.Text = null;
                    textBox1.Text = "4";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                if (textBox1.Text == "Sayıyı 0'a bölemesiniz.")
                {
                    textBox1.Text = null;
                    textBox1.Text = "5";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                if (textBox1.Text == "Sayıyı 0'a bölemesiniz.")
                {
                    textBox1.Text = null;
                    textBox1.Text = "6";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                if (textBox1.Text == "Sayıyı 0'a bölemesiniz.")
                {
                    textBox1.Text = null;
                    textBox1.Text = "7";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                if (textBox1.Text == "Sayıyı 0'a bölemesiniz.")
                {
                    textBox1.Text = null;
                    textBox1.Text = "8";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                if (textBox1.Text == "Sayıyı 0'a bölemesiniz.")
                {
                    textBox1.Text = null;
                    textBox1.Text = "9";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                if (textBox1.Text == "Sayıyı 0'a bölemesiniz.")
                {
                    textBox1.Text = null;
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (giriSayi!=0)
            {
                giriSayi = giriSayi + Convert.ToDouble(textBox1.Text);//Dönüşüm eştliliği sağlandı.
            }
            else
            {
                giriSayi = Convert.ToDouble(textBox1.Text);//Dönüşüm eştliliği sağlandı.
            }
            
            
            textBox1.Text = null;//textBox ın içini boşalttık.
            operation = '+';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (giriSayi != 0)
            {
                giriSayi = giriSayi - Convert.ToDouble(textBox1.Text);//Dönüşüm eştliliği sağlandı.
            }
            else
            {
                giriSayi = Convert.ToDouble(textBox1.Text);//Dönüşüm eştliliği sağlandı.
            }
            textBox1.Text = null;//textBox ın içini boşalttık.
            operation = '-';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (giriSayi != 0)
            {
                giriSayi = giriSayi * Convert.ToDouble(textBox1.Text);//Dönüşüm eştliliği sağlandı.
            }
            else
            {
                giriSayi = Convert.ToDouble(textBox1.Text);//Dönüşüm eştliliği sağlandı.
            }
            textBox1.Text = null;//textBox ın içini boşalttık.
            operation = '*';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (giriSayi != 0)
            {
                giriSayi = giriSayi / Convert.ToDouble(textBox1.Text);//Dönüşüm eştliliği sağlandı.
            }
            else
            {
                giriSayi = Convert.ToDouble(textBox1.Text);//Dönüşüm eştliliği sağlandı.
            }
            textBox1.Text = null;//textBox ın içini boşalttık.
            operation = '/';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operation=='0')
            {
                int arti;
                int eksi;
                int carpma;
                int bolme;
                
                arti = textBox1.Text.IndexOf('+');

                eksi = textBox1.Text.IndexOf('-');

                carpma = textBox1.Text.IndexOf('*');

                bolme = textBox1.Text.IndexOf('/');

                textBox1.Text = Convert.ToString(arti);

                char[] operatorler = { '+', '-', '*', '/' };

                

                string[] sayilar =textBox1.Text.Split(operatorler);

            }
            else
            {
                if (operation == '/')
                {
                    if (Convert.ToDouble(textBox1.Text) == 0)
                    {
                        textBox1.Text = ("Sayıyı 0'a bölemesiniz.");
                    }
                }
                else
                {
                    switch (operation)//eşitliğin cevablarını bulmak için hangi operatörü kullandığımızı anlayıp girilen sayıları işleme tabi tutuyoruz.
                    {
                        case '+':
                            textBox1.Text = Convert.ToString(giriSayi + Convert.ToDouble(textBox1.Text));
                            break;
                        case '-':
                            textBox1.Text = Convert.ToString(giriSayi - Convert.ToDouble(textBox1.Text));
                            break;
                        case '*':
                            textBox1.Text = Convert.ToString(giriSayi * Convert.ToDouble(textBox1.Text));
                            break;
                        case '/':
                            textBox1.Text = Convert.ToString(giriSayi / Convert.ToDouble(textBox1.Text));
                            break;

                    }
                }
            }
            
            
            
            
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + ",";
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            giriSayi = 0;
            operation = '0';
        }
    }
}
