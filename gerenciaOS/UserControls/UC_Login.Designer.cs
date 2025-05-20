namespace gerenciaOS.UserControls
{
    partial class UC_Login
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
            btnLogar = new Button();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            lnkCadastro = new LinkLabel();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(332, 223);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(98, 42);
            btnLogar.TabIndex = 0;
            btnLogar.Text = "Login";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 81);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(294, 99);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(183, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(294, 165);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(183, 23);
            txtSenha.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 138);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // lnkCadastro
            // 
            lnkCadastro.AutoSize = true;
            lnkCadastro.Location = new Point(294, 191);
            lnkCadastro.Name = "lnkCadastro";
            lnkCadastro.Size = new Size(0, 15);
            lnkCadastro.TabIndex = 5;
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lnkCadastro);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(btnLogar);
            Name = "UC_Login";
            Size = new Size(800, 419);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogar;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label2;
        private LinkLabel lnkCadastro;
    }
}
