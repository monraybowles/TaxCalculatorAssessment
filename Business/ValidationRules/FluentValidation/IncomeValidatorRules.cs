using Business.Abstract;
namespace Business.ValidationRules.FluentValidation
{ 
    public class IncomeValidatorRules:IIncomeValidatorService
    {
        public void Validate(double annualIncome)
        {
            if (annualIncome < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(annualIncome), "Annual Income cannot be less than 0");
            }
            if (annualIncome > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(annualIncome), $"Annual Income cannot be more than {double.MaxValue}");
            }
        }
    }
}
