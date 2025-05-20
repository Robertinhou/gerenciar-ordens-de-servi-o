using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciaOS
{
    public class ConexaoBD
    {

        private string conexaoBanco = "Server=localhost; Database=we;Uid = root;Pwd=''";

        public MySqlConnection Conectar()
        {

            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();
            return conexao;


        }

    }
}
