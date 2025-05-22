using System;
using System.Windows.Forms;

namespace gerenciaOS.UserControls
{
    public partial class conteudoOS : UserControl
    {
        private GerenciarOS os;

        public conteudoOS(GerenciarOS osS)
        {
            InitializeComponent();
            os = osS;

            txtNome.Text = os.Nome_Cliente;
            txtTitulo.Text = os.Titulo;
            comboBox1.Text = os.Status;
            txtDescricao.Text = os.Descricao;
        }

        private void conteudoOS_Load(object sender, EventArgs e)
        {
            // Pode deixar vazio ou remover se não for usado
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            os.Titulo = txtTitulo.Text;
            os.Nome_Cliente = txtNome.Text;
            os.Descricao = txtDescricao.Text;
            os.Status = comboBox1.SelectedItem?.ToString() ?? "";

            if (os.AtualizarOS())
            {
                MessageBox.Show("Dados atualizados com sucesso!");
                this.Controls.Clear();
                UC_Home home = new UC_Home();
                this.Controls.Add(home);
            }
            else
            {
                MessageBox.Show("Não foi possível atualizar os dados!");
            }
        }
    }
}
