using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Data
{
    static public class ConexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            //String com informações para uma conexão.
            string stringConexao = "Server=localhost;Database=dbAgenda;User ID=root;Password=root;";

            //Criando a conxão.
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }

        static public MySqlConnection CriarConexao(string usuario, string senha)
        {
            //String com informações para uma conexão.
            string stringConexao = $"Server=localhost;Database=dbAgenda;User ID={usuario};Password={senha};";

            //Criando a conxão.
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }
    }
}
