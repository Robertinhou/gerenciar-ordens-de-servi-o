
namespace gerenciaOS.UserControls
{
    partial class UC_CadastrarOs
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
            label1 = new Label();
            txtDesc = new TextBox();
            txtTitulo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            btnCadastrar = new Button();
            lnkHome = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Título";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(146, 118);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(437, 75);
            txtDesc.TabIndex = 1;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(225, 56);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(286, 23);
            txtTitulo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 210);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome do cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(238, 228);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(244, 23);
            txtNome.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(284, 295);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(158, 37);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lnkHome
            // 
            lnkHome.AutoSize = true;
            lnkHome.Location = new Point(318, 345);
            lnkHome.Name = "lnkHome";
            lnkHome.Size = new Size(91, 15);
            lnkHome.TabIndex = 9;
            lnkHome.TabStop = true;
            lnkHome.Text = "Voltar pra home";
            lnkHome.LinkClicked += this.lnkHome_LinkClicked;
            // 
            // UC_CadastrarOs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lnkHome);
            Controls.Add(btnCadastrar);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(txtDesc);
            Controls.Add(label1);
            Name = "UC_CadastrarOs";
            Size = new Size(800, 419);
            Load += this.UC_CadastrarOs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDesc;
        private TextBox txtTitulo;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private Button btnCadastrar;
        private LinkLabel lnkHome;
     
    }
}
