using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Validations
{
	public class TicketValidation : ValidationAttribute
	{
		protected override ValidationResult? IsValid(Object? value, ValidationContext validationContext)
		{
			if (value == null)
			{
				return new ValidationResult(ErrorMessage);
			}

			int ticket = (int)value;

			return ticket >= 18 ? ValidationResult.Success : new  ValidationResult(ErrorMessage);
		}
	}
}
