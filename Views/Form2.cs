using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void habilitarBotaoCadastrar()
        {
            if (txtVisorNome.Text.Length > 0 && txtVisorUsuario.Text.Length > 0 && txtTelefone.Text.Length > 0 && txtSenha.Text.Length >= 8 && txtSenha.Text == txtRepitirSenha.Text & checkConfirmar.Checked)
            {
                bttnCadastrar.Enabled = true;
            }
            else
            {
                bttnCadastrar.Enabled = false;
            }
        }

        private void txtVisorNome_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtVisorUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtRepitirSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void checkConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void bttnCadastrar_Click(object sender, EventArgs e)
        {
            //Criação de uma conexão.
            MySqlConnection conexao = ConexaoDB.CriarConexao();
            
            //Abrindo conexão com o banco.
            conexao.Open();
            
            //Crinado um comando MySQL para a realização de inserir o usuário.
            string sql = $"Insert into tbUsuarios (nome, usuario, telefone, senha) values (@nome,@usuario,@telefone,@senha)";
            
            //Criando comando.
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            //Comando para substituir os '@', evitando utilizar '); DROP DATABESE dbAgenda; -- ' (comando para excluir um banco de dados, normalmente muito utilizado em senhas).
            comando.Parameters.AddWithValue("@nome",txtVisorNome.Text);
            comando.Parameters.AddWithValue("@usuario", txtVisorUsuario.Text);
            comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);

            //Execultando a instrução SQL no banco de dados.
            // O "ExecuteNonQuery" não retorna nada para mim.
            comando.ExecuteNonQuery();

            //Fechando conexão com o banco.
            conexao.Close();

            //Aparecer a mensagem avisando que o cadastro deu certo.
            MessageBox.Show("Cadastro efetuado com sucesso! \n Você já poderá realizar o login!");
            
            //Fechando a tela de cadastro e arbindo a tela de login.
            this.Close();
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
