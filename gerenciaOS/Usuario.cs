using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace gerenciaOS
{
    class Usuarios
    {

        private string nome_completo;
        private string cpf;
        private string usuario;
        private string email;
        private string senha;

        public string Nome_Completo
        {

            get { return nome_completo; }
            set { nome_completo = value; }

        }

        public string Cpf
        {

            get { return cpf; }
            set { cpf = value; }

        }

        public string Usuario
        {

            get { return usuario; }
            set { usuario = value; }

        }

        public string Email
        {

            get { return email; }
            set { email = value; }

        }


        public string Senha
        {

            get { return senha; }
            set { senha = value; }

        }


        public bool verificarLogin()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);

                    string consultaUsuarios = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario and senha = @senha";
                    MySqlCommand comando = new MySqlCommand(consultaUsuarios, conexao);

                    comando.Parameters.AddWithValue("@usuario", Usuario);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar login no banco -> " + ex.Message);
                return false;
            }
        }

        public static bool ValidarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

    


        public static string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }

                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool CadastrarUsuario()
        {

            try
            {

                if (verificarLogin())
                {
                    MessageBox.Show("Esse usuário já está cadatrado!");
                    return false;
                }
                else
                {

                    using (MySqlConnection conexao = new ConexaoBD().Conectar())
                    {

                        string sql = "INSERT INTO usuarios (nome, usuario, email, senha) VALUES (@nome, @usuario, @email, @senha)";

                        MySqlCommand cmd = new MySqlCommand(sql, conexao);

                        cmd.Parameters.AddWithValue("@nome", Nome_Completo);
                        cmd.Parameters.AddWithValue("@usuario", Usuario);
                        cmd.Parameters.AddWithValue("@email", Email);
                        cmd.Parameters.AddWithValue("@senha", CriptografarSenha(Senha));

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {

                            MessageBox.Show("Usuaário cadastrado!");
                            return true;

                        }
                        else
                        {

                            return false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro! Verfique sua conexão!");
                return false;

            }

        }


       
        

    }
}
