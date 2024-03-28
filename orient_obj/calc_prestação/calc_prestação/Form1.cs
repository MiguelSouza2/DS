using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_prestação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        calc_prest op = new calc_prest();

        private void button1_Click(object sender, EventArgs e)
        {
            double prest, taxa, dias, prestatraso;
            prest = double.Parse(txt_valor_prest.Text);

            taxa = double.Parse(txt_taxa.Text);

            dias = double.Parse(txt_tempo.Text);

            txt_result.Text = "" + op.prest(prest, taxa, dias);
        }
    }
}
