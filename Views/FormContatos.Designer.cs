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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContatos));
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
            dgvContatos.Location = new Point(477, 83);
            dgvContatos.Margin = new Padding(3, 4, 3, 4);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.RowHeadersWidth = 51;
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(297, 191);
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
            grpContatos.Location = new Point(88, 61);
            grpContatos.Margin = new Padding(3, 4, 3, 4);
            grpContatos.Name = "grpContatos";
            grpContatos.Padding = new Padding(3, 4, 3, 4);
            grpContatos.Size = new Size(314, 212);
            grpContatos.TabIndex = 3;
            grpContatos.TabStop = false;
            grpContatos.Text = "Insira os contatos";
            // 
            // bttnAlterarUsuario
            // 
            bttnAlterarUsuario.BackColor = Color.Blue;
            bttnAlterarUsuario.FlatStyle = FlatStyle.Popup;
            bttnAlterarUsuario.Location = new Point(6, 160);
            bttnAlterarUsuario.Margin = new Padding(3, 4, 3, 4);
            bttnAlterarUsuario.Name = "bttnAlterarUsuario";
            bttnAlterarUsuario.Size = new Size(302, 35);
            bttnAlterarUsuario.TabIndex = 7;
            bttnAlterarUsuario.Text = "Alterar Usuário";
            bttnAlterarUsuario.UseVisualStyleBackColor = false;
            bttnAlterarUsuario.Click += bttnAlterarUsuario_Click;
            // 
            // bttnExcluirUsuario
            // 
            bttnExcluirUsuario.BackColor = Color.Blue;
            bttnExcluirUsuario.BackgroundImageLayout = ImageLayout.Center;
            bttnExcluirUsuario.FlatStyle = FlatStyle.Popup;
            bttnExcluirUsuario.Location = new Point(6, 117);
            bttnExcluirUsuario.Margin = new Padding(3, 4, 3, 4);
            bttnExcluirUsuario.Name = "bttnExcluirUsuario";
            bttnExcluirUsuario.Size = new Size(302, 36);
            bttnExcluirUsuario.TabIndex = 6;
            bttnExcluirUsuario.Text = "Excluir";
            bttnExcluirUsuario.UseVisualStyleBackColor = false;
            bttnExcluirUsuario.Click += bttnExcluirUsuario_Click;
            // 
            // buttCadastrarUsuario
            // 
            buttCadastrarUsuario.BackColor = Color.Blue;
            buttCadastrarUsuario.BackgroundImageLayout = ImageLayout.Center;
            buttCadastrarUsuario.FlatStyle = FlatStyle.Popup;
            buttCadastrarUsuario.Location = new Point(6, 75);
            buttCadastrarUsuario.Margin = new Padding(3, 4, 3, 4);
            buttCadastrarUsuario.Name = "buttCadastrarUsuario";
            buttCadastrarUsuario.Size = new Size(302, 36);
            buttCadastrarUsuario.TabIndex = 4;
            buttCadastrarUsuario.Text = "Cadastrar ";
            buttCadastrarUsuario.UseVisualStyleBackColor = false;
            buttCadastrarUsuario.Click += buttCadastrarUsuario_Click;
            // 
            // textVisorContato
            // 
            textVisorContato.BackColor = Color.White;
            textVisorContato.BorderStyle = BorderStyle.None;
            textVisorContato.Location = new Point(6, 29);
            textVisorContato.Margin = new Padding(3, 4, 3, 4);
            textVisorContato.Multiline = true;
            textVisorContato.Name = "textVisorContato";
            textVisorContato.Size = new Size(302, 32);
            textVisorContato.TabIndex = 5;
            textVisorContato.TextAlign = HorizontalAlignment.Center;
            // 
            // bttnVoltar
            // 
            bttnVoltar.BackColor = Color.Blue;
            bttnVoltar.FlatStyle = FlatStyle.Popup;
            bttnVoltar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnVoltar.ForeColor = Color.White;
            bttnVoltar.Location = new Point(790, 307);
            bttnVoltar.Margin = new Padding(3, 4, 3, 4);
            bttnVoltar.Name = "bttnVoltar";
            bttnVoltar.Size = new Size(79, 36);
            bttnVoltar.TabIndex = 4;
            bttnVoltar.Text = "Voltar";
            bttnVoltar.UseVisualStyleBackColor = false;
            // 
            // FormContatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fundo_principal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 359);
            Controls.Add(bttnVoltar);
            Controls.Add(grpContatos);
            Controls.Add(dgvContatos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormContatos";
            Text = "FormContatos";
            Load += FormContatos_Load;
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