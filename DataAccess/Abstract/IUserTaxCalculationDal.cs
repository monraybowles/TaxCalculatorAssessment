using Core.DataAccess.Abstract;
using Core.Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IUserTaxCalculationDal : IEntityRepository<UserTaxCalculation>
    {
        List<UserTaxCalculation> GetUserTaxCalculationDetails();

        List<UserTaxCalculation> GetUserTaxCalculationD();
        List<UserTaxCalculation> GetUserTaxCalculationByUserTaxCalculationId(Guid id);
    }}

