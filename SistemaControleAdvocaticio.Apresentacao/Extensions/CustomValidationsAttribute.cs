using System;
using System.ComponentModel.DataAnnotations;
using Util.Validacoes;

namespace SistemaControleAdvocaticio.Apresentacao.Extensions
{

    public class CpfAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string mensagemInvalido = "CPF em formato inválido.";
            try
            {
                var cpf = value.ToString();
                if (Validacoes.ValidaCpf(cpf))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(mensagemInvalido);
                }
            }
            catch (Exception)
            {
                return new ValidationResult(mensagemInvalido);
            }
        }
    }

    public class CnpjAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string mensagemInvalido = "CNPJ em formato inválido.";
            try
            {
                var Cnpj = value.ToString();
                if (Validacoes.ValidaCnpj(Cnpj))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(mensagemInvalido);
                }
            }
            catch (Exception)
            {
                return new ValidationResult(mensagemInvalido);
            }
        }
    }

    public class CepAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string mensagemInvalido = "CNPJ em formato inválido.";
            try
            {
                var cep = value.ToString();
                if (Validacoes.validaCep(cep))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(mensagemInvalido);
                }
            }
            catch (Exception)
            {
                return new ValidationResult(mensagemInvalido);
            }
        }
    }

    public class TelefoneAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string mensagemInvalido = "Telefone em formato inválido.";
            try
            {
                var telefone = value.ToString();
                if (Validacoes.validaTelefone(telefone))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(mensagemInvalido);
                }
            }
            catch (Exception)
            {
                return new ValidationResult(mensagemInvalido);
            }
        }
    }


    public class EmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string mensagemInvalido = "E-mail em formato inválido.";
            try
            {
                var email = value.ToString();
                if (Validacoes.validaEmail(email))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(mensagemInvalido);
                }
            }
            catch (Exception)
            {
                return new ValidationResult(mensagemInvalido);
            }
        }
    }

}
