using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpPisemka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vysledek;
        double prvnicislo;
        double druhecislo;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void prevod_Click(object sender, EventArgs e)
        {
            try
            {
                prvnicislo = double.Parse(textBox1.Text);
                druhecislo = double.Parse(textBox2.Text);
                if (plus.Checked)
                {
                    vysledek = (int)(prvnicislo + druhecislo);
                    textBox3.Text = vysledek.ToString();
                }
                if (minus.Checked)
                {
                    vysledek = (int)(prvnicislo - druhecislo);
                    textBox3.Text = vysledek.ToString();
                }
                if (krat.Checked)
                {
                    vysledek = (int)(prvnicislo * druhecislo);
                    textBox3.Text = vysledek.ToString();
                }
                if (deleno.Checked)
                {
                    vysledek = prvnicislo / druhecislo;
                    textBox3.Text = vysledek.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Něco zadáváš špatně");
            }

        }

        private void smazat_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void plus_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "+";
        }

        private void minus_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void krat_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "x";
        }

        private void deleno_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "/";
        }

        double vysledek2;
        private void prevod2_Click(object sender, EventArgs e)
        {
            try
            {


                double cislo = double.Parse(textBox4.Text);
                if (mocnina.Checked)
                {
                    vysledek2 = Math.Pow(cislo, 2);
                    textBox5.Text = vysledek2.ToString();
                }
                if (odmocnina.Checked)
                {
                    vysledek2 = Math.Sqrt(cislo);
                    textBox5.Text = vysledek2.ToString();
                }
                if (faktorial.Checked)
                {
                    vysledek2 = 1;
                    if (cislo < 14)
                    {
                        for (int c = 0; cislo > c; cislo--)
                        {
                            vysledek2 *= cislo;
                        }
                        textBox5.Text = vysledek2.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Na faktorial zadej prosim mensi cislo");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Něco zadáváš špatně");
            }
        }
    }
}
