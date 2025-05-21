using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace gerenciaOS.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            UC_CadastrarOs cad = new UC_CadastrarOs();
            this.Controls.Clear();
            this.Controls.Add(cad);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {



        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            GerenciarOS os = new GerenciarOS();

            os.ListarOS(dgvOS);

        }

        private void dgvOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string 

        }
    }
}
