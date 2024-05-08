using Villa.Data.Abstrack;
using Villa.Data.Context;
using Villa.Data.Repositories;
using Villa.Entities.Concrete;

namespace Villa.Data.EntityFramework
{
    public class EfQuestDal : GenericRepository<Quest>, IQuestDal
    {
        public EfQuestDal(VillaContext context) : base(context)
        {
        }
    }
}
