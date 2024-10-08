namespace ProjetoAgenda
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            txtVisorNome = new TextBox();
            txtVisorUsuario = new TextBox();
            txtTelefone = new TextBox();
            txtSenha = new TextBox();
            lblNome = new Label();
            lblUsuario = new Label();
            lblTelefone = new Label();
            lblSenha = new Label();
            lblRepetirSenha = new Label();
            txtRepitirSenha = new TextBox();
            bttnCadastrar = new Button();
            bttnCancelar = new Button();
            label7 = new Label();
            lblNaoSouRobo = new Label();
            checkConfirmar = new CheckBox();
            SuspendLayout();
            // 
            // txtVisorNome
            // 
            txtVisorNome.BackColor = Color.White;
            txtVisorNome.BorderStyle = BorderStyle.None;
            txtVisorNome.Location = new Point(67, 85);
            txtVisorNome.Multiline = true;
            txtVisorNome.Name = "txtVisorNome";
            txtVisorNome.Size = new Size(302, 23);
            txtVisorNome.TabIndex = 0;
            txtVisorNome.TextChanged += txtVisorNome_TextChanged;
            // 
            // txtVisorUsuario
            // 
            txtVisorUsuario.BorderStyle = BorderStyle.None;
            txtVisorUsuario.Location = new Point(67, 157);
            txtVisorUsuario.Multiline = true;
            txtVisorUsuario.Name = "txtVisorUsuario";
            txtVisorUsuario.Size = new Size(302, 23);
            txtVisorUsuario.TabIndex = 1;
            txtVisorUsuario.TextChanged += txtVisorUsuario_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Location = new Point(67, 228);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(302, 23);
            txtTelefone.TabIndex = 2;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(67, 288);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(198, 23);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(67, 67);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(67, 139);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuário";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(67, 210);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(53, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(67, 270);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(40, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // lblRepetirSenha
            // 
            lblRepetirSenha.AutoSize = true;
            lblRepetirSenha.BackColor = Color.Transparent;
            lblRepetirSenha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepetirSenha.ForeColor = Color.White;
            lblRepetirSenha.Location = new Point(67, 337);
            lblRepetirSenha.Name = "lblRepetirSenha";
            lblRepetirSenha.Size = new Size(83, 15);
            lblRepetirSenha.TabIndex = 8;
            lblRepetirSenha.Text = "Repita a senha";
            // 
            // txtRepitirSenha
            // 
            txtRepitirSenha.BorderStyle = BorderStyle.None;
            txtRepitirSenha.Location = new Point(67, 355);
            txtRepitirSenha.Multiline = true;
            txtRepitirSenha.Name = "txtRepitirSenha";
            txtRepitirSenha.Size = new Size(198, 23);
            txtRepitirSenha.TabIndex = 9;
            txtRepitirSenha.TextChanged += txtRepitirSenha_TextChanged;
            // 
            // bttnCadastrar
            // 
            bttnCadastrar.BackColor = SystemColors.Highlight;
            bttnCadastrar.Enabled = false;
            bttnCadastrar.FlatStyle = FlatStyle.Popup;
            bttnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnCadastrar.Location = new Point(67, 406);
            bttnCadastrar.Name = "bttnCadastrar";
            bttnCadastrar.Size = new Size(147, 23);
            bttnCadastrar.TabIndex = 10;
            bttnCadastrar.Text = "Cadastrar";
            bttnCadastrar.UseVisualStyleBackColor = false;
            // 
            // bttnCancelar
            // 
            bttnCancelar.BackColor = SystemColors.Highlight;
            bttnCancelar.FlatStyle = FlatStyle.Popup;
            bttnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnCancelar.Location = new Point(222, 406);
            bttnCancelar.Name = "bttnCancelar";
            bttnCancelar.Size = new Size(147, 23);
            bttnCancelar.TabIndex = 11;
            bttnCancelar.Text = "Cancelar";
            bttnCancelar.UseVisualStyleBackColor = false;
            bttnCancelar.Click += bttnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 220);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 14;
            // 
            // lblNaoSouRobo
            // 
            lblNaoSouRobo.BackColor = Color.Transparent;
            lblNaoSouRobo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaoSouRobo.ForeColor = Color.White;
            lblNaoSouRobo.Location = new Point(286, 294);
            lblNaoSouRobo.Name = "lblNaoSouRobo";
            lblNaoSouRobo.Size = new Size(119, 36);
            lblNaoSouRobo.TabIndex = 16;
            lblNaoSouRobo.Text = "Certifique que vocênão é um robô:";
            // 
            // checkConfirmar
            // 
            checkConfirmar.AutoSize = true;
            checkConfirmar.BackColor = Color.Transparent;
            checkConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            checkConfirmar.ForeColor = Color.White;
            checkConfirmar.Location = new Point(286, 333);
            checkConfirmar.Name = "checkConfirmar";
            checkConfirmar.Size = new Size(119, 19);
            checkConfirmar.TabIndex = 17;
            checkConfirmar.Text = "Não sou um robô";
            checkConfirmar.UseVisualStyleBackColor = false;
            checkConfirmar.CheckedChanged += checkConfirmar_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fundo_principal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(439, 511);
            Controls.Add(checkConfirmar);
            Controls.Add(lblNaoSouRobo);
            Controls.Add(label7);
            Controls.Add(bttnCancelar);
            Controls.Add(bttnCadastrar);
            Controls.Add(txtRepitirSenha);
            Controls.Add(lblRepetirSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblTelefone);
            Controls.Add(lblUsuario);
            Controls.Add(lblNome);
            Controls.Add(txtSenha);
            Controls.Add(txtTelefone);
            Controls.Add(txtVisorUsuario);
            Controls.Add(txtVisorNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Tela de Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisorNome;
        private TextBox txtVisorUsuario;
        private TextBox txtTelefone;
        private TextBox txtSenha;
        private Label lblNome;
        private Label lblUsuario;
        private Label lblTelefone;
        private Label lblSenha;
        private Label lblRepetirSenha;
        private TextBox txtRepitirSenha;
        private Button bttnCadastrar;
        private Button bttnCancelar;
        private Label label7;
        private CheckBox checkConfirma;
        private Label lblNaoSouRobo;
        private CheckBox checkConfirmar;
    }
}