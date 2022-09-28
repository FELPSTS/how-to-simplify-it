using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace lanconet
{
    public partial class Form1 : Form
    {
        double n1, n2, soma = 0;
        char n3 = '.';
        double vquant1 = 0;
        double vquant2 = 0;
        double vquant3 = 0;
        double total1 = 0;
        double total2 = 0;
        double total3 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {


                {
                    if (n3 == 's') ;
                       
                    do
                    {

                        n1 = Convert.ToDouble(Interaction.InputBox("Informe o código"));
                        n2 = Convert.ToDouble(Interaction.InputBox("Qual a quantidade?"));
                        n3 = Convert.ToChar(Interaction.InputBox("Deseja adcionar mais alguma coisa?"));


                        if (n1 == 111)
                        {
                            (this.vquant1) = 5 * n2;
                            (this.total1) = (this.total1) + (this.vquant1);
                            listBox1.Items.Add("Misto Quente,\t R$5,00 \t\t" + n2 + "\t R$" + (this.total1));
                        }
                        if (n1 == 222)
                        {
                            (this.vquant2) = 3 * n2;
                            (this.total2) = (this.total2) + (this.vquant2);
                            listBox1.Items.Add("S. laranja,\t R$3,00 \t\t" + n2 + "\t R$" + (this.total2));
                        }
                        if (n1 == 333)
                        {
                            (this.vquant3) = 1 * n2;
                            (this.total3) = (this.total3) + (this.vquant3);
                            listBox1.Items.Add("Brigadeiro,\t R$1,00 \t\t" + n2 + "\t R$" + (this.total3));
                        }

                        
                    } while (n3 == 's');
                }

                if (n3 == 'n')
                {
                    (this.soma) = (this.total1) + (this.total2) + (this.total3);
                    listBox1.Items.Add("total   R$" + soma);
                }


            }
        }
    }
}

    

     
