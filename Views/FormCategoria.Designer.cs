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
            grpCategoria = new GroupBox();
            buttCadastrar = new Button();
            textVisor = new TextBox();
            dgvCategoria = new DataGridView();
            grpCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // grpCategoria
            // 
            grpCategoria.BackgroundImage = Properties.Resources.Fundo_principal;
            grpCategoria.BackgroundImageLayout = ImageLayout.Stretch;
            grpCategoria.Controls.Add(buttCadastrar);
            grpCategoria.Controls.Add(textVisor);
            grpCategoria.ForeColor = Color.White;
            grpCategoria.Location = new Point(12, 12);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Size = new Size(287, 143);
            grpCategoria.TabIndex = 0;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "Insira o nome da nova categoria";
            // 
            // buttCadastrar
            // 
            buttCadastrar.BackColor = Color.Blue;
            buttCadastrar.BackgroundImageLayout = ImageLayout.Center;
            buttCadastrar.FlatStyle = FlatStyle.Flat;
            buttCadastrar.Location = new Point(31, 71);
            buttCadastrar.Name = "buttCadastrar";
            buttCadastrar.Size = new Size(210, 42);
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
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(354, 12);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(260, 143);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(644, 172);
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCategoria;
        private Button buttCadastrar;
        private TextBox textVisor;
        private DataGridView dgvCategoria;
    }
}