namespace ProjetoAgenda.Views
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            grpCategoria = new GroupBox();
            bttnAlterar = new Button();
            bttnExcluir = new Button();
            buttCadastrar = new Button();
            textVisor = new TextBox();
            dgvCategoria = new DataGridView();
            grpbAlterarSenha = new GroupBox();
            bttnAleteraSenha = new Button();
            txtVisorNovaSenha = new TextBox();
            bttnVoltar = new Button();
            grpCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            grpbAlterarSenha.SuspendLayout();
            SuspendLayout();
            // 
            // grpCategoria
            // 
            grpCategoria.BackgroundImageLayout = ImageLayout.Stretch;
            grpCategoria.Controls.Add(bttnAlterar);
            grpCategoria.Controls.Add(bttnExcluir);
            grpCategoria.Controls.Add(buttCadastrar);
            grpCategoria.Controls.Add(textVisor);
            grpCategoria.ForeColor = Color.White;
            grpCategoria.Location = new Point(41, 35);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Size = new Size(278, 177);
            grpCategoria.TabIndex = 0;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "Insira o nome da nova categoria";
            // 
            // bttnAlterar
            // 
            bttnAlterar.BackColor = Color.Blue;
            bttnAlterar.FlatStyle = FlatStyle.Popup;
            bttnAlterar.Location = new Point(6, 135);
            bttnAlterar.Name = "bttnAlterar";
            bttnAlterar.Size = new Size(264, 25);
            bttnAlterar.TabIndex = 3;
            bttnAlterar.Text = "Alterar Categoria";
            bttnAlterar.UseVisualStyleBackColor = false;
            bttnAlterar.Click += bttnAlterar_Click;
            // 
            // bttnExcluir
            // 
            bttnExcluir.BackColor = Color.Blue;
            bttnExcluir.BackgroundImageLayout = ImageLayout.Center;
            bttnExcluir.FlatStyle = FlatStyle.Popup;
            bttnExcluir.Location = new Point(6, 103);
            bttnExcluir.Name = "bttnExcluir";
            bttnExcluir.Size = new Size(264, 26);
            bttnExcluir.TabIndex = 2;
            bttnExcluir.Text = "Excluir";
            bttnExcluir.UseVisualStyleBackColor = false;
            bttnExcluir.Click += bttnExcluir_Click;
            // 
            // buttCadastrar
            // 
            buttCadastrar.BackColor = Color.Blue;
            buttCadastrar.BackgroundImageLayout = ImageLayout.Center;
            buttCadastrar.FlatStyle = FlatStyle.Popup;
            buttCadastrar.Location = new Point(6, 71);
            buttCadastrar.Name = "buttCadastrar";
            buttCadastrar.Size = new Size(264, 26);
            buttCadastrar.TabIndex = 1;
            buttCadastrar.Text = "Cadastrar";
            buttCadastrar.UseVisualStyleBackColor = false;
            buttCadastrar.Click += buttCadastrar_Click;
            // 
            // textVisor
            // 
            textVisor.BackColor = Color.White;
            textVisor.BorderStyle = BorderStyle.None;
            textVisor.Location = new Point(6, 33);
            textVisor.Multiline = true;
            textVisor.Name = "textVisor";
            textVisor.Size = new Size(264, 23);
            textVisor.TabIndex = 1;
            textVisor.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = Color.Black;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.GridColor = Color.Black;
            dgvCategoria.Location = new Point(342, 52);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(260, 143);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // grpbAlterarSenha
            // 
            grpbAlterarSenha.Controls.Add(bttnAleteraSenha);
            grpbAlterarSenha.Controls.Add(txtVisorNovaSenha);
            grpbAlterarSenha.ForeColor = Color.White;
            grpbAlterarSenha.Location = new Point(656, 52);
            grpbAlterarSenha.Name = "grpbAlterarSenha";
            grpbAlterarSenha.Size = new Size(291, 143);
            grpbAlterarSenha.TabIndex = 2;
            grpbAlterarSenha.TabStop = false;
            grpbAlterarSenha.Text = "Alterar Senha";
            // 
            // bttnAleteraSenha
            // 
            bttnAleteraSenha.BackColor = Color.Blue;
            bttnAleteraSenha.FlatStyle = FlatStyle.Popup;
            bttnAleteraSenha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnAleteraSenha.ForeColor = Color.White;
            bttnAleteraSenha.Location = new Point(14, 87);
            bttnAleteraSenha.Name = "bttnAleteraSenha";
            bttnAleteraSenha.Size = new Size(262, 25);
            bttnAleteraSenha.TabIndex = 1;
            bttnAleteraSenha.Text = "Alterar Senha";
            bttnAleteraSenha.UseVisualStyleBackColor = false;
            bttnAleteraSenha.Click += bttnAleteraSenha_Click;
            // 
            // txtVisorNovaSenha
            // 
            txtVisorNovaSenha.Location = new Point(14, 39);
            txtVisorNovaSenha.Multiline = true;
            txtVisorNovaSenha.Name = "txtVisorNovaSenha";
            txtVisorNovaSenha.Size = new Size(262, 27);
            txtVisorNovaSenha.TabIndex = 0;
            txtVisorNovaSenha.TextChanged += txtVisorNovaSenha_TextChanged;
            // 
            // bttnVoltar
            // 
            bttnVoltar.BackColor = Color.Blue;
            bttnVoltar.FlatStyle = FlatStyle.Popup;
            bttnVoltar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnVoltar.ForeColor = Color.White;
            bttnVoltar.Location = new Point(878, 217);
            bttnVoltar.Name = "bttnVoltar";
            bttnVoltar.Size = new Size(69, 27);
            bttnVoltar.TabIndex = 3;
            bttnVoltar.Text = "Voltar";
            bttnVoltar.UseVisualStyleBackColor = false;
            bttnVoltar.Click += bttnVoltar_Click;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(993, 256);
            Controls.Add(bttnVoltar);
            Controls.Add(grpbAlterarSenha);
            Controls.Add(dgvCategoria);
            Controls.Add(grpCategoria);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormCategoria";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Categoria";
            Load += FormCategoria_Load;
            grpCategoria.ResumeLayout(false);
            grpCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            grpbAlterarSenha.ResumeLayout(false);
            grpbAlterarSenha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCategoria;
        private Button buttCadastrar;
        private TextBox textVisor;
        private DataGridView dgvCategoria;
        private GroupBox grpbAlterarSenha;
        private Button bttnExcluir;
        private Button bttnAleteraSenha;
        private TextBox txtVisorNovaSenha;
        private Button bttnAlterar;
        private Button bttnVoltar;
    }
}