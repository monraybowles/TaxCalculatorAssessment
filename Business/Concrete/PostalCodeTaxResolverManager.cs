

using Business.ValidationRules.FluentValidation;
using Business.Concrete;
using Business.Abstract;

namespace Business.Concrete
{
    public class PostalCodeTaxResolverManager : TaxResolverManager
    {
        public PostalCodeTaxResolverManager(IIncomeValidatorService incomeValidator)
        {

            RegisterTaxCalculator("7441", new ProgressiveTaxCalculatorRules(incomeValidator));


            RegisterTaxCalculator("A100", new FlatValueTaxCalculatorRules(incomeValidator));
            RegisterTaxCalculator("7000", new FlatRateTaxCalculatorRules(incomeValidator));

            RegisterTaxCalculator("1000", new ProgressiveTaxCalculatorRules(incomeValidator));

        }
    }
}
