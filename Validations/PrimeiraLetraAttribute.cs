using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Validations
{
    public class PrimeiraLetraAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Validando se não é nulo
            if (value == null || string.IsNullOrEmpty(value.ToString())) return ValidationResult.Success;
            
            // Vendo se a Primeira letra é maiuscula
            var pri = value.ToString()[0].ToString();
            
            // Fazendo a validação
            if (pri != pri.ToUpper()) return new ValidationResult("Deve iniciar com maiúscu");
            
            return base.IsValid(value, validationContext);
        }
    }
}
