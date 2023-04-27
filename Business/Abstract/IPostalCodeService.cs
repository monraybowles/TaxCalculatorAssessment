using Core.Entities.Concrete;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface IPostalCodeService
    {


        IDataResult<List<PostalCode>> GetAll();
        IDataResult<List<PostalCode>> GetPostalCodeDetails();
        // IDataResult<List<PostalCode>> GetPostalCodeByPostalCodeId(Guid id);      
        IDataResult<PostalCode> GetById(Guid id);
        IResult Add(PostalCode postalCode);
        IResult Delete(PostalCode postalCode);
        IResult Update(PostalCode postalCode);


    }
}