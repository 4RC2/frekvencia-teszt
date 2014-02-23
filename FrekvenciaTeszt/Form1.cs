using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrekvenciaTeszt
{
    public partial class Form1 : Form
    {

        Int32 frekvencia;
        Int32 időtartam;
        Int32 növelés;
        Int32 maxFrekvencia;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                frekvencia = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                frekvencia = 37;
            }

            if (textBox2.Text != "")
            {
                időtartam = Convert.ToInt32(textBox2.Text);
            }
            else
            {
                időtartam = 500;
            }

            if (textBox3.Text != "")
            {
                növelés = Convert.ToInt32(textBox3.Text);
            }
            else
            {
                növelés = 1000;
            }

            if (frekvencia >= 37 && frekvencia <= 32766)
            {
                if (checkBox1.Checked)
                {
                    if (textBox4.Text != "")
                    {
                            maxFrekvencia = Convert.ToInt32(textBox4.Text);
                    }
                    else
                    {
                        maxFrekvencia = 32766;
                    }

                    if (növelés <= 32766)
                    {
                        if (maxFrekvencia <= 32766)
                        {
                            while (frekvencia <= maxFrekvencia)
                            {
                                label1.Text = Convert.ToString(frekvencia);
                                Console.Beep(frekvencia, időtartam);
                                Application.DoEvents();
                                frekvencia += növelés;
                            }
                        }
                        else
                        {
                            MessageBox.Show("A maximális frekvencia 37 és 32766 közé eshet.", "Frekvencia teszt");
                        }
                    }
                    else
                    {
                            MessageBox.Show("A növelési érték nem lehet nagyobb 32766-nál.", "Frekvencia teszt");
                    }
                }
                else
                {
                    maxFrekvencia = frekvencia;
                    if (textBox1.Text != "")
                    {
                        frekvencia = Convert.ToInt32(textBox1.Text);
                    }
                    else
                    {
                        frekvencia = 37;
                    }
                    Console.Beep(frekvencia, időtartam);
                    label1.Text = Convert.ToString(frekvencia);
                }
            }
            else
            {
                MessageBox.Show("A hangjelzés frekvenciája 37 és 32766 közé eshet.", "Frekvencia teszt");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frekvencia = 32766;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBox3.Enabled = false;
                textBox3.Text = "";
                textBox4.Enabled = false;
                textBox4.Text = "";
                maxFrekvencia = frekvencia;
            }
            else
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
        }
    }
}
