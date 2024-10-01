using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmWindow : Form
    {
        public FrmWindow()
        {
            InitializeComponent();
        }
        private double valor = 0;
        private string operacao = "";
        private double celcius = 0;
        private double fahrenheit = 0;
        private void FrmWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text); // Pega o valor que o cara digitou
            operacao = "+"; // Armazena a operação pq dps eu vou usar ele
            txtResultado.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text); // Pega o valor que o cara digitou
            operacao = "-"; // Armazena a operação pq dps eu vou usar ele
            txtResultado.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text); // Pega o valor que o cara digitou
            operacao = "/"; // Armazena a operação pq dps eu vou usar ele
            txtResultado.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text); // Pega o valor que o cara digitou
            operacao = "*"; // Armazena a operação pq dps eu vou usar ele
            txtResultado.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void cºParaFºToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text);
            operacao = "f";
        }

        private void fºParaCºToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text);
            operacao = "c";
        }

        private void cMParaPolegadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtResultado.Text);
            operacao = "cm";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            double valor2 = double.Parse(txtResultado.Text); // ele pega o 2 numero que a pessoa digitou
            double resultado = 0; // aqui é a variavel que vai ser usada para exibir o resultado vou usar ela la embaixo

            if (operacao == "+")
            {
                resultado = valor + valor2;
            }
            else if (operacao == "-")
            {
                resultado = valor - valor2;
            }
            else if (operacao == "/")
            {
                resultado = valor / valor2;
            }
            else if (operacao == "*")
            {
                resultado = valor * valor2;
            }
            else if (operacao == "c")
            {
                resultado = (valor - 32) / 1.8;
            }
            else if (operacao == "f")
            {
                resultado = valor * 1.8 + 32;
            }
            else if (operacao == "cm")
            {
                resultado = valor / 2.54;
            }
            txtResultado.Text = resultado.ToString(); // ele converte o resultado de volta para a string ja que antes ele era int para fazer as contas
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
