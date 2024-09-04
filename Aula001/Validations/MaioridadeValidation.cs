using System.ComponentModel.DataAnnotations;

namespace Aula001.Validations
{
    public class MaioridadeValidation : ValidationAttribute 
    {
        public override bool IsValid(object? value)
        {
            if(value is null) return false;
            int idade = (int)value;
            return idade >= 18 ? true : false;
        }

    }
}
