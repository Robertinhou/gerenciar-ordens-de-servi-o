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
    public partial class UC_CadastrarOs : UserControl
    {
        public UC_CadastrarOs()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            GerenciarOS OS = new GerenciarOS();

            OS.Titulo = txtTitulo.Text;
            OS.Descricao = txtDesc.Text;
            OS.Nome_Cliente = txtNome.Text;
            OS.Status = "Pendente";
            OS.Data = DateTime.Now;

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
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void lnkHome_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {

            UC_Home home = new UC_Home();

            this.Controls.Clear();
            this.Controls.Add(home);
           
        }

        private void UC_CadastrarOs_Load(object sender, EventArgs e)
        {

        }

    }
}
