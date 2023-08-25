namespace Funcionario.DataAcess
{
    static class ConexaoBanco
    {

        private const string servidor = "localhost";
        private const string bancoDados = "dbFuncionarios";
        private const string usuario = "root";
        private const string senha = "";

        static public string ConexaoIni = $"server={servidor};user id={usuario};database={bancoDados};password={senha}";

    }
}
