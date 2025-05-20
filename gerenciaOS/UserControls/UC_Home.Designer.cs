namespace gerenciaOS.UserControls
{
    partial class UC_Home
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
            label4 = new Label();
            dtpData = new DateTimePicker();
            btnCadastrar = new Button();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 278);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 6;
            label4.Text = "Selecione a data de hoje:";
            // 
            // dtpData
            // 
            dtpData.Checked = false;
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(305, 274);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(109, 23);
            dtpData.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(279, 340);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(158, 37);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCadastrar);
            Controls.Add(dtpData);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(txtDesc);
            Controls.Add(label1);
            Name = "UC_Home";
            Size = new Size(800, 419);
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
        private Label label4;
        private DateTimePicker dtpData;
        private Button btnCadastrar;
    }
}
