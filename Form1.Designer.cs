namespace ProjetoAgenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtVisorUsuario = new TextBox();
            txtVisorSenha = new TextBox();
            bttnEntrar = new Button();
            bttnCadastrar = new Button();
            lblUsuario = new Label();
            lblSenha = new Label();
            SuspendLayout();
            // 
            // txtVisorUsuario
            // 
            txtVisorUsuario.BorderStyle = BorderStyle.None;
            txtVisorUsuario.Location = new Point(74, 76);
            txtVisorUsuario.Multiline = true;
            txtVisorUsuario.Name = "txtVisorUsuario";
            txtVisorUsuario.Size = new Size(188, 23);
            txtVisorUsuario.TabIndex = 0;
            txtVisorUsuario.TextChanged += txtVisorUsuario_TextChanged;
            // 
            // txtVisorSenha
            // 
            txtVisorSenha.BorderStyle = BorderStyle.None;
            txtVisorSenha.Location = new Point(74, 152);
            txtVisorSenha.Multiline = true;
            txtVisorSenha.Name = "txtVisorSenha";
            txtVisorSenha.PasswordChar = '*';
            txtVisorSenha.Size = new Size(188, 23);
            txtVisorSenha.TabIndex = 1;
            txtVisorSenha.TextChanged += txtVisorSenha_TextChanged;
            // 
            // bttnEntrar
            // 
            bttnEntrar.BackColor = SystemColors.Highlight;
            bttnEntrar.Enabled = false;
            bttnEntrar.FlatStyle = FlatStyle.Popup;
            bttnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnEntrar.Location = new Point(74, 207);
            bttnEntrar.Name = "bttnEntrar";
            bttnEntrar.Size = new Size(75, 23);
            bttnEntrar.TabIndex = 2;
            bttnEntrar.Text = "Entrar";
            bttnEntrar.UseVisualStyleBackColor = false;
            // 
            // bttnCadastrar
            // 
            bttnCadastrar.BackColor = SystemColors.Highlight;
            bttnCadastrar.FlatStyle = FlatStyle.Popup;
            bttnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnCadastrar.Location = new Point(187, 207);
            bttnCadastrar.Name = "bttnCadastrar";
            bttnCadastrar.Size = new Size(75, 23);
            bttnCadastrar.TabIndex = 3;
            bttnCadastrar.Text = "Cadastrar";
            bttnCadastrar.UseVisualStyleBackColor = false;
            bttnCadastrar.Click += bttnCadastrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(74, 58);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(74, 134);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(43, 15);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fundo_principal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(356, 327);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(bttnCadastrar);
            Controls.Add(bttnEntrar);
            Controls.Add(txtVisorSenha);
            Controls.Add(txtVisorUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Login da agenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisorUsuario;
        private TextBox txtVisorSenha;
        private Button bttnEntrar;
        private Button bttnCadastrar;
        private Label lblUsuario;
        private Label lblSenha;
    }
}
