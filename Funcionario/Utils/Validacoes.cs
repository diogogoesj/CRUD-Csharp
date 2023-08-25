using System.Text.RegularExpressions;

namespace Funcionario.Utils
{
    public static class Validacoes
    {
        public static bool ValidarCPF(string cpf)
        {

            if (cpf.Length != 11 || !long.TryParse(cpf, out _))
            {
                return false;
            }


            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int count = 0; count < 9; count++)
            {
                soma += int.Parse(tempCpf[count].ToString()) * multiplicadores1[count];
            }

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digitoVerificador1 = resto.ToString();
            tempCpf += digitoVerificador1;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadores2[i];
            }

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digitoVerificador2 = resto.ToString();
            return cpf.EndsWith(digitoVerificador1 + digitoVerificador2);
        }

        public static bool ValidarEmail(string email)
        {

            string emailRegexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex emailRegex = new Regex(emailRegexPattern);

            return emailRegex.IsMatch(email);
        }
    }
}
