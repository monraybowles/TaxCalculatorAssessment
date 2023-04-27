using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserTaxCalculationManager : IUserTaxCalculationService
    {
        IUserTaxCalculationDal _userTaxCalculationDal;
        public UserTaxCalculationManager(IUserTaxCalculationDal userTaxCalculationDal)
        {
            _userTaxCalculationDal = userTaxCalculationDal;
        }

        //[SecuredOperation("userTaxCalculation.add")]
        ////[ValidationAspect(typeof(userTaxCalculationValidator))]
        //[CacheRemoveAspect("IUserTaxCalculationService.Add")]
      

        public IResult Add(UserTaxCalculation userTaxCalculation)
        {
            //if (userTaxCalculation.FirstName.Length < 2 || userTaxCalculation.LastName.Length < 2)
            //    return new ErrorResult(Messages.UserNameInvalid);


            _userTaxCalculationDal.Add(userTaxCalculation);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(UserTaxCalculation userTaxCalculation)
        {
            _userTaxCalculationDal.Delete(userTaxCalculation);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<UserTaxCalculation>> GetAll()
        {
            return new SuccessDataResult<List<UserTaxCalculation>>(_userTaxCalculationDal.GetAll());
        }

        public IDataResult<UserTaxCalculation> GetById(Guid id)
        {
            return new SuccessDataResult<UserTaxCalculation>(_userTaxCalculationDal.Get(p => p.Id == id));
        }

        //public IDataResult<UserTaxCalculation> GetUserTaxCalculationByUserTaxCalculationId(Guid id)
        //{
        //    return new SuccessDataResult<UserTaxCalculation>(_userTaxCalculationDal.Get(p => p.Id == id));
        //}

        public IDataResult<List<UserTaxCalculation>> GetUserTaxCalculationDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserTaxCalculation UserTaxCalculation)
        {
            throw new NotImplementedException();
        }
    }
}
