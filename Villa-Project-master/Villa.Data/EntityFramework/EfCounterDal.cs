using Villa.Data.Abstrack;
using Villa.Data.Context;
using Villa.Data.Repositories;
using Villa.Entities.Concrete;

namespace Villa.Data.EntityFramework
{
    public class EfCounterDal : GenericRepository<Counter>, ICounterDal
    {
        public EfCounterDal(VillaContext context) : base(context)
        {
        }
    }
}
