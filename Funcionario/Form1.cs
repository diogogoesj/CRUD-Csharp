using Funcionario.Services;
using Funcionario.Utils;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCpf.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {

                    if (!Validacoes.ValidarCPF(txtCpf.Text))
                    {
                        MessageBox.Show("CPF inv�lido. Por favor, insira um CPF v�lido.");
                        return;
                    }

                    if (!Validacoes.ValidarEmail(txtEmail.Text))
                    {
                        MessageBox.Show("Email inv�lido. Por favor, insira um email v�lido.");
                        return;
                    }

                    CadastroFuncionarios cadastroDeFuncionarios = new()
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Cpf = txtCpf.Text,
                        Endereco = txtEndereco.Text
                    };

                    if (cadastroDeFuncionarios.CadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcion�rio {cadastroDeFuncionarios.Nome} foi cadastrado com sucesso.");

                        LimparCamposEFocus();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"N�o foi poss�vel cadastrar funcion�rio.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigat�rios.");
                    LimparCamposEFocus();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar funcion�rio: {ex.Message}");
            }
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals(""))
                {
                    CadastroFuncionarios cadastroDeFuncionarios = new()
                    {
                        Cpf = txtCpf.Text
                    };

                    MySqlDataReader reader = cadastroDeFuncionarios.LocalizarOFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblId.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();

                        }
                        else
                        {
                            MessageBox.Show($"Funcionario n�o encontrado");
                            LimparCamposEFocus();
                            txtCpf.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Funcionario n�o encontrado");
                        LimparCamposEFocus();
                        txtCpf.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigat�rios.");
                    LimparCamposEFocus();
                    txtCpf.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao encontrar funcionario {ex.Message}");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposEFocus();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    CadastroFuncionarios cadastroDeFuncionarios = new();
                    cadastroDeFuncionarios.Cpf = txtCpf.Text;

                    // Recuperar os dados atuais do funcion�rio
                    MySqlDataReader reader = cadastroDeFuncionarios.LocalizarOFuncionario();
                    if (reader != null && reader.HasRows)
                    {
                        reader.Read();
                        string nomeAtual = reader["nome"].ToString();
                        string cpfAtual = reader["cpf"].ToString();
                        reader.Close();

                        // Verificar se houve altera��es no nome ou CPF
                        if (!txtNome.Text.Equals(nomeAtual) || !txtCpf.Text.Equals(cpfAtual))
                        {
                            MessageBox.Show("N�o � permitido modificar o nome ou o CPF do funcion�rio.");
                            LimparCamposEFocus();
                            return;
                        }

                        // Caso n�o tenha havido altera��es, prosseguir com a atualiza��o dos demais campos
                        cadastroDeFuncionarios.Id = int.Parse(lblId.Text);
                        cadastroDeFuncionarios.Email = txtEmail.Text;
                        cadastroDeFuncionarios.Endereco = txtEndereco.Text;

                        if (cadastroDeFuncionarios.AtualizarFuncionario())
                        {
                            MessageBox.Show($"Os dados do funcion�rio foram atualizados com sucesso");
                            LimparCamposEFocus();
                            txtCpf.Focus();
                        }
                        else
                        {
                            MessageBox.Show($"N�o foi poss�vel atualizar as informa��es do funcion�rio");
                            LimparCamposEFocus();
                            txtCpf.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Funcion�rio n�o encontrado");
                        LimparCamposEFocus();
                        txtCpf.Focus();
                    }
                }
                else
                {
                    MessageBox.Show($"Por favor, localize o funcion�rio que deseja atualizar antes de prosseguir.");
                    LimparCamposEFocus();
                    txtCpf.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar os dados do funcion�rio {ex.Message}");
            }
        }



        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    CadastroFuncionarios cadastroDeFuncionarios = new()
                    {
                        Id = int.Parse(lblId.Text)
                    };

                    if (cadastroDeFuncionarios.DeletarFuncionario())
                    {
                        MessageBox.Show("O funcion�rio foi exclu�do com sucesso");
                        LimparCamposEFocus();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi possivel excluir funcion�rio ");
                        LimparCamposEFocus();
                    }
                }
                else
                {
                    MessageBox.Show($"Por favor, localize o funcion�rio que deseja excluir antes de prosseguir.");
                    LimparCamposEFocus();
                    txtCpf.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir funcion�rio {ex.Message}");
            }
        }


        private void LimparCamposEFocus()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            lblId.Text = "";
        }

    }
}