
using Business.Abstract;


namespace Business.Concrete
{
    internal class ProgressiveTaxCalculatorManager : ITaxCalculatorService
    {
        private IIncomeValidatorService incomeValidator;

        public ProgressiveTaxCalculatorManager(IIncomeValidatorService incomeValidator)
        {
            this.incomeValidator = incomeValidator;
        }

        public double Calculate(double annualIncome)
        {
            return annualIncome;
        }

       
    }
}