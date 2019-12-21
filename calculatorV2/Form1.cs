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
                            if (b != 0)
                            {
                                resultat = a / b;
                                label3.Text = "" + resultat;
                            }
                            else
                            {
                                label3.Text = "impossible";
                                resultat = 0;
                            }
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
            panel2.Hide();
            panel4.Show();
            //panel4.Hide();
            pnlInfo.Hide();
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
            pnlInfo.Hide();
            panel2.Show();
            flowLayoutPanel1.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //don't touch, that's the background
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            panel2.Hide();
            pnlInfo.Hide();
            panel4.Show();
            flowLayoutPanel1.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            // %
            double b;
            try
            {
                double.TryParse(textBox1.Text, out b);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (b != 0 && elements != 2)
            {

                label3.Text = (b/100).ToString();
                elements = 2;
            }
            else
            {
                double.TryParse(label3.Text, out b);
                if (elements == 2 && b != 0)
                {
                    label3.Text = (b/100).ToString();
                }
                else
                {

                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //carre
            double b;
            try
            {
                double.TryParse(textBox1.Text, out b);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            if (b!= 0 && elements!=2)
            {
                
                label3.Text = Math.Pow(b,2).ToString();
                elements = 2;
            }
            else
            {
                double.TryParse(label3.Text, out b);
                if (elements==2 && b != 0)
                {
                    label3.Text = Math.Pow(b, 2).ToString();
                }
                else
                {

                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //racine carre
            double b;
            try
            {
                double.TryParse(textBox1.Text, out b);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (b != 0 && elements != 2)
            {

                label3.Text = Math.Sqrt(b).ToString();
                elements = 2;
            }
            else
            {
                double.TryParse(label3.Text, out b);
                if (elements == 2 && b != 0)
                {
                    label3.Text = Math.Sqrt(b).ToString();
                }
                else
                {

                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // 1/x
            double b;
            try
            {
                double.TryParse(textBox1.Text, out b);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (b != 0 && elements != 2)
            {

                label3.Text = (1/b).ToString();
                elements = 2;
            }
            else
            {
                double.TryParse(label3.Text, out b);
                if (elements == 2 && b != 0)
                {
                    label3.Text = (1/b).ToString();
                }
                else
                {

                }
            }
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel4.Hide();
            pnlInfo.Show();
            flowLayoutPanel1.Hide();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            // enleve un char
            string svg="";
            char a= textBox1.Text[(textBox1.Text.Length-1)];
            for(int i=0; i<(textBox1.Text.Length-1); i++)
            {
                svg += textBox1.Text[i];
            }
            if(a=='+' || a=='-' || a=='*' || a == '/')
            {
                elements--;
            }
            textBox1.Text = svg;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            // supprimer un element

            if (elements == 0)
            {
                textBox1.Text = "";
                label3.Text = "";
                elements = 0;
            }
            else
            {
                char[] a = { '+', '-', '*', '/' };
                int index = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (textBox1.Text.Contains(a[i]))
                    {
                        index = textBox1.Text.IndexOf(a[i]);
                    }
                }
                textBox1.Text = textBox1.Text.Substring(0, (index + 1));
            }
            
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