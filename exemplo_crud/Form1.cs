using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        colaborador c = new colaborador();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c.setNome(txt_nome.Text);
                c.setSobrenome(txt_sobrenome.Text);
                c.setCpf(txt_cpf.Text);
                c.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso!");
            }

        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();
            //Alteração deos nomes das colunas do datagridview
            dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
            dataGridView1.Columns["codigo_colaborador"].HeaderText = "Código";
            dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
            dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCodigo(txt_codigo.Text);
                c.excluir();
                dataGridView1.DataSource = c.Consultar();
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
                c.setCodigo(txt_codigo.Text);
                c.setNome(txt_nome.Text);
                c.setSobrenome(txt_sobrenome.Text);
                c.setCpf(txt_cpf.Text);
                c.alterar();

                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

        }
    }
}
