using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace gerenciaOS
{
    class GerenciarOS
    {

        private string titulo;
        private string descricao;
        private string nome_cliente;
        private DateTime data;
        private string status;

        public string Titulo
        {

            get { return titulo; }
            set { titulo = value; }

        }

        public string Descricao
        {

            get { return descricao; }
            set { descricao = value; }

        }

        public string Nome_Cliente
        {

            get { return nome_cliente; }
            set { nome_cliente = value; }

        }

        public string Status
        {

            get { return status; }
            set { status = value; }

        }

        public DateTime Data
        {

            get { return data; }
            set { data = value; }

        }


        public bool CadastrarOs()
        {

            try
            {


                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {

                    string sql = "INSERT INTO os (titulo, descricao, nome_cliente, data_emissao, statusOS) VALUES (@titulo, @desc, @nome, @data, @status)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    cmd.Parameters.AddWithValue("@titulo", Titulo);
                    cmd.Parameters.AddWithValue("@desc", Descricao);
                    cmd.Parameters.AddWithValue("@nome", Nome_Cliente);
                    cmd.Parameters.AddWithValue("@data", Data);
                    cmd.Parameters.AddWithValue("@status", Status);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {

                        return true;

                    }
                    else
                    {
                        return false;
                    }


                }


            }

            catch (Exception ex) {

                MessageBox.Show("Erro! Verfique sua conexão!");
                return false;

            }


        }



        public void ListarOS(DataGridView dgv)
        {

            try {




                using (MySqlConnection conexao = new ConexaoBD().Conectar()) {



                    DataTable dt = new DataTable();
                    string busca = "SELECT * FROM os";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(busca, conexao);
                    adapter.Fill(dt);

                    dgv.AllowUserToAddRows = false;

                    dgv.DataSource = dt;
                    dgv.ClearSelection();



                }


            }
            catch (Exception ex)
            {

            }

        }
    }
}
