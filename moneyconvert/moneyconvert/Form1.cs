using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyconvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int awal;
            int akhir;
            double jumlah;
            double hasil;

            jumlah = Convert.ToDouble(textBox1.Text);
            awal = comboBox1.SelectedIndex;
            akhir = comboBox2.SelectedIndex;
            if (comboBox1.SelectedIndex == 0)
            {
                if (jumlah >= 0)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        hasil = jumlah;
                        textBox2.Text = "" + hasil;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        hasil = jumlah * 0.000069;
                        textBox2.Text = "" + hasil;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        hasil = jumlah * 0.000062;
                        textBox2.Text = "" + hasil;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        hasil = jumlah * 0.000055;
                        textBox2.Text = "" + hasil;
                    }
                    textBox3.Text = "KONVERSI BERHASIL!!";
                }
                else
                {
                    textBox3.Text = "INPUTAN SALAH!!";
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (jumlah >= 0)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        hasil = jumlah * 14000;
                        textBox2.Text = "" + hasil;
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        hasil = jumlah;
                        textBox2.Text = "" + hasil;
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        hasil = jumlah * 0.90;
                        textBox2.Text = "" + hasil;
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        hasil = jumlah * 0.79;
                        textBox2.Text = "" + hasil;
                    }
                    textBox3.Text = "KONVERSI BERHASIL!!";
                }
                else
                {
                    textBox3.Text = "INPUTAN SALAH!!";
                }
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                if (jumlah >= 0)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        hasil = jumlah * 16000;
                        textBox2.Text = "" + hasil;
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        hasil = jumlah * 1.12;
                        textBox2.Text = "" + hasil;
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        hasil = jumlah;
                        textBox2.Text = "" + hasil;
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        hasil = jumlah * 0.88;
                        textBox2.Text = "" + hasil;
                    }
                    textBox3.Text = "KONVERSI BERHASIL!!";
                }
                else
                {
                    textBox3.Text = "INPUTAN SALAH!!";
                }
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                if (jumlah >= 0)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        hasil = jumlah * 18000;
                        textBox2.Text = "" + hasil;
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        hasil = jumlah * 1.27;
                        textBox2.Text = "" + hasil;
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        hasil = jumlah * 1.14;
                        textBox2.Text = "" + hasil;
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        hasil = jumlah;
                        textBox2.Text = "" + hasil;
                    }
                    textBox3.Text = "KONVERSI BERHASIL!!";
                }
                else
                {
                    textBox3.Text = "INPUTAN SALAH!!";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45)
            {
                e.Handled = true; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
