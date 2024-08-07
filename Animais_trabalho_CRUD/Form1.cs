using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animais_trabalho_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Animal ani = new Animal();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                ani.setNome(txt_nome.Text);
                ani.setEspecie(txt_especie.Text);
                ani.setGenero(txt_genero.Text);
                ani.setPatas(txt_patas.Text);

                ani.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso!");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ani.Consultar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
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
    }
}
