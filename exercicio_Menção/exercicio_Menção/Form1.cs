using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_Menção
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            string result = "";
            double soma = 0;
            double[] n = new double[4];

            n[0] = double.Parse(txt_mention_1.Text);
            n[1] = double.Parse(txt_mention_2.Text);
            n[2] = double.Parse(txt_mention_3.Text);
            n[3] = double.Parse(txt_mention_4.Text);

            for (int i = 0; i < n.Length; i++)
            {
                soma = soma + n[i];
            }

            double media = soma / n.Length;

            if (media < 5)
            {
                txt_result.ForeColor = Color.Red;
                result = "I";
            }
            else if (media <= 6.9 && media >= 5)
            {
                result = "R";
                txt_result.ForeColor = Color.Orange;
            }
            else if (media <= 8.9 && media >= 7)
            {
                txt_result.ForeColor = Color.LightBlue;
                result = "B";
            }
            else
            {
                txt_result.ForeColor = Color.Blue;
                result = "MB";
            }

            txt_result.Text = result;
        }

    }
}
