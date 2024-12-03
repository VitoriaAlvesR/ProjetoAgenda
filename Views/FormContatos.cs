using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class FormContatos : Form
    {
        public FormContatos()
        {
            InitializeComponent();
        }

        private void buttCadastrarUsuario_Click(object sender, EventArgs e)
        {
            ContatoController controleContato = new ContatoController();

            bool result = controleContato.AddContato(textVisorContato.Text);
            if (result)
            {
                MessageBox.Show("Cadastro do contato efetuado com sucesso!");

            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o novo contato.");
            }

            ContatoController control = new ContatoController();
            DataTable tb = control.GetContatos();

            dgvContatos.DataSource = tb;
        }

        private void AtualizaDataGread()
        {
            ContatoController control = new ContatoController();
            DataTable tb = control.GetContatos();
            dgvContatos.DataSource = tb;

        }

        private void FormContatos_Load(object sender, EventArgs e)
        {
            AtualizaDataGread();
        }

        private void bttnExcluirUsuario_Click(object sender, EventArgs e)
        {
            int cod = ConvertToInt32(dvgContatos.SelectedRows[0].Cells[0].Value);

            ContatoController contatoController = new ContatoController();
            contatoController.DeletTable(cod);

            AtualizaDataGread();
        }

        private void bttnAlterarUsuario_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInto32(dgvContatos.SelectedRows[0].Cells[0].Value);

            string Contat = textVisorContato.Text;
            ContatoController contcontroller = new ContatoController();
            contcontroller.AlterarTable(cod, Contat);

            AtualizaDataGread();
        }
    }
}
