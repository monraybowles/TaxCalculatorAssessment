using Business.Abstract;
using System;


namespace Business.ValidationRules.FluentValidation
{
    public class FlatRateTaxCalculatorRules : ITaxCalculatorService
    {
        private const double FLAT_PERCENT_RATE = 0.175d;
        private readonly IIncomeValidatorService _incomeValidator;

        public FlatRateTaxCalculatorRules(IIncomeValidatorService incomeValidator)
        {
            _incomeValidator = incomeValidator ?? throw new ArgumentNullException(nameof(incomeValidator));
        }

        public double Calculate(double annualIncome)
        {
            _incomeValidator.Validate(annualIncome);
            return Math.Round(annualIncome * FLAT_PERCENT_RATE,2);
        }
    }
}
