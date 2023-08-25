using Funcionario.DataAcess;
using MySql.Data.MySqlClient;
using System;

namespace Funcionario.Services
{
    class CadastroFuncionarios
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _cpf;
        private string _endereco;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public bool CadastrarFuncionarios()
        {
            try
            {
                MySqlConnection mysqlConexaoBanco = new(ConexaoBanco.ConexaoIni);
                mysqlConexaoBanco.Open();

                string insert = $" INSERT INTO funcionarios (nome,email,cpf,endereco) VALUES ('{Nome}','{Email}','{Cpf}','{Endereco}')";

                MySqlCommand comandoSql = mysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados - {ex.Message}");

                return false;
            }
        }

        public MySqlDataReader LocalizarOFuncionario()
        {
            try
            {
                MySqlConnection mysqlConexaoBanco = new(ConexaoBanco.ConexaoIni);
                mysqlConexaoBanco.Open();

                string select = $"SELECT id, nome, email, cpf, endereco FROM funcionarios WHERE cpf = '{Cpf}'; ";
                MySqlCommand comandoSql = mysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados {ex.Message}");
                return null;
            }
        }

        public bool AtualizarFuncionario()
        {
            try
            {
                MySqlConnection mysqlConexaoBanco = new(ConexaoBanco.ConexaoIni);
                mysqlConexaoBanco.Open();

                string update = $"UPDATE funcionarios SET email = '{Email}', endereco='{Endereco}' WHERE id = '{Id}';";
                MySqlCommand comandoSql = mysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados - Método ATT FUNC {ex.Message}");
                return false;
            }
        }

        public bool DeletarFuncionario()
        {
            try
            {
                MySqlConnection mysqlConexaoBanco = new(ConexaoBanco.ConexaoIni);
                mysqlConexaoBanco.Open();

                string delete = $"DELETE FROM funcionarios WHERE id = '{Id}';";
                MySqlCommand comandoSql = mysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados - Método DEL FUNC {ex.Message}");
                return false;
            }
        }
    }
}
