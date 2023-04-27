using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class PostalCodeManager : IPostalCodeService
    {
        IPostalCodeDal _postalCodeDal;
        public PostalCodeManager(IPostalCodeDal postalCodeDal)
        {
            _postalCodeDal = postalCodeDal;
        }

        //[SecuredOperation("userTaxCalculation.add")]
        ////[ValidationAspect(typeof(userTaxCalculationValidator))]
        //[CacheRemoveAspect("IUserTaxCalculationService.Add")]


        public IResult Add(PostalCode postalCode)
        {
            //if (userTaxCalculation.FirstName.Length < 2 || userTaxCalculation.LastName.Length < 2)
            //    return new ErrorResult(Messages.UserNameInvalid);


            _postalCodeDal.Add(postalCode);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(PostalCode postalCode)
        {
            _postalCodeDal.Delete(postalCode);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<PostalCode>> GetAll()
        {
            return new SuccessDataResult<List<PostalCode>>(_postalCodeDal.GetAll());
        }

        public IDataResult<PostalCode> GetById(Guid id)
        {
            return new SuccessDataResult<PostalCode>(_postalCodeDal.Get(p => p.Id == id));
        }

        //public IDataResult<PostalCode> GetpostalCodeByPostalCodeId(Guid id)
        //{
        //    return new SuccessDataResult<PostalCode>(_postalCodeDal.Get(p => p.Id == id));
        //}

        public IDataResult<List<PostalCode>> GetPostalCodeDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(PostalCode postalCode)
        {
            throw new NotImplementedException();
        }
    }
}
