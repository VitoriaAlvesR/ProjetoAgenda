using ProjetoAgenda.Controller;
using ProjetoAgenda.Views;

namespace ProjetoAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            //Se o usuário for diferente de vazio e a quantidade de caracteres na Senha for maior que 8 habilita o botão de login
            if (txtVisorUsuario.Text.Length > 0 && txtVisorSenha.Text.Length >= 8)
            {
                bttnEntrar.Enabled = true;
            }
            else
            {
                bttnEntrar.Enabled = false;
            }
        }

        private void bttnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void txtVisorUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void txtVisorSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void bttnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.LogarUsuario(txtVisorUsuario.Text,txtVisorSenha.Text);

            //Mensagem par teste do comando acima.
            //MessageBox.Show(resultado.ToString());

            // Autorização de Usuário estar correto ou não
            if (resultado == true)
            {
                MessageBox.Show("Bem-vido a sua tela principal");

                this.Hide();
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos, tente novamente");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
