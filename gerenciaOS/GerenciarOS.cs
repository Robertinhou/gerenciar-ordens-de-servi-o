using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace gerenciaOS
{
    public class GerenciarOS
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Nome_Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

        public bool CadastrarOs()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string sql = "INSERT INTO os (titulo, descricao, nome_cliente, data_emissao, statusOS) " +
                                 "VALUES (@titulo, @desc, @nome, @data, @status)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@titulo", Titulo);
                    cmd.Parameters.AddWithValue("@desc", Descricao);
                    cmd.Parameters.AddWithValue("@nome", Nome_Cliente);
                    cmd.Parameters.AddWithValue("@data", Data);
                    cmd.Parameters.AddWithValue("@status", Status);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro! Verifique sua conexão!");
                return false;
            }
        }

        public bool AtualizarOS()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string sql = "UPDATE os SET titulo = @titulo, descricao = @desc, nome_cliente = @nome, data_emissao = @data, statusOS = @status WHERE id_os = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@titulo", Titulo);
                    cmd.Parameters.AddWithValue("@desc", Descricao);
                    cmd.Parameters.AddWithValue("@nome", Nome_Cliente);
                    cmd.Parameters.AddWithValue("@data", Data);
                    cmd.Parameters.AddWithValue("@status", Status);

                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro fatal! Verifique sua conexão!");
                return false;
            }
        }
         public bool DeletarOS()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string sql = "DELETE FROM os WHERE id_os = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", Id);
                    


                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro fatal! Verifique sua conexão!");
                return false;
            }
        }

        public void ListarOS(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    DataTable dt = new DataTable();
                    string busca = "SELECT * FROM os";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(busca, conexao);
                    adapter.Fill(dt);

                    dgv.AllowUserToAddRows = false;
                    dgv.DataSource = dt;
                    dgv.ClearSelection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar os dados.");
            }
        }
    }
}
