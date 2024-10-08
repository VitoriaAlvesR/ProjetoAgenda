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

        }
    }
}
