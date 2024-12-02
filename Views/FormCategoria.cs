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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }
        private void buttCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciando o objeto AddCategoria
            CategoriaController controleCategoria = new CategoriaController();

            //Inserindo a categoria
            bool resultado = controleCategoria.AddCategoria(textVisor.Text);
            if (resultado)
            {
                MessageBox.Show("Cadastro da categoria efetuado com sucessso");


            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar a categoria.");
            }

            //Comando para aparecer o dgvCategoria.
            CategoriaController controle = new CategoriaController();

            DataTable table = controle.GetCategorias();

            dgvCategoria.DataSource = table;
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizaDataGread()
        {
            //Comando para aprecer em lista no dgvCategoria
            CategoriaController controle = new CategoriaController();

            DataTable table = controle.GetCategorias();

            dgvCategoria.DataSource = table;
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            AtualizaDataGread();
        }

        private void bttnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);

            CategoriaController categoriaController = new CategoriaController();
            categoriaController.DeleteTable(codigo);

            AtualizaDataGread();
        }

        private void bttnAlterar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);

            string Category = textVisor.Text;

            CategoriaController catecontroller = new CategoriaController();
            catecontroller.AlterarTable(codigo, Category);

            AtualizaDataGread();
        }

        private void txtVisorNovaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnAleteraSenha_Click(object sender, EventArgs e)
        {

        }

        private void bttnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.ShowDialog();
        }
    }
}
