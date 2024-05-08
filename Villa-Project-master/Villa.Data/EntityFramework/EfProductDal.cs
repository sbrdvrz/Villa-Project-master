using Villa.Data.Abstrack;
using Villa.Data.Context;
using Villa.Data.Repositories;
using Villa.Entities.Concrete;

namespace Villa.Data.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(VillaContext context) : base(context)
        {
        }
    }
}
