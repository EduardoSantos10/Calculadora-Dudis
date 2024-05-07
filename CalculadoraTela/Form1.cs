using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTela
{
    public partial class Form1 : Form
    {
        Model modelo;
        public Form1()
        {
            InitializeComponent();
            modelo = new Model();
        }//Fim do Construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void numeroUm_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Input numeroUm

        private void numeroDois_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Input numeroDois

        private void Somar_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                Resultado.Text = "" + modelo.Somar(num1, num2);
            }
        }// Fim do Somar

        private void Subtrair_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                Resultado.Text = "" + modelo.Subtrair(num1, num2);
            }
        }// Fim do Subtrair

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                Resultado.Text = "" + modelo.Multiplicar(num1, num2);
            }
        }// Fim do Multiplicar

        private void Dividir_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                if (modelo.Dividir(num1, num2) == -1)
                {
                    Resultado.Text = "Impossivel Dividir";
                }
                else
                {
                    Resultado.Text = "" + modelo.Dividir(num1, num2);
                }
            }
        }// Fim do Dividir

        private void Limpar_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                numeroUm.Text = "";
                numeroDois.Text = "";
                Resultado.Text = "";
            }
        }// Fim do Limpar

        private void Resultado_TextChanged(object sender, EventArgs e)
        {
            
        }// Fim do Resultado
    }//Fim da Classe
}// Fim do Projeto
