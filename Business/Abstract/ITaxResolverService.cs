using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract
{


    public interface ITaxResolverService
    {

        ITaxCalculatorService GetTaxCalculator(string identifier);
        void RegisterTaxCalculator(string identifier, ITaxCalculatorService taxCalculator);
        int Count();


    }
}
