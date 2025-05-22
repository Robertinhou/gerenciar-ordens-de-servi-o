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
using Org.BouncyCastle.Pqc.Crypto.Lms;

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
            this.Controls.Clear();
            GerenciarOS osS = new GerenciarOS();
            osS.Id = Convert.ToInt32(dgvOS.Rows[e.RowIndex].Cells[0].Value);
            osS.Titulo = dgvOS.Rows[e.RowIndex].Cells[1].Value.ToString();
            osS.Descricao = dgvOS.Rows[e.RowIndex].Cells[2].Value.ToString();
            osS.Nome_Cliente = dgvOS.Rows[e.RowIndex].Cells[3].Value.ToString();
            osS.Data = Convert.ToDateTime(dgvOS.Rows[e.RowIndex].Cells[4].Value);
            osS.Status = dgvOS.Rows[e.RowIndex].Cells[5].Value.ToString();

            conteudoOS editar = new conteudoOS(osS);

            this.Controls.Add(editar);

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem certeza que deseja deletar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                GerenciarOS os = new GerenciarOS();
                os.Id = Convert.ToInt32(dgvOS.CurrentRow.Cells[0].Value);
                os.DeletarOS();
                os.ListarOS(dgvOS);
            }
            
        }
    }
}
