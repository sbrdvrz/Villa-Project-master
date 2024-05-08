using Villa.Businnes.Abstrack;
using Villa.Data.Abstrack;
using Villa.Entities.Concrete;

namespace Villa.Businnes.Concrete
{
    public class DealManager : GenericManager<Deal>, IDealService
    {
        public DealManager(IGenericDal<Deal> genericDal) : base(genericDal)
        {
        }
    }
}
