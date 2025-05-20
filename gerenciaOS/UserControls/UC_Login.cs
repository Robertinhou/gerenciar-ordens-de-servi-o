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
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {


            if(!txtSenha.Text.Equals("") && !txtUsuario.Text.Equals(""))
            {

                Usuarios usuario = new Usuarios();
                usuario.Senha = txtSenha.Text;
                usuario.Usuario = txtUsuario.Text;


                if (usuario.verificarLogin())
                {

                    UC_Home home = new UC_Home();
                    this.Controls.Clear();
                    this.Controls.Add(home);

                }

            }

        }
    }
}
