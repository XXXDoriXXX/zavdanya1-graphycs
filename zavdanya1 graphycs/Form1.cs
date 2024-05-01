using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavdanya1_graphycs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        double a;
        void conver()
        {
            if (!reverce)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    if (textBox1.Text == "")
                    {
                        a = 0;
                        label2.Text = (a * 128).ToString();
                    }
                    else
                    {
                        a = double.Parse(textBox1.Text);
                        label2.Text = (a * 128).ToString();
                    }

                }
                if (comboBox1.SelectedIndex == 0)
                {
                    if (textBox1.Text == "")
                    {
                        a = 0;
                        label2.Text = (a * 3.624).ToString();
                    }
                    else
                    {
                        double a = double.Parse(textBox1.Text);
                        label2.Text = (a * 3.624).ToString();
                    }

                }
            }
            if (reverce)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    if (textBox1.Text == "")
                    {
                        a = 0;
                        label2.Text = (a / 128).ToString();
                    }
                    else
                    {
                        a = double.Parse(textBox1.Text);
                        label2.Text = (a / 128).ToString();
                    }

                }
                if (comboBox1.SelectedIndex == 0)
                {
                    if (textBox1.Text == "")
                    {
                        a = 0;
                        label2.Text = (a / 128).ToString();
                    }
                    else
                    {
                        double a = double.Parse(textBox1.Text);
                        label2.Text = (a / 3.624).ToString();
                    }

                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conver();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conver();
        }
        bool reverce = false;
        int pr = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            pr++;
            
            if (pr % 2 == 0)
            {
                reverce = false;
                label4.Location = new Point(45,119);
                comboBox1.Location = new Point(347, 113);
            }
            else
            {
                reverce = true;
                label4.Location = new Point(347,113);
                comboBox1.Location = new Point(0, 113); 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
