using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class caluladora : Form
    {
      
        public caluladora()
        {
            InitializeComponent();
        }
        double valor1, valor2, resultado;
        char operacao;
        

        private void nunero1_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 1;
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 2;
        }

        private void numero3_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 3;
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 4;
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 5;
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 6;
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 7;
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 8;
        }

        private void botaoMais_Click(object sender, EventArgs e)
        {
            if(telaDeResposta.Text == "")
            {
                MessageBox.Show("digite um valor!");
            }
            else
            {
                valor1 = double.Parse(telaDeResposta.Text);
                telaDeResposta.Clear();
                operacao = '+';
            }
           
        }

        private void botaoMenos_Click(object sender, EventArgs e)
        {
            if (telaDeResposta.Text == "")
            {
                MessageBox.Show("digite um valor!");
            }
            else
            {
                valor1 = double.Parse(telaDeResposta.Text);
                telaDeResposta.Clear();
                operacao = '-';
            }
           
        }

        private void botaoMultiplicar_Click(object sender, EventArgs e)
        {
            if (telaDeResposta.Text == "")
            {
                MessageBox.Show("digite um valor!");
            }
            else
            {
                valor1 = double.Parse(telaDeResposta.Text);
                telaDeResposta.Clear();
                operacao = '*';
            }
           
        }

        private void botaoDividir_Click(object sender, EventArgs e)
        {
            if (telaDeResposta.Text == "")
            {
                MessageBox.Show("digite um valor!");
            }
            else
            {
                valor1 = double.Parse(telaDeResposta.Text);
                telaDeResposta.Clear();
                operacao = '/';
            }
           
        }

        private void botaoIgualdade_Click(object sender, EventArgs e)
        {
            if (telaDeResposta.Text == "")
            {
                MessageBox.Show("digite uma operação!");
            }
            else
            {


                valor2 = double.Parse(telaDeResposta.Text);
                telaDeResposta.Clear();
                switch (operacao)
                {
                    case '+':
                        resultado = valor1 + valor2;
                        break;
                    case '-':
                        resultado = valor1 - valor2;
                        break;
                    case '/':
                        if (valor2 == 0)
                        {
                            MessageBox.Show("valor invalido");
                        }
                        else
                        {
                            resultado = valor1 / valor2;
                        }
                        break;
                    case '*':
                        resultado = valor1 * valor2;
                        break;
                }
                telaDeResposta.Text = resultado.ToString();
            }
        }

        private void botaoDesligar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void botaoC_Click(object sender, EventArgs e)
        {
            if (telaDeResposta.Text == "")
            {
                MessageBox.Show("visor vazio!");
            }
            else
            {
                telaDeResposta.Text = "";
            }
        }

        private void botaoDEL_Click(object sender, EventArgs e)
        {
            try
            {
                telaDeResposta.Text = telaDeResposta.Text.Substring(0, telaDeResposta.Text.Length - 1);
            }
            catch
            {
                MessageBox.Show("visor vazio!", "calculadora diz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void botaoPonto_Click(object sender, EventArgs e)
        {
            if (telaDeResposta.Text == "")
            {
                MessageBox.Show("digite um valor!");
            }
            else
            {
                telaDeResposta.Text = telaDeResposta.Text + ',';
            }
               
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 9;
        }

        private void numero0_Click(object sender, EventArgs e)
        {
            telaDeResposta.Text = telaDeResposta.Text + 0;
        }
        
    }
}
