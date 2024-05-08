using Villa.Data.Abstrack;
using Villa.Data.Context;
using Villa.Data.Repositories;
using Villa.Entities.Concrete;

namespace Villa.Data.EntityFramework
{
    public class EfVideoDal : GenericRepository<Video>, IVideoDal
    {
        public EfVideoDal(VillaContext context) : base(context)
        {
        }
    }
}
