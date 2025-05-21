using gerenciaOS.UserControls;

namespace gerenciaOS
{
    public partial class Conteudo : Form
    {

        bool mouseDown;
        Point lastLoc;

        public Conteudo()
        {
            InitializeComponent();
        }

        public void addUc(UserControl UC)
        {

            UC.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(UC);
            UC.BringToFront();

        }

        private void Conteudo_Load(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Conteudo_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                this.Location = new Point(

                    (this.Location.X - lastLoc.X) + e.X, (this.Location.Y - lastLoc.Y) + e.Y

                );

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLoc = e.Location;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void pnlConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Conteudo_Load_1(object sender, EventArgs e)
        {

            UC_Login log = new UC_Login();

            addUc(log);

        }

        private void pnlConteudo_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
