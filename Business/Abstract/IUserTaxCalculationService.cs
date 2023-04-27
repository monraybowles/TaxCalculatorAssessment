using Core.Entities.Concrete;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface IUserTaxCalculationService
    {


        IDataResult<List<UserTaxCalculation>> GetAll();
        IDataResult<List<UserTaxCalculation>> GetUserTaxCalculationDetails();
       // IDataResult<List<UserTaxCalculation>> GetUserTaxCalculationByUserTaxCalculationId(Guid id);      
        IDataResult<UserTaxCalculation> GetById(Guid id);
        IResult Add(UserTaxCalculation userTaxCalculation);
        IResult Delete(UserTaxCalculation userTaxCalculation);
        IResult Update(UserTaxCalculation userTaxCalculation);


    }
}
