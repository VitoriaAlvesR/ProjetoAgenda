namespace ProjetoAgenda.Views
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            lblMensage = new Label();
            comboCategoria = new ComboBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.BackColor = Color.Black;
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.ForeColor = Color.White;
            arquivoToolStripMenuItem.ImageTransparentColor = Color.Black;
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.Black;
            sairToolStripMenuItem.ForeColor = Color.White;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.BackColor = Color.Black;
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            editarToolStripMenuItem.ForeColor = Color.White;
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.BackColor = Color.Black;
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem });
            cadastroToolStripMenuItem.ForeColor = Color.White;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(121, 22);
            cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.BackColor = Color.Black;
            categoriaToolStripMenuItem.ForeColor = Color.White;
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(125, 22);
            categoriaToolStripMenuItem.Text = "Ca&tegoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // lblMensage
            // 
            lblMensage.AutoSize = true;
            lblMensage.BackColor = Color.Transparent;
            lblMensage.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensage.ForeColor = Color.White;
            lblMensage.Location = new Point(201, 25);
            lblMensage.Name = "lblMensage";
            lblMensage.Size = new Size(0, 47);
            lblMensage.TabIndex = 2;
            lblMensage.Click += lblMensage_Click;
            // 
            // comboCategoria
            // 
            comboCategoria.BackColor = Color.White;
            comboCategoria.Font = new Font("Sitka Display", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCategoria.ForeColor = Color.Black;
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(39, 127);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(162, 24);
            comboCategoria.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Romantic", 12F, FontStyle.Regular, GraphicsUnit.Point, 2);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 106);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 4;
            label1.Text = "Categorias";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboCategoria);
            Controls.Add(lblMensage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Principal";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private Label lblMensage;
        private ComboBox comboCategoria;
        private Label label1;
    }
}