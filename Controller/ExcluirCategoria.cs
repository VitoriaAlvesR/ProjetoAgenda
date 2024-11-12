using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ExcluirCategoria
    {
        public ExcluirCategoria (string codCatego)
        {
            MySqlConnection conexao = null;
            try
            {
                //Criando a conexão, estou utilizando a classe ConexaoDB que esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao();

                //Comando do SQL que será executado
                string sql = @"DELETE FROM tbcategoria WHERE (codCategoria) VALUES (@codigo);";

                //Abrindo a conexão
                conexao.Open();

                //Comando responsável por estar execultando o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Troca do valor dado pelos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@codigo",codCatego);

                //Execusão no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                //Fechandno conexao
                conexao.Close();

            }
            catch (Exception erro)
            {

            }
        }
    }
}
