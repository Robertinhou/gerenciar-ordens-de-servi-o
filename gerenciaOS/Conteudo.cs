using gerenciaOS.UserControls;

namespace gerenciaOS
{
    public partial class Conteudo : Form
    {
        public Conteudo()
        {
            InitializeComponent();
        }

        public void addUc(UserControl UC)
        {

            UC.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(UC);

        }

        private void Conteudo_Load(object sender, EventArgs e)
        {

            UC_Login log = new UC_Login();

            addUc(log);

        }
    }
}
