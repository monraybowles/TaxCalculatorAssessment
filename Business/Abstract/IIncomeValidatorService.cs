using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IIncomeValidatorService
    {
        void Validate(double income);
    }
}
