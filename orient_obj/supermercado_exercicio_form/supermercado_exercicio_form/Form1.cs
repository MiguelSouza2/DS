using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermercado_exercicio_form
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

        private void txt_estoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_maxima_TextChanged(object sender, EventArgs e)
        {

        }
        soma soma = new soma();
        private void button1_Click(object sender, EventArgs e)
        {
            int qtdmax, qtdestoque;
            string nomeproduto;

            qtdmax = int.Parse(txt_maxima.Text);

            qtdestoque = int.Parse(txt_estoque.Text);

            nomeproduto = txt_nome.Text;

            txt_result.Text = "Produto: " + nomeproduto + " e a Quantidade a comprar: " + soma.subtrair(qtdmax, qtdestoque);
        }
    }
}
