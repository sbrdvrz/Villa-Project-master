using Villa.Data.Abstrack;
using Villa.Data.Context;
using Villa.Data.Repositories;
using Villa.Entities.Concrete;

namespace Villa.Data.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(VillaContext context) : base(context)
        {
        }
    }
}
