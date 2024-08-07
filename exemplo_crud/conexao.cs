using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Biblioteca para conexão ao MySQL

using MySql.Data;
using MySql.Data.MySqlClient;

namespace exemplo_crud
{
    class conexao
    {
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;

        public conexao()
        {
            inicializar();
        }

        public void inicializar()
        {
            servidor = "127.0.0.1";
            // local onde está localizado o banco de dados (online ou local) quando está local 127.0.0.1 ou localhost. Quando estiver online é necessário saber o ip do servidor ou nome do servidor
            database = "crud_csharp";
            // database do banco de dados que iremos criar futuramente
            usuario = "root";
            senha = "";
            // usuário e senha padrôes (root e senha em branco). Em acesso online necessário colocar usuário e senha de acesso

            string conexaostring;
            conexaostring = "SERVER=" + servidor + ";" + "DATABASE=" + database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";";

            // variável conectar utilizada para localizar e acessar o banco de  dados (local ou online)
            conectar = new MySqlConnection(conexaostring);
        }

        // Abertura da conexão

        public bool abrirconexao() //try é um tratamento de erro
        {                          // O que está dentro do try deve ser executado
            try                    // O que está dentro do catch é a exceção do try
            {                      // Caso o try não execute ou não funcione será direcionado para o catch
                conectar.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possível conectar");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuário e senha inválidos");
                        break;
                }
                return false;
            }
        }
        // fechar conexão   

        public bool fecharconexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;   
            }
        }


    }
}
