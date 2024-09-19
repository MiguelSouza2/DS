using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;


namespace prova_miguelisack
{
    class prova : conexao
    {
        private string atributo1;
        private string atributo2;
        private string atributo3;
        private string atributo4;


        public void setAtr1(string atributo1)
        {
            this.atributo1 = atributo1;
        }
        public string getAtr1()
        {
            return this.atributo1;
        }
        public void setAtr2(string atributo2)
        {
            this.atributo2 = atributo2;
        }
        public string getAtr2()
        {
            return this.atributo2;
        }
        public void setAtr3(string atributo3)
        {
            this.atributo3 = atributo3;
        }
        public string getAtr3()
        {
            return this.atributo3;
        }
        public void setAtr4(string atributo4)
        {
            this.atributo4 = atributo4;
        }
        public string getAtr4()
        {
            return this.atributo4;
        }




        // Método para inserir as informações
        public void inserir()
        {
            string query = "INSERT INTO dados(Atributo, atributo2)VALUES('" + getAtr1() + "','" + getAtr2() + "')";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir()
        {
            string query = "DELETE FROM dados WHERE Atributo = '" + getAtr4() + "'";
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

            string mSQL = "SELECT * FROM dados";
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
            string query = "UPDATE dados SET atributto3 = '" + getAtr3() + "' WHERE Atributo = '" + getAtr1() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

    }
}
