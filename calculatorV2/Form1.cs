using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorV2
{
    public partial class Form1 : Form
    {

        double resultat, a, b, elements = 0;
        char type_operation = ' ';

        /// <summary>
        /// fonction qui s'exécute lorsqu'un chiffre de la calculatrice est cliqué
        /// </summary>
        /// <param name="sender"></param>
        public void chiffre(object sender)
        {
            
            if (elements == 2)
            {
                textBox1.Text = "0";
                label3.Text = "";
                elements = 0;
            }
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;

        }

        public void operateur(object sender)
        {
            if (elements == 0)
            {
                double.TryParse(textBox1.Text, out a);
                Button btn = (Button)sender;
                textBox1.Text = textBox1.Text + btn.Text;
                type_operation = btn.Text[0];
                elements++;
            }
            else if (elements == 2)
            {
                double.TryParse(label3.Text, out a);
                Button btn = (Button)sender;
                textBox1.Text = resultat + btn.Text;
                type_operation = btn.Text[0];
                elements =1;
            }
        }

        public void egale(object sender)
        {
            if (elements > 0 && type_operation != ' ')
            {
                elements++;
                try
                {
                    b = double.Parse(textBox1.Text.Split(type_operation)[1]);
                    switch (type_operation)
                    {
                        case '+':
                            resultat = a + b;
                            label3.Text = "" + resultat;
                            break;
                        case '-':
                            resultat = a - b;
                            label3.Text = "" + resultat;
                            break;
                        case '*':
                            resultat = a * b;
                            label3.Text = "" + resultat;
                            break;
                        case '/':
                            resultat = a / b;
                            label3.Text = "" + resultat;
                            break;
                        default:
                            
                            break;
                    }
                }
                catch (Exception e)
                {
                    textBox1.Text = "0";
                    label3.Text = "";
                }



                type_operation = ' ';
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        
        
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible)
            {

                flowLayoutPanel1.Hide();
            }
            else
            {
                flowLayoutPanel1.Show();

            }

        }




        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operateur(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operateur(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operateur(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operateur(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel2.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //don't touch, that's the background
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            panel2.Hide();
            panel4.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //+ std
            operateur(sender);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //* std
            operateur(sender);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // / std
            operateur(sender);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //- std
            operateur(sender);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            // = std
            egale(sender);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
            elements = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            egale(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chiffre(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
            elements = 0;
        }
    }
}