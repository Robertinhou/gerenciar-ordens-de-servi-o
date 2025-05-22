namespace gerenciaOS.UserControls
{
    partial class conteudoOS
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            btnEditar = new Button();
            txtDescricao = new TextBox();
            lblDesc = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblStatus = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(271, 36);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(240, 23);
            txtTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(352, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(71, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo da OS";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(649, 28);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 36);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Salvar alterações";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(199, 91);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(384, 160);
            txtDescricao.TabIndex = 4;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(362, 73);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(58, 15);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "Descrição";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(339, 264);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(95, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome do cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(245, 287);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(273, 23);
            txtNome.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(362, 322);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pendente", "Concluido" });
            comboBox1.Location = new Point(317, 349);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // conteudoOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(lblStatus);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblDesc);
            Controls.Add(txtDescricao);
            Controls.Add(btnEditar);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Name = "conteudoOS";
            Size = new Size(800, 419);
            Load += conteudoOS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label lblTitulo;
        private Button btnEditar;
        private TextBox txtDescricao;
        private Label lblDesc;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblStatus;
        private ComboBox comboBox1;
    }
}
