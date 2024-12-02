namespace ProjetoAgenda.Views
{
    partial class FormContatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvContatos = new DataGridView();
            grpContatos = new GroupBox();
            bttnAlterarUsuario = new Button();
            bttnExcluirUsuario = new Button();
            buttCadastrarUsuario = new Button();
            textVisorContato = new TextBox();
            bttnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            grpContatos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvContatos
            // 
            dgvContatos.BackgroundColor = Color.Black;
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.GridColor = Color.Black;
            dgvContatos.Location = new Point(417, 62);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(260, 143);
            dgvContatos.TabIndex = 2;
            // 
            // grpContatos
            // 
            grpContatos.BackColor = Color.Black;
            grpContatos.Controls.Add(bttnAlterarUsuario);
            grpContatos.Controls.Add(bttnExcluirUsuario);
            grpContatos.Controls.Add(buttCadastrarUsuario);
            grpContatos.Controls.Add(textVisorContato);
            grpContatos.ForeColor = Color.White;
            grpContatos.Location = new Point(77, 46);
            grpContatos.Name = "grpContatos";
            grpContatos.Size = new Size(275, 159);
            grpContatos.TabIndex = 3;
            grpContatos.TabStop = false;
            grpContatos.Text = "Insira os contatos";
            // 
            // bttnAlterarUsuario
            // 
            bttnAlterarUsuario.BackColor = Color.Blue;
            bttnAlterarUsuario.FlatStyle = FlatStyle.Popup;
            bttnAlterarUsuario.Location = new Point(5, 120);
            bttnAlterarUsuario.Name = "bttnAlterarUsuario";
            bttnAlterarUsuario.Size = new Size(264, 26);
            bttnAlterarUsuario.TabIndex = 7;
            bttnAlterarUsuario.Text = "Alterar Usuário";
            bttnAlterarUsuario.UseVisualStyleBackColor = false;
            // 
            // bttnExcluirUsuario
            // 
            bttnExcluirUsuario.BackColor = Color.Blue;
            bttnExcluirUsuario.BackgroundImageLayout = ImageLayout.Center;
            bttnExcluirUsuario.FlatStyle = FlatStyle.Popup;
            bttnExcluirUsuario.Location = new Point(5, 88);
            bttnExcluirUsuario.Name = "bttnExcluirUsuario";
            bttnExcluirUsuario.Size = new Size(264, 27);
            bttnExcluirUsuario.TabIndex = 6;
            bttnExcluirUsuario.Text = "Excluir";
            bttnExcluirUsuario.UseVisualStyleBackColor = false;
            // 
            // buttCadastrarUsuario
            // 
            buttCadastrarUsuario.BackColor = Color.Blue;
            buttCadastrarUsuario.BackgroundImageLayout = ImageLayout.Center;
            buttCadastrarUsuario.FlatStyle = FlatStyle.Popup;
            buttCadastrarUsuario.Location = new Point(5, 56);
            buttCadastrarUsuario.Name = "buttCadastrarUsuario";
            buttCadastrarUsuario.Size = new Size(264, 27);
            buttCadastrarUsuario.TabIndex = 4;
            buttCadastrarUsuario.Text = "Cadastrar ";
            buttCadastrarUsuario.UseVisualStyleBackColor = false;
            // 
            // textVisorContato
            // 
            textVisorContato.BackColor = Color.White;
            textVisorContato.BorderStyle = BorderStyle.None;
            textVisorContato.Location = new Point(5, 22);
            textVisorContato.Multiline = true;
            textVisorContato.Name = "textVisorContato";
            textVisorContato.Size = new Size(264, 24);
            textVisorContato.TabIndex = 5;
            textVisorContato.TextAlign = HorizontalAlignment.Center;
            // 
            // bttnVoltar
            // 
            bttnVoltar.BackColor = Color.Blue;
            bttnVoltar.FlatStyle = FlatStyle.Popup;
            bttnVoltar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnVoltar.ForeColor = Color.White;
            bttnVoltar.Location = new Point(691, 230);
            bttnVoltar.Name = "bttnVoltar";
            bttnVoltar.Size = new Size(69, 27);
            bttnVoltar.TabIndex = 4;
            bttnVoltar.Text = "Voltar";
            bttnVoltar.UseVisualStyleBackColor = false;
            // 
            // FormContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fundo_principal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(772, 269);
            Controls.Add(bttnVoltar);
            Controls.Add(grpContatos);
            Controls.Add(dgvContatos);
            Name = "FormContatos";
            Text = "FormContatos";
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            grpContatos.ResumeLayout(false);
            grpContatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContatos;
        private GroupBox grpContatos;
        private Button bttnVoltar;
        private Button bttnAlterarUsuario;
        private Button bttnExcluirUsuario;
        private Button buttCadastrarUsuario;
        private TextBox textVisorContato;
    }
}