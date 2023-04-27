using Business.Abstract;
using System;


namespace Business.ValidationRules.FluentValidation
{
    public class FlatValueTaxCalculatorRules : ITaxCalculatorService
    {
        private const double FLAT_PERCENT_RATE = 0.05d;
        private readonly IIncomeValidatorService _incomeValidator;

        public FlatValueTaxCalculatorRules(IIncomeValidatorService incomeValidator)
        {
            _incomeValidator = incomeValidator ?? throw new ArgumentNullException(nameof(incomeValidator));
        }

        public double Calculate(double annualIncome)
        {
            _incomeValidator.Validate(annualIncome);
            if (annualIncome > 200000)
            {
                return 10000f;
            }
            return annualIncome <= 0 ? 0 : Math.Round(annualIncome * FLAT_PERCENT_RATE,2);
        }
    }
}