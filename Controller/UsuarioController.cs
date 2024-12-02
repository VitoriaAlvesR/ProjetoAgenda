using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que esta dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "INSERT INTO tbUsuarios(nome, usuario, telefone, senha) VALUES(@nome, @usuario, @telefone, @senha);" +
                              $"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';" +
                              $"GRANT ALL PRIVILEGES ON dbagenda.* TO '{usuario}'@'%';" +
                               "FLUSH PRIVILEGES;";

                //Abrir a conexão com o banco
                conexao.Open();

                //Responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Troca do valor dado pelos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

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
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }
            // Independente do que acontecer, execulte mesmo assim.
            //finally
            //{
            //    conexao.Close();
            //}
        }
        
        public bool LogarUsuario(string usuario, string senha)
        {
            try 
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao(usuario,senha);

                string sql = $@"select nome,usuario,senha,telefone from tbUsuarios
                                where usuario = '{usuario}'
                                and BINARY senha = '{senha}';";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand (sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                //Comando para execultar retornando os dados que foram utilizados
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    UserSession.nome = resultado.GetString("nome");
                    UserSession.usuario = resultado.GetString("usuario");
                    UserSession.senha = resultado.GetString("senha");
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }
    }
}
