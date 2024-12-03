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
            grpCategoria.Location = new Point(47, 47);
            grpCategoria.Margin = new Padding(3, 4, 3, 4);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Padding = new Padding(3, 4, 3, 4);
            grpCategoria.Size = new Size(318, 236);
            grpCategoria.TabIndex = 0;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "Insira o nome da nova categoria";
            // 
            // bttnAlterar
            // 
            bttnAlterar.BackColor = Color.Blue;
            bttnAlterar.FlatStyle = FlatStyle.Popup;
            bttnAlterar.Location = new Point(7, 180);
            bttnAlterar.Margin = new Padding(3, 4, 3, 4);
            bttnAlterar.Name = "bttnAlterar";
            bttnAlterar.Size = new Size(302, 33);
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
            bttnExcluir.Location = new Point(7, 137);
            bttnExcluir.Margin = new Padding(3, 4, 3, 4);
            bttnExcluir.Name = "bttnExcluir";
            bttnExcluir.Size = new Size(302, 35);
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
            buttCadastrar.Location = new Point(7, 95);
            buttCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttCadastrar.Name = "buttCadastrar";
            buttCadastrar.Size = new Size(302, 35);
            buttCadastrar.TabIndex = 1;
            buttCadastrar.Text = "Cadastrar";
            buttCadastrar.UseVisualStyleBackColor = false;
            buttCadastrar.Click += buttCadastrar_Click;
            // 
            // textVisor
            // 
            textVisor.BackColor = Color.White;
            textVisor.BorderStyle = BorderStyle.None;
            textVisor.Location = new Point(7, 44);
            textVisor.Margin = new Padding(3, 4, 3, 4);
            textVisor.Multiline = true;
            textVisor.Name = "textVisor";
            textVisor.Size = new Size(302, 31);
            textVisor.TabIndex = 1;
            textVisor.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = Color.Black;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.GridColor = Color.Black;
            dgvCategoria.Location = new Point(391, 69);
            dgvCategoria.Margin = new Padding(3, 4, 3, 4);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(297, 191);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // grpbAlterarSenha
            // 
            grpbAlterarSenha.Controls.Add(bttnAleteraSenha);
            grpbAlterarSenha.Controls.Add(txtVisorNovaSenha);
            grpbAlterarSenha.ForeColor = Color.White;
            grpbAlterarSenha.Location = new Point(750, 69);
            grpbAlterarSenha.Margin = new Padding(3, 4, 3, 4);
            grpbAlterarSenha.Name = "grpbAlterarSenha";
            grpbAlterarSenha.Padding = new Padding(3, 4, 3, 4);
            grpbAlterarSenha.Size = new Size(333, 191);
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
            bttnAleteraSenha.Location = new Point(16, 116);
            bttnAleteraSenha.Margin = new Padding(3, 4, 3, 4);
            bttnAleteraSenha.Name = "bttnAleteraSenha";
            bttnAleteraSenha.Size = new Size(299, 33);
            bttnAleteraSenha.TabIndex = 1;
            bttnAleteraSenha.Text = "Alterar Senha";
            bttnAleteraSenha.UseVisualStyleBackColor = false;
            bttnAleteraSenha.Click += bttnAleteraSenha_Click;
            // 
            // txtVisorNovaSenha
            // 
            txtVisorNovaSenha.Location = new Point(16, 52);
            txtVisorNovaSenha.Margin = new Padding(3, 4, 3, 4);
            txtVisorNovaSenha.Multiline = true;
            txtVisorNovaSenha.Name = "txtVisorNovaSenha";
            txtVisorNovaSenha.Size = new Size(299, 35);
            txtVisorNovaSenha.TabIndex = 0;
            txtVisorNovaSenha.TextChanged += txtVisorNovaSenha_TextChanged;
            // 
            // bttnVoltar
            // 
            bttnVoltar.BackColor = Color.Blue;
            bttnVoltar.FlatStyle = FlatStyle.Popup;
            bttnVoltar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnVoltar.ForeColor = Color.White;
            bttnVoltar.Location = new Point(1003, 289);
            bttnVoltar.Margin = new Padding(3, 4, 3, 4);
            bttnVoltar.Name = "bttnVoltar";
            bttnVoltar.Size = new Size(79, 36);
            bttnVoltar.TabIndex = 3;
            bttnVoltar.Text = "Voltar";
            bttnVoltar.UseVisualStyleBackColor = false;
            bttnVoltar.Click += bttnVoltar_Click;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1135, 341);
            Controls.Add(bttnVoltar);
            Controls.Add(grpbAlterarSenha);
            Controls.Add(dgvCategoria);
            Controls.Add(grpCategoria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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