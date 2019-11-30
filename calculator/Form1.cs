using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        int resultat, a, b, elements = 0;
        char type_operation =' ';

        /// <summary>
        /// fonction qui s'exécute lorsqu'un chiffre de la calculatrice est cliqué
        /// </summary>
        /// <param name="sender"></param>
        public void chiffre(object sender)
        {
            if (elements == 2)
            {
                textBox1.Text = "";
                elements = 0;
            }
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
            
        }

        public void operateur(object sender)
        {
            if (elements == 0)
            {
                int.TryParse(textBox1.Text, out a);
                Button btn = (Button)sender;
                textBox1.Text = textBox1.Text + btn.Text;
                type_operation = btn.Text[0];
                elements++;
            }else if (elements == 2)
            {
                int.TryParse(textBox1.Text, out a);
                Button btn = (Button)sender;
                textBox1.Text = textBox1.Text + btn.Text;
                type_operation = btn.Text[0];
                elements = 1;
            }
        }

        public void egale(object sender)
        {
            if (elements > 0 && type_operation!= ' ')
            {
                elements++;
                try
                {
                    b = int.Parse(textBox1.Text.Split(type_operation)[1]);
                    switch (type_operation)
                    {
                        case '+':
                            resultat = a + b;
                            textBox1.Text = "" + resultat;
                            break;
                        case '-':
                            resultat = a - b;
                            textBox1.Text = "" + resultat;
                            break;
                        case '*':
                            resultat = a * b;
                            textBox1.Text = "" + resultat;
                            break;
                        case '/':
                            resultat = a / b;
                            textBox1.Text = "" + resultat;
                            break;
                        default:
                            // squall
                            break;
                    }
                }catch(Exception e)
                {
                    textBox1.Text = "";
                }
                
                
                
                type_operation = ' ';
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operateur(sender);
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operateur(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operateur(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operateur(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            egale(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            elements = 0;
        }
    }
}
