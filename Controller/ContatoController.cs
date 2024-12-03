using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {
        public bool AddContato(string nomeContato)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = "INSERT INTO tbContato (nomeConato) VALUES (@nomeContato);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nomeContato", nomeContato);

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
            catch(Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro do contato: {erro.Message}");
                return false;
            }

        }

        public DataTable GetContatos()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = @"";

                conexao.Open();

                MySqlDataAdapter adapta = new MySqlDataAdapter(sql, conexao);

                DataTable table = new DataTable();

                adapta.Fill(table);

                return table;
            }
            catch (Exception erro) 
            {
                MessageBox.Show($"Erro ao recuperar os contatos: {erro.Message}");

                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable DeletTable (int codContato)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = @"";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("cod", codContato);

                int linhasAfetadas = comando.ExecuteNonQuery();
                if(linhasAfetadas > 0 )
                {
                    return new DataTable();
                }
                else
                {
                    return new DataTable();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show($"Erro ao excluir contato: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();

            }
        }
        public DataTable AlterarTable(int codContato, string Contat)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();
                string sql = @$"UPDATE tbContato
                                SET nomeContato = '{Contat}
                                WHERE codConatto = @cod";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@cod", codContato);
                comando.Parameters.AddWithValue("@Contat", Contat);

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
                MessageBox.Show($"Erro ao alterar contato: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
