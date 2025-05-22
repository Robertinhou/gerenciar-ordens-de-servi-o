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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pbVisivel = new PictureBox();
            pbOculto = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVisivel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOculto).BeginInit();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(581, 278);
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
            label1.Location = new Point(607, 145);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(540, 163);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(183, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(540, 229);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(183, 23);
            txtSenha.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(607, 202);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // lnkCadastro
            // 
            lnkCadastro.AutoSize = true;
            lnkCadastro.Location = new Point(445, 207);
            lnkCadastro.Name = "lnkCadastro";
            lnkCadastro.Size = new Size(0, 15);
            lnkCadastro.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 25, 26);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 419);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pjo1;
            pictureBox1.Location = new Point(99, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(68, 77);
            label3.Name = "label3";
            label3.Size = new Size(340, 32);
            label3.TabIndex = 8;
            label3.Text = "COMEÇE O DIA MOTIVADO!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(587, 80);
            label4.Name = "label4";
            label4.Size = new Size(89, 30);
            label4.TabIndex = 9;
            label4.Text = "LOGIN";
            // 
            // pbVisivel
            // 
            pbVisivel.Image = Properties.Resources.icons8_visível_48;
            pbVisivel.Location = new Point(731, 221);
            pbVisivel.Name = "pbVisivel";
            pbVisivel.Size = new Size(44, 38);
            pbVisivel.SizeMode = PictureBoxSizeMode.CenterImage;
            pbVisivel.TabIndex = 10;
            pbVisivel.TabStop = false;
            pbVisivel.Click += pbVisivel_Click;
            // 
            // pbOculto
            // 
            pbOculto.Image = Properties.Resources.icons8_ocultar_50;
            pbOculto.Location = new Point(731, 221);
            pbOculto.Name = "pbOculto";
            pbOculto.Size = new Size(44, 38);
            pbOculto.SizeMode = PictureBoxSizeMode.CenterImage;
            pbOculto.TabIndex = 11;
            pbOculto.TabStop = false;
            pbOculto.Click += pbOculto_Click;
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbOculto);
            Controls.Add(pbVisivel);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(lnkCadastro);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(btnLogar);
            Name = "UC_Login";
            Size = new Size(800, 419);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVisivel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOculto).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private PictureBox pbVisivel;
        private PictureBox pbOculto;
    }
}
