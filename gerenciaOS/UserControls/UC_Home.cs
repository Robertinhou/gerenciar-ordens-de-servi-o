using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


            GerenciarOS OS = new GerenciarOS();

            OS.Titulo = txtTitulo.Text;
            OS.Descricao = txtDesc.Text;
            OS.Nome_Cliente = txtNome.Text;
            OS.Data = dtpData.Value;

            if (!txtNome.Text.Equals("") || !txtDesc.Text.Equals("") || !txtTitulo.Text.Equals("")  ) {


                if (OS.CadastrarOs())
                {

                    MessageBox.Show("OS cadastrada!");

                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar a OS!");
                }
                
                

            }
        }



    }
}
