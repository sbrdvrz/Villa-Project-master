using Villa.Data.Abstrack;
using Villa.Data.Context;
using Villa.Data.Repositories;
using Villa.Entities.Concrete;

namespace Villa.Data.EntityFramework
{
    public class EfDealDal : GenericRepository<Deal>, IDealDal
    {
        public EfDealDal(VillaContext context) : base(context)
        {
        }
    }
}
