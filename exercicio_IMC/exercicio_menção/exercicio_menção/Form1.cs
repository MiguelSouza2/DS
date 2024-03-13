using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_menção
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txt_peso.Text);
            double altura = double.Parse(txt_altura.Text) / 100;
            double imc;


            imc = peso / (altura * altura);

            if(imc < 16)
            {
                txt_result.Text = "Baixo peso grau III";
            }
            else if(imc < 17 && imc >= 16)
            {
                txt_result.Text = "Baixo peso grau II";
            }
            else if (imc < 18.5 && imc >= 17)
            {
                txt_result.Text = "Baixo peso grau I";
            }
            else if (imc < 25 && imc >= 18.5)
            {
                txt_result.Text = "Peso Saudável";
            }
            else if (imc < 30 && imc >= 25)
            {
                txt_result.Text = "Sobrepeso";
            }
            else if(imc < 35 && imc >= 30)
            {
                txt_result.Text = "Obesidade grau I";
            }
            else if (imc < 40 && imc >= 35)
            {
                txt_result.Text = "Obesidade grau II";
            }
            else if (imc >= 40)
            {
                txt_result.Text = "Obesidade grau III";
            }

        }
    }
}
