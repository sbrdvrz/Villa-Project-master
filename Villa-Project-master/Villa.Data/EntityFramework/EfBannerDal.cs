using Villa.Data.Abstrack;
using Villa.Data.Context;
using Villa.Data.Repositories;
using Villa.Entities.Concrete;

namespace Villa.Data.EntityFramework
{
    public class EfBannerDal : GenericRepository<Banner>, IBannerDal
    {
        public EfBannerDal(VillaContext context) : base(context)
        {
        }
    }
}
