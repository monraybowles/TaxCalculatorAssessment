using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserTaxCalculationDal : EfEntityRepositoryBase<UserTaxCalculation, ApplicationDbContext>, IUserTaxCalculationDal
    {
        public List<UserTaxCalculation> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from UserTaxCalculation in context.UserTaxCalculation
                             //where UserTaxCalculation.Id == user.Id
                             select new UserTaxCalculation { Id = UserTaxCalculation.Id, CalculationDate = UserTaxCalculation.CalculationDate };

                return result.ToList();

            }
        }

        public List<UserTaxCalculation> GetUserTaxCalculation(UserTaxCalculation user)
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from UserTaxCalculation in context.UserTaxCalculation
                             where UserTaxCalculation.Id == user.Id
                             select new UserTaxCalculation { Id = UserTaxCalculation.Id, CalculationDate = UserTaxCalculation.CalculationDate };

                return result.ToList();

            }
        }

        public List<UserTaxCalculation> GetUserTaxCalculationByUserTaxCalculationId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<UserTaxCalculation> GetUserTaxCalculationD()
        {
            throw new NotImplementedException();
        }

        public List<UserTaxCalculation> GetUserTaxCalculationDetails()
        {
            throw new NotImplementedException();
        }
    }
}
