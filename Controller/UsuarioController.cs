using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
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
            //Cria a conexão, estou utilizando a classe ConexaoDB que esta dentro da pasta DATA
            MySqlConnection conexao = ConexaoDB.CriarConexao();

            //Comando SQL que será executado
            string sql = "INSERT INTO tbUsuarios(nome, usuario, telefone, senha) VALUES(@nome, @usuario, @telefone, @senha);";

            //Abrir a conexão com o banco
            conexao.Open();

            //Responsável por executar o comando SQL
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            //Troca do valor dado pelos @ pelas informações que serão cadastradas
            // Essas informações vieram dos parametros da função
            comando.Parameters.AddWithValue("@nome",nome);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@telefone",telefone);
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
    }
}
