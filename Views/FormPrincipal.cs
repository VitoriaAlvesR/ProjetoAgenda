using ProjetoAgenda.VariableGlobal;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            lblMensage.Text = $"Seja bem-vindo, {UserSession.nome} ";
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCategoria form = new FormCategoria();
            form.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
            

        }

        private void lblMensage_Click(object sender, EventArgs e)
        {
           
        }
    }
}
