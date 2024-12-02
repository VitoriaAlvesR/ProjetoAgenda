using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
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
    }
}
