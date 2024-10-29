using MySql.Data.MySqlClient;
using ProjetoAgenda.Controller;
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
            if (txtVisorNome.Text.Length > 0 && txtVisorUsuario.Text.Length > 0 && txtSenha.Text.Length >= 8 && txtSenha.Text == txtRepitirSenha.Text & checkConfirmar.Checked)
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

            //Peganod os dados do formulario
            string nome = txtVisorNome.Text;
            string usuario = txtVisorUsuario.Text;
            string telefone = txtTelefone.Text;
            string senha = txtSenha.Text;

            //Instanciando o objeto UsuarioController
            UsuarioController controleUsuario = new UsuarioController();

            //Inserindo o usuário
            bool resultado = controleUsuario.AddUsuario(nome, usuario, telefone, senha);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucessso");
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o usuário.");
            }
        }
    }
}
