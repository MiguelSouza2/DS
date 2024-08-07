using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace exemplo_crud
{
    class colaborador : conexao
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private string codigo;

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string getCodigo()
        {
            return this.codigo;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;

        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return this.cpf;

        }

        // Método para inserir as informações
        public void inserir()
        {
            string query = "INSERT INTO colaborador(nome_colaborador,sobrenome_colaborador,cpf_colaborador)VALUES('" + getNome() + "','" + getSobrenome() + "','" + getCpf() + "')";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir()
        {
            string query = "DELETE FROM colaborador WHERE codigo_colaborador = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        /*
            Criar um método para consultar
            Colocar biblioteca Using System.Data
        */
        public DataTable Consultar()
        {
            this.abrirconexao();

            string mSQL = "SELECT * FROM colaborador";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();
            // Retornar a consulta SQL em formato de tabela
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }


        public void alterar()
        {
            string query = "UPDATE colaborador SET nome_colaborador = '"+ getNome() + "', sobrenome_colaborador = '" + getSobrenome() + "', cpf_colaborador = '" + getCpf() + "' WHERE codigo_colaborador = '" + getCodigo() + "' ";
            if(this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        

    }
}
