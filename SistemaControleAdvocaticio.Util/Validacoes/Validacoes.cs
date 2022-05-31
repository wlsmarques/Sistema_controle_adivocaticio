using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Util.Validacoes
{
    public static class Validacoes
    {

        public static bool ValidaCpf(string cpf)
        {
            bool retornoValidacao = true;

            if (string.IsNullOrEmpty(cpf))
            {
                retornoValidacao = false;
            }
            else
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                string digitosVerificadores;
                int soma;
                int resto;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");

                if ((cpf == "00000000000") || (cpf == "11111111111") ||
                    (cpf == "22222222222") || (cpf == "33333333333") ||
                    (cpf == "44444444444") || (cpf == "55555555555") ||
                    (cpf == "66666666666") || (cpf == "77777777777") ||
                    (cpf == "88888888888") || (cpf == "99999999999"))
                {
                    retornoValidacao = false;
                }

                if (cpf.Length != 11)
                {
                    retornoValidacao = false;
                }

                tempCpf = cpf.Substring(0, 9);
                soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                }
                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                digitosVerificadores = digito;
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                }
                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = resto.ToString();
                digitosVerificadores += digito;
                retornoValidacao = (digitosVerificadores != cpf.Remove(0, 9));
            }

            return retornoValidacao;
        }

        public static bool ValidaCnpj(string cnpj)
        {
            bool retornoValidacao = false;
            string validacaoRegex = @"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}$";
            string match = Convert.ToString(Regex.Match(cnpj, validacaoRegex));

            retornoValidacao = match.Equals(cnpj);

            return retornoValidacao;
        }


        public static bool validaCep(string cep)
        {
            bool retornoValidacao = false;
            string validacaoRegex = @"^\d{5}\-?\d{3}$";
            string match = Convert.ToString(Regex.Match(cep, validacaoRegex));

            retornoValidacao = match.Equals(cep);

            return retornoValidacao;
        }

        public static bool validaTelefone(string telefone)
        {
            bool retornoValidacao = false;
            if (!string.IsNullOrEmpty(telefone))
            {
                string telefonevalidacao = telefone.ToString().Replace("-", "").Replace("(", "").Replace(")", "").Trim();
                string validacaoRegex = @"[0-9]{2}[0-9]{5}[0-9]{4}";
                string match = Convert.ToString(Regex.Match(telefonevalidacao, validacaoRegex));
                retornoValidacao = match.Equals(telefonevalidacao);
            }
            return retornoValidacao;
        }

        public static bool validaEmail(string email)
        {
            bool retornoValidacao = false;

            string validacaoRegex1 = @"^([\w\-]+\.)*[\w\- ]+@([\w\- ]+\.)+([\w\-]{2,3})$";
            string validacaoRegex2 = @"^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+[_-]*?)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$";
            
            string match = Convert.ToString(Regex.Match(email, validacaoRegex1));

            retornoValidacao = match.Equals(email);

            if (retornoValidacao)
            {
                match = Convert.ToString(Regex.Match(email, validacaoRegex2));
                retornoValidacao = match.Equals(email);
            }

            return retornoValidacao;
        }

    }
}
