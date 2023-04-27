using Business.Abstract;
using System;
using System.Collections.Generic;


namespace Business.Concrete
{
    public abstract class TaxResolverManager : ITaxResolverService
    {
        Dictionary<string, ITaxCalculatorService> _taxCalculators = new Dictionary<string, ITaxCalculatorService>();

        public ITaxCalculatorService GetTaxCalculator(string identifier)
        {
            if (!_taxCalculators.ContainsKey(identifier))
            {
                throw new Exception("No Tax Calculator found");
            }
            return _taxCalculators[identifier];
        }
        public void RegisterTaxCalculator(string identifier, ITaxCalculatorService taxCalculator)
        {
            if (!_taxCalculators.ContainsKey(identifier))
            {
                _taxCalculators.Add(identifier, taxCalculator);
            }
        }

        public int Count()
        {
            return _taxCalculators.Count;
        }
    }
}
