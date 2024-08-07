using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;


namespace Animais_trabalho_CRUD 
{
    class Animal : conexao
    {
        private string nome;
        private string especie;
        private string codigo;
        private string genero;
        private string patas;


        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setEspecie(string especie)
        {
            this.especie = especie;
        }
        public string getEspecie()
        {
            return this.especie;
        }
        public void setPatas(string patas)
        {
            this.patas = patas;
        }
        public string getPatas()
        {
            return this.patas;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }
        public string getGenero()
        {
            return this.genero;
        }
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCodigo()
        {
            return this.codigo;
        }

        // Método para inserir as informações
        public void inserir()
        {
            string query = "INSERT INTO animal(nome_animal, especie_animal, patas_animal, genero_animal)VALUES('" + getNome() + "','" + getEspecie() + "','" + getPatas() + "','" + getGenero() + "')";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir()
        {
            string query = "DELETE FROM animal WHERE codigo_animal = '" + getCodigo() + "'";
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

            string mSQL = "SELECT * FROM animal";
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
            string query = "UPDATE animal SET nome_animal = '" + getNome() + "', especie_animal = '" + getEspecie() + "', patas_animal = '" + getPatas() + "', genero_animal = '" + getGenero() + "'  WHERE codigo_animal = '" + getCodigo() + "' ";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

    }
}
