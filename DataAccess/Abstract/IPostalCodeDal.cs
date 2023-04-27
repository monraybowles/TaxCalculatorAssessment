using Core.DataAccess.Abstract;
using Core.Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IPostalCodeDal : IEntityRepository<PostalCode>
    {
        List<PostalCode> GetPostalCodeDetails();

        List<PostalCode> GetAll();
        List<PostalCode> GetPostalCodeByUserPostalCodeId(Guid id);
    }
}

