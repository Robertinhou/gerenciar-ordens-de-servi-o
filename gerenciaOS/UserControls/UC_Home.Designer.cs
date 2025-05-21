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
            dgvOS = new DataGridView();
            btnCadastrar = new Button();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOS).BeginInit();
            SuspendLayout();
            // 
            // dgvOS
            // 
            dgvOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOS.Location = new Point(23, 139);
            dgvOS.Name = "dgvOS";
            dgvOS.Size = new Size(754, 257);
            dgvOS.TabIndex = 0;
            dgvOS.CellDoubleClick += dgvOS_CellDoubleClick;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(247, 80);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(114, 37);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar OS";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(429, 80);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(114, 37);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnListar);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvOS);
            Name = "UC_Home";
            Size = new Size(800, 419);
            ((System.ComponentModel.ISupportInitialize)dgvOS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOS;
        private Button btnCadastrar;
        private Button btnListar;
    }
}
