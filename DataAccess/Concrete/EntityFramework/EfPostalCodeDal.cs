using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPostalCodeDal : EfEntityRepositoryBase<PostalCode, ApplicationDbContext>,IPostalCodeDal
    {
               
        public List<PostalCode> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from PostalCode in context.PostalCode
                                 //where PostalCode.Id == user.Id
                             select new PostalCode { Id = PostalCode.Id, Code = PostalCode.Code };
                return result.ToList();
            }
        }

        public List<PostalCode> GetPostalCode(PostalCode user)
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from PostalCode in context.PostalCode
                             where PostalCode.Id == user.Id
                             select new PostalCode { Id = PostalCode.Id, Code = PostalCode.Code };

                return result.ToList();

            }
        }

        public List<PostalCode> GetPostalCodeByPostalCodeId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PostalCode> GetPostalCodeByUserPostalCodeId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PostalCode> GetPostalCodeDetails()
        {
            throw new NotImplementedException();
        }
        // this handles the Tax Details
        public List<PostalCode> GetUserTaxCalculationDetails()
        {
            throw new NotImplementedException();
        }

    
    }
}
