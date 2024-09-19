using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_miguelisack
{
    public partial class frm_prova : Form
    {
        public frm_prova()
        {
            InitializeComponent();
        }

        prova p = new prova();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                p.setAtr1(txt_atr1.Text);
                p.setAtr2(txt_atr2.Text);

                

                p.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso!");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.Consultar();
        }
        

        /*private void btn_excluir_Click(object sender, EventArgs e)
        {

            try
            {
                ani.setCodigo(txt_codigo.Text);
                ani.excluir();
                dataGridView1.DataSource = ani.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações excluídas");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                ani.setCodigo(txt_codigo.Text);
                ani.setNome(txt_nome.Text);
                ani.setEspecie(txt_especie.Text);
                ani.setGenero(txt_genero.Text);
                ani.setPatas(txt_patas.Text);

                ani.alterar();
                dataGridView1.DataSource = ani.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações Alteradas");
            }
        }
*/
        public void exibir_registro(int i)
        {
            

            txt_atr1.Text = "" + dataGridView1[0, i].Value;
            txt_atr2.Text = "" + dataGridView1[1, i].Value;
            

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibir_registro(dataGridView1.CurrentRow.Index);
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.Consultar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                p.setAtr4(txt_atr4.Text);
                p.excluir();
                dataGridView1.DataSource = p.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações excluídas");
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                p.setAtr3(txt_Atr3.Text);
                

                p.alterar();
                dataGridView1.DataSource = p.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações Alteradas");
            }
        }
        /*
private void button1_Click(object sender, EventArgs e)
{
txt_codigo.Text = "";
txt_nome.Text = "";
txt_especie.Text = "";
txt_patas.Text = "";
txt_genero.Text = "";
}
*/
    }
}
