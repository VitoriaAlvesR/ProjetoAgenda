using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategoria(string nomeCategoria)
        {
            MySqlConnection conexao = null;
            try
            {
                //Criando a conexão, estou utilizando a classe ConexaoDB que esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao(UserSession.usuario,UserSession.senha); 

                //Comando do SQL que será executado
                string sql = "INSERT INTO tbCategoria (nomeCategoria) VALUES (@nomeCategoria);";

                //Abrindo a conexão
                conexao.Open();

                //Comando responsável por estar execultando o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Troca do valor dado pelos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nomeCategoria", nomeCategoria);

                //Execusão no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro da categotia: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;
            try
            {
                //Criação da conexao, reutilizei ConexaoDB que já estava criada.
                conexao = ConexaoDB.CriarConexao(UserSession.usuario,UserSession.senha);

                //SELECT - Retornar os dados.
                string sql = @"SELECT codCategoria AS 'Código', nomeCategoria AS 'Categoria' FROM tbCategoria
                              WHERE usuario = User();";

                //Abrindo Conexão.
                conexao.Open();

                // Utilização do MySqlDataAdapter pois quero apenas trabalhar com a tabela inteira.
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Criação de uma tabela vazia
                DataTable tabela = new DataTable();

                //Adaptador para preencher a tabela com os dados
                adaptador.Fill(tabela);

                //Retornando a tabela
                return tabela;

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar categorias: {erro.Message}");
                //Retornando algo para nn dar erro no 'GetCatefgorias'
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable DeleteTable(int codCategoria)
        {
            MySqlConnection conexao = null;
            try
            {
                //Criando a conexão, estou utilizando a classe ConexaoDB que esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao(UserSession.usuario,UserSession.senha);

                //Comando do SQL que será executado
                string sql = @$"DELETE FROM  tbCategoria WHERE codCategoria = {codCategoria} ";

                //Abrindo a conexão
                conexao.Open();

                //Comando responsável por estar execultando o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Troca do valor dado pelos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@codigo", codCategoria);

                //Execusão no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return new DataTable();
                }
                else
                {
                    return new DataTable();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir categoria: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable AlterarTable (int codCategoria, string Category)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao(UserSession.usuario,UserSession.senha);
                string sql =@$"UPDATE  tbCategoria 
                               SET  nomeCategoria = '{Category}'
                               WHERE codCategoria = @codigo ";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", codCategoria);
                comando.Parameters.AddWithValue("@nomeCategoria", Category);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return new DataTable();
                }
                else
                {
                    return new DataTable();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao alterar categoria: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
